using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Web.WebView2.Wpf;
using Microsoft.Win32;
using Sownloader.Contracts.Services;
using Sownloader.Core;
using Sownloader.Core.Models;
using Sownloader.Core.Services;
using Sownloader.Helpers;



namespace Sownloader.ViewModels
{
    public class MainViewModel : Observable
    {

        private readonly ISystemService _systemService;
        private readonly IDefaultPageService _defaultPageService;
        private readonly DownloadService _downloadService;
        private readonly UrlParserService _urlParserService;
        private readonly IHttpClientFactory _clientFactory;
        private Uri _source;
        private bool _isLoading = true;
        private bool _isShowingFailedMessage;
        private Visibility _isLoadingVisibility = Visibility.Visible;
        private Visibility _failedMesageVisibility = Visibility.Collapsed;
        private ICommand _refreshCommand;
        private RelayCommand _browserBackCommand;
        private RelayCommand _browserForwardCommand;
        private ICommand _openInBrowserCommand;
        private WebView2 _webView;

        private Performance? _performance;
        private double _progressPercentage;

        private string _downloadStatus;

        private bool _isDownloading;

        public bool IsDownloading
        {
            get { return _isDownloading; }
            set
            {
                Set(ref _isDownloading, value);
                IsDownloadStatusVisibility = value ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        public string DownloadStatus
        {
            get { return _downloadStatus; }
            set { Set(ref _downloadStatus, value); }
        }

        public double ProgressPercentage
        {
            get { return _progressPercentage; }
            set { Set(ref _progressPercentage, value); }
        }

        public Performance? Performance
        {
            get { return _performance; }
            set { Set(ref _performance, value); }
        }

        public Uri Source
        {
            get { return _source; }
            set { Set(ref _source, value); }
        }

        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                Set(ref _isLoading, value);
                IsLoadingVisibility = value ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        public bool IsShowingFailedMessage
        {
            get => _isShowingFailedMessage;
            set
            {
                Set(ref _isShowingFailedMessage, value);
                FailedMesageVisibility = value ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        private Visibility _isDownloadStatusVisibility = Visibility.Collapsed;

        public Visibility IsDownloadStatusVisibility
        {
            get { return _isDownloadStatusVisibility; }
            set { Set(ref _isDownloadStatusVisibility, value); }
        }

        public Visibility IsLoadingVisibility
        {
            get { return _isLoadingVisibility; }
            set { Set(ref _isLoadingVisibility, value); }
        }

        public Visibility FailedMesageVisibility
        {
            get { return _failedMesageVisibility; }
            set { Set(ref _failedMesageVisibility, value); }
        }



        private bool _isAudioDownloadAvailable;

        public bool IsAudioDownloadAvailable
        {
            get { return _isAudioDownloadAvailable; }
            private set { Set(ref _isAudioDownloadAvailable, value); }
        }

        public bool IsVideoDownloadAvailable => _performance is not null && _performance.video_media_mp4_url is not null;



        public ICommand RefreshCommand => _refreshCommand ?? (_refreshCommand = new RelayCommand(OnRefresh));

        public RelayCommand BrowserBackCommand => _browserBackCommand ?? (_browserBackCommand = new RelayCommand(() => _webView?.GoBack(), () => _webView?.CanGoBack ?? false));

        public RelayCommand BrowserForwardCommand => _browserForwardCommand ?? (_browserForwardCommand = new RelayCommand(() => _webView?.GoForward(), () => _webView?.CanGoForward ?? false));

        public ICommand OpenInBrowserCommand => _openInBrowserCommand ?? (_openInBrowserCommand = new RelayCommand(async () => await OnOpenInBrowser()));

        public MainViewModel(ISystemService systemService, IDefaultPageService defaultPageService, DownloadService downloadService, UrlParserService urlParserService, IHttpClientFactory clientFactory)
        {
            _systemService = systemService;
            _defaultPageService = defaultPageService;
            _downloadService = downloadService;
            _urlParserService = urlParserService;
            _clientFactory = clientFactory;
            Source = _defaultPageService.GetDefaultPage();
            _downloadService.ProgressChanged += _downloadService_ProgressChanged;
        }

        private void _downloadService_ProgressChanged(long? totalFileSize, long totalBytesDownloaded, double? progressPercentage)
        {
            ProgressPercentage = progressPercentage is null ? 0 : (double)progressPercentage;
            DownloadStatus = $"{ProgressPercentage}%";
        }

        public void Initialize(WebView2 webView)
        {
            _webView = webView;

        }


        public async void OnNavigationCompleted(Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            IsLoading = false;
            if (e != null && !e.IsSuccess)
            {
                // Use `e.WebErrorStatus` to vary the displayed message based on the error reason
                IsShowingFailedMessage = true;
            }

            BrowserBackCommand.OnCanExecuteChanged();
            BrowserForwardCommand.OnCanExecuteChanged();

            Source = _webView.Source;


            var html = await _webView.CoreWebView2.ExecuteScriptAsync("window.DataStore.Pages.Recording.performance");
            _performance = JsonSerializer.Deserialize<Performance>(html);
            IsAudioDownloadAvailable = _performance is not null;
        }



        private void OnRefresh()
        {
            IsShowingFailedMessage = false;
            IsLoading = true;
            _webView?.Reload();
        }

        private async Task OnOpenInBrowser()
        {
            if (_performance is null)
                return;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = IsVideoDownloadAvailable ? "MP4 Video (*.mp4)|*.mp4|MP4 Audio (*.m4a)|*.m4a|MP3 Audio (*.mp3)|*.mp3" : "MP4 Audio (*.m4a)|*.m4a|MP3 Audio (*.mp3)|*.mp3";


            if (saveFileDialog.ShowDialog() == true)
            {
                IsDownloading = true;
                string fileExtension = Path.GetExtension(saveFileDialog.FileName);

                string? mediaUrl = String.Empty;
                bool isVideo = false;
                if (fileExtension.Equals(".mp4", StringComparison.OrdinalIgnoreCase))
                {
                    isVideo = true;
                    if (_performance.video_media_mp4_url is null)
                    {
                        _performance = await _performance.RenderPerformance(_clientFactory, PerformanceType.Video, StatusTryReport);
                    }
                }
                else
                {
                    // The performance might not be rendered yet
                    if (_performance.media_url is null)
                    {
                        _performance = await _performance.RenderPerformance(_clientFactory, PerformanceType.Audio, StatusTryReport);
                    }
                }

                if (_performance is null)
                {
                    DownloadStatus = "Download failed. Timeout during rendering. Please try again.";
                    return;
                }
                mediaUrl = _urlParserService.ProcessRecording(isVideo ? _performance.video_media_mp4_url : _performance.media_url);
                if (mediaUrl is null)
                {
                    DownloadStatus = "Download failed. Could not parse URL.";
                    return;
                }
                DownloadStatus = "Start download...";
                await _downloadService.StartDownload(mediaUrl, saveFileDialog.FileName);
                string coverFilePath = String.Empty;
                // Download Cover art
                if (_performance.cover_url is not null)
                {
                    string coverUrl = _performance.cover_url;

                    // The cover url is not unified. It can start with either // or http:// or https://
                    if (coverUrl.Substring(0, 5) is not "https" and not "http:")
                    {
                        coverUrl = $"https:{coverUrl}";
                    }

                    string coverExtension = Path.GetExtension(coverUrl);
                    coverFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "covers", $"{HelperMethods.GenerateRandomString(5)}{coverExtension}");
                    DownloadStatus = "Downloading cover art...";
                    await _downloadService.StartDownload(coverUrl, coverFilePath);
                }

                //Taglib#
                TagLib.File.LocalFileAbstraction AudioFilePath = new TagLib.File.LocalFileAbstraction(saveFileDialog.FileName);
                TagLib.File AudioFile = TagLib.File.Create(AudioFilePath);
                try
                {
                    AudioFile.Tag.Title = _performance.title;
                    AudioFile.Tag.Performers = new string[] { _performance.performed_by };
                    AudioFile.Tag.Album = _performance.app_uid;
                    AudioFile.Tag.Year = Convert.ToUInt32(_performance.created_at.Year);

                    if (File.Exists(coverFilePath))
                    {
                        AudioFile.Tag.Pictures = new TagLib.Picture[] { new TagLib.Picture(coverFilePath) };
                        AudioFile.Tag.Pictures[0].Type = TagLib.PictureType.FrontCover;
                    }
                    AudioFile.Save();
                    AudioFile.Dispose();

                }
                catch (Exception ex)
                {
                    //logfile.WriteLog("Unable to set ID3Tags for file <" + tempFile + ">" + Environment.NewLine + ex.Message, FileHandler.Logfile.LOGLEVEL.ERROR);
                }

                DownloadStatus = "Finished";
                IsDownloading = false;
            }

            _systemService.OpenInWebBrowser(Source.AbsoluteUri);
        }

        private void StatusTryReport(int currentTry)
        {
            DownloadStatus = $"Try render performance {currentTry}/5";
        }
    }
}

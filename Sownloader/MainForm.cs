#if DEBUG
//#define TEST_UPDATE_SERVICE
#endif
using Microsoft.Web.WebView2.Core;
using Microsoft.WindowsAPICodePack.Taskbar;
using Serilog;
using Sownloader.Core;
using Sownloader.Core.Models;
using System.ComponentModel;
using System.Reflection;
using System.Text.Json;

namespace Sownloader;

public partial class MainForm : DarkControls.DarkThemeForm
{
    /// <summary>
    /// Gets or set the current performance which has been found by the WebView2
    /// </summary>
    private Performance? _performance;
    private SownloaderSettings _settings;
    private BindingList<DownloadPerformance> _downloadPerformances = new();
    private bool _isDownloading;
    private Image _refreshImage;
    private Image _refreshLoadingImage;

    private ComponentResourceManager _resources = new ComponentResourceManager(typeof(MainForm));

    public MainForm(SownloaderSettings settings)
    {
        InitializeComponent();
        _settings = settings;
        DataGridViewDownloads.DataSource = _downloadPerformances;
        Downloader.ProgressChanged += Downloader_ProgressChanged;
        _refreshImage = Image.FromFile("Resources/White/icon_refresh.png");
        _refreshLoadingImage = Image.FromFile("Resources/White/icon_refresh_ajax.gif");
    }



    private async void MainWebView_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
    {
        TextBoxUrl.Text = MainWebView.Source.AbsoluteUri;
        try
        {
            var json = await MainWebView.CoreWebView2.ExecuteScriptAsync("window.DataStore.Pages.Recording.performance");
            _performance = JsonSerializer.Deserialize<Performance>(json);

            // If there is no media_url, we try to automatically render the performance by the server.
            if (_performance is not null && _performance.media_url is null)
            {
                Log.Information($"Could not find performance data. The performance needs to be rendered by Smule first. Send command to render performance. https://smule.com/p/{_performance.performance_key}/render");
                await Downloader.TriggerRenderAsync($"https://smule.com/p/{_performance.performance_key}/render");

                // TODO: Add popup for user to display what he needs to do?
            }
        }
        catch (Exception ex)
        {
            Log.Error("Could not fetch performance data. Url {url}; Error: {ex}", MainWebView.Source.AbsoluteUri, ex);
            _performance = null;
        }

        EnableControls();
        ButtonRefresh.Image = _refreshImage;
    }

    private void EnableControls()
    {
        ButtonAdd.Enabled = _performance is not null && !_isDownloading;
        copyMediaURLToolStripMenuItem.Enabled = _performance is not null;
        ButtonDownload.Enabled = _performance is not null && !_isDownloading;
        ButtonRemove.Enabled = !_isDownloading && DataGridViewDownloads.SelectedRows.Count > 0;
        PanelFooter.Visible = _isDownloading;


        if (MainWebView.CanGoBack)
        {
            ButtonBack.Enabled = true;
            backwardToolStripMenuItem.Enabled = true;
        }
        else
        {
            ButtonBack.Enabled = false;
            backwardToolStripMenuItem.Enabled = false;
        }

        if (MainWebView.CanGoForward)
        {
            ButtonForward.Enabled = true;
            forwardToolStripMenuItem.Enabled = true;
        }
        else
        {
            ButtonForward.Enabled = false;
            forwardToolStripMenuItem.Enabled = false;
        }
    }

    private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SettingsForm stg = new(_settings);
        stg.Location = new Point(Location.X + Width / 2 - stg.Width / 2, Location.Y + Height / 2 - stg.Height / 2);
        if (stg.ShowDialog() == DialogResult.OK)
        {
            _settings = stg.Settings;

            // Reload some settings
            TopMost = _settings.KeepInForeground;
        }
    }

    #region Webbrowser Navigation
    private void SmuleToolStripMenuItem_Click(object sender, EventArgs e) => NavigateWebView("https://www.smule.com");

    private void YokeeKaraokeToolStripMenuItem_Click(object sender, EventArgs e) => NavigateWebView("https://www.yokee.tv");

    private void MarvinKleinMusicFavouritesToolStripMenuItem_Click(object sender, EventArgs e) => NavigateWebView("https://www.sownloader.com/marvinkleinmusic-favourites.php?view=swn");

    private void NewsToolStripMenuItem_Click(object sender, EventArgs e) => NavigateWebView("https://www.sownloader.com/news");

    private void SmuleloginToolStripMenuItem_Click(object sender, EventArgs e) => NavigateWebView("https://www.smule.com/user/login");

    private void HelpToolStripMenuItem1_Click(object sender, EventArgs e) => NavigateWebView("https://www.sownloader.com/faq");

    private void WebsiteToolStripMenuItem_Click(object sender, EventArgs e) => NavigateWebView("https://www.sownloader.com/");

    private void AboutSownloader8ToolStripMenuItem_Click(object sender, EventArgs e) => NavigateWebView("http://sownloader.com/news/2018/04/06/introducing-sownloader-8/");

    private void Refresh_Click(object sender, EventArgs e) => MainWebView.Reload();

    private void Backward_Click(object sender, EventArgs e) => MainWebView.GoBack();

    private void Forward_Click(object sender, EventArgs e) => MainWebView.GoForward();

    private void ButtonGoToUrl_Click(object sender, EventArgs e) => NavigateWebView(TextBoxUrl.Text);

    private void NavigateWebView(string url)
    {
        if (!url.StartsWith("https://") && !url.StartsWith("http://"))
        {
            url = $"https://{url}";
        }

        if (Uri.TryCreate(url, UriKind.Absolute, out Uri? uri) && uri is not null)
        {
            MainWebView.Source = uri;
        }
    }

    private void TextBoxUrl_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            NavigateWebView(TextBoxUrl.Text);
        }
    }
    #endregion

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

    private async void MainForm_Load(object sender, EventArgs e)
    {
        MainWebView.CoreWebView2InitializationCompleted += WebView2_CoreWebView2InitializationCompleted;
        await MainWebView.EnsureCoreWebView2Async();
        NavigateWebView(_settings.DefaultPage);
    }


    private void WebView2_CoreWebView2InitializationCompleted(object? sender, CoreWebView2InitializationCompletedEventArgs e)
    {
        if (!e.IsSuccess)
        {
            MessageBox.Show($"WebView2 init failed: {e.InitializationException}");
            return;
        }

        MainWebView.CoreWebView2.SourceChanged += (obj, e) =>
        {
            MainWebView.Reload();
        };
    }

    private void CopyMediaURLToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (_performance is not null)
        {
            Clipboard.SetDataObject(_performance.GetMediaUrlDecoded());
            System.Media.SystemSounds.Asterisk.Play();
        }
    }

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        AboutForm aboutForm = new();
        aboutForm.Location = new Point(Location.X + Width / 2 - aboutForm.Width / 2, Location.Y + Height / 2 - aboutForm.Height / 2);
        aboutForm.ShowDialog();
    }

    private void Add_Click(object sender, EventArgs e)
    {
        if (_performance is not null)
        {
            if (Directory.Exists(_settings.DefaultSavePath))
            {
                SaveMediaFileDialog.InitialDirectory = _settings.DefaultSavePath;
            }

            if (!string.IsNullOrWhiteSpace(_performance.video_media_mp4_url))
            {
                SaveMediaFileDialog.Filter = "MP4 Video (*.mp4)|*.mp4|MP4 Audio (*.m4a)|*.m4a|MP3 Audio (*.mp3)|*.mp3";
                SaveMediaFileDialog.DefaultExt = ".mp4";
            }
            else
            {
                SaveMediaFileDialog.Filter = "MP4 Audio (*.m4a)|*.m4a|MP3 Audio (*.mp3)|*.mp3";
                SaveMediaFileDialog.DefaultExt = ".m4a";
            }

            if (SaveMediaFileDialog.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(SaveMediaFileDialog.FileName);
                _downloadPerformances.Add(new DownloadPerformance(SaveMediaFileDialog.FileName, extension, _performance));
            }
        }
    }

    private void ShowListToolStripMenuItem_Click(object sender, EventArgs e) => PanelList.Visible = !PanelList.Visible;

    private void HomeToolStripMenuItem_Click(object sender, EventArgs e) => NavigateWebView(_settings.DefaultPage);

    private void DataGridViewDownloads_SelectionChanged(object sender, EventArgs e)
    {
        EnableControls();
    }

    private void ButtonRemove_Click(object sender, EventArgs e)
    {
        foreach (DataGridViewRow row in DataGridViewDownloads.SelectedRows)
        {
            DataGridViewDownloads.Rows.Remove(row);
        }
    }

    private async void ButtonDownload_Click(object sender, EventArgs e)
    {
        if (_downloadPerformances.Count is 0)
        {
            Add_Click(ButtonDownload, EventArgs.Empty);
        }

        if (_downloadPerformances.Count > 0)
        {
            await DownloadAsync();
        }
    }

    private async Task DownloadAsync()
    {
        _isDownloading = true;

        EnableControls();
        int anzahlDownloads = DataGridViewDownloads.Rows.Count;
        for (int i = 0; i < anzahlDownloads; i++)
        {
            DownloadPerformance performance = _downloadPerformances[0];
            SownloaderController controller = new SownloaderController(performance);

            await Task.Run(async () =>
            {
                // Download song
                try
                {
                    Log.Information("Download performance. Performance: {performance}; MediaUrl: {media_url}", performance.Performance.web_url, performance.GetDownloadUrl());
                    await controller.DownloadAsync();
                    Log.Information("Performance has been downloaded successfully! Performance: {performance}; MediaUrl: {media_url}", performance.Performance.web_url, performance.GetDownloadUrl());
                }
                catch (Exception ex)
                {
                    Log.Error("Could not download performance {performance} Error: {error}", performance.Performance.web_url, ex);
                }

                // Download cover
                try
                {
                    Log.Information("Download performance cover. Performance: {performance}; CoverUrl: {cover_url}", performance.Performance.web_url, performance.CoverUrl);
                    await controller.DownloadCoverAsync();
                    Log.Information("Performance cover has been downloaded successfully. Performance: {performance}; CoverUrl: {cover_url}", performance.Performance.web_url, performance.CoverUrl);
                }
                catch (Exception ex)
                {
                    Log.Error("Could not download cover for performance {performance} CoverURL: {cover_url} Error: {error}", performance.Performance.web_url, performance.CoverUrl, ex);
                }

                // Set meta data
                try
                {
                    Log.Information("Set meta data for performance. Performance: {performance}", performance.Performance.web_url);
                    await controller.SetMetaDataAsync();
                    Log.Information("Meta data for performance has been set successfully. Performance: {performance}", performance.Performance.web_url);
                }
                catch (Exception ex)
                {
                    Log.Error("Could not set meta data for performance {performance} Error: {error}", performance.Performance.web_url, ex);
                }


                // Convert if neccessary
                if (performance.RequiresConverting)
                {
                    try
                    {
                        Log.Information("Convert performance. Performance: {performance}; Input: {input}; Output: {output}", performance.Performance.web_url, performance.GetDownloadFilename(), performance.SavePath);
                        await controller.ConvertAsync(_settings);
                        Log.Information("Performance has been converted successfully. Performance: {performance}; Input: {input}; Output: {output}", performance.Performance.web_url, performance.GetDownloadFilename(), performance.SavePath);
                    }
                    catch (Exception ex)
                    {
                        Log.Error("Could not convert performance {performance} Error: {error}", performance.Performance.web_url, ex);
                    }
                }
            });

            DataGridViewDownloads.Rows.RemoveAt(0);
        }

        MessageBox.Show("All downloads have finished!", "Downloading has finished!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        _isDownloading = false;

        EnableControls();

        // Support for Windows Taskbar
        TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
        TaskbarManager.Instance.SetProgressValue(0, 100);
    }


    private void Downloader_ProgressChanged(long? totalFileSize, long totalBytesDownloaded, double? progressPercentage)
    {
        if (ProgressbarFortschritt.InvokeRequired)
        {
            ProgressbarFortschritt.Invoke(new System.Windows.Forms.MethodInvoker(delegate ()
            {
                ProgressbarFortschritt.Value = (int)progressPercentage;
            }));
        }
        else
        {
            ProgressbarFortschritt.Value = (int)progressPercentage;

        }

        TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
        TaskbarManager.Instance.SetProgressValue((int)progressPercentage, 100);
    }

    private void LicensesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LicenseForm licenseForm = new LicenseForm();
        licenseForm.Location = new Point(this.Location.X + (int)(this.Width / 2) - (int)(licenseForm.Width / 2), this.Location.Y + (int)(this.Height / 2) - (int)(licenseForm.Height / 2));
        licenseForm.Show();
    }

    private void ConverterToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ConverterForm converterForm = new ConverterForm(_settings);
        converterForm.Location = new Point(Location.X + Width / 2 - converterForm.Width / 2, Location.Y + Height / 2 - converterForm.Height / 2);
        converterForm.ShowDialog();
    }

    private void tagEditorToolStripMenuItem_Click(object sender, EventArgs e)
    {
        TagEditorForm tagEditorForm = new TagEditorForm();
        tagEditorForm.Location = new Point(Location.X + Width / 2 - tagEditorForm.Width / 2, Location.Y + Height / 2 - tagEditorForm.Height / 2);
        tagEditorForm.ShowDialog();
    }

    private void MainWebView_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
    {
        ButtonRefresh.Image = _refreshLoadingImage;
    }

    private async void searchForupdateToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Version installedVersion = Assembly.GetExecutingAssembly().GetName().Version!;

#if TEST_UPDATE_SERVICE
        installedVersion = new Version(1, 0, 0, 0);
#endif 
        UpdateSearch updateSearch = await UpdateSearch.CreateAsync(installedVersion);


        if (updateSearch.IsUpdateAvailable())
        {
            UpdateForm updateForm = new UpdateForm(updateSearch, _settings);
            updateForm.ShowDialog();
        }
        else
        {
            MessageBox.Show
            (
                text: "You are running the latest version of Sownloader",
                caption: "Information",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information
            );

        }


    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => Environment.Exit(0);

    private void MainWebView_ContentLoading(object sender, Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs e)
    {
        Console.WriteLine("Loading...");
    }

    private void MainWebView_LocationChanged(object sender, EventArgs e)
    {
        Console.WriteLine("Loading...");
    }
}
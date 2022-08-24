using Microsoft.WindowsAPICodePack.Taskbar;
using Sownloader.Core;
using Sownloader.Core.Models;
using System.ComponentModel;
using System.Text.Json;

namespace Sownloader
{
    public partial class MainForm : DarkControls.DarkThemeForm
    {
        /// <summary>
        /// Gets or set the current performance which has been found by the WebView2
        /// </summary>
        private Performance? _performance;
        private SownloaderSettings _settings;
        private BindingList<DownloadPerformance> _downloadPerformances = new();
        private bool _isDownloading;

        public MainForm(SownloaderSettings settings)
        {
            InitializeComponent();
            _settings = settings;
            DataGridViewDownloads.DataSource = _downloadPerformances;
            Downloader.ProgressChanged += Downloader_ProgressChanged;
        }



        private async void MainWebView_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            TextBoxUrl.Text = MainWebView.Source.AbsoluteUri;
            var json = await MainWebView.CoreWebView2.ExecuteScriptAsync("window.DataStore.Pages.Recording.performance");
            _performance = JsonSerializer.Deserialize<Performance>(json);

            EnableControls();
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

        private void Refresh_Click(object sender, EventArgs e) => MainWebView.Refresh();

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            NavigateWebView(_settings.DefaultPage);
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
            if(_downloadPerformances.Count is 0)
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
                    await controller.DownloadAsync();

                    // Download cover
                    await controller.DownloadCoverAsync();

                    // Set meta data
                    await controller.SetMetaDataAsync();

                    // Convert if neccessary
                    if (performance.RequiresConverting)
                    {
                        await controller.ConvertAsync(_settings);
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
                ProgressbarFortschritt.Invoke(new MethodInvoker(delegate ()
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

        private void licensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseForm licenseForm = new LicenseForm();
            licenseForm.Location = new Point(this.Location.X + (int)(this.Width / 2) - (int)(licenseForm.Width / 2), this.Location.Y + (int)(this.Height / 2) - (int)(licenseForm.Height / 2));
            licenseForm.Show();
        }
    }
}
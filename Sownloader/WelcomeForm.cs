#if DEBUG
//#define TEST_UPDATE_SERVICE
#endif
using Sownloader.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Sownloader
{
    public partial class WelcomeForm : Form
    {
        private readonly SownloaderSettings _settings;
        public const string DOWNLOAD_UPDATE_BAT_URL = "https://www.sownloader.com/downloads/update.bat";
        public WelcomeForm(SownloaderSettings settings)
        {
            _settings = settings;
            InitializeComponent();
            lblStatus.Parent = pbLogo;
            lblVersion.Parent = pbLogo;
            lblVersion.Text = SownloaderConstants.GetVersion();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timerLoad.Enabled = false;
            MainForm mainForm = new MainForm(_settings);
            mainForm.Show();
            this.Hide();
        }

        private async void WelcomeForm_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Update files...";
            try
            {
                if (File.Exists(Program.UPDATE_PATH))
                {
                    File.Delete(Program.UPDATE_PATH);
                }

                Downloader downloader = new Downloader();

                await downloader.DownloadFileAsync(DOWNLOAD_UPDATE_BAT_URL, Program.UPDATE_PATH);
            }
            catch (Exception ex)
            {
                //lfg.WriteLog(wex.Message, FileHandler.Logfile.LOGLEVEL.ERROR);
            }



            lblStatus.Text = "Searching for updates...";

            Version installedVersion = Assembly.GetExecutingAssembly().GetName().Version!;
#if TEST_UPDATE_SERVICE
            installedVersion = new Version(1, 0, 0, 0);
#endif
            UpdateSearch updateSearch = await UpdateSearch.CreateAsync(installedVersion);
            _ = Version.TryParse(_settings.SkipVersion, out Version? skipVersion);

            if(skipVersion is null)
            {
                skipVersion = new Version(1, 0, 0, 0);
            }

            if(updateSearch.IsUpdateAvailable() && !updateSearch.SkipVersion(skipVersion))
            {
                UpdateForm updateForm = new UpdateForm(updateSearch, _settings);
                updateForm.ShowDialog();
            }

            lblStatus.Text = "Loading...";
            timerLoad.Enabled = true;

        }

    }
}

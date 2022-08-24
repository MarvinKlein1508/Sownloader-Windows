using Sownloader.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            lblVersion.Text = Application.ProductVersion;
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

            //UpdateSearch updatesearch = new UpdateSearch();
            //updatesearch.UpdateSearchFinished += Updatesearch_UpdateSearchFinished;
            //updatesearch.SearchForUpdate();

            Updatesearch_UpdateSearchFinished(this, EventArgs.Empty);
        }

        private void Updatesearch_UpdateSearchFinished(object sender, EventArgs e)
        {
            lblStatus.Text = "Loading...";
            timerLoad.Enabled = true;
        }
    }
}

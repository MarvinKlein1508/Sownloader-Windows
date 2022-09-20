using Sownloader.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Sownloader
{
    public partial class UpdateForm : Form
    {
        private readonly UpdateSearch _updateSearch;
        private readonly SownloaderSettings _settings;

        public UpdateForm(UpdateSearch updateSearch, SownloaderSettings settings)
        {
            _updateSearch = updateSearch;
            _settings = settings;
            InitializeComponent();
            lblVersionOld.Text = Application.ProductVersion;
            lblVersionNew.Text = updateSearch.LatestVersion?.ToString();
        }

        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            lblStatus.Visible = true;
            pgbDownload.Visible = true;
            await _updateSearch.UpdateAsync(DownloadProgressChanged);
        }

        private void DownloadProgressChanged(long? totalFileSize, long totalBytesDownloaded, double? progressPercentage)
        {
#nullable disable
            if (pgbDownload.InvokeRequired)
            {
                pgbDownload.Invoke(new MethodInvoker(delegate ()
                {
                    pgbDownload.Value = (int)progressPercentage;
                }));
            }
            else
            {
                pgbDownload.Value = (int)progressPercentage;

            }
#nullable enable
        }
        private void ButtonLater_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ButtonSkip_Click(object sender, EventArgs e)
        {
            _settings.SkipVersion = _updateSearch.LatestVersion!.ToString();
            _settings.Save(Program.SOWNLOADER_SETTINGS_PATH);
            this.Close();
        }
    }
}

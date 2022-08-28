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
    public partial class LicenseForm : DarkControls.DarkThemeForm
    {
        public LicenseForm()
        {
            InitializeComponent();
        }

        private void btnMPL_Click(object sender, EventArgs e)
        {

        }

        private void btnInstagram_Click(object sender, EventArgs e) => Helpers.OpenUrl("https://www.instagram.com/zora.mediaart/");

        private void btnFacebook_Click(object sender, EventArgs e) => Helpers.OpenUrl("https://www.facebook.com/ART337");

        private void btnFFmpeg_Click(object sender, EventArgs e) => Helpers.OpenUrl("https://www.ffmpeg.org/");

        private void btnTaglibSharp_Click(object sender, EventArgs e) => Helpers.OpenUrl("https://taglib.github.io/");

        private void btnIconfinder_Click(object sender, EventArgs e) => Helpers.OpenUrl("https://www.iconfinder.com");
        private void ButtonSerilog_Click(object sender, EventArgs e) => Helpers.OpenUrl("https://serilog.net/");
    }
}

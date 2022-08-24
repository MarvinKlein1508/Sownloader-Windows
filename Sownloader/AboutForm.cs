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
    public partial class AboutForm : Form
    {
        private const string FACEBOOK = "https://www.facebook.com/marvin.smule.7";
        private const string TWITTER = "https://twitter.com/MagicPianoApp";
        private const string INSTAGRAM = "https://instagram.com/marvinkleinmusic";
        private const string YOUTUBE = "https://youtube.com/marvinkleinmusic";
        private const string SMULE = "https://smule.com/marvinkleinmusic";
        private const string WEBSITE = "https://sownloader.com";
        private const string SUPPORT = "mailto:support@sownloader.com";
        private const string KEVIN_ZORA = "https://www.de.linkedin.com/in/kevinzora";
        public AboutForm()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e) => this.Close();

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Ver. " + Application.ProductVersion;
        }

        private void llblWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Helpers.OpenUrl(WEBSITE);

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Helpers.OpenUrl(SUPPORT);

        private void lklblZoraMediaArt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Helpers.OpenUrl(KEVIN_ZORA);

        private void pbFacebook_Click(object sender, EventArgs e) => Helpers.OpenUrl(FACEBOOK);

        private void pbTwitter_Click(object sender, EventArgs e) => Helpers.OpenUrl(TWITTER);

        private void pbInstagram_Click(object sender, EventArgs e) => Helpers.OpenUrl(INSTAGRAM);

        private void pbYoutube_Click(object sender, EventArgs e) => Helpers.OpenUrl(YOUTUBE);

        private void pbSmule_Click(object sender, EventArgs e) => Helpers.OpenUrl(SMULE);

        private void btnLicenses_Click(object sender, EventArgs e)
        {
            LicenseForm licenseForm = new LicenseForm();
            licenseForm.Location = new Point(this.Location.X + (int)(this.Width / 2) - (int)(licenseForm.Width / 2), this.Location.Y + (int)(this.Height / 2) - (int)(licenseForm.Height / 2));
            licenseForm.Show();
        }
    }
}

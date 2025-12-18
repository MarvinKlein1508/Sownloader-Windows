using Sownloader.Core;

namespace Sownloader
{
    public partial class SettingsForm : DarkControls.DarkThemeForm
    {
        public SownloaderSettings Settings { get; }

        public SettingsForm(SownloaderSettings settings)
        {
            InitializeComponent();
            Settings = (SownloaderSettings)settings.Clone();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            tbSavePath.Text = Settings.DefaultSavePath;
            tbDefaultPage.Text = Settings.DefaultPage;

            CheckBoxKeepInForeground.Checked = Settings.KeepInForeground;

            cbBitrate.Text = Settings.Bitrate;


            TopMost = Settings.KeepInForeground;

        }

        private void ButtonCancel_Click(object sender, EventArgs e) => this.Close();

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(tbSavePath.Text))
            {
                MessageBox.Show
                (
                    caption: "Invalid default save path",
                    text: $"The path \"{tbSavePath.Text}\" does not exist. Please select a valid path.",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error
                );

                return;
            }


            Settings.DefaultPage = tbDefaultPage.Text;
            Settings.DefaultSavePath = tbSavePath.Text;
            Settings.KeepInForeground = CheckBoxKeepInForeground.Checked;
            Settings.Bitrate = cbBitrate.Text;
            Settings.Save(Program.SOWNLOADER_SETTINGS_PATH);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ButtonBrowseSavePath_Click(object sender, EventArgs e)
        {
            // TODO: Implement
        }
    }
}

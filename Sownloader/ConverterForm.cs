using Sownloader.Core;
using System.ComponentModel;
using System.Diagnostics;

namespace Sownloader;

public partial class ConverterForm : DarkControls.DarkThemeForm
{
    private readonly SownloaderSettings _settings;
    private string _input = string.Empty;
    public ConverterForm(SownloaderSettings settings)
    {
        InitializeComponent();
        _settings = settings;
    }
    private void ButtonInput_Click(object sender, EventArgs e) => ofdMediaFile.ShowDialog();
    private void OpenFileDialog_FileOk(object sender, CancelEventArgs e) => tbInput.Text = ofdMediaFile.FileName;

    private void tbInput_TextChanged(object sender, EventArgs e)
    {
        btnStartConverting.Enabled = tbInput.Text.Length > 0;
        _input = tbInput.Text;
    }

    private async void btnStartConverting_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveDialog = new SaveFileDialog();

        if (tbInput.Text.EndsWith(".m4a"))
        {
            saveDialog.Filter = "MP3 Audio(*.mp3) | *.mp3";
        }
        else
        {
            saveDialog.Filter = "MP3 Audio(*.mp3) | *.mp3|MP4 Audio (*.m4a)|*.m4a";
            saveDialog.DefaultExt = ".mp3";
        }

        if (saveDialog.ShowDialog() == DialogResult.OK)
        {
            await Task.Run(() =>
            {
                Convert(saveDialog.FileName);
            });
        }
    }
    // TODO: ConvertController
    private void Convert(string output)
    {
        try
        {
            using Process FFmpeg = new Process();
            FFmpeg.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            FFmpeg.StartInfo.FileName = Path.Combine(Application.StartupPath, "ffmpeg.exe");
            FFmpeg.StartInfo.UseShellExecute = false;
            FFmpeg.StartInfo.CreateNoWindow = false;
            string tempFile = Path.Combine(Path.GetTempPath(), $"{Helpers.GenerateRandomString(5)}{Path.GetExtension(_input)}");

            File.Copy(_input, tempFile);


            string outputExtension = output[^4..];

            string codec = outputExtension switch
            {
                ".mp3" => $"-i {tempFile} -f mp3 -b:a {_settings.Bitrate} -acodec libmp3lame {tempFile[0..^4]}.mp3",
                ".m4a" => $"-i {tempFile} -vn -c:a copy {tempFile[0..^4]}.m4a",
                _ => string.Empty,
            };

            FFmpeg.StartInfo.Arguments = codec;

            FFmpeg.Start();

            while (!FFmpeg.HasExited)
            {

            }

            FFmpeg.Dispose();
            FFmpeg.Close();
            File.Copy($"{tempFile[0..^4]}{outputExtension}", output);
            File.Delete(tempFile);
            File.Delete($"{tempFile[0..^4]}{outputExtension}");



        }
        catch (Exception ex)
        {
            MessageBox.Show
            (
                text: $"Converting has been canceled{Environment.NewLine}{Environment.NewLine}{ex}",
                caption: "Error",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Error
            );

            // TODO: Serilog
        }

        MessageBox.Show
        (
            text: "Converting has been finished!",
            caption: "Finished",
            buttons: MessageBoxButtons.OK,
            icon: MessageBoxIcon.Information
        );
    }

}

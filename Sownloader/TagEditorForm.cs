using System.ComponentModel;

namespace Sownloader;

public partial class TagEditorForm : DarkControls.DarkThemeForm
{
    private string coverPath = "";

    public TagEditorForm()
    {
        InitializeComponent();
    }

    private void btnChooseFile_Click(object sender, EventArgs e)
    {
        ofdMediaFile.ShowDialog();
    }

    private void ofdMediaFile_FileOk(object sender, CancelEventArgs e)
    {
        btnChooseFile.Enabled = false;
        btnCancel.Visible = true;
        btnSave.Visible = true;
        tbFile.Text = ofdMediaFile.FileName;
        grbID3.Visible = true;
        btnSave.Enabled = true;
        btnCancel.Enabled = true;
        tbApp.Text = "";
        tbPerformer.Text = "";
        tbTitle.Text = "";
        pbCoverArt.Image = null;

        try
        {
            TagLib.File.LocalFileAbstraction AudioFilePath = new TagLib.File.LocalFileAbstraction(tbFile.Text);
            TagLib.File AudioFile = TagLib.File.Create(AudioFilePath);
            tbTitle.Text = AudioFile.Tag.Title;
            tbPerformer.Text = AudioFile.Tag.FirstPerformer;
            tbApp.Text = AudioFile.Tag.Album;
            tbYear.Text = AudioFile.Tag.Year.ToString();
            tbComment.Text = AudioFile.Tag.Comment;
            if (AudioFile.Tag.Pictures.Length >= 1)
            {
                pbCoverArt.Image = Image.FromStream(new System.IO.MemoryStream(AudioFile.Tag.Pictures[0].Data.Data));
            }
            AudioFile.Dispose();
        }
        catch (Exception)
        {

            throw;
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            TagLib.File.LocalFileAbstraction AudioFilePath = new TagLib.File.LocalFileAbstraction(tbFile.Text);
            TagLib.File AudioFile = TagLib.File.Create(AudioFilePath);

            AudioFile.Tag.Title = tbTitle.Text;
            AudioFile.Tag.Performers = new string[] { tbPerformer.Text };
            AudioFile.Tag.Album = tbApp.Text;
            AudioFile.Tag.Year = Convert.ToUInt32(tbYear.Text);
            AudioFile.Tag.Comment = tbComment.Text;

            if (pbCoverArt.Image != null && !String.IsNullOrEmpty(coverPath))
            {
                AudioFile.Tag.Pictures = new TagLib.Picture[] { new TagLib.Picture(coverPath) };
                AudioFile.Tag.Pictures[0].Type = TagLib.PictureType.FrontCover;
            }

            AudioFile.Save();
            AudioFile.Dispose();
            btnCancel.PerformClick();
            MessageBox.Show("ID3Tags were successfully changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        catch (Exception)
        {

            throw;
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        btnSave.Visible = false;
        btnCancel.Visible = false;
        grbID3.Visible = false;
        tbFile.Text = "";
        coverPath = "";
        btnChooseFile.Enabled = true;
    }

    private void pbCoverArt_Click(object sender, EventArgs e)
    {
        ofdImage.ShowDialog();
    }

    private void ofdImage_FileOk(object sender, CancelEventArgs e)
    {
        pbCoverArt.Image = new Bitmap(ofdImage.FileName);
        coverPath = ofdImage.FileName;
    }
}

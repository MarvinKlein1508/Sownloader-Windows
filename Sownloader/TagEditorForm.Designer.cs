namespace Sownloader
{
    partial class TagEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagEditorForm));
            tbFile = new DarkControls.DarkThemeTextBox();
            btnChooseFile = new DarkControls.DarkThemeButton();
            grbID3 = new GroupBox();
            lblSize = new Label();
            TableLayoutPanel3 = new TableLayoutPanel();
            tbTitle = new TextBox();
            lblTagTitle = new Label();
            lblTagApp = new Label();
            tbPerformer = new TextBox();
            tbApp = new TextBox();
            lblTagArtist = new Label();
            lblTagYear = new Label();
            tbYear = new TextBox();
            tbComment = new TextBox();
            lblTagComment = new Label();
            pbCoverArt = new PictureBox();
            btnSave = new DarkControls.DarkThemeButton();
            btnCancel = new DarkControls.DarkThemeButton();
            ofdMediaFile = new OpenFileDialog();
            ofdImage = new OpenFileDialog();
            grbID3.SuspendLayout();
            TableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCoverArt).BeginInit();
            SuspendLayout();
            // 
            // tbFile
            // 
            tbFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFile.BackColor = Color.FromArgb(61, 61, 65);
            tbFile.BorderStyle = BorderStyle.FixedSingle;
            tbFile.Font = new Font("Consolas", 12F);
            tbFile.ForeColor = Color.White;
            tbFile.Location = new Point(14, 14);
            tbFile.Margin = new Padding(4, 3, 4, 3);
            tbFile.Name = "tbFile";
            tbFile.ReadOnly = true;
            tbFile.Size = new Size(633, 26);
            tbFile.TabIndex = 0;
            // 
            // btnChooseFile
            // 
            btnChooseFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChooseFile.BackColor = Color.FromArgb(69, 69, 73);
            btnChooseFile.DisabledForeColor = Color.Gray;
            btnChooseFile.EnabledForeColor = Color.White;
            btnChooseFile.FlatAppearance.BorderColor = Color.FromArgb(69, 69, 73);
            btnChooseFile.FlatStyle = FlatStyle.Flat;
            btnChooseFile.ForeColor = Color.White;
            btnChooseFile.Location = new Point(654, 14);
            btnChooseFile.Margin = new Padding(4, 3, 4, 3);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(43, 30);
            btnChooseFile.TabIndex = 1;
            btnChooseFile.Text = "...";
            btnChooseFile.UseVisualStyleBackColor = false;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // grbID3
            // 
            grbID3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grbID3.BackColor = Color.Transparent;
            grbID3.Controls.Add(lblSize);
            grbID3.Controls.Add(TableLayoutPanel3);
            grbID3.Controls.Add(pbCoverArt);
            grbID3.ForeColor = Color.White;
            grbID3.Location = new Point(14, 51);
            grbID3.Margin = new Padding(4, 3, 4, 3);
            grbID3.Name = "grbID3";
            grbID3.Padding = new Padding(4, 3, 4, 3);
            grbID3.Size = new Size(684, 347);
            grbID3.TabIndex = 19;
            grbID3.TabStop = false;
            grbID3.Text = "ID3Tag information";
            grbID3.Visible = false;
            // 
            // lblSize
            // 
            lblSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSize.AutoSize = true;
            lblSize.ForeColor = Color.White;
            lblSize.Location = new Point(365, 317);
            lblSize.Margin = new Padding(4, 0, 4, 0);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(195, 15);
            lblSize.TabIndex = 13;
            lblSize.Text = "The perfect image size is 256x256px.";
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TableLayoutPanel3.ColumnCount = 2;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.61842F));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.38158F));
            TableLayoutPanel3.Controls.Add(tbTitle, 1, 0);
            TableLayoutPanel3.Controls.Add(lblTagTitle, 0, 0);
            TableLayoutPanel3.Controls.Add(lblTagApp, 0, 2);
            TableLayoutPanel3.Controls.Add(tbPerformer, 1, 1);
            TableLayoutPanel3.Controls.Add(tbApp, 1, 2);
            TableLayoutPanel3.Controls.Add(lblTagArtist, 0, 1);
            TableLayoutPanel3.Controls.Add(lblTagYear, 0, 3);
            TableLayoutPanel3.Controls.Add(tbYear, 1, 3);
            TableLayoutPanel3.Controls.Add(tbComment, 1, 4);
            TableLayoutPanel3.Controls.Add(lblTagComment, 0, 4);
            TableLayoutPanel3.Location = new Point(4, 18);
            TableLayoutPanel3.Margin = new Padding(4, 3, 4, 3);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 5;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 203F));
            TableLayoutPanel3.Size = new Size(355, 325);
            TableLayoutPanel3.TabIndex = 12;
            // 
            // tbTitle
            // 
            tbTitle.Dock = DockStyle.Fill;
            tbTitle.Location = new Point(105, 3);
            tbTitle.Margin = new Padding(4, 3, 4, 3);
            tbTitle.MaxLength = 30;
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(246, 23);
            tbTitle.TabIndex = 9;
            // 
            // lblTagTitle
            // 
            lblTagTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTagTitle.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            lblTagTitle.ForeColor = Color.White;
            lblTagTitle.Location = new Point(4, 0);
            lblTagTitle.Margin = new Padding(4, 0, 4, 0);
            lblTagTitle.Name = "lblTagTitle";
            lblTagTitle.Size = new Size(93, 29);
            lblTagTitle.TabIndex = 8;
            lblTagTitle.Text = "Title:";
            lblTagTitle.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTagApp
            // 
            lblTagApp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTagApp.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            lblTagApp.ForeColor = Color.White;
            lblTagApp.Location = new Point(4, 58);
            lblTagApp.Margin = new Padding(4, 0, 4, 0);
            lblTagApp.Name = "lblTagApp";
            lblTagApp.Size = new Size(93, 29);
            lblTagApp.TabIndex = 10;
            lblTagApp.Text = "Album:";
            lblTagApp.TextAlign = ContentAlignment.TopRight;
            // 
            // tbPerformer
            // 
            tbPerformer.Dock = DockStyle.Fill;
            tbPerformer.Location = new Point(105, 32);
            tbPerformer.Margin = new Padding(4, 3, 4, 3);
            tbPerformer.MaxLength = 30;
            tbPerformer.Name = "tbPerformer";
            tbPerformer.Size = new Size(246, 23);
            tbPerformer.TabIndex = 10;
            // 
            // tbApp
            // 
            tbApp.Dock = DockStyle.Fill;
            tbApp.Location = new Point(105, 61);
            tbApp.Margin = new Padding(4, 3, 4, 3);
            tbApp.MaxLength = 30;
            tbApp.Name = "tbApp";
            tbApp.Size = new Size(246, 23);
            tbApp.TabIndex = 11;
            // 
            // lblTagArtist
            // 
            lblTagArtist.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTagArtist.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            lblTagArtist.ForeColor = Color.White;
            lblTagArtist.Location = new Point(4, 29);
            lblTagArtist.Margin = new Padding(4, 0, 4, 0);
            lblTagArtist.Name = "lblTagArtist";
            lblTagArtist.Size = new Size(93, 29);
            lblTagArtist.TabIndex = 9;
            lblTagArtist.Text = "Artist:";
            lblTagArtist.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTagYear
            // 
            lblTagYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTagYear.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            lblTagYear.ForeColor = Color.White;
            lblTagYear.Location = new Point(4, 87);
            lblTagYear.Margin = new Padding(4, 0, 4, 0);
            lblTagYear.Name = "lblTagYear";
            lblTagYear.Size = new Size(93, 29);
            lblTagYear.TabIndex = 12;
            lblTagYear.Text = "Year:";
            lblTagYear.TextAlign = ContentAlignment.TopRight;
            // 
            // tbYear
            // 
            tbYear.Dock = DockStyle.Fill;
            tbYear.Location = new Point(105, 90);
            tbYear.Margin = new Padding(4, 3, 4, 3);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(246, 23);
            tbYear.TabIndex = 13;
            // 
            // tbComment
            // 
            tbComment.Dock = DockStyle.Fill;
            tbComment.Location = new Point(105, 119);
            tbComment.Margin = new Padding(4, 3, 4, 3);
            tbComment.Name = "tbComment";
            tbComment.Size = new Size(246, 23);
            tbComment.TabIndex = 14;
            // 
            // lblTagComment
            // 
            lblTagComment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTagComment.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            lblTagComment.ForeColor = Color.White;
            lblTagComment.Location = new Point(4, 116);
            lblTagComment.Margin = new Padding(4, 0, 4, 0);
            lblTagComment.Name = "lblTagComment";
            lblTagComment.Size = new Size(93, 209);
            lblTagComment.TabIndex = 15;
            lblTagComment.Text = "Comment:";
            lblTagComment.TextAlign = ContentAlignment.TopRight;
            // 
            // pbCoverArt
            // 
            pbCoverArt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbCoverArt.BackColor = Color.DarkGray;
            pbCoverArt.Cursor = Cursors.Hand;
            pbCoverArt.Location = new Point(369, 18);
            pbCoverArt.Margin = new Padding(4, 3, 4, 3);
            pbCoverArt.Name = "pbCoverArt";
            pbCoverArt.Size = new Size(299, 295);
            pbCoverArt.SizeMode = PictureBoxSizeMode.Zoom;
            pbCoverArt.TabIndex = 11;
            pbCoverArt.TabStop = false;
            pbCoverArt.Click += pbCoverArt_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(69, 69, 73);
            btnSave.DisabledForeColor = Color.Gray;
            btnSave.EnabledForeColor = Color.White;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(69, 69, 73);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(610, 405);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 27);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(69, 69, 73);
            btnCancel.DisabledForeColor = Color.Gray;
            btnCancel.EnabledForeColor = Color.White;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(69, 69, 73);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(516, 405);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 27);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ofdMediaFile
            // 
            ofdMediaFile.FileOk += ofdMediaFile_FileOk;
            // 
            // ofdImage
            // 
            ofdImage.FileOk += ofdImage_FileOk;
            // 
            // TagEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(710, 443);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grbID3);
            Controls.Add(btnChooseFile);
            Controls.Add(tbFile);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "TagEditorForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Sownloader - Tag Editor";
            grbID3.ResumeLayout(false);
            grbID3.PerformLayout();
            TableLayoutPanel3.ResumeLayout(false);
            TableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCoverArt).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DarkControls.DarkThemeTextBox tbFile;
        private DarkControls.DarkThemeButton btnChooseFile;
        internal System.Windows.Forms.GroupBox grbID3;
        internal System.Windows.Forms.Label lblSize;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel3;
        internal System.Windows.Forms.TextBox tbTitle;
        internal System.Windows.Forms.Label lblTagTitle;
        internal System.Windows.Forms.Label lblTagApp;
        internal System.Windows.Forms.TextBox tbPerformer;
        internal System.Windows.Forms.TextBox tbApp;
        internal System.Windows.Forms.Label lblTagArtist;
        internal System.Windows.Forms.Label lblTagYear;
        internal System.Windows.Forms.TextBox tbYear;
        internal System.Windows.Forms.TextBox tbComment;
        internal System.Windows.Forms.Label lblTagComment;
        internal System.Windows.Forms.PictureBox pbCoverArt;
        private DarkControls.DarkThemeButton btnSave;
        private DarkControls.DarkThemeButton btnCancel;
        private System.Windows.Forms.OpenFileDialog ofdMediaFile;
        private System.Windows.Forms.OpenFileDialog ofdImage;
    }
}
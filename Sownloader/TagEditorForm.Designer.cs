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
            this.tbFile = new DarkControls.DarkThemeTextBox();
            this.btnChooseFile = new DarkControls.DarkThemeButton();
            this.grbID3 = new System.Windows.Forms.GroupBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblTagTitle = new System.Windows.Forms.Label();
            this.lblTagApp = new System.Windows.Forms.Label();
            this.tbPerformer = new System.Windows.Forms.TextBox();
            this.tbApp = new System.Windows.Forms.TextBox();
            this.lblTagArtist = new System.Windows.Forms.Label();
            this.lblTagYear = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.lblTagComment = new System.Windows.Forms.Label();
            this.pbCoverArt = new System.Windows.Forms.PictureBox();
            this.btnSave = new DarkControls.DarkThemeButton();
            this.btnCancel = new DarkControls.DarkThemeButton();
            this.ofdMediaFile = new System.Windows.Forms.OpenFileDialog();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.grbID3.SuspendLayout();
            this.TableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverArt)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFile
            // 
            this.tbFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.tbFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFile.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFile.ForeColor = System.Drawing.Color.White;
            this.tbFile.Location = new System.Drawing.Point(14, 14);
            this.tbFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbFile.Name = "tbFile";
            this.tbFile.ReadOnly = true;
            this.tbFile.Size = new System.Drawing.Size(633, 26);
            this.tbFile.TabIndex = 0;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.btnChooseFile.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnChooseFile.EnabledForeColor = System.Drawing.Color.White;
            this.btnChooseFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.btnChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFile.ForeColor = System.Drawing.Color.White;
            this.btnChooseFile.Location = new System.Drawing.Point(654, 14);
            this.btnChooseFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(43, 30);
            this.btnChooseFile.TabIndex = 1;
            this.btnChooseFile.Text = "...";
            this.btnChooseFile.UseVisualStyleBackColor = false;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // grbID3
            // 
            this.grbID3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbID3.BackColor = System.Drawing.Color.Transparent;
            this.grbID3.Controls.Add(this.lblSize);
            this.grbID3.Controls.Add(this.TableLayoutPanel3);
            this.grbID3.Controls.Add(this.pbCoverArt);
            this.grbID3.ForeColor = System.Drawing.Color.White;
            this.grbID3.Location = new System.Drawing.Point(14, 51);
            this.grbID3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbID3.Name = "grbID3";
            this.grbID3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbID3.Size = new System.Drawing.Size(684, 347);
            this.grbID3.TabIndex = 19;
            this.grbID3.TabStop = false;
            this.grbID3.Text = "ID3Tag information";
            this.grbID3.Visible = false;
            // 
            // lblSize
            // 
            this.lblSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(365, 317);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(196, 15);
            this.lblSize.TabIndex = 13;
            this.lblSize.Text = "The perfect image size is 256x256px.";
            // 
            // TableLayoutPanel3
            // 
            this.TableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel3.ColumnCount = 2;
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.61842F));
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.38158F));
            this.TableLayoutPanel3.Controls.Add(this.tbTitle, 1, 0);
            this.TableLayoutPanel3.Controls.Add(this.lblTagTitle, 0, 0);
            this.TableLayoutPanel3.Controls.Add(this.lblTagApp, 0, 2);
            this.TableLayoutPanel3.Controls.Add(this.tbPerformer, 1, 1);
            this.TableLayoutPanel3.Controls.Add(this.tbApp, 1, 2);
            this.TableLayoutPanel3.Controls.Add(this.lblTagArtist, 0, 1);
            this.TableLayoutPanel3.Controls.Add(this.lblTagYear, 0, 3);
            this.TableLayoutPanel3.Controls.Add(this.tbYear, 1, 3);
            this.TableLayoutPanel3.Controls.Add(this.tbComment, 1, 4);
            this.TableLayoutPanel3.Controls.Add(this.lblTagComment, 0, 4);
            this.TableLayoutPanel3.Location = new System.Drawing.Point(4, 18);
            this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 5;
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.TableLayoutPanel3.Size = new System.Drawing.Size(355, 325);
            this.TableLayoutPanel3.TabIndex = 12;
            // 
            // tbTitle
            // 
            this.tbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTitle.Location = new System.Drawing.Point(105, 3);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTitle.MaxLength = 30;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(246, 23);
            this.tbTitle.TabIndex = 9;
            // 
            // lblTagTitle
            // 
            this.lblTagTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTagTitle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTagTitle.ForeColor = System.Drawing.Color.White;
            this.lblTagTitle.Location = new System.Drawing.Point(4, 0);
            this.lblTagTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTagTitle.Name = "lblTagTitle";
            this.lblTagTitle.Size = new System.Drawing.Size(93, 29);
            this.lblTagTitle.TabIndex = 8;
            this.lblTagTitle.Text = "Title:";
            this.lblTagTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTagApp
            // 
            this.lblTagApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTagApp.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTagApp.ForeColor = System.Drawing.Color.White;
            this.lblTagApp.Location = new System.Drawing.Point(4, 58);
            this.lblTagApp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTagApp.Name = "lblTagApp";
            this.lblTagApp.Size = new System.Drawing.Size(93, 29);
            this.lblTagApp.TabIndex = 10;
            this.lblTagApp.Text = "Album:";
            this.lblTagApp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbPerformer
            // 
            this.tbPerformer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPerformer.Location = new System.Drawing.Point(105, 32);
            this.tbPerformer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPerformer.MaxLength = 30;
            this.tbPerformer.Name = "tbPerformer";
            this.tbPerformer.Size = new System.Drawing.Size(246, 23);
            this.tbPerformer.TabIndex = 10;
            // 
            // tbApp
            // 
            this.tbApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbApp.Location = new System.Drawing.Point(105, 61);
            this.tbApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbApp.MaxLength = 30;
            this.tbApp.Name = "tbApp";
            this.tbApp.Size = new System.Drawing.Size(246, 23);
            this.tbApp.TabIndex = 11;
            // 
            // lblTagArtist
            // 
            this.lblTagArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTagArtist.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTagArtist.ForeColor = System.Drawing.Color.White;
            this.lblTagArtist.Location = new System.Drawing.Point(4, 29);
            this.lblTagArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTagArtist.Name = "lblTagArtist";
            this.lblTagArtist.Size = new System.Drawing.Size(93, 29);
            this.lblTagArtist.TabIndex = 9;
            this.lblTagArtist.Text = "Artist:";
            this.lblTagArtist.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTagYear
            // 
            this.lblTagYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTagYear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTagYear.ForeColor = System.Drawing.Color.White;
            this.lblTagYear.Location = new System.Drawing.Point(4, 87);
            this.lblTagYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTagYear.Name = "lblTagYear";
            this.lblTagYear.Size = new System.Drawing.Size(93, 29);
            this.lblTagYear.TabIndex = 12;
            this.lblTagYear.Text = "Year:";
            this.lblTagYear.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbYear
            // 
            this.tbYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbYear.Location = new System.Drawing.Point(105, 90);
            this.tbYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(246, 23);
            this.tbYear.TabIndex = 13;
            // 
            // tbComment
            // 
            this.tbComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbComment.Location = new System.Drawing.Point(105, 119);
            this.tbComment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(246, 23);
            this.tbComment.TabIndex = 14;
            // 
            // lblTagComment
            // 
            this.lblTagComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTagComment.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTagComment.ForeColor = System.Drawing.Color.White;
            this.lblTagComment.Location = new System.Drawing.Point(4, 116);
            this.lblTagComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTagComment.Name = "lblTagComment";
            this.lblTagComment.Size = new System.Drawing.Size(93, 209);
            this.lblTagComment.TabIndex = 15;
            this.lblTagComment.Text = "Comment:";
            this.lblTagComment.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbCoverArt
            // 
            this.pbCoverArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCoverArt.BackColor = System.Drawing.Color.DarkGray;
            this.pbCoverArt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCoverArt.Location = new System.Drawing.Point(369, 18);
            this.pbCoverArt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbCoverArt.Name = "pbCoverArt";
            this.pbCoverArt.Size = new System.Drawing.Size(299, 295);
            this.pbCoverArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCoverArt.TabIndex = 11;
            this.pbCoverArt.TabStop = false;
            this.pbCoverArt.Click += new System.EventHandler(this.pbCoverArt_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.btnSave.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSave.EnabledForeColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(610, 405);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 27);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.btnCancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCancel.EnabledForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(516, 405);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 27);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ofdMediaFile
            // 
            this.ofdMediaFile.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdMediaFile_FileOk);
            // 
            // ofdImage
            // 
            this.ofdImage.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdImage_FileOk);
            // 
            // TagEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(710, 443);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbID3);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.tbFile);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TagEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sownloader - Tag Editor";
            this.grbID3.ResumeLayout(false);
            this.grbID3.PerformLayout();
            this.TableLayoutPanel3.ResumeLayout(false);
            this.TableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
namespace Sownloader
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.LabelDefaultPage = new System.Windows.Forms.Label();
            this.LabelSavePath = new System.Windows.Forms.Label();
            this.ButtonBrowseSavePath = new DarkControls.DarkThemeButton();
            this.tbDefaultPage = new DarkControls.DarkThemeTextBox();
            this.tbSavePath = new DarkControls.DarkThemeTextBox();
            this.CheckBoxKeepInForeground = new System.Windows.Forms.CheckBox();
            this.cbBitrate = new System.Windows.Forms.ComboBox();
            this.Labelbitrate = new System.Windows.Forms.Label();
            this.ButtonCancel = new DarkControls.DarkThemeButton();
            this.ButtonSave = new DarkControls.DarkThemeButton();
            this.SuspendLayout();
            // 
            // LabelDefaultPage
            // 
            this.LabelDefaultPage.AutoSize = true;
            this.LabelDefaultPage.ForeColor = System.Drawing.Color.White;
            this.LabelDefaultPage.Location = new System.Drawing.Point(14, 62);
            this.LabelDefaultPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDefaultPage.Name = "LabelDefaultPage";
            this.LabelDefaultPage.Size = new System.Drawing.Size(77, 15);
            this.LabelDefaultPage.TabIndex = 1;
            this.LabelDefaultPage.Text = "Default page:";
            // 
            // LabelSavePath
            // 
            this.LabelSavePath.AutoSize = true;
            this.LabelSavePath.ForeColor = System.Drawing.Color.White;
            this.LabelSavePath.Location = new System.Drawing.Point(14, 10);
            this.LabelSavePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSavePath.Name = "LabelSavePath";
            this.LabelSavePath.Size = new System.Drawing.Size(61, 15);
            this.LabelSavePath.TabIndex = 2;
            this.LabelSavePath.Text = "Save path:";
            // 
            // ButtonBrowseSavePath
            // 
            this.ButtonBrowseSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBrowseSavePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.ButtonBrowseSavePath.DisabledForeColor = System.Drawing.Color.Gray;
            this.ButtonBrowseSavePath.EnabledForeColor = System.Drawing.Color.White;
            this.ButtonBrowseSavePath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.ButtonBrowseSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBrowseSavePath.ForeColor = System.Drawing.Color.White;
            this.ButtonBrowseSavePath.Location = new System.Drawing.Point(443, 29);
            this.ButtonBrowseSavePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonBrowseSavePath.Name = "ButtonBrowseSavePath";
            this.ButtonBrowseSavePath.Size = new System.Drawing.Size(36, 30);
            this.ButtonBrowseSavePath.TabIndex = 3;
            this.ButtonBrowseSavePath.Text = "...";
            this.ButtonBrowseSavePath.UseVisualStyleBackColor = false;
            this.ButtonBrowseSavePath.Click += new System.EventHandler(this.ButtonBrowseSavePath_Click);
            // 
            // tbDefaultPage
            // 
            this.tbDefaultPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefaultPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.tbDefaultPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDefaultPage.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDefaultPage.ForeColor = System.Drawing.Color.White;
            this.tbDefaultPage.Location = new System.Drawing.Point(18, 81);
            this.tbDefaultPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDefaultPage.Name = "tbDefaultPage";
            this.tbDefaultPage.Size = new System.Drawing.Size(462, 26);
            this.tbDefaultPage.TabIndex = 4;
            // 
            // tbSavePath
            // 
            this.tbSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSavePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.tbSavePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSavePath.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSavePath.ForeColor = System.Drawing.Color.White;
            this.tbSavePath.Location = new System.Drawing.Point(18, 29);
            this.tbSavePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.Size = new System.Drawing.Size(418, 26);
            this.tbSavePath.TabIndex = 5;
            // 
            // CheckBoxKeepInForeground
            // 
            this.CheckBoxKeepInForeground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxKeepInForeground.AutoSize = true;
            this.CheckBoxKeepInForeground.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxKeepInForeground.ForeColor = System.Drawing.Color.White;
            this.CheckBoxKeepInForeground.Location = new System.Drawing.Point(18, 118);
            this.CheckBoxKeepInForeground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CheckBoxKeepInForeground.Name = "CheckBoxKeepInForeground";
            this.CheckBoxKeepInForeground.Size = new System.Drawing.Size(220, 19);
            this.CheckBoxKeepInForeground.TabIndex = 17;
            this.CheckBoxKeepInForeground.Text = "Keep the program in the foreground";
            this.CheckBoxKeepInForeground.UseVisualStyleBackColor = true;
            // 
            // cbBitrate
            // 
            this.cbBitrate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBitrate.FormattingEnabled = true;
            this.cbBitrate.Items.AddRange(new object[] {
            "8k",
            "16k",
            "24k",
            "32k",
            "40k",
            "48k",
            "64k",
            "80k",
            "96k",
            "112k",
            "128k",
            "160k",
            "192k",
            "224k",
            "256k",
            "320k"});
            this.cbBitrate.Location = new System.Drawing.Point(18, 164);
            this.cbBitrate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbBitrate.Name = "cbBitrate";
            this.cbBitrate.Size = new System.Drawing.Size(461, 23);
            this.cbBitrate.TabIndex = 21;
            // 
            // Labelbitrate
            // 
            this.Labelbitrate.AutoSize = true;
            this.Labelbitrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Labelbitrate.ForeColor = System.Drawing.Color.White;
            this.Labelbitrate.Location = new System.Drawing.Point(14, 143);
            this.Labelbitrate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Labelbitrate.Name = "Labelbitrate";
            this.Labelbitrate.Size = new System.Drawing.Size(45, 15);
            this.Labelbitrate.TabIndex = 20;
            this.Labelbitrate.Text = "Bitrate:";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.ButtonCancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.ButtonCancel.EnabledForeColor = System.Drawing.Color.White;
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(298, 204);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(88, 27);
            this.ButtonCancel.TabIndex = 24;
            this.ButtonCancel.Text = "&Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.ButtonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonSave.DisabledForeColor = System.Drawing.Color.Gray;
            this.ButtonSave.EnabledForeColor = System.Drawing.Color.White;
            this.ButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.Location = new System.Drawing.Point(392, 204);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(88, 27);
            this.ButtonSave.TabIndex = 25;
            this.ButtonSave.Text = "&Save";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(499, 243);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.cbBitrate);
            this.Controls.Add(this.Labelbitrate);
            this.Controls.Add(this.CheckBoxKeepInForeground);
            this.Controls.Add(this.tbSavePath);
            this.Controls.Add(this.tbDefaultPage);
            this.Controls.Add(this.ButtonBrowseSavePath);
            this.Controls.Add(this.LabelSavePath);
            this.Controls.Add(this.LabelDefaultPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sownloader - Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDefaultPage;
        private System.Windows.Forms.Label LabelSavePath;
        private DarkControls.DarkThemeButton ButtonBrowseSavePath;
        private DarkControls.DarkThemeTextBox tbDefaultPage;
        private DarkControls.DarkThemeTextBox tbSavePath;
        internal System.Windows.Forms.CheckBox CheckBoxKeepInForeground;
        internal System.Windows.Forms.ComboBox cbBitrate;
        internal System.Windows.Forms.Label Labelbitrate;
        private DarkControls.DarkThemeButton ButtonCancel;
        private DarkControls.DarkThemeButton ButtonSave;
    }
}
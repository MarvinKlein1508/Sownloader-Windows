namespace Sownloader
{
    partial class ConverterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConverterForm));
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.tbInput = new DarkControls.DarkThemeTextBox();
            this.btnInput = new DarkControls.DarkThemeButton();
            this.btnStartConverting = new DarkControls.DarkThemeButton();
            this.cbShowFeed = new System.Windows.Forms.CheckBox();
            this.ofdMediaFile = new System.Windows.Forms.OpenFileDialog();
            this.gbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInput
            // 
            this.gbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInput.Controls.Add(this.tbInput);
            this.gbInput.Controls.Add(this.btnInput);
            this.gbInput.ForeColor = System.Drawing.Color.White;
            this.gbInput.Location = new System.Drawing.Point(14, 14);
            this.gbInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInput.Name = "gbInput";
            this.gbInput.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInput.Size = new System.Drawing.Size(614, 66);
            this.gbInput.TabIndex = 0;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input";
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.tbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbInput.ForeColor = System.Drawing.Color.White;
            this.tbInput.Location = new System.Drawing.Point(7, 23);
            this.tbInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbInput.Name = "tbInput";
            this.tbInput.ReadOnly = true;
            this.tbInput.Size = new System.Drawing.Size(539, 26);
            this.tbInput.TabIndex = 1;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // btnInput
            // 
            this.btnInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.btnInput.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnInput.EnabledForeColor = System.Drawing.Color.White;
            this.btnInput.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInput.ForeColor = System.Drawing.Color.White;
            this.btnInput.Location = new System.Drawing.Point(553, 23);
            this.btnInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(41, 30);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "...";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // btnStartConverting
            // 
            this.btnStartConverting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartConverting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.btnStartConverting.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnStartConverting.Enabled = false;
            this.btnStartConverting.EnabledForeColor = System.Drawing.Color.White;
            this.btnStartConverting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.btnStartConverting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartConverting.ForeColor = System.Drawing.Color.White;
            this.btnStartConverting.Location = new System.Drawing.Point(500, 95);
            this.btnStartConverting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStartConverting.Name = "btnStartConverting";
            this.btnStartConverting.Size = new System.Drawing.Size(127, 45);
            this.btnStartConverting.TabIndex = 2;
            this.btnStartConverting.Text = "Start converting...";
            this.btnStartConverting.UseVisualStyleBackColor = false;
            this.btnStartConverting.Click += new System.EventHandler(this.btnStartConverting_Click);
            // 
            // cbShowFeed
            // 
            this.cbShowFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbShowFeed.AutoSize = true;
            this.cbShowFeed.Enabled = false;
            this.cbShowFeed.ForeColor = System.Drawing.Color.White;
            this.cbShowFeed.Location = new System.Drawing.Point(14, 118);
            this.cbShowFeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbShowFeed.Name = "cbShowFeed";
            this.cbShowFeed.Size = new System.Drawing.Size(141, 19);
            this.cbShowFeed.TabIndex = 3;
            this.cbShowFeed.Text = "Show converting feed";
            this.cbShowFeed.UseVisualStyleBackColor = true;
            // 
            // ofdMediaFile
            // 
            this.ofdMediaFile.DefaultExt = "m4a";
            this.ofdMediaFile.Filter = "MP4 Audio (*.m4a)|*.m4a|MP4 Video (*.mp4)|*.mp4";
            this.ofdMediaFile.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
            // 
            // ConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(638, 151);
            this.Controls.Add(this.cbShowFeed);
            this.Controls.Add(this.btnStartConverting);
            this.Controls.Add(this.gbInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ConverterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Converter";
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInput;
        private DarkControls.DarkThemeTextBox tbInput;
        private DarkControls.DarkThemeButton btnInput;
        private DarkControls.DarkThemeButton btnStartConverting;
        private System.Windows.Forms.CheckBox cbShowFeed;
        private System.Windows.Forms.OpenFileDialog ofdMediaFile;
    }
}
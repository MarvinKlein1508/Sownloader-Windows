namespace Sownloader
{
    partial class UpdateForm
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnUpdate = new DarkControls.DarkThemeButton();
            this.btnSkip = new DarkControls.DarkThemeButton();
            this.btnLater = new DarkControls.DarkThemeButton();
            this.lblLatestVersion = new System.Windows.Forms.Label();
            this.lblInstalledVersion = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblVersionNew = new System.Windows.Forms.Label();
            this.lblVersionOld = new System.Windows.Forms.Label();
            this.pgbDownload = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(14, 10);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(566, 70);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "There is an update available for Sownloader! Please update to the latest version " +
    "of Sownloader to get the latest features and bugfixes.";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.btnUpdate.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnUpdate.EnabledForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(19, 160);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 55);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.btnSkip.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSkip.EnabledForeColor = System.Drawing.Color.White;
            this.btnSkip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.ForeColor = System.Drawing.Color.White;
            this.btnSkip.Location = new System.Drawing.Point(209, 160);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(183, 55);
            this.btnSkip.TabIndex = 2;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.ButtonSkip_Click);
            // 
            // btnLater
            // 
            this.btnLater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.btnLater.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnLater.EnabledForeColor = System.Drawing.Color.White;
            this.btnLater.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.btnLater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLater.ForeColor = System.Drawing.Color.White;
            this.btnLater.Location = new System.Drawing.Point(399, 160);
            this.btnLater.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLater.Name = "btnLater";
            this.btnLater.Size = new System.Drawing.Size(183, 55);
            this.btnLater.TabIndex = 3;
            this.btnLater.Text = "Update later";
            this.btnLater.UseVisualStyleBackColor = false;
            this.btnLater.Click += new System.EventHandler(this.ButtonLater_Click);
            // 
            // lblLatestVersion
            // 
            this.lblLatestVersion.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLatestVersion.ForeColor = System.Drawing.Color.White;
            this.lblLatestVersion.Location = new System.Drawing.Point(4, 34);
            this.lblLatestVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLatestVersion.Name = "lblLatestVersion";
            this.lblLatestVersion.Size = new System.Drawing.Size(481, 25);
            this.lblLatestVersion.TabIndex = 4;
            this.lblLatestVersion.Text = "Latest version:";
            this.lblLatestVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInstalledVersion
            // 
            this.lblInstalledVersion.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInstalledVersion.ForeColor = System.Drawing.Color.White;
            this.lblInstalledVersion.Location = new System.Drawing.Point(4, 0);
            this.lblInstalledVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstalledVersion.Name = "lblInstalledVersion";
            this.lblInstalledVersion.Size = new System.Drawing.Size(481, 25);
            this.lblInstalledVersion.TabIndex = 5;
            this.lblInstalledVersion.Text = "Installed version:";
            this.lblInstalledVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.74948F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.25052F));
            this.tableLayoutPanel1.Controls.Add(this.lblVersionNew, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblVersionOld, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInstalledVersion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLatestVersion, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 84);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 69);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblVersionNew
            // 
            this.lblVersionNew.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVersionNew.ForeColor = System.Drawing.Color.White;
            this.lblVersionNew.Location = new System.Drawing.Point(493, 34);
            this.lblVersionNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersionNew.Name = "lblVersionNew";
            this.lblVersionNew.Size = new System.Drawing.Size(67, 25);
            this.lblVersionNew.TabIndex = 7;
            this.lblVersionNew.Text = "7.3.3";
            this.lblVersionNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVersionOld
            // 
            this.lblVersionOld.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVersionOld.ForeColor = System.Drawing.Color.White;
            this.lblVersionOld.Location = new System.Drawing.Point(493, 0);
            this.lblVersionOld.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersionOld.Name = "lblVersionOld";
            this.lblVersionOld.Size = new System.Drawing.Size(67, 25);
            this.lblVersionOld.TabIndex = 6;
            this.lblVersionOld.Text = "8.0.0";
            this.lblVersionOld.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pgbDownload
            // 
            this.pgbDownload.Location = new System.Drawing.Point(19, 252);
            this.pgbDownload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pgbDownload.Name = "pgbDownload";
            this.pgbDownload.Size = new System.Drawing.Size(564, 51);
            this.pgbDownload.TabIndex = 7;
            this.pgbDownload.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(14, 223);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(568, 25);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Downloading...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.Visible = false;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(594, 314);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pgbDownload);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnLater);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sownloader - Update";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private DarkControls.DarkThemeButton btnUpdate;
        private DarkControls.DarkThemeButton btnSkip;
        private DarkControls.DarkThemeButton btnLater;
        private System.Windows.Forms.Label lblLatestVersion;
        private System.Windows.Forms.Label lblInstalledVersion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblVersionNew;
        private System.Windows.Forms.Label lblVersionOld;
        private System.Windows.Forms.ProgressBar pgbDownload;
        private System.Windows.Forms.Label lblStatus;
    }
}
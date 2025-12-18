namespace Sownloader
{
    partial class WelcomeForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            panelMain = new Panel();
            lblVersion = new Label();
            lblStatus = new Label();
            pbLogo = new PictureBox();
            timerLoad = new System.Windows.Forms.Timer(components);
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(lblVersion);
            panelMain.Controls.Add(lblStatus);
            panelMain.Controls.Add(pbLogo);
            panelMain.Dock = DockStyle.Fill;
            panelMain.ForeColor = SystemColors.Control;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(4, 3, 4, 3);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(456, 242);
            panelMain.TabIndex = 0;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            lblVersion.ForeColor = Color.Gray;
            lblVersion.Location = new Point(409, 205);
            lblVersion.Margin = new Padding(4, 0, 4, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(41, 15);
            lblVersion.TabIndex = 4;
            lblVersion.Text = "10.0.0";
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(28, 255, 156);
            lblStatus.Location = new Point(192, 225);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(262, 15);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Searching for updates...";
            lblStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pbLogo
            // 
            pbLogo.Dock = DockStyle.Fill;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(0, 0);
            pbLogo.Margin = new Padding(4, 3, 4, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(454, 240);
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // timerLoad
            // 
            timerLoad.Interval = 2000;
            timerLoad.Tick += Timer_Tick;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 242);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            TopMost = true;
            Load += WelcomeForm_Load;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pbLogo;
        internal System.Windows.Forms.Label lblVersion;
        internal System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timerLoad;
    }
}
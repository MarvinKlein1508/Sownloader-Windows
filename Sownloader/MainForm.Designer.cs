namespace Sownloader
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenuStrip = new DarkControls.DarkThemeMenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyMediaURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.converterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marvinkleinmusicfavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yokeeKaraokeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.smuleloginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForupdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.licensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSownloader8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelNavigation = new System.Windows.Forms.Panel();
            this.ButtonDownload = new DarkControls.DarkThemeButton();
            this.ButtonAdd = new DarkControls.DarkThemeButton();
            this.ButtonGoToUrl = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.TextBoxUrl = new DarkControls.DarkThemeTextBox();
            this.ButtonForward = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.MainWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.ProgressbarFortschritt = new System.Windows.Forms.ProgressBar();
            this.PanelList = new System.Windows.Forms.Panel();
            this.ButtonRemove = new DarkControls.DarkThemeButton();
            this.DataGridViewDownloads = new System.Windows.Forms.DataGridView();
            this.SaveMediaFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainMenuStrip.SuspendLayout();
            this.PanelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainWebView)).BeginInit();
            this.PanelFooter.SuspendLayout();
            this.PanelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDownloads)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MainMenuStrip.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.extrasToolStripMenuItem,
            this.bookmarksToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1177, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "darkThemeMenuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.forwardToolStripMenuItem,
            this.backwardToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.toolStripSeparator1,
            this.copyMediaURLToolStripMenuItem,
            this.showListToolStripMenuItem,
            this.addToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "E&dit";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reloadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloadToolStripMenuItem.Image")));
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reloadToolStripMenuItem.Text = "&Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // forwardToolStripMenuItem
            // 
            this.forwardToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.forwardToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("forwardToolStripMenuItem.Image")));
            this.forwardToolStripMenuItem.Name = "forwardToolStripMenuItem";
            this.forwardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.forwardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.forwardToolStripMenuItem.Text = "&Forward";
            this.forwardToolStripMenuItem.Click += new System.EventHandler(this.Forward_Click);
            // 
            // backwardToolStripMenuItem
            // 
            this.backwardToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.backwardToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backwardToolStripMenuItem.Image")));
            this.backwardToolStripMenuItem.Name = "backwardToolStripMenuItem";
            this.backwardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backwardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backwardToolStripMenuItem.Text = "&Backward";
            this.backwardToolStripMenuItem.Click += new System.EventHandler(this.Backward_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.homeToolStripMenuItem.Text = "&Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // copyMediaURLToolStripMenuItem
            // 
            this.copyMediaURLToolStripMenuItem.Enabled = false;
            this.copyMediaURLToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.copyMediaURLToolStripMenuItem.Name = "copyMediaURLToolStripMenuItem";
            this.copyMediaURLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyMediaURLToolStripMenuItem.Text = "Copy &Media-URL";
            this.copyMediaURLToolStripMenuItem.Click += new System.EventHandler(this.CopyMediaURLToolStripMenuItem_Click);
            // 
            // showListToolStripMenuItem
            // 
            this.showListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showListToolStripMenuItem.Image")));
            this.showListToolStripMenuItem.Name = "showListToolStripMenuItem";
            this.showListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.showListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showListToolStripMenuItem.Text = "&Show list";
            this.showListToolStripMenuItem.Click += new System.EventHandler(this.ShowListToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Enabled = false;
            this.addToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem.Image")));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.Add_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tagEditorToolStripMenuItem,
            this.converterToolStripMenuItem,
            this.newsToolStripMenuItem,
            this.marvinkleinmusicfavouritesToolStripMenuItem,
            this.toolStripSeparator3,
            this.settingsToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.extrasToolStripMenuItem.Text = "E&xtras";
            // 
            // tagEditorToolStripMenuItem
            // 
            this.tagEditorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tagEditorToolStripMenuItem.Name = "tagEditorToolStripMenuItem";
            this.tagEditorToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.tagEditorToolStripMenuItem.Text = "&Tag Editor";
            this.tagEditorToolStripMenuItem.Click += new System.EventHandler(this.tagEditorToolStripMenuItem_Click);
            // 
            // converterToolStripMenuItem
            // 
            this.converterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.converterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("converterToolStripMenuItem.Image")));
            this.converterToolStripMenuItem.Name = "converterToolStripMenuItem";
            this.converterToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.converterToolStripMenuItem.Text = "&Converter";
            this.converterToolStripMenuItem.Click += new System.EventHandler(this.ConverterToolStripMenuItem_Click);
            // 
            // newsToolStripMenuItem
            // 
            this.newsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newsToolStripMenuItem.Image")));
            this.newsToolStripMenuItem.Name = "newsToolStripMenuItem";
            this.newsToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.newsToolStripMenuItem.Text = "N&ews";
            this.newsToolStripMenuItem.Click += new System.EventHandler(this.NewsToolStripMenuItem_Click);
            // 
            // marvinkleinmusicfavouritesToolStripMenuItem
            // 
            this.marvinkleinmusicfavouritesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.marvinkleinmusicfavouritesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("marvinkleinmusicfavouritesToolStripMenuItem.Image")));
            this.marvinkleinmusicfavouritesToolStripMenuItem.Name = "marvinkleinmusicfavouritesToolStripMenuItem";
            this.marvinkleinmusicfavouritesToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.marvinkleinmusicfavouritesToolStripMenuItem.Text = "MarvinKleinMusic &favourites";
            this.marvinkleinmusicfavouritesToolStripMenuItem.Click += new System.EventHandler(this.MarvinKleinMusicFavouritesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // bookmarksToolStripMenuItem
            // 
            this.bookmarksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smuleToolStripMenuItem,
            this.yokeeKaraokeToolStripMenuItem,
            this.toolStripSeparator4,
            this.smuleloginToolStripMenuItem});
            this.bookmarksToolStripMenuItem.Name = "bookmarksToolStripMenuItem";
            this.bookmarksToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.bookmarksToolStripMenuItem.Text = "B&ookmarks";
            // 
            // smuleToolStripMenuItem
            // 
            this.smuleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.smuleToolStripMenuItem.Name = "smuleToolStripMenuItem";
            this.smuleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.smuleToolStripMenuItem.Text = "Sm&ule";
            this.smuleToolStripMenuItem.Click += new System.EventHandler(this.SmuleToolStripMenuItem_Click);
            // 
            // yokeeKaraokeToolStripMenuItem
            // 
            this.yokeeKaraokeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.yokeeKaraokeToolStripMenuItem.Name = "yokeeKaraokeToolStripMenuItem";
            this.yokeeKaraokeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yokeeKaraokeToolStripMenuItem.Text = "Y&okee Karaoke";
            this.yokeeKaraokeToolStripMenuItem.Click += new System.EventHandler(this.YokeeKaraokeToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // smuleloginToolStripMenuItem
            // 
            this.smuleloginToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.smuleloginToolStripMenuItem.Name = "smuleloginToolStripMenuItem";
            this.smuleloginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.smuleloginToolStripMenuItem.Text = "Smule &login";
            this.smuleloginToolStripMenuItem.Click += new System.EventHandler(this.SmuleloginToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.websiteToolStripMenuItem,
            this.searchForupdateToolStripMenuItem,
            this.sendFeedbackToolStripMenuItem,
            this.toolStripSeparator5,
            this.licensesToolStripMenuItem,
            this.aboutSownloader8ToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem1.Image")));
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.helpToolStripMenuItem1.Text = "&Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.HelpToolStripMenuItem1_Click);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.websiteToolStripMenuItem.Text = "&Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.WebsiteToolStripMenuItem_Click);
            // 
            // searchForupdateToolStripMenuItem
            // 
            this.searchForupdateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.searchForupdateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchForupdateToolStripMenuItem.Image")));
            this.searchForupdateToolStripMenuItem.Name = "searchForupdateToolStripMenuItem";
            this.searchForupdateToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.searchForupdateToolStripMenuItem.Text = "Search for &update";
            // 
            // sendFeedbackToolStripMenuItem
            // 
            this.sendFeedbackToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sendFeedbackToolStripMenuItem.Name = "sendFeedbackToolStripMenuItem";
            this.sendFeedbackToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.sendFeedbackToolStripMenuItem.Text = "S&end feedback...";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(178, 6);
            // 
            // licensesToolStripMenuItem
            // 
            this.licensesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.licensesToolStripMenuItem.Name = "licensesToolStripMenuItem";
            this.licensesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.licensesToolStripMenuItem.Text = "L&icenses";
            this.licensesToolStripMenuItem.Click += new System.EventHandler(this.LicensesToolStripMenuItem_Click);
            // 
            // aboutSownloader8ToolStripMenuItem
            // 
            this.aboutSownloader8ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutSownloader8ToolStripMenuItem.Name = "aboutSownloader8ToolStripMenuItem";
            this.aboutSownloader8ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.aboutSownloader8ToolStripMenuItem.Text = "About Sownloader 8";
            this.aboutSownloader8ToolStripMenuItem.Click += new System.EventHandler(this.AboutSownloader8ToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // PanelNavigation
            // 
            this.PanelNavigation.Controls.Add(this.ButtonDownload);
            this.PanelNavigation.Controls.Add(this.ButtonAdd);
            this.PanelNavigation.Controls.Add(this.ButtonGoToUrl);
            this.PanelNavigation.Controls.Add(this.ButtonRefresh);
            this.PanelNavigation.Controls.Add(this.TextBoxUrl);
            this.PanelNavigation.Controls.Add(this.ButtonForward);
            this.PanelNavigation.Controls.Add(this.ButtonBack);
            this.PanelNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelNavigation.Location = new System.Drawing.Point(0, 24);
            this.PanelNavigation.Name = "PanelNavigation";
            this.PanelNavigation.Size = new System.Drawing.Size(1177, 38);
            this.PanelNavigation.TabIndex = 1;
            // 
            // ButtonDownload
            // 
            this.ButtonDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.ButtonDownload.DisabledForeColor = System.Drawing.Color.Gray;
            this.ButtonDownload.Enabled = false;
            this.ButtonDownload.EnabledForeColor = System.Drawing.Color.White;
            this.ButtonDownload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.ButtonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDownload.ForeColor = System.Drawing.Color.White;
            this.ButtonDownload.Location = new System.Drawing.Point(1096, 7);
            this.ButtonDownload.Name = "ButtonDownload";
            this.ButtonDownload.Size = new System.Drawing.Size(78, 26);
            this.ButtonDownload.TabIndex = 7;
            this.ButtonDownload.Text = "&Download";
            this.ButtonDownload.UseVisualStyleBackColor = false;
            this.ButtonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.ButtonAdd.DisabledForeColor = System.Drawing.Color.Gray;
            this.ButtonAdd.Enabled = false;
            this.ButtonAdd.EnabledForeColor = System.Drawing.Color.White;
            this.ButtonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Location = new System.Drawing.Point(1040, 7);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(50, 26);
            this.ButtonAdd.TabIndex = 6;
            this.ButtonAdd.Text = "&Add";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // ButtonGoToUrl
            // 
            this.ButtonGoToUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonGoToUrl.FlatAppearance.BorderSize = 0;
            this.ButtonGoToUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGoToUrl.ForeColor = System.Drawing.Color.White;
            this.ButtonGoToUrl.Image = ((System.Drawing.Image)(resources.GetObject("ButtonGoToUrl.Image")));
            this.ButtonGoToUrl.Location = new System.Drawing.Point(1009, 7);
            this.ButtonGoToUrl.Name = "ButtonGoToUrl";
            this.ButtonGoToUrl.Size = new System.Drawing.Size(25, 25);
            this.ButtonGoToUrl.TabIndex = 5;
            this.ButtonGoToUrl.UseVisualStyleBackColor = true;
            this.ButtonGoToUrl.Click += new System.EventHandler(this.ButtonGoToUrl_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.FlatAppearance.BorderSize = 0;
            this.ButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRefresh.ForeColor = System.Drawing.Color.White;
            this.ButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRefresh.Image")));
            this.ButtonRefresh.Location = new System.Drawing.Point(65, 7);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(25, 25);
            this.ButtonRefresh.TabIndex = 4;
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // TextBoxUrl
            // 
            this.TextBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.TextBoxUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxUrl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxUrl.ForeColor = System.Drawing.Color.White;
            this.TextBoxUrl.Location = new System.Drawing.Point(96, 6);
            this.TextBoxUrl.Name = "TextBoxUrl";
            this.TextBoxUrl.Size = new System.Drawing.Size(907, 26);
            this.TextBoxUrl.TabIndex = 3;
            this.TextBoxUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxUrl_KeyUp);
            // 
            // ButtonForward
            // 
            this.ButtonForward.FlatAppearance.BorderSize = 0;
            this.ButtonForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonForward.ForeColor = System.Drawing.Color.White;
            this.ButtonForward.Image = ((System.Drawing.Image)(resources.GetObject("ButtonForward.Image")));
            this.ButtonForward.Location = new System.Drawing.Point(34, 7);
            this.ButtonForward.Name = "ButtonForward";
            this.ButtonForward.Size = new System.Drawing.Size(25, 25);
            this.ButtonForward.TabIndex = 1;
            this.ButtonForward.UseVisualStyleBackColor = true;
            this.ButtonForward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Enabled = false;
            this.ButtonBack.FlatAppearance.BorderSize = 0;
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.ForeColor = System.Drawing.Color.White;
            this.ButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBack.Image")));
            this.ButtonBack.Location = new System.Drawing.Point(3, 7);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(25, 25);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.Backward_Click);
            // 
            // MainWebView
            // 
            this.MainWebView.AllowExternalDrop = true;
            this.MainWebView.CreationProperties = null;
            this.MainWebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.MainWebView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWebView.Location = new System.Drawing.Point(0, 62);
            this.MainWebView.Name = "MainWebView";
            this.MainWebView.Size = new System.Drawing.Size(1177, 640);
            this.MainWebView.TabIndex = 2;
            this.MainWebView.ZoomFactor = 1D;
            this.MainWebView.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.MainWebView_NavigationStarting);
            this.MainWebView.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.MainWebView_NavigationCompleted);
            // 
            // PanelFooter
            // 
            this.PanelFooter.Controls.Add(this.ProgressbarFortschritt);
            this.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFooter.Location = new System.Drawing.Point(0, 702);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(1177, 31);
            this.PanelFooter.TabIndex = 3;
            this.PanelFooter.Visible = false;
            // 
            // ProgressbarFortschritt
            // 
            this.ProgressbarFortschritt.Location = new System.Drawing.Point(969, 5);
            this.ProgressbarFortschritt.Name = "ProgressbarFortschritt";
            this.ProgressbarFortschritt.Size = new System.Drawing.Size(196, 23);
            this.ProgressbarFortschritt.TabIndex = 0;
            // 
            // PanelList
            // 
            this.PanelList.Controls.Add(this.ButtonRemove);
            this.PanelList.Controls.Add(this.DataGridViewDownloads);
            this.PanelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelList.Location = new System.Drawing.Point(0, 62);
            this.PanelList.Name = "PanelList";
            this.PanelList.Size = new System.Drawing.Size(1177, 640);
            this.PanelList.TabIndex = 4;
            this.PanelList.Visible = false;
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.ButtonRemove.DisabledForeColor = System.Drawing.Color.Gray;
            this.ButtonRemove.Enabled = false;
            this.ButtonRemove.EnabledForeColor = System.Drawing.Color.White;
            this.ButtonRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.ButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemove.ForeColor = System.Drawing.Color.White;
            this.ButtonRemove.Location = new System.Drawing.Point(3, 598);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(143, 36);
            this.ButtonRemove.TabIndex = 1;
            this.ButtonRemove.Text = "&Remove";
            this.ButtonRemove.UseVisualStyleBackColor = false;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // DataGridViewDownloads
            // 
            this.DataGridViewDownloads.AllowUserToAddRows = false;
            this.DataGridViewDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewDownloads.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewDownloads.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DataGridViewDownloads.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewDownloads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDownloads.Location = new System.Drawing.Point(3, 3);
            this.DataGridViewDownloads.Name = "DataGridViewDownloads";
            this.DataGridViewDownloads.RowHeadersVisible = false;
            this.DataGridViewDownloads.RowTemplate.Height = 25;
            this.DataGridViewDownloads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDownloads.Size = new System.Drawing.Size(1171, 589);
            this.DataGridViewDownloads.TabIndex = 0;
            this.DataGridViewDownloads.SelectionChanged += new System.EventHandler(this.DataGridViewDownloads_SelectionChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this.ButtonGoToUrl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1177, 733);
            this.Controls.Add(this.PanelList);
            this.Controls.Add(this.MainWebView);
            this.Controls.Add(this.PanelFooter);
            this.Controls.Add(this.PanelNavigation);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sownloader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.PanelNavigation.ResumeLayout(false);
            this.PanelNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainWebView)).EndInit();
            this.PanelFooter.ResumeLayout(false);
            this.PanelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDownloads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkControls.DarkThemeMenuStrip MainMenuStrip;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem reloadToolStripMenuItem;
        private ToolStripMenuItem forwardToolStripMenuItem;
        private ToolStripMenuItem backwardToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem copyMediaURLToolStripMenuItem;
        private ToolStripMenuItem showListToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem extrasToolStripMenuItem;
        private ToolStripMenuItem tagEditorToolStripMenuItem;
        private ToolStripMenuItem converterToolStripMenuItem;
        private ToolStripMenuItem newsToolStripMenuItem;
        private ToolStripMenuItem marvinkleinmusicfavouritesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem bookmarksToolStripMenuItem;
        private ToolStripMenuItem smuleToolStripMenuItem;
        private ToolStripMenuItem yokeeKaraokeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem smuleloginToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem websiteToolStripMenuItem;
        private ToolStripMenuItem searchForupdateToolStripMenuItem;
        private ToolStripMenuItem sendFeedbackToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem licensesToolStripMenuItem;
        private ToolStripMenuItem aboutSownloader8ToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel PanelNavigation;
        private Microsoft.Web.WebView2.WinForms.WebView2 MainWebView;
        private DarkControls.DarkThemeButton ButtonDownload;
        private DarkControls.DarkThemeButton ButtonAdd;
        private Button ButtonGoToUrl;
        private Button ButtonRefresh;
        private DarkControls.DarkThemeTextBox TextBoxUrl;
        private Button ButtonForward;
        private Button ButtonBack;
        private Panel PanelFooter;
        private Panel PanelList;
        private DataGridView DataGridViewDownloads;
        private DarkControls.DarkThemeButton ButtonRemove;
        private ProgressBar ProgressbarFortschritt;
        private SaveFileDialog SaveMediaFileDialog;
    }
}
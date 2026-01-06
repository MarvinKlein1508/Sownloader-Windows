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
            MainMenuStrip = new DarkControls.DarkThemeMenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            reloadToolStripMenuItem = new ToolStripMenuItem();
            forwardToolStripMenuItem = new ToolStripMenuItem();
            backwardToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            copyMediaURLToolStripMenuItem = new ToolStripMenuItem();
            showListToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            extrasToolStripMenuItem = new ToolStripMenuItem();
            tagEditorToolStripMenuItem = new ToolStripMenuItem();
            converterToolStripMenuItem = new ToolStripMenuItem();
            newsToolStripMenuItem = new ToolStripMenuItem();
            marvinkleinmusicfavouritesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            bookmarksToolStripMenuItem = new ToolStripMenuItem();
            smuleToolStripMenuItem = new ToolStripMenuItem();
            yokeeKaraokeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            smuleloginToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            websiteToolStripMenuItem = new ToolStripMenuItem();
            searchForupdateToolStripMenuItem = new ToolStripMenuItem();
            sendFeedbackToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            licensesToolStripMenuItem = new ToolStripMenuItem();
            aboutSownloader8ToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            PanelNavigation = new Panel();
            ButtonDownload = new DarkControls.DarkThemeButton();
            ButtonAdd = new DarkControls.DarkThemeButton();
            ButtonGoToUrl = new Button();
            ButtonRefresh = new Button();
            TextBoxUrl = new DarkControls.DarkThemeTextBox();
            ButtonForward = new Button();
            ButtonBack = new Button();
            MainWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            PanelFooter = new Panel();
            ProgressbarFortschritt = new ProgressBar();
            PanelList = new Panel();
            ButtonRemove = new DarkControls.DarkThemeButton();
            DataGridViewDownloads = new DataGridView();
            SaveMediaFileDialog = new SaveFileDialog();
            MainMenuStrip.SuspendLayout();
            PanelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainWebView).BeginInit();
            PanelFooter.SuspendLayout();
            PanelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewDownloads).BeginInit();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.BackColor = Color.FromArgb(45, 45, 48);
            MainMenuStrip.ForeColor = Color.White;
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, extrasToolStripMenuItem, bookmarksToolStripMenuItem, helpToolStripMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(1177, 24);
            MainMenuStrip.TabIndex = 0;
            MainMenuStrip.Text = "darkThemeMenuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reloadToolStripMenuItem, forwardToolStripMenuItem, backwardToolStripMenuItem, homeToolStripMenuItem, toolStripSeparator1, copyMediaURLToolStripMenuItem, showListToolStripMenuItem, addToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "E&dit";
            // 
            // reloadToolStripMenuItem
            // 
            reloadToolStripMenuItem.ForeColor = Color.White;
            reloadToolStripMenuItem.Image = (Image)resources.GetObject("reloadToolStripMenuItem.Image");
            reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            reloadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            reloadToolStripMenuItem.Size = new Size(166, 22);
            reloadToolStripMenuItem.Text = "&Reload";
            reloadToolStripMenuItem.Click += Refresh_Click;
            // 
            // forwardToolStripMenuItem
            // 
            forwardToolStripMenuItem.ForeColor = Color.White;
            forwardToolStripMenuItem.Image = (Image)resources.GetObject("forwardToolStripMenuItem.Image");
            forwardToolStripMenuItem.Name = "forwardToolStripMenuItem";
            forwardToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            forwardToolStripMenuItem.Size = new Size(166, 22);
            forwardToolStripMenuItem.Text = "&Forward";
            forwardToolStripMenuItem.Click += Forward_Click;
            // 
            // backwardToolStripMenuItem
            // 
            backwardToolStripMenuItem.ForeColor = Color.White;
            backwardToolStripMenuItem.Image = (Image)resources.GetObject("backwardToolStripMenuItem.Image");
            backwardToolStripMenuItem.Name = "backwardToolStripMenuItem";
            backwardToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
            backwardToolStripMenuItem.Size = new Size(166, 22);
            backwardToolStripMenuItem.Text = "&Backward";
            backwardToolStripMenuItem.Click += Backward_Click;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.ForeColor = Color.White;
            homeToolStripMenuItem.Image = (Image)resources.GetObject("homeToolStripMenuItem.Image");
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            homeToolStripMenuItem.Size = new Size(166, 22);
            homeToolStripMenuItem.Text = "&Home";
            homeToolStripMenuItem.Click += HomeToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(163, 6);
            // 
            // copyMediaURLToolStripMenuItem
            // 
            copyMediaURLToolStripMenuItem.Enabled = false;
            copyMediaURLToolStripMenuItem.ForeColor = Color.White;
            copyMediaURLToolStripMenuItem.Name = "copyMediaURLToolStripMenuItem";
            copyMediaURLToolStripMenuItem.Size = new Size(166, 22);
            copyMediaURLToolStripMenuItem.Text = "Copy &Media-URL";
            copyMediaURLToolStripMenuItem.Click += CopyMediaURLToolStripMenuItem_Click;
            // 
            // showListToolStripMenuItem
            // 
            showListToolStripMenuItem.ForeColor = Color.White;
            showListToolStripMenuItem.Image = (Image)resources.GetObject("showListToolStripMenuItem.Image");
            showListToolStripMenuItem.Name = "showListToolStripMenuItem";
            showListToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            showListToolStripMenuItem.Size = new Size(166, 22);
            showListToolStripMenuItem.Text = "&Show list";
            showListToolStripMenuItem.Click += ShowListToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Enabled = false;
            addToolStripMenuItem.ForeColor = Color.White;
            addToolStripMenuItem.Image = (Image)resources.GetObject("addToolStripMenuItem.Image");
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            addToolStripMenuItem.Size = new Size(166, 22);
            addToolStripMenuItem.Text = "&Add";
            addToolStripMenuItem.Click += Add_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(163, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.ForeColor = Color.White;
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(166, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // extrasToolStripMenuItem
            // 
            extrasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tagEditorToolStripMenuItem, converterToolStripMenuItem, newsToolStripMenuItem, marvinkleinmusicfavouritesToolStripMenuItem, toolStripSeparator3, settingsToolStripMenuItem });
            extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            extrasToolStripMenuItem.Size = new Size(49, 20);
            extrasToolStripMenuItem.Text = "E&xtras";
            // 
            // tagEditorToolStripMenuItem
            // 
            tagEditorToolStripMenuItem.ForeColor = Color.White;
            tagEditorToolStripMenuItem.Name = "tagEditorToolStripMenuItem";
            tagEditorToolStripMenuItem.Size = new Size(224, 22);
            tagEditorToolStripMenuItem.Text = "&Tag Editor";
            tagEditorToolStripMenuItem.Click += tagEditorToolStripMenuItem_Click;
            // 
            // converterToolStripMenuItem
            // 
            converterToolStripMenuItem.ForeColor = Color.White;
            converterToolStripMenuItem.Image = (Image)resources.GetObject("converterToolStripMenuItem.Image");
            converterToolStripMenuItem.Name = "converterToolStripMenuItem";
            converterToolStripMenuItem.Size = new Size(224, 22);
            converterToolStripMenuItem.Text = "&Converter";
            converterToolStripMenuItem.Click += ConverterToolStripMenuItem_Click;
            // 
            // newsToolStripMenuItem
            // 
            newsToolStripMenuItem.ForeColor = Color.White;
            newsToolStripMenuItem.Image = (Image)resources.GetObject("newsToolStripMenuItem.Image");
            newsToolStripMenuItem.Name = "newsToolStripMenuItem";
            newsToolStripMenuItem.Size = new Size(224, 22);
            newsToolStripMenuItem.Text = "N&ews";
            newsToolStripMenuItem.Click += NewsToolStripMenuItem_Click;
            // 
            // marvinkleinmusicfavouritesToolStripMenuItem
            // 
            marvinkleinmusicfavouritesToolStripMenuItem.ForeColor = Color.White;
            marvinkleinmusicfavouritesToolStripMenuItem.Image = (Image)resources.GetObject("marvinkleinmusicfavouritesToolStripMenuItem.Image");
            marvinkleinmusicfavouritesToolStripMenuItem.Name = "marvinkleinmusicfavouritesToolStripMenuItem";
            marvinkleinmusicfavouritesToolStripMenuItem.Size = new Size(224, 22);
            marvinkleinmusicfavouritesToolStripMenuItem.Text = "MarvinKleinMusic &favourites";
            marvinkleinmusicfavouritesToolStripMenuItem.Click += MarvinKleinMusicFavouritesToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(221, 6);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.ForeColor = Color.White;
            settingsToolStripMenuItem.Image = (Image)resources.GetObject("settingsToolStripMenuItem.Image");
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(224, 22);
            settingsToolStripMenuItem.Text = "&Settings";
            settingsToolStripMenuItem.Click += SettingsToolStripMenuItem_Click;
            // 
            // bookmarksToolStripMenuItem
            // 
            bookmarksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smuleToolStripMenuItem, yokeeKaraokeToolStripMenuItem, toolStripSeparator4, smuleloginToolStripMenuItem });
            bookmarksToolStripMenuItem.Name = "bookmarksToolStripMenuItem";
            bookmarksToolStripMenuItem.Size = new Size(78, 20);
            bookmarksToolStripMenuItem.Text = "B&ookmarks";
            // 
            // smuleToolStripMenuItem
            // 
            smuleToolStripMenuItem.ForeColor = Color.White;
            smuleToolStripMenuItem.Name = "smuleToolStripMenuItem";
            smuleToolStripMenuItem.Size = new Size(150, 22);
            smuleToolStripMenuItem.Text = "Sm&ule";
            smuleToolStripMenuItem.Click += SmuleToolStripMenuItem_Click;
            // 
            // yokeeKaraokeToolStripMenuItem
            // 
            yokeeKaraokeToolStripMenuItem.ForeColor = Color.White;
            yokeeKaraokeToolStripMenuItem.Name = "yokeeKaraokeToolStripMenuItem";
            yokeeKaraokeToolStripMenuItem.Size = new Size(150, 22);
            yokeeKaraokeToolStripMenuItem.Text = "Y&okee Karaoke";
            yokeeKaraokeToolStripMenuItem.Click += YokeeKaraokeToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(147, 6);
            // 
            // smuleloginToolStripMenuItem
            // 
            smuleloginToolStripMenuItem.ForeColor = Color.White;
            smuleloginToolStripMenuItem.Name = "smuleloginToolStripMenuItem";
            smuleloginToolStripMenuItem.Size = new Size(150, 22);
            smuleloginToolStripMenuItem.Text = "Smule &login";
            smuleloginToolStripMenuItem.Click += SmuleloginToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpToolStripMenuItem1, websiteToolStripMenuItem, searchForupdateToolStripMenuItem, sendFeedbackToolStripMenuItem, toolStripSeparator5, licensesToolStripMenuItem, aboutSownloader8ToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.ForeColor = Color.White;
            helpToolStripMenuItem1.Image = (Image)resources.GetObject("helpToolStripMenuItem1.Image");
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(181, 22);
            helpToolStripMenuItem1.Text = "&Help";
            helpToolStripMenuItem1.Click += HelpToolStripMenuItem1_Click;
            // 
            // websiteToolStripMenuItem
            // 
            websiteToolStripMenuItem.ForeColor = Color.White;
            websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            websiteToolStripMenuItem.Size = new Size(181, 22);
            websiteToolStripMenuItem.Text = "&Website";
            websiteToolStripMenuItem.Click += WebsiteToolStripMenuItem_Click;
            // 
            // searchForupdateToolStripMenuItem
            // 
            searchForupdateToolStripMenuItem.ForeColor = Color.White;
            searchForupdateToolStripMenuItem.Image = (Image)resources.GetObject("searchForupdateToolStripMenuItem.Image");
            searchForupdateToolStripMenuItem.Name = "searchForupdateToolStripMenuItem";
            searchForupdateToolStripMenuItem.Size = new Size(181, 22);
            searchForupdateToolStripMenuItem.Text = "Search for &update";
            searchForupdateToolStripMenuItem.Click += searchForupdateToolStripMenuItem_Click;
            // 
            // sendFeedbackToolStripMenuItem
            // 
            sendFeedbackToolStripMenuItem.ForeColor = Color.White;
            sendFeedbackToolStripMenuItem.Name = "sendFeedbackToolStripMenuItem";
            sendFeedbackToolStripMenuItem.Size = new Size(181, 22);
            sendFeedbackToolStripMenuItem.Text = "S&end feedback...";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(178, 6);
            // 
            // licensesToolStripMenuItem
            // 
            licensesToolStripMenuItem.ForeColor = Color.White;
            licensesToolStripMenuItem.Name = "licensesToolStripMenuItem";
            licensesToolStripMenuItem.Size = new Size(181, 22);
            licensesToolStripMenuItem.Text = "L&icenses";
            licensesToolStripMenuItem.Click += LicensesToolStripMenuItem_Click;
            // 
            // aboutSownloader8ToolStripMenuItem
            // 
            aboutSownloader8ToolStripMenuItem.ForeColor = Color.White;
            aboutSownloader8ToolStripMenuItem.Name = "aboutSownloader8ToolStripMenuItem";
            aboutSownloader8ToolStripMenuItem.Size = new Size(181, 22);
            aboutSownloader8ToolStripMenuItem.Text = "About Sownloader 8";
            aboutSownloader8ToolStripMenuItem.Click += AboutSownloader8ToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.ForeColor = Color.White;
            aboutToolStripMenuItem.Image = (Image)resources.GetObject("aboutToolStripMenuItem.Image");
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys = Keys.F12;
            aboutToolStripMenuItem.Size = new Size(181, 22);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // PanelNavigation
            // 
            PanelNavigation.Controls.Add(ButtonDownload);
            PanelNavigation.Controls.Add(ButtonAdd);
            PanelNavigation.Controls.Add(ButtonGoToUrl);
            PanelNavigation.Controls.Add(ButtonRefresh);
            PanelNavigation.Controls.Add(TextBoxUrl);
            PanelNavigation.Controls.Add(ButtonForward);
            PanelNavigation.Controls.Add(ButtonBack);
            PanelNavigation.Dock = DockStyle.Top;
            PanelNavigation.Location = new Point(0, 24);
            PanelNavigation.Name = "PanelNavigation";
            PanelNavigation.Size = new Size(1177, 38);
            PanelNavigation.TabIndex = 1;
            // 
            // ButtonDownload
            // 
            ButtonDownload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonDownload.BackColor = Color.FromArgb(69, 69, 73);
            ButtonDownload.DisabledForeColor = Color.Gray;
            ButtonDownload.Enabled = false;
            ButtonDownload.EnabledForeColor = Color.White;
            ButtonDownload.FlatAppearance.BorderColor = Color.FromArgb(69, 69, 73);
            ButtonDownload.FlatStyle = FlatStyle.Flat;
            ButtonDownload.ForeColor = Color.White;
            ButtonDownload.Location = new Point(1096, 7);
            ButtonDownload.Name = "ButtonDownload";
            ButtonDownload.Size = new Size(78, 26);
            ButtonDownload.TabIndex = 6;
            ButtonDownload.Text = "&Download";
            ButtonDownload.UseVisualStyleBackColor = false;
            ButtonDownload.Click += ButtonDownload_Click;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonAdd.BackColor = Color.FromArgb(69, 69, 73);
            ButtonAdd.DisabledForeColor = Color.Gray;
            ButtonAdd.Enabled = false;
            ButtonAdd.EnabledForeColor = Color.White;
            ButtonAdd.FlatAppearance.BorderColor = Color.FromArgb(69, 69, 73);
            ButtonAdd.FlatStyle = FlatStyle.Flat;
            ButtonAdd.ForeColor = Color.White;
            ButtonAdd.Location = new Point(1040, 7);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(50, 26);
            ButtonAdd.TabIndex = 5;
            ButtonAdd.Text = "&Add";
            ButtonAdd.UseVisualStyleBackColor = false;
            ButtonAdd.Click += Add_Click;
            // 
            // ButtonGoToUrl
            // 
            ButtonGoToUrl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonGoToUrl.FlatAppearance.BorderSize = 0;
            ButtonGoToUrl.FlatStyle = FlatStyle.Flat;
            ButtonGoToUrl.ForeColor = Color.White;
            ButtonGoToUrl.Image = (Image)resources.GetObject("ButtonGoToUrl.Image");
            ButtonGoToUrl.Location = new Point(1009, 7);
            ButtonGoToUrl.Name = "ButtonGoToUrl";
            ButtonGoToUrl.Size = new Size(25, 25);
            ButtonGoToUrl.TabIndex = 4;
            ButtonGoToUrl.UseVisualStyleBackColor = true;
            ButtonGoToUrl.Click += ButtonGoToUrl_Click;
            // 
            // ButtonRefresh
            // 
            ButtonRefresh.FlatAppearance.BorderSize = 0;
            ButtonRefresh.FlatStyle = FlatStyle.Flat;
            ButtonRefresh.ForeColor = Color.White;
            ButtonRefresh.Image = (Image)resources.GetObject("ButtonRefresh.Image");
            ButtonRefresh.Location = new Point(65, 7);
            ButtonRefresh.Name = "ButtonRefresh";
            ButtonRefresh.Size = new Size(25, 25);
            ButtonRefresh.TabIndex = 2;
            ButtonRefresh.UseVisualStyleBackColor = true;
            ButtonRefresh.Click += Refresh_Click;
            // 
            // TextBoxUrl
            // 
            TextBoxUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxUrl.BackColor = Color.FromArgb(61, 61, 65);
            TextBoxUrl.BorderStyle = BorderStyle.FixedSingle;
            TextBoxUrl.Font = new Font("Consolas", 12F);
            TextBoxUrl.ForeColor = Color.White;
            TextBoxUrl.Location = new Point(96, 6);
            TextBoxUrl.Name = "TextBoxUrl";
            TextBoxUrl.Size = new Size(907, 26);
            TextBoxUrl.TabIndex = 3;
            TextBoxUrl.KeyUp += TextBoxUrl_KeyUp;
            // 
            // ButtonForward
            // 
            ButtonForward.FlatAppearance.BorderSize = 0;
            ButtonForward.FlatStyle = FlatStyle.Flat;
            ButtonForward.ForeColor = Color.White;
            ButtonForward.Image = (Image)resources.GetObject("ButtonForward.Image");
            ButtonForward.Location = new Point(34, 7);
            ButtonForward.Name = "ButtonForward";
            ButtonForward.Size = new Size(25, 25);
            ButtonForward.TabIndex = 1;
            ButtonForward.UseVisualStyleBackColor = true;
            ButtonForward.Click += Forward_Click;
            // 
            // ButtonBack
            // 
            ButtonBack.Enabled = false;
            ButtonBack.FlatAppearance.BorderSize = 0;
            ButtonBack.FlatStyle = FlatStyle.Flat;
            ButtonBack.ForeColor = Color.White;
            ButtonBack.Image = (Image)resources.GetObject("ButtonBack.Image");
            ButtonBack.Location = new Point(3, 7);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(25, 25);
            ButtonBack.TabIndex = 0;
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += Backward_Click;
            // 
            // MainWebView
            // 
            MainWebView.AllowExternalDrop = false;
            MainWebView.CausesValidation = false;
            MainWebView.CreationProperties = null;
            MainWebView.DefaultBackgroundColor = Color.White;
            MainWebView.Dock = DockStyle.Fill;
            MainWebView.Location = new Point(0, 62);
            MainWebView.Name = "MainWebView";
            MainWebView.Size = new Size(1177, 640);
            MainWebView.TabIndex = 2;
            MainWebView.ZoomFactor = 1D;
            MainWebView.NavigationStarting += MainWebView_NavigationStarting;
            MainWebView.NavigationCompleted += MainWebView_NavigationCompleted;
            MainWebView.ContentLoading += MainWebView_ContentLoading;
            MainWebView.LocationChanged += MainWebView_LocationChanged;
            // 
            // PanelFooter
            // 
            PanelFooter.Controls.Add(ProgressbarFortschritt);
            PanelFooter.Dock = DockStyle.Bottom;
            PanelFooter.Location = new Point(0, 702);
            PanelFooter.Name = "PanelFooter";
            PanelFooter.Size = new Size(1177, 31);
            PanelFooter.TabIndex = 3;
            PanelFooter.Visible = false;
            // 
            // ProgressbarFortschritt
            // 
            ProgressbarFortschritt.Location = new Point(969, 5);
            ProgressbarFortschritt.Name = "ProgressbarFortschritt";
            ProgressbarFortschritt.Size = new Size(196, 23);
            ProgressbarFortschritt.TabIndex = 0;
            // 
            // PanelList
            // 
            PanelList.Controls.Add(ButtonRemove);
            PanelList.Controls.Add(DataGridViewDownloads);
            PanelList.Dock = DockStyle.Fill;
            PanelList.Location = new Point(0, 62);
            PanelList.Name = "PanelList";
            PanelList.Size = new Size(1177, 640);
            PanelList.TabIndex = 4;
            PanelList.Visible = false;
            // 
            // ButtonRemove
            // 
            ButtonRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonRemove.BackColor = Color.FromArgb(69, 69, 73);
            ButtonRemove.DisabledForeColor = Color.Gray;
            ButtonRemove.Enabled = false;
            ButtonRemove.EnabledForeColor = Color.White;
            ButtonRemove.FlatAppearance.BorderColor = Color.FromArgb(69, 69, 73);
            ButtonRemove.FlatStyle = FlatStyle.Flat;
            ButtonRemove.ForeColor = Color.White;
            ButtonRemove.Location = new Point(3, 598);
            ButtonRemove.Name = "ButtonRemove";
            ButtonRemove.Size = new Size(143, 36);
            ButtonRemove.TabIndex = 1;
            ButtonRemove.Text = "&Remove";
            ButtonRemove.UseVisualStyleBackColor = false;
            ButtonRemove.Click += ButtonRemove_Click;
            // 
            // DataGridViewDownloads
            // 
            DataGridViewDownloads.AllowUserToAddRows = false;
            DataGridViewDownloads.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewDownloads.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewDownloads.BackgroundColor = Color.FromArgb(45, 45, 48);
            DataGridViewDownloads.BorderStyle = BorderStyle.None;
            DataGridViewDownloads.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewDownloads.Location = new Point(3, 3);
            DataGridViewDownloads.Name = "DataGridViewDownloads";
            DataGridViewDownloads.RowHeadersVisible = false;
            DataGridViewDownloads.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewDownloads.Size = new Size(1171, 589);
            DataGridViewDownloads.TabIndex = 0;
            DataGridViewDownloads.SelectionChanged += DataGridViewDownloads_SelectionChanged;
            // 
            // MainForm
            // 
            AcceptButton = ButtonGoToUrl;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(1177, 733);
            Controls.Add(PanelList);
            Controls.Add(MainWebView);
            Controls.Add(PanelFooter);
            Controls.Add(PanelNavigation);
            Controls.Add(MainMenuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sownloader";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            PanelNavigation.ResumeLayout(false);
            PanelNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MainWebView).EndInit();
            PanelFooter.ResumeLayout(false);
            PanelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewDownloads).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
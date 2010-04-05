namespace uTorrentNotifier
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWebUI_URL = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.systrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.systrayMenuStrip = new System.Windows.Forms.ContextMenu();
            this.tsmiStartAll = new System.Windows.Forms.MenuItem();
            this.tsmiPauseAll = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.tsmiSettings = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.tsmiClose = new System.Windows.Forms.MenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbProwlEnable = new System.Windows.Forms.CheckBox();
            this.tbProwlAPIKey = new System.Windows.Forms.TextBox();
            this.lblProwlAPIKey = new System.Windows.Forms.Label();
            this.cbShowBalloonTips = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbRunOnStartup = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.tbProwl = new System.Windows.Forms.TabPage();
            this.tpNotifications = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbProwlNotification_TorentAdded = new System.Windows.Forms.CheckBox();
            this.cbTorrentNotification_DownloadComplete = new System.Windows.Forms.CheckBox();
            this.tbAbout = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cbCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tbProwl.SuspendLayout();
            this.tpNotifications.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tbAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Location = new System.Drawing.Point(6, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credentials";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(67, 56);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(171, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(67, 22);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(171, 20);
            this.tbUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 59);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 25);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbWebUI_URL);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 60);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WebUI URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "e.x. http://localhost/gui/";
            // 
            // tbWebUI_URL
            // 
            this.tbWebUI_URL.Location = new System.Drawing.Point(6, 19);
            this.tbWebUI_URL.Name = "tbWebUI_URL";
            this.tbWebUI_URL.Size = new System.Drawing.Size(232, 20);
            this.tbWebUI_URL.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(12, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(201, 284);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // systrayIcon
            // 
            this.systrayIcon.ContextMenu = this.systrayMenuStrip;
            this.systrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("systrayIcon.Icon")));
            this.systrayIcon.Text = "uTorrent Notifier";
            this.systrayIcon.Visible = true;
            this.systrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.systrayIcon_MouseDoubleClick);
            // 
            // systrayMenuStrip
            // 
            this.systrayMenuStrip.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.tsmiStartAll,
            this.tsmiPauseAll,
            this.menuItem2,
            this.tsmiSettings,
            this.menuItem1,
            this.tsmiClose});
            // 
            // tsmiStartAll
            // 
            this.tsmiStartAll.Index = 0;
            this.tsmiStartAll.Text = "Start All";
            this.tsmiStartAll.Click += new System.EventHandler(this.tsmiStartAll_Click);
            // 
            // tsmiPauseAll
            // 
            this.tsmiPauseAll.Index = 1;
            this.tsmiPauseAll.Text = "Pause All";
            this.tsmiPauseAll.Click += new System.EventHandler(this.tsmiPauseAll_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "-";
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.Index = 3;
            this.tsmiSettings.Text = "Settings";
            this.tsmiSettings.Click += new System.EventHandler(this.tsmiSettings_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 4;
            this.menuItem1.Text = "-";
            // 
            // tsmiClose
            // 
            this.tsmiClose.Index = 5;
            this.tsmiClose.Text = "Exit";
            this.tsmiClose.Click += new System.EventHandler(this.tsmiClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbProwlEnable);
            this.groupBox3.Controls.Add(this.tbProwlAPIKey);
            this.groupBox3.Controls.Add(this.lblProwlAPIKey);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 70);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // cbProwlEnable
            // 
            this.cbProwlEnable.AutoSize = true;
            this.cbProwlEnable.Location = new System.Drawing.Point(9, 20);
            this.cbProwlEnable.Name = "cbProwlEnable";
            this.cbProwlEnable.Size = new System.Drawing.Size(59, 17);
            this.cbProwlEnable.TabIndex = 1;
            this.cbProwlEnable.Text = "Enable";
            this.cbProwlEnable.UseVisualStyleBackColor = true;
            // 
            // tbProwlAPIKey
            // 
            this.tbProwlAPIKey.Location = new System.Drawing.Point(74, 44);
            this.tbProwlAPIKey.Name = "tbProwlAPIKey";
            this.tbProwlAPIKey.Size = new System.Drawing.Size(163, 20);
            this.tbProwlAPIKey.TabIndex = 2;
            // 
            // lblProwlAPIKey
            // 
            this.lblProwlAPIKey.AutoSize = true;
            this.lblProwlAPIKey.Location = new System.Drawing.Point(7, 47);
            this.lblProwlAPIKey.Name = "lblProwlAPIKey";
            this.lblProwlAPIKey.Size = new System.Drawing.Size(45, 13);
            this.lblProwlAPIKey.TabIndex = 0;
            this.lblProwlAPIKey.Text = "API Key";
            // 
            // cbShowBalloonTips
            // 
            this.cbShowBalloonTips.AutoSize = true;
            this.cbShowBalloonTips.Location = new System.Drawing.Point(111, 20);
            this.cbShowBalloonTips.Name = "cbShowBalloonTips";
            this.cbShowBalloonTips.Size = new System.Drawing.Size(114, 17);
            this.cbShowBalloonTips.TabIndex = 3;
            this.cbShowBalloonTips.Text = "Show Balloon Tips";
            this.cbShowBalloonTips.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbCheckForUpdates);
            this.groupBox4.Controls.Add(this.cbShowBalloonTips);
            this.groupBox4.Controls.Add(this.cbRunOnStartup);
            this.groupBox4.Location = new System.Drawing.Point(6, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 72);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Windows";
            // 
            // cbRunOnStartup
            // 
            this.cbRunOnStartup.AutoSize = true;
            this.cbRunOnStartup.Location = new System.Drawing.Point(9, 20);
            this.cbRunOnStartup.Name = "cbRunOnStartup";
            this.cbRunOnStartup.Size = new System.Drawing.Size(96, 17);
            this.cbRunOnStartup.TabIndex = 0;
            this.cbRunOnStartup.Text = "Run on startup";
            this.cbRunOnStartup.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpGeneral);
            this.tabControl1.Controls.Add(this.tbProwl);
            this.tabControl1.Controls.Add(this.tpNotifications);
            this.tabControl1.Controls.Add(this.tbAbout);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(264, 266);
            this.tabControl1.TabIndex = 7;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.groupBox2);
            this.tpGeneral.Controls.Add(this.groupBox1);
            this.tpGeneral.Controls.Add(this.groupBox4);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(256, 240);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // tbProwl
            // 
            this.tbProwl.Controls.Add(this.groupBox3);
            this.tbProwl.Location = new System.Drawing.Point(4, 22);
            this.tbProwl.Name = "tbProwl";
            this.tbProwl.Padding = new System.Windows.Forms.Padding(3);
            this.tbProwl.Size = new System.Drawing.Size(256, 215);
            this.tbProwl.TabIndex = 1;
            this.tbProwl.Text = "Prowl";
            this.tbProwl.UseVisualStyleBackColor = true;
            // 
            // tpNotifications
            // 
            this.tpNotifications.Controls.Add(this.groupBox5);
            this.tpNotifications.Location = new System.Drawing.Point(4, 22);
            this.tpNotifications.Name = "tpNotifications";
            this.tpNotifications.Size = new System.Drawing.Size(256, 215);
            this.tpNotifications.TabIndex = 2;
            this.tpNotifications.Text = "Notifications";
            this.tpNotifications.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbProwlNotification_TorentAdded);
            this.groupBox5.Controls.Add(this.cbTorrentNotification_DownloadComplete);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(244, 206);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Settings";
            // 
            // cbProwlNotification_TorentAdded
            // 
            this.cbProwlNotification_TorentAdded.AutoSize = true;
            this.cbProwlNotification_TorentAdded.Location = new System.Drawing.Point(9, 20);
            this.cbProwlNotification_TorentAdded.Name = "cbProwlNotification_TorentAdded";
            this.cbProwlNotification_TorentAdded.Size = new System.Drawing.Size(94, 17);
            this.cbProwlNotification_TorentAdded.TabIndex = 4;
            this.cbProwlNotification_TorentAdded.Text = "Torrent Added";
            this.cbProwlNotification_TorentAdded.UseVisualStyleBackColor = true;
            // 
            // cbTorrentNotification_DownloadComplete
            // 
            this.cbTorrentNotification_DownloadComplete.AutoSize = true;
            this.cbTorrentNotification_DownloadComplete.Location = new System.Drawing.Point(9, 43);
            this.cbTorrentNotification_DownloadComplete.Name = "cbTorrentNotification_DownloadComplete";
            this.cbTorrentNotification_DownloadComplete.Size = new System.Drawing.Size(121, 17);
            this.cbTorrentNotification_DownloadComplete.TabIndex = 5;
            this.cbTorrentNotification_DownloadComplete.Text = "Download Complete";
            this.cbTorrentNotification_DownloadComplete.UseVisualStyleBackColor = true;
            // 
            // tbAbout
            // 
            this.tbAbout.Controls.Add(this.linkLabel1);
            this.tbAbout.Controls.Add(this.lblVersion);
            this.tbAbout.Controls.Add(this.label2);
            this.tbAbout.Location = new System.Drawing.Point(4, 22);
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.Size = new System.Drawing.Size(256, 240);
            this.tbAbout.TabIndex = 3;
            this.tbAbout.Text = "About";
            this.tbAbout.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "uTorrent Notifier";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(14, 35);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(37, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "v0.4.1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(14, 63);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Eric Holmes";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cbCheckForUpdates
            // 
            this.cbCheckForUpdates.AutoSize = true;
            this.cbCheckForUpdates.Location = new System.Drawing.Point(9, 45);
            this.cbCheckForUpdates.Name = "cbCheckForUpdates";
            this.cbCheckForUpdates.Size = new System.Drawing.Size(113, 17);
            this.cbCheckForUpdates.TabIndex = 4;
            this.cbCheckForUpdates.Text = "Check for updates";
            this.cbCheckForUpdates.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 319);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::uTorrentNotifier.Properties.Resources.un_icon;
            this.Name = "SettingsForm";
            this.Text = "uTorrent Notifier";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Shown += new System.EventHandler(this.Settings_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tbProwl.ResumeLayout(false);
            this.tpNotifications.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tbAbout.ResumeLayout(false);
            this.tbAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbWebUI_URL;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NotifyIcon systrayIcon;
        private System.Windows.Forms.ContextMenu systrayMenuStrip;
        private System.Windows.Forms.MenuItem tsmiSettings;
        private System.Windows.Forms.MenuItem tsmiClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbProwlAPIKey;
        private System.Windows.Forms.Label lblProwlAPIKey;
        private System.Windows.Forms.CheckBox cbShowBalloonTips;
        private System.Windows.Forms.CheckBox cbProwlEnable;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbRunOnStartup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuItem tsmiStartAll;
        private System.Windows.Forms.MenuItem tsmiPauseAll;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tbProwl;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbTorrentNotification_DownloadComplete;
        private System.Windows.Forms.CheckBox cbProwlNotification_TorentAdded;
        private System.Windows.Forms.TabPage tpNotifications;
        private System.Windows.Forms.TabPage tbAbout;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbCheckForUpdates;

    }
}


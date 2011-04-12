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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbProwlEnable = new System.Windows.Forms.CheckBox();
            this.tbProwlAPIKey = new System.Windows.Forms.TextBox();
            this.lblProwlAPIKey = new System.Windows.Forms.Label();
            this.cbShowBalloonTips = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.cbRunOnStartup = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.tpProwl = new System.Windows.Forms.TabPage();
            this.tpGrowl = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tbGrowlPort = new System.Windows.Forms.TextBox();
            this.lblGrowlPort = new System.Windows.Forms.Label();
            this.tbGrowlHost = new System.Windows.Forms.TextBox();
            this.lblGrowlHost = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbGrowlEnable = new System.Windows.Forms.CheckBox();
            this.tbGrowlPassword = new System.Windows.Forms.TextBox();
            this.lblGrowlPassword = new System.Windows.Forms.Label();
            this.tpTwitter = new System.Windows.Forms.TabPage();
            this.btnSendTestTweet = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cbTwitterEnable = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTwitterAuthorize = new System.Windows.Forms.Button();
            this.btnStartAuthorization = new System.Windows.Forms.Button();
            this.tbTwitterPIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTwitterPIN = new System.Windows.Forms.Label();
            this.tpBoxcar = new System.Windows.Forms.TabPage();
            this.btnBoxcarInvite = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tbBoxcarEmail = new System.Windows.Forms.TextBox();
            this.lblBoxcarEmail = new System.Windows.Forms.Label();
            this.cbBoxcarEnable = new System.Windows.Forms.CheckBox();
            this.tpNotifications = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbProwlNotification_TorentAdded = new System.Windows.Forms.CheckBox();
            this.cbTorrentNotification_DownloadComplete = new System.Windows.Forms.CheckBox();
            this.tbAbout = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tpProwl.SuspendLayout();
            this.tpGrowl.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tpTwitter.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tpBoxcar.SuspendLayout();
            this.groupBox10.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(288, 84);
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
            this.groupBox2.Size = new System.Drawing.Size(288, 60);
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
            this.tbWebUI_URL.Size = new System.Drawing.Size(276, 20);
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
            this.btnCancel.Location = new System.Drawing.Point(245, 284);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbProwlEnable);
            this.groupBox3.Controls.Add(this.tbProwlAPIKey);
            this.groupBox3.Controls.Add(this.lblProwlAPIKey);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 72);
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
            this.groupBox4.Size = new System.Drawing.Size(288, 72);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Windows";
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
            this.tabControl1.Controls.Add(this.tpProwl);
            this.tabControl1.Controls.Add(this.tpGrowl);
            this.tabControl1.Controls.Add(this.tpTwitter);
            this.tabControl1.Controls.Add(this.tpBoxcar);
            this.tabControl1.Controls.Add(this.tpNotifications);
            this.tabControl1.Controls.Add(this.tbAbout);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(308, 266);
            this.tabControl1.TabIndex = 7;
            // 
            // tpGeneral
            // 
            this.tpGeneral.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpGeneral.Controls.Add(this.groupBox2);
            this.tpGeneral.Controls.Add(this.groupBox1);
            this.tpGeneral.Controls.Add(this.groupBox4);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(300, 240);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // tpProwl
            // 
            this.tpProwl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpProwl.Controls.Add(this.groupBox3);
            this.tpProwl.Location = new System.Drawing.Point(4, 22);
            this.tpProwl.Name = "tpProwl";
            this.tpProwl.Padding = new System.Windows.Forms.Padding(3);
            this.tpProwl.Size = new System.Drawing.Size(300, 240);
            this.tpProwl.TabIndex = 1;
            this.tpProwl.Text = "Prowl";
            this.tpProwl.UseVisualStyleBackColor = true;
            // 
            // tpGrowl
            // 
            this.tpGrowl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpGrowl.Controls.Add(this.groupBox7);
            this.tpGrowl.Controls.Add(this.groupBox6);
            this.tpGrowl.Location = new System.Drawing.Point(4, 22);
            this.tpGrowl.Name = "tpGrowl";
            this.tpGrowl.Padding = new System.Windows.Forms.Padding(3);
            this.tpGrowl.Size = new System.Drawing.Size(300, 240);
            this.tpGrowl.TabIndex = 4;
            this.tpGrowl.Text = "Growl";
            this.tpGrowl.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tbGrowlPort);
            this.groupBox7.Controls.Add(this.lblGrowlPort);
            this.groupBox7.Controls.Add(this.tbGrowlHost);
            this.groupBox7.Controls.Add(this.lblGrowlHost);
            this.groupBox7.Location = new System.Drawing.Point(6, 83);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(288, 73);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Optional Host";
            // 
            // tbGrowlPort
            // 
            this.tbGrowlPort.Location = new System.Drawing.Point(74, 45);
            this.tbGrowlPort.Name = "tbGrowlPort";
            this.tbGrowlPort.Size = new System.Drawing.Size(163, 20);
            this.tbGrowlPort.TabIndex = 11;
            // 
            // lblGrowlPort
            // 
            this.lblGrowlPort.AutoSize = true;
            this.lblGrowlPort.Location = new System.Drawing.Point(7, 48);
            this.lblGrowlPort.Name = "lblGrowlPort";
            this.lblGrowlPort.Size = new System.Drawing.Size(26, 13);
            this.lblGrowlPort.TabIndex = 10;
            this.lblGrowlPort.Text = "Port";
            // 
            // tbGrowlHost
            // 
            this.tbGrowlHost.Location = new System.Drawing.Point(74, 19);
            this.tbGrowlHost.Name = "tbGrowlHost";
            this.tbGrowlHost.Size = new System.Drawing.Size(163, 20);
            this.tbGrowlHost.TabIndex = 9;
            // 
            // lblGrowlHost
            // 
            this.lblGrowlHost.AutoSize = true;
            this.lblGrowlHost.Location = new System.Drawing.Point(7, 22);
            this.lblGrowlHost.Name = "lblGrowlHost";
            this.lblGrowlHost.Size = new System.Drawing.Size(29, 13);
            this.lblGrowlHost.TabIndex = 8;
            this.lblGrowlHost.Text = "Host";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbGrowlEnable);
            this.groupBox6.Controls.Add(this.tbGrowlPassword);
            this.groupBox6.Controls.Add(this.lblGrowlPassword);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(288, 72);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Settings";
            // 
            // cbGrowlEnable
            // 
            this.cbGrowlEnable.AutoSize = true;
            this.cbGrowlEnable.Location = new System.Drawing.Point(9, 20);
            this.cbGrowlEnable.Name = "cbGrowlEnable";
            this.cbGrowlEnable.Size = new System.Drawing.Size(59, 17);
            this.cbGrowlEnable.TabIndex = 1;
            this.cbGrowlEnable.Text = "Enable";
            this.cbGrowlEnable.UseVisualStyleBackColor = true;
            // 
            // tbGrowlPassword
            // 
            this.tbGrowlPassword.Location = new System.Drawing.Point(74, 44);
            this.tbGrowlPassword.Name = "tbGrowlPassword";
            this.tbGrowlPassword.Size = new System.Drawing.Size(163, 20);
            this.tbGrowlPassword.TabIndex = 2;
            // 
            // lblGrowlPassword
            // 
            this.lblGrowlPassword.AutoSize = true;
            this.lblGrowlPassword.Location = new System.Drawing.Point(7, 47);
            this.lblGrowlPassword.Name = "lblGrowlPassword";
            this.lblGrowlPassword.Size = new System.Drawing.Size(53, 13);
            this.lblGrowlPassword.TabIndex = 0;
            this.lblGrowlPassword.Text = "Password";
            // 
            // tpTwitter
            // 
            this.tpTwitter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpTwitter.Controls.Add(this.btnSendTestTweet);
            this.tpTwitter.Controls.Add(this.groupBox9);
            this.tpTwitter.Controls.Add(this.groupBox8);
            this.tpTwitter.Location = new System.Drawing.Point(4, 22);
            this.tpTwitter.Name = "tpTwitter";
            this.tpTwitter.Padding = new System.Windows.Forms.Padding(3);
            this.tpTwitter.Size = new System.Drawing.Size(300, 240);
            this.tpTwitter.TabIndex = 5;
            this.tpTwitter.Text = "Twitter";
            this.tpTwitter.UseVisualStyleBackColor = true;
            // 
            // btnSendTestTweet
            // 
            this.btnSendTestTweet.Location = new System.Drawing.Point(168, 206);
            this.btnSendTestTweet.Name = "btnSendTestTweet";
            this.btnSendTestTweet.Size = new System.Drawing.Size(125, 23);
            this.btnSendTestTweet.TabIndex = 8;
            this.btnSendTestTweet.Text = "Send test Tweet";
            this.btnSendTestTweet.UseVisualStyleBackColor = true;
            this.btnSendTestTweet.Click += new System.EventHandler(this.btnSendTestTweet_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cbTwitterEnable);
            this.groupBox9.Location = new System.Drawing.Point(6, 150);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(288, 50);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Settings";
            // 
            // cbTwitterEnable
            // 
            this.cbTwitterEnable.AutoSize = true;
            this.cbTwitterEnable.Location = new System.Drawing.Point(9, 20);
            this.cbTwitterEnable.Name = "cbTwitterEnable";
            this.cbTwitterEnable.Size = new System.Drawing.Size(59, 17);
            this.cbTwitterEnable.TabIndex = 1;
            this.cbTwitterEnable.Text = "Enable";
            this.cbTwitterEnable.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.btnTwitterAuthorize);
            this.groupBox8.Controls.Add(this.btnStartAuthorization);
            this.groupBox8.Controls.Add(this.tbTwitterPIN);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.lblTwitterPIN);
            this.groupBox8.Location = new System.Drawing.Point(6, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(288, 139);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Authorization";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Like any Twitter client, uTorrent Notifier must be authorized to send tweets if y" +
                "ou wish to use this feature.";
            // 
            // btnTwitterAuthorize
            // 
            this.btnTwitterAuthorize.Enabled = false;
            this.btnTwitterAuthorize.Location = new System.Drawing.Point(127, 101);
            this.btnTwitterAuthorize.Name = "btnTwitterAuthorize";
            this.btnTwitterAuthorize.Size = new System.Drawing.Size(75, 23);
            this.btnTwitterAuthorize.TabIndex = 6;
            this.btnTwitterAuthorize.Text = "Authorize";
            this.btnTwitterAuthorize.UseVisualStyleBackColor = true;
            this.btnTwitterAuthorize.Click += new System.EventHandler(this.btnTwitterAuthorize_Click);
            // 
            // btnStartAuthorization
            // 
            this.btnStartAuthorization.Location = new System.Drawing.Point(6, 59);
            this.btnStartAuthorization.Name = "btnStartAuthorization";
            this.btnStartAuthorization.Size = new System.Drawing.Size(128, 23);
            this.btnStartAuthorization.TabIndex = 5;
            this.btnStartAuthorization.Text = "Start authorization";
            this.btnStartAuthorization.UseVisualStyleBackColor = true;
            this.btnStartAuthorization.Click += new System.EventHandler(this.btnStartAuthorization_Click);
            // 
            // tbTwitterPIN
            // 
            this.tbTwitterPIN.Enabled = false;
            this.tbTwitterPIN.Location = new System.Drawing.Point(34, 103);
            this.tbTwitterPIN.Name = "tbTwitterPIN";
            this.tbTwitterPIN.Size = new System.Drawing.Size(87, 20);
            this.tbTwitterPIN.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 1;
            // 
            // lblTwitterPIN
            // 
            this.lblTwitterPIN.AutoSize = true;
            this.lblTwitterPIN.Location = new System.Drawing.Point(6, 106);
            this.lblTwitterPIN.Name = "lblTwitterPIN";
            this.lblTwitterPIN.Size = new System.Drawing.Size(25, 13);
            this.lblTwitterPIN.TabIndex = 0;
            this.lblTwitterPIN.Text = "PIN";
            // 
            // tpBoxcar
            // 
            this.tpBoxcar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpBoxcar.Controls.Add(this.btnBoxcarInvite);
            this.tpBoxcar.Controls.Add(this.groupBox10);
            this.tpBoxcar.Location = new System.Drawing.Point(4, 22);
            this.tpBoxcar.Name = "tpBoxcar";
            this.tpBoxcar.Size = new System.Drawing.Size(300, 240);
            this.tpBoxcar.TabIndex = 5;
            this.tpBoxcar.Text = "Boxcar";
            this.tpBoxcar.UseVisualStyleBackColor = true;
            // 
            // btnBoxcarInvite
            // 
            this.btnBoxcarInvite.Location = new System.Drawing.Point(6, 85);
            this.btnBoxcarInvite.Name = "btnBoxcarInvite";
            this.btnBoxcarInvite.Size = new System.Drawing.Size(126, 23);
            this.btnBoxcarInvite.TabIndex = 1;
            this.btnBoxcarInvite.Text = "Send Boxcar Invitation";
            this.btnBoxcarInvite.UseVisualStyleBackColor = true;
            this.btnBoxcarInvite.Click += new System.EventHandler(this.btnBoxcarInvite_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.tbBoxcarEmail);
            this.groupBox10.Controls.Add(this.lblBoxcarEmail);
            this.groupBox10.Controls.Add(this.cbBoxcarEnable);
            this.groupBox10.Location = new System.Drawing.Point(6, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(288, 72);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Settings";
            // 
            // tbBoxcarEmail
            // 
            this.tbBoxcarEmail.Location = new System.Drawing.Point(48, 44);
            this.tbBoxcarEmail.Name = "tbBoxcarEmail";
            this.tbBoxcarEmail.Size = new System.Drawing.Size(189, 20);
            this.tbBoxcarEmail.TabIndex = 2;
            // 
            // lblBoxcarEmail
            // 
            this.lblBoxcarEmail.AutoSize = true;
            this.lblBoxcarEmail.Location = new System.Drawing.Point(7, 47);
            this.lblBoxcarEmail.Name = "lblBoxcarEmail";
            this.lblBoxcarEmail.Size = new System.Drawing.Size(32, 13);
            this.lblBoxcarEmail.TabIndex = 1;
            this.lblBoxcarEmail.Text = "Email";
            // 
            // cbBoxcarEnable
            // 
            this.cbBoxcarEnable.AutoSize = true;
            this.cbBoxcarEnable.Location = new System.Drawing.Point(9, 20);
            this.cbBoxcarEnable.Name = "cbBoxcarEnable";
            this.cbBoxcarEnable.Size = new System.Drawing.Size(59, 17);
            this.cbBoxcarEnable.TabIndex = 0;
            this.cbBoxcarEnable.Text = "Enable";
            this.cbBoxcarEnable.UseVisualStyleBackColor = true;
            this.cbBoxcarEnable.CheckedChanged += new System.EventHandler(this.cbBoxcarEnable_CheckedChanged);
            // 
            // tpNotifications
            // 
            this.tpNotifications.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpNotifications.Controls.Add(this.groupBox5);
            this.tpNotifications.Location = new System.Drawing.Point(4, 22);
            this.tpNotifications.Name = "tpNotifications";
            this.tpNotifications.Size = new System.Drawing.Size(300, 240);
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
            this.groupBox5.Size = new System.Drawing.Size(287, 72);
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
            this.tbAbout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbAbout.Controls.Add(this.richTextBox1);
            this.tbAbout.Controls.Add(this.linkLabel1);
            this.tbAbout.Controls.Add(this.lblVersion);
            this.tbAbout.Controls.Add(this.label2);
            this.tbAbout.Location = new System.Drawing.Point(4, 22);
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.Size = new System.Drawing.Size(300, 240);
            this.tbAbout.TabIndex = 3;
            this.tbAbout.Text = "About";
            this.tbAbout.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(17, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(267, 141);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Special Thanks:\nGrowl notifications by Ryan Farley\nhttps://github.com/RyanFarley\n" +
                "\nTwitter notifications by Dave Nicoll\nhttp://davenicoll.com/";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(14, 213);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Eric Holmes";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(14, 35);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(34, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "vx.x.x";
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 319);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::uTorrentNotifier.Properties.Resources.un_icon;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "uTorrent Notifier";
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
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
            this.tpProwl.ResumeLayout(false);
            this.tpGrowl.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tpTwitter.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tpBoxcar.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbProwlAPIKey;
        private System.Windows.Forms.Label lblProwlAPIKey;
        private System.Windows.Forms.CheckBox cbShowBalloonTips;
        private System.Windows.Forms.CheckBox cbProwlEnable;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbRunOnStartup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpProwl;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbTorrentNotification_DownloadComplete;
        private System.Windows.Forms.CheckBox cbProwlNotification_TorentAdded;
        private System.Windows.Forms.TabPage tpNotifications;
        private System.Windows.Forms.TabPage tbAbout;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbCheckForUpdates;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tpGrowl;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tbGrowlPort;
        private System.Windows.Forms.Label lblGrowlPort;
        private System.Windows.Forms.TextBox tbGrowlHost;
        private System.Windows.Forms.Label lblGrowlHost;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cbGrowlEnable;
        private System.Windows.Forms.TextBox tbGrowlPassword;
        private System.Windows.Forms.Label lblGrowlPassword;
        private System.Windows.Forms.TabPage tpTwitter;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox tbTwitterPIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTwitterPIN;
        private System.Windows.Forms.Button btnStartAuthorization;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox cbTwitterEnable;
        private System.Windows.Forms.Button btnTwitterAuthorize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSendTestTweet;
        private System.Windows.Forms.TabPage tpBoxcar;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox tbBoxcarEmail;
        private System.Windows.Forms.Label lblBoxcarEmail;
        private System.Windows.Forms.CheckBox cbBoxcarEnable;
        private System.Windows.Forms.Button btnBoxcarInvite;

    }
}
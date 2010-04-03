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
            this.cbNotificationMode = new System.Windows.Forms.CheckBox();
            this.cbProwlEnable = new System.Windows.Forms.CheckBox();
            this.tbProwlAPIKey = new System.Windows.Forms.TextBox();
            this.lblProwlAPIKey = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbRunOnStartup = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Location = new System.Drawing.Point(6, 78);
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
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
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
            this.btnSave.Location = new System.Drawing.Point(12, 299);
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
            this.btnCancel.Location = new System.Drawing.Point(170, 299);
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
            this.groupBox3.Controls.Add(this.cbNotificationMode);
            this.groupBox3.Controls.Add(this.cbProwlEnable);
            this.groupBox3.Controls.Add(this.tbProwlAPIKey);
            this.groupBox3.Controls.Add(this.lblProwlAPIKey);
            this.groupBox3.Location = new System.Drawing.Point(7, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 73);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prowl";
            // 
            // cbNotificationMode
            // 
            this.cbNotificationMode.AutoSize = true;
            this.cbNotificationMode.Location = new System.Drawing.Point(74, 19);
            this.cbNotificationMode.Name = "cbNotificationMode";
            this.cbNotificationMode.Size = new System.Drawing.Size(139, 17);
            this.cbNotificationMode.TabIndex = 3;
            this.cbNotificationMode.Text = "Run in Prowl Only mode";
            this.cbNotificationMode.UseVisualStyleBackColor = true;
            // 
            // cbProwlEnable
            // 
            this.cbProwlEnable.AutoSize = true;
            this.cbProwlEnable.Location = new System.Drawing.Point(9, 20);
            this.cbProwlEnable.Name = "cbProwlEnable";
            this.cbProwlEnable.Size = new System.Drawing.Size(59, 17);
            this.cbProwlEnable.TabIndex = 2;
            this.cbProwlEnable.Text = "Enable";
            this.cbProwlEnable.UseVisualStyleBackColor = true;
            // 
            // tbProwlAPIKey
            // 
            this.tbProwlAPIKey.Location = new System.Drawing.Point(74, 44);
            this.tbProwlAPIKey.Name = "tbProwlAPIKey";
            this.tbProwlAPIKey.Size = new System.Drawing.Size(163, 20);
            this.tbProwlAPIKey.TabIndex = 1;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbRunOnStartup);
            this.groupBox4.Location = new System.Drawing.Point(7, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(130, 45);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Windows";
            // 
            // cbRunOnStartup
            // 
            this.cbRunOnStartup.AutoSize = true;
            this.cbRunOnStartup.Location = new System.Drawing.Point(9, 19);
            this.cbRunOnStartup.Name = "cbRunOnStartup";
            this.cbRunOnStartup.Size = new System.Drawing.Size(96, 17);
            this.cbRunOnStartup.TabIndex = 0;
            this.cbRunOnStartup.Text = "Run on startup";
            this.cbRunOnStartup.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 334);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
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
        private System.Windows.Forms.CheckBox cbNotificationMode;
        private System.Windows.Forms.CheckBox cbProwlEnable;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbRunOnStartup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuItem tsmiStartAll;
        private System.Windows.Forms.MenuItem tsmiPauseAll;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem1;

    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
using System.Diagnostics;
using System.Threading;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace uTorrentNotifier
{
    public class Program : Form
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Program());
        }

        private NotifyIcon _trayIcon;
        private ContextMenu _trayMenu;
        private MenuItem _miStartAll;
        private MenuItem _miPauseAll;
        private MenuItem _menuItem2;
        private MenuItem _miSettings;
        private MenuItem _menuItem1;
        private MenuItem _miClose;

        private SettingsForm settingsForm;

        public Config Config = new Config();
        private ClassRegistry ClassRegistry;
        private int loginErrors = 25; //only show balloon tip every 25 attempts

        public Program()
        {
            this.ClassRegistry = new ClassRegistry(this.Config);

            InitializeComponent();

            this.ClassRegistry.Version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            if (this.Config.CheckForUpdates)
            {
                System.Threading.ThreadPool.QueueUserWorkItem(this.CheckForUpdates);
            }
            this.ClassRegistry.uTorrent.TorrentAdded += new WebUIAPI.TorrentAddedEventHandler(this.utorrent_TorrentAdded);
            this.ClassRegistry.uTorrent.DownloadComplete += new WebUIAPI.DownloadFinishedEventHandler(this.utorrent_DownloadComplete);
            this.ClassRegistry.uTorrent.LoginError += new WebUIAPI.LoginErrorEventHandler(this.utorrent_LoginError);
            this.ClassRegistry.uTorrent.Start();

            this.settingsForm = new SettingsForm(this.ClassRegistry);

            this.FirstRun();
        }

        private void FirstRun()
        {
            if (Properties.Settings.Default.FirstRun)
            {
                this.settingsForm.Show();
                Properties.Settings.Default.Upgrade();
                this.Config = new Config();
                Properties.Settings.Default.FirstRun = false;
            }
        }

        void utorrent_LoginError(object sender, Exception e)
        {
            if (this.loginErrors >= 5)
            {
                if (!this.Config.Growl.Enable)
                    this._trayIcon.ShowBalloonTip(5000, "Login Error", e.Message, ToolTipIcon.Error);
                else
                    this.ClassRegistry.Growl.Add(GrowlNotificationType.Error, e.Message);

                this.loginErrors = 0;
            }
            else
            {
                this.loginErrors++;
            }
        }

        void utorrent_DownloadComplete(List<TorrentFile> finished)
        {
            if (this.Config.Notifications.DownloadComplete)
            {
                foreach (TorrentFile f in finished)
                {
                    if (this.Config.Prowl.Enable)
                    {
                        this.ClassRegistry.Prowl.Add("Download Complete", f.Name);
                    }

                    if (this.Config.Growl.Enable)
                    {
                        this.ClassRegistry.Growl.Add(GrowlNotificationType.InfoComplete, f.Name);
                    }

                    if (this.Config.Twitter.Enable)
                    {
                        this.ClassRegistry.Twitter.Update("Downloaded " + f.Name);
                    }

                    if (this.Config.Boxcar.Enable)
                    {
                        this.ClassRegistry.Boxcar.Add("Download Complete: " + f.Name);
                    }

                    if (this.Config.ShowBalloonTips)
                    {
                        this._trayIcon.ShowBalloonTip(5000, "Download Complete", f.Name, ToolTipIcon.Info);
                    }
                }
            }
        }

        void utorrent_TorrentAdded(List<TorrentFile> added)
        {
            if (this.Config.Notifications.TorrentAdded)
            {
                foreach (TorrentFile f in added)
                {
                    if (this.Config.Prowl.Enable)
                    {
                        this.ClassRegistry.Prowl.Add("Torrent Added", f.Name);
                    }

                    if (this.Config.Growl.Enable)
                    {
                        this.ClassRegistry.Growl.Add(GrowlNotificationType.InfoAdded, f.Name);
                    }

                    if (this.Config.Twitter.Enable)
                    {
                        this.ClassRegistry.Twitter.Update("Added " + f.Name + " | " + Utilities.FormatBytes((long)f.Size));
                    }

                    if (this.Config.Boxcar.Enable)
                    {
                        this.ClassRegistry.Boxcar.Add("Torrent Added: " + f.Name);
                    }

                    if (this.Config.ShowBalloonTips)
                    {
                        this._trayIcon.ShowBalloonTip(5000, "Torrent Added", f.Name, ToolTipIcon.Info);
                    }
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            this.settingsForm.Show();
        }

        private void PauseAll_Click(object sender, EventArgs e)
        {
            this.ClassRegistry.uTorrent.PauseAll();
        }

        private void StartAll_Click(object sender, EventArgs e)
        {
            this.ClassRegistry.uTorrent.StartAll();
        }

        private void CheckForUpdates(object sender)
        {
            System.Net.WebClient webclient = new System.Net.WebClient();
            string latestVersion = webclient.DownloadString(Config.LatestVersion);

            string[] components = latestVersion.Split(".".ToCharArray());
            if (components.Length < 3)
            {
                components[2] = "0";
            }

            if (Int32.Parse(components[0]) > this.ClassRegistry.Version.Major ||
                (Int32.Parse(components[0]) == this.ClassRegistry.Version.Major && Int32.Parse(components[1]) > this.ClassRegistry.Version.Minor) ||
                (Int32.Parse(components[0]) == this.ClassRegistry.Version.Major && Int32.Parse(components[1]) == this.ClassRegistry.Version.Minor && Int32.Parse(components[2]) > this.ClassRegistry.Version.Build))
            {
                if (MessageBox.Show("You are using version " + this.ClassRegistry.Version.ToString() + ". Would you like to download version " + latestVersion + "?",
                    "New Version Available",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start(Config.LatestDownload);
                }
            }
        }

        private void InitializeComponent()
        {
            // 
            // StartAll
            // 
            this._miStartAll = new System.Windows.Forms.MenuItem();
            this._miStartAll.Index = 0;
            this._miStartAll.Text = "Start All";
            this._miStartAll.Click += new System.EventHandler(this.StartAll_Click);
            // 
            // PauseAll
            // 
            this._miPauseAll = new System.Windows.Forms.MenuItem();
            this._miPauseAll.Index = 1;
            this._miPauseAll.Text = "Pause All";
            this._miPauseAll.Click += new System.EventHandler(this.PauseAll_Click);
            // 
            // menuItem2
            // 
            this._menuItem2 = new System.Windows.Forms.MenuItem();
            this._menuItem2.Index = 2;
            this._menuItem2.Text = "-";
            // 
            // Settings
            // 
            this._miSettings = new System.Windows.Forms.MenuItem();
            this._miSettings.Index = 3;
            this._miSettings.Text = "Settings";
            this._miSettings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // menuItem1
            // 
            this._menuItem1 = new System.Windows.Forms.MenuItem();
            this._menuItem1.Index = 4;
            this._menuItem1.Text = "-";
            // 
            // Close
            // 
            this._miClose = new System.Windows.Forms.MenuItem();
            this._miClose.Index = 5;
            this._miClose.Text = "Exit";
            this._miClose.Click += new System.EventHandler(this.Close_Click);
            // Create a simple tray menu with only one item.
            this._trayMenu = new ContextMenu();
            this._trayMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                this._miStartAll,
                this._miPauseAll,
                this._menuItem2,
                this._miSettings,
                this._menuItem1,
                this._miClose});

            // Create a tray icon. In this example we use a
            // standard system icon for simplicity, but you
            // can of course use your own custom icon too.
            this._trayIcon = new NotifyIcon();
            this._trayIcon.Text = "uTorrentNotifier";
            this._trayIcon.Icon = global::uTorrentNotifier.Properties.Resources.un_icon_systray;

            // Add menu to tray icon and show it.
            this._trayIcon.ContextMenu = this._trayMenu;
            this._trayIcon.Visible = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.

            base.OnLoad(e);
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                // Release the icon resource.
                this._trayIcon.Dispose();
            }

            base.Dispose(isDisposing);
        }
    }
}
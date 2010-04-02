using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace uTorrentNotifier
{
    public partial class SettingsForm : Form
    {
        private Config Config = new Config();
        private WebUIAPI utorrent;
        private Prowl prowl;

        public SettingsForm()
        {
            InitializeComponent();

            utorrent = new WebUIAPI(this.Config);
            utorrent.TorrentAdded += new WebUIAPI.TorrentAddedEventHandler(utorrent_TorrentAdded);
            utorrent.DownloadComplete += new WebUIAPI.DownloadFinishedEventHandler(utorrent_DownloadComplete);
            utorrent.LoginError += new WebUIAPI.LoginErrorEventHandler(utorrent_LoginError);
            utorrent.Start();

            prowl = new Prowl(this.Config.ProwlAPIKey);
        }

        void utorrent_LoginError()
        {
            this.systrayIcon.ShowBalloonTip(5000, "Login Error", "Either the credentials or the web ui url is not correct", ToolTipIcon.Error);
            utorrent.Stop();
        }

        void utorrent_DownloadComplete(List<TorrentFile> finished)
        {
            foreach (TorrentFile f in finished)
            {
                if (this.Config.ProwlEnable)
                {
                    this.prowl.Add("Download Complete", f.Name);
                }

                if (!this.Config.ProwlNotificationMode)
                {
                    this.systrayIcon.ShowBalloonTip(5000, "Download Complete", f.Name, ToolTipIcon.Info);
                }
            }
        }

        void utorrent_TorrentAdded(List<TorrentFile> added)
        {
            foreach (TorrentFile f in added)
            {
                if (this.Config.ProwlEnable)
                {
                    this.prowl.Add("Torrent Added", f.Name);
                }

                if (!this.Config.ProwlNotificationMode)
                {
                    this.systrayIcon.ShowBalloonTip(5000, "Torrent Added", f.Name, ToolTipIcon.Info);
                }
            }
        }

        private void BackToSystray()
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void RestoreFromSystray()
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void MainWindow_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.BackToSystray();
        }

        private void Settings_Shown(object sender, System.EventArgs e)
        {
            this.tbPassword.Text                = this.Config.Password;
            this.tbUsername.Text                = this.Config.Username;
            this.tbWebUI_URL.Text               = this.Config.URI;
            this.tbProwlAPIKey.Text             = this.Config.ProwlAPIKey;
            this.cbProwlEnable.Checked          = this.Config.ProwlEnable;
            this.cbNotificationMode.Checked     = this.Config.ProwlNotificationMode;
            this.cbRunOnStartup.Checked         = this.Config.RunOnStartup;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Config.URI                     = this.tbWebUI_URL.Text;
            this.Config.Username                = this.tbUsername.Text;
            this.Config.Password                = this.tbPassword.Text;
            this.Config.ProwlAPIKey             = this.tbProwlAPIKey.Text;
            this.Config.ProwlEnable             = this.cbProwlEnable.Checked;
            this.Config.ProwlNotificationMode   = this.cbNotificationMode.Checked;
            this.Config.RunOnStartup            = this.cbRunOnStartup.Checked;

            this.Config.Save();
            this.BackToSystray();

            if (this.utorrent.Stopped)
                this.utorrent.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.BackToSystray();
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tsmiSettings_Click(object sender, EventArgs e)
        {
            this.RestoreFromSystray();
        }

        private void systrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.RestoreFromSystray();
        }

        private void systrayIcon_Click(object sender, System.EventArgs e)
        {
            
        }
    }
}

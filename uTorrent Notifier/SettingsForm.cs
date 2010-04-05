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

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace uTorrentNotifier
{
    public partial class SettingsForm : Form
    {
        private Config Config = new Config();
        private WebUIAPI utorrent;
        private Prowl prowl;
        private int loginErrors = 25; //only show balloon tip every 25 attempts

        public SettingsForm()
        {
            InitializeComponent();

            this.utorrent = new WebUIAPI(this.Config);
            this.utorrent.TorrentAdded += new WebUIAPI.TorrentAddedEventHandler(utorrent_TorrentAdded);
            this.utorrent.DownloadComplete += new WebUIAPI.DownloadFinishedEventHandler(utorrent_DownloadComplete);
            this.utorrent.LoginError += new WebUIAPI.LoginErrorEventHandler(utorrent_LoginError);
            this.utorrent.Start();

            this.prowl = new Prowl(this.Config.Prowl);
            this.prowl.ProwlError += new Prowl.ProwlErrorHandler(prowl_ProwlError);
        }

        void prowl_ProwlError(object sender, Exception e)
        {
        }

        void utorrent_LoginError(object sender, Exception e)
        {
            if (this.loginErrors >= 25)
            {
                this.systrayIcon.ShowBalloonTip(5000, "Login Error", e.Message, ToolTipIcon.Error);
                this.loginErrors = 0;
            }
            else
            {
                this.loginErrors++;
            }
        }

        void utorrent_DownloadComplete(List<TorrentFile> finished)
        {
            foreach (TorrentFile f in finished)
            {
                if (this.Config.Prowl.Enable && this.Config.Prowl.Notification_DownloadComplete)
                {
                    this.prowl.Add("Download Complete", f.Name);
                }

                if (this.Config.ShowBalloonTips)
                {
                    this.systrayIcon.ShowBalloonTip(5000, "Download Complete", f.Name, ToolTipIcon.Info);
                }
            }
        }

        void utorrent_TorrentAdded(List<TorrentFile> added)
        {
            foreach (TorrentFile f in added)
            {
                if (this.Config.Prowl.Enable && this.Config.Prowl.Notification_TorrentAdded)
                {
                    this.prowl.Add("Torrent Added", f.Name);
                }

                if (this.Config.ShowBalloonTips)
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

        private void Settings_Shown(object sender, System.EventArgs e)
        {
            if (Properties.Settings.Default.FirstRun)
            {
                this.RestoreFromSystray();
                Properties.Settings.Default.FirstRun = false;
            }
            else
            {
                this.BackToSystray();
            }
            this.SetConfig();
        }

        private void SetConfig()
        {
            this.tbPassword.Text                                = this.Config.Password;
            this.tbUsername.Text                                = this.Config.Username;
            this.tbWebUI_URL.Text                               = this.Config.URI;
            this.cbRunOnStartup.Checked                         = this.Config.RunOnStartup;
            this.cbShowBalloonTips.Checked                      = this.Config.ShowBalloonTips;

            this.tbProwlAPIKey.Text                             = this.Config.Prowl.APIKey;
            this.cbProwlEnable.Checked                          = this.Config.Prowl.Enable;
            this.cbProwlNotification_TorentAdded.Checked        = this.Config.Prowl.Notification_TorrentAdded;
            this.cbTorrentNotification_DownloadComplete.Checked = this.Config.Prowl.Notification_DownloadComplete;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Config.URI                                 = this.tbWebUI_URL.Text;
            this.Config.Username                            = this.tbUsername.Text;
            this.Config.Password                            = this.tbPassword.Text;
            this.Config.RunOnStartup                        = this.cbRunOnStartup.Checked;
            this.Config.ShowBalloonTips                     = this.cbShowBalloonTips.Checked;

            this.Config.Prowl.APIKey                        = this.tbProwlAPIKey.Text;
            this.Config.Prowl.Enable                        = this.cbProwlEnable.Checked;
            this.Config.Prowl.Notification_TorrentAdded     = this.cbProwlNotification_TorentAdded.Checked;
            this.Config.Prowl.Notification_DownloadComplete = this.cbTorrentNotification_DownloadComplete.Checked;

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

        private void tsmiPauseAll_Click(object sender, EventArgs e)
        {
            this.utorrent.PauseAll();
        }

        private void tsmiStartAll_Click(object sender, EventArgs e)
        {
            this.utorrent.StartAll();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = true;
            startInfo.WorkingDirectory = Environment.CurrentDirectory;
            startInfo.FileName = "associations.cpp";
            startInfo.Verb = "runas";

            Process p = Process.Start(startInfo);
            p.WaitForExit();
        }*/
    }
}

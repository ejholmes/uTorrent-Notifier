using System;
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

        public SettingsForm()
        {
            InitializeComponent();

            utorrent = new WebUIAPI(this.Config);
            utorrent.TorrentAdded += new WebUIAPI.TorrentAddedEventHandler(utorrent_TorrentAdded);
            utorrent.DownloadComplete += new WebUIAPI.DownloadFinishedEventHandler(utorrent_DownloadComplete);
            utorrent.Start();
        }

        void utorrent_DownloadComplete(List<TorrentFile> finished)
        {
            MessageBox.Show("complete");
        }

        void utorrent_TorrentAdded(List<TorrentFile> added)
        {
            MessageBox.Show(added[0].Name);
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
            this.tbPassword.Text = this.Config.Password;
            this.tbUsername.Text = this.Config.Username;
            this.tbWebUI_URL.Text = this.Config.URI;
        }

        void systrayIcon_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Config.URI         = this.tbWebUI_URL.Text;
            this.Config.Username    = this.tbUsername.Text;
            this.Config.Password    = this.tbPassword.Text;
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

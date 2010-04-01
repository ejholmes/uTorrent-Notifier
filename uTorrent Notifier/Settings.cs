using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace µTorrent
{
    public partial class Settings : Form
    {
        private Config Config = new Config();
        private API utorrent;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        List<TorrentFile> last = new List<TorrentFile>();

        public Settings()
        {
            InitializeComponent();

            utorrent = new API(this.Config);
            timer.Tick += new EventHandler(PollForChanges);
            timer.Interval = 5000;
            timer.Start();
        }

        void PollForChanges(object sender, EventArgs e)
        {
            List<TorrentFile> current = new List<TorrentFile>();
            current = utorrent.List();

            List<TorrentFile> changes = utorrent.FindDone(current, last);
            List<TorrentFile> newtors = utorrent.FindNew(current, last);

            if (changes.Count > 0)
            {
                this.systrayIcon.ShowBalloonTip(5000, "Download Finished", changes[0].Name, ToolTipIcon.Info);
            }

            if (newtors.Count > 0)
            {
                this.systrayIcon.ShowBalloonTip(5000, "Torrent Added", newtors[0].Name, ToolTipIcon.Info);
            }

            last = current;
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

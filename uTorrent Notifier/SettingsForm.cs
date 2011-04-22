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
    public partial class SettingsForm : Form
    {
        //private Version _Version;
        private oAuthTwitter oAuth;
        private ClassRegistry ClassRegistry;

        public SettingsForm(ClassRegistry classRegistry)
        {
            this.ClassRegistry = classRegistry;

            InitializeComponent();
        }

        private void SettingsForm_Shown(object sender, System.EventArgs e)
        {
            this.lblVersion.Text = ClassRegistry.Version.ToString();
            this.SetConfig();
        }

        private void SetConfig()
        {
            this.tbPassword.Text                                = this.ClassRegistry.Config.Password;
            this.tbUsername.Text                                = this.ClassRegistry.Config.UserName;
            this.tbWebUI_URL.Text                               = this.ClassRegistry.Config.Uri;
            this.cbRunOnStartup.Checked                         = this.ClassRegistry.Config.RunOnStartup;
            this.cbShowBalloonTips.Checked                      = this.ClassRegistry.Config.ShowBalloonTips;
            this.cbCheckForUpdates.Checked                      = this.ClassRegistry.Config.CheckForUpdates;

            this.tbProwlAPIKey.Text                             = this.ClassRegistry.Config.Prowl.ApiKey;
            this.cbProwlEnable.Checked                          = this.ClassRegistry.Config.Prowl.Enable;

			this.cbGrowlEnable.Checked							= this.ClassRegistry.Config.Growl.Enable;
			this.tbGrowlPassword.Text							= this.ClassRegistry.Config.Growl.Password;
			this.tbGrowlHost.Text								= this.ClassRegistry.Config.Growl.Host;
			this.tbGrowlPort.Text								= this.ClassRegistry.Config.Growl.Port;

            this.tbTwitterPIN.Text                              = this.ClassRegistry.Config.Twitter.Pin;
            this.cbTwitterEnable.Checked                        = this.ClassRegistry.Config.Twitter.Enable;

            this.cbBoxcarEnable.Checked                         = this.ClassRegistry.Config.Boxcar.Enable;
            this.tbBoxcarEmail.Text                             = this.ClassRegistry.Config.Boxcar.Email;
            this.tbBoxcarAPIKey.Text                            = this.ClassRegistry.Config.Boxcar.APIKey;

            this.cbProwlNotification_TorentAdded.Checked        = this.ClassRegistry.Config.Notifications.TorrentAdded;
            this.cbTorrentNotification_DownloadComplete.Checked = this.ClassRegistry.Config.Notifications.DownloadComplete;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.ClassRegistry.Config.Uri                                 = this.tbWebUI_URL.Text;
            this.ClassRegistry.Config.UserName                            = this.tbUsername.Text;
            this.ClassRegistry.Config.Password                            = this.tbPassword.Text;
            this.ClassRegistry.Config.RunOnStartup                        = this.cbRunOnStartup.Checked;
            this.ClassRegistry.Config.ShowBalloonTips                     = this.cbShowBalloonTips.Checked;
            this.ClassRegistry.Config.CheckForUpdates                     = this.cbCheckForUpdates.Checked;

            this.ClassRegistry.Config.Prowl.ApiKey                        = this.tbProwlAPIKey.Text;
            this.ClassRegistry.Config.Prowl.Enable                        = this.cbProwlEnable.Checked;

			this.ClassRegistry.Config.Growl.Enable						  = this.cbGrowlEnable.Checked;
			this.ClassRegistry.Config.Growl.Password					  = this.tbGrowlPassword.Text;
			this.ClassRegistry.Config.Growl.Host						  = this.tbGrowlHost.Text;
			this.ClassRegistry.Config.Growl.Port						  = this.tbGrowlPort.Text;

            this.ClassRegistry.Config.Twitter.Enable                      = this.cbTwitterEnable.Checked;

            this.ClassRegistry.Config.Boxcar.Enable                       = this.cbBoxcarEnable.Checked;
            this.ClassRegistry.Config.Boxcar.Email                        = this.tbBoxcarEmail.Text;
            this.ClassRegistry.Config.Boxcar.APIKey                       = this.tbBoxcarAPIKey.Text;

            this.ClassRegistry.Config.Notifications.TorrentAdded          = this.cbProwlNotification_TorentAdded.Checked;
            this.ClassRegistry.Config.Notifications.DownloadComplete      = this.cbTorrentNotification_DownloadComplete.Checked;

            this.ClassRegistry.Config.Save();
            this.Hide();

            if (!this.ClassRegistry.uTorrent.Stopped)
                this.ClassRegistry.uTorrent.Stop();
            this.ClassRegistry.uTorrent.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://ejholmes.github.com/uTorrent-Notifier/");
        }

        private void btnStartAuthorization_Click(object sender, EventArgs e)
        {
            oAuth = new oAuthTwitter();
            oAuth.ConsumerKey = this.ClassRegistry.Config.Twitter.ConsumerKey;
            oAuth.ConsumerSecret = this.ClassRegistry.Config.Twitter.ConsumerSecret;

            this.ClassRegistry.Config.Twitter.Pin = String.Empty;
            this.ClassRegistry.Config.Twitter.Token = String.Empty;
            this.ClassRegistry.Config.Twitter.TokenSecret = String.Empty;

            string oAuthLink = oAuth.AuthorizationLinkGet();
            try
            {
                Process.Start(oAuthLink);
                tbTwitterPIN.Text = String.Empty;
                tbTwitterPIN.Enabled = true;
                lblTwitterPIN.Enabled = true;
                btnTwitterAuthorize.Enabled = true;
            }
            catch
            {
                tbTwitterPIN.Text = String.Empty;
                lblTwitterPIN.Enabled = false;
                tbTwitterPIN.Enabled = false;
                btnTwitterAuthorize.Enabled = false;
                MessageBox.Show("An error occurred trying to authenticate. Check your network settings and browser config, and try again.", "uTorrent Notifier - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTwitterAuthorize_Click(object sender, EventArgs e)
        {
            string PIN = tbTwitterPIN.Text;
            if (!string.IsNullOrEmpty(PIN))
            {
                PIN = PIN.Trim();
            }
            else
            {
                MessageBox.Show("Copy and paste the authentication PIN code from Twitter", "uTorrent Notifier - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                oAuth.AccessTokenGet(oAuth.OAuthToken, PIN);
                this.ClassRegistry.Config.Twitter.Token = oAuth.Token;
                this.ClassRegistry.Config.Twitter.TokenSecret = oAuth.TokenSecret;
                this.ClassRegistry.Config.Twitter.Pin = PIN;
                tbTwitterPIN.Enabled = false;
                btnTwitterAuthorize.Enabled = false;
                MessageBox.Show("Successfully authenticated with Twitter", "uTorrent Notifier - Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                this.ClassRegistry.Config.Twitter.Pin = String.Empty;
                tbTwitterPIN.Text = String.Empty;
                lblTwitterPIN.Enabled = false;
                tbTwitterPIN.Enabled = false;
                btnTwitterAuthorize.Enabled = false;
                MessageBox.Show("An error occurred trying to authenticate. Check your network settings and browser config, and try again.", "uTorrent Notifier - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSendTestTweet_Click(object sender, EventArgs e)
        {
            bool bCanSend=true;
            if (this.ClassRegistry.Twitter == null) bCanSend = false;
            if(!this.cbTwitterEnable.Checked) bCanSend=false;

            if(bCanSend)
            {
                this.ClassRegistry.Twitter.Update("Congratulations! Twitter notifications from uTorrent Notifier are working correctly :)");
                MessageBox.Show("A test tweet has been sent...", "uTorrent Notifier - Test sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("uTorrent Notifier must be authenticated and enabled before testing. Please check your settings, and try again.", "uTorrent Notifier - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBoxcarGetAPIKey_Click(object sender, EventArgs e)
        {
            Process.Start("http://boxcar.io/site/providers/new");
        }
    }
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace StudyMate
{
    public partial class CheckForUpdateFrm : Form
    {
        string LatestVersion = "";

        public CheckForUpdateFrm()
        {
            InitializeComponent();
        }

        private void CheckForUpdateFrm_Shown(object sender, EventArgs e)
        {
            bgUpdateCheck.RunWorkerAsync();
        }

        private void bgUpdateCheck_DoWork(object sender, DoWorkEventArgs e)
        {
            if (bgUpdateCheck.CancellationPending == true)
            {
                e.Cancel = true;
            }
            else
            {
                DBAccess GetLatestVersion = new DBAccess();
                LatestVersion = GetLatestVersion.Get("SELECT LatestVersion FROM StudyMate", "LatestVersion");
            }
        }

        private void bgUpdateCheck_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UpdateProgress.Value = 100;
            UpdateProgress.Style = ProgressBarStyle.Continuous;

            if (LatestVersion == "")
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Could not connect to update server.";
                btnUpdate.Text = "Close";
            }
            else
            {
                if (LatestVersion != Application.ProductVersion)
                {
                    lblStatus.ForeColor = Color.Orange;
                    lblStatus.Text = "StudyMate " + LatestVersion + " is available.";
                    btnUpdate.Text = "Update";
                }
                else
                {
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = "StudyMate is up to date.";
                    btnUpdate.Text = "Close";
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Close")
            {
                this.Close();
            }
            else
            {
                if (btnUpdate.Text == "Cancel")
                {
                    bgUpdateCheck.CancelAsync();
                    this.Close();
                }
                else
                {
                    btnUpdate.Text = "Close";
                    WebClient Client = new WebClient();
                    Client.DownloadFileAsync(Properties.Settings.Default.Website, "StudyMate.rar");
                    this.Close();
                }
            }
        }

    }
}
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace StudyMate
{
    public partial class ReportABugFrm : Form
    {
        string BugCategory = "";

        public ReportABugFrm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bg.CancelAsync();
            this.Close();
        }

        private void BugsFrm_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
        }

        private void btnOther_CheckedChanged(object sender, EventArgs e)
        {
            BugCategory = ActiveControl.Text;

            if (txtDescription.Text != "" && BugCategory != "")
                btnSend.Enabled = true;
            else
                btnSend.Enabled = false;

            if (txtDescription.Text != "" || BugCategory != "")
            {
                btnCancel.Enabled = true;
                btnSend.Text = "Send";
            }
            else
            {
                btnCancel.Enabled = false;
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (txtDescription.Text != "" && BugCategory != "")
                btnSend.Enabled = true;
            else
                btnSend.Enabled = false;

            if (txtDescription.Text != "" || BugCategory != "")
            {
                btnCancel.Enabled = true;
                btnSend.Text = "Send";
            }
            else
            {
                btnCancel.Enabled = false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (btnSend.Text == "Send")
            {

                DBAccess SendBugs = new DBAccess();
                if (SendBugs.SendBug(Application.ProductVersion, BugCategory, txtDescription.Text) == true)
                {
                    MessageFrm ShowMessage = new MessageFrm();
                    ShowMessage.Title = "Information";
                    ShowMessage.Content = "Report successfully sent.";
                    ShowMessage.ShowDialog();

                    btnSend.Text = "Close";
                    btnCancel.Enabled = false;
                }
                else
                {
                    MessageFrm ShowMessage = new MessageFrm();
                    ShowMessage.Title = "Error";
                    ShowMessage.Content = "Error sending problem report.\n\nDetails:\n" + SendBugs.error;
                    ShowMessage.ShowDialog();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void BugsFrm_Shown(object sender, EventArgs e)
        {
            bg.RunWorkerAsync();
        }

        private void bg_DoWork(object sender, DoWorkEventArgs e)
        {
            if (bg.CancellationPending == true)
            {
                e.Cancel = true;
            }
            else
            {
                DBAccess GetLatestVersion = new DBAccess();
                string version = GetLatestVersion.Get("SELECT LatestVErsion FROM StudyMate", "LatestVersion");
                if (version != Application.ProductVersion)
                {
                    DialogResult result = MessageBox.Show("We detected that your current version is out of date,\nPlease update to the latest version to see if your problem is already fixed.\n\nChoose OK to update now or Cancel to continue your report.", "StudyMate - Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                        System.Diagnostics.Process.Start(Properties.Settings.Default.Website.ToString());
                    }
                }
            }
        }

    }
}
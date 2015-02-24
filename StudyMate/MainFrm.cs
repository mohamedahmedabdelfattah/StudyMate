using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;

namespace StudyMate
{
    public partial class MainFrm : Form
    {
        string OtherCategory = "", CellValue = "", LatestVersion = Application.ProductVersion;

        public void SaveSettings()
        {
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "CloseToTray", CloseToTrayMenu.Checked, RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "MinimizeToTray", MinimizeToTrayMenu.Checked, RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "StartWithWindows", StartWithWindowsMenu.Checked, RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "AlwaysShowTrayIcon", AlwaysShowTrayIconMenu.Checked, RegistryValueKind.String);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "AutoUpdateCheck", AutoUpdateCheckMenu.Checked, RegistryValueKind.String);
        }

        public MainFrm()
        {
            InitializeComponent();
        }

        // MainFrm
        private void MainFrm_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstRun == true)
            {
                // Creating Application Registries
                Registry.LocalMachine.CreateSubKey("SOFTWARE\\StudyMate");
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "CloseToTray", "false", RegistryValueKind.String);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "MinimizeToTray", "false", RegistryValueKind.String);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "StartWithWindows", "false", RegistryValueKind.String);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "AlwaysShowTrayIcon", "false", RegistryValueKind.String);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "AutoUpdateCheck", "false", RegistryValueKind.String);

                WelcomeFrm Welcome = new WelcomeFrm();
                Welcome.ShowDialog();

                Properties.Settings.Default.FirstRun = false;
                Properties.Settings.Default.Save();
            }
            else
            {   // Load User Settings
                CloseToTrayMenu.Checked = Boolean.Parse(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "CloseToTray", "").ToString());
                MinimizeToTrayMenu.Checked = Boolean.Parse(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "MinimizeToTray", "").ToString());
                StartWithWindowsMenu.Checked = Boolean.Parse(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "StartWithWindows", "").ToString());
                AlwaysShowTrayIconMenu.Checked = TrayIcon.Visible = Boolean.Parse(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "AlwaysShowTrayIcon", "").ToString());
                AutoUpdateCheckMenu.Checked = Boolean.Parse(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "AutoUpdateCheck", "").ToString());

                if (AutoUpdateCheckMenu.Checked == true)
                {
                    bgAutoUpdateCheck.RunWorkerAsync();
                }
            }
        }

        private void MainFrm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                if (MinimizeToTrayMenu.Checked == true)
                {
                    this.Hide();
                    this.ShowInTaskbar = false;
                    TrayIcon.Visible = true;
                }
                else
                {
                    this.WindowState = FormWindowState.Minimized;
                }
            }
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseToTrayMenu.Checked == true)
            {
                this.Hide();
                this.ShowInTaskbar = false;
                TrayIcon.Visible = true;
                e.Cancel = true;
            }
            else
            {
                SaveSettings();
                Application.Exit();
            }
        }

        private void MainFrm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            HelpMenu.PerformClick();
        }

        private void bgAutoUpdateCheck_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DBAccess GetLatestVersion = new DBAccess();
            LatestVersion = GetLatestVersion.Get("SELECT LatestVersion FROM StudyMate", "LatestVersion");
        }

        private void bgAutoUpdateCheck_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (LatestVersion != Application.ProductVersion)
            {
                DialogResult result = MessageBox.Show("StudyMate " + LatestVersion + " is available, click OK to Update now.", "StudyMate Update Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    WebClient Client = new WebClient();
                    Client.DownloadFileAsync(Properties.Settings.Default.Website, "StudyMate.rar");
                }
            }
        }

        // Updates Tab
        private void tabUpdates_Enter(object sender, EventArgs e)
        {
            bgAdvisor.RunWorkerAsync();
        }

        private void bgAdvisor_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Code to get updates

        }

        private void bgAdvisor_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //UpdateProgress.Visible = false;
            
            // Code

            //UpdatesViewer.Visible = true;
        }

        // General Tab
        private void tabGeneral_Enter(object sender, EventArgs e)
        {
            Sub1Lec.Checked = false;
            Sub2Lec.Checked = false;
            Sub3Lec.Checked = false;
            Sub4Lec.Checked = false;
            Sub5Lec.Checked = false;
            Sub1Lab.Checked = false;
            Sub2Lab.Checked = false;
            Sub3Lab.Checked = false;
            Sub4Lab.Checked = false;
            Sub5Lab.Checked = false;
            Extra1.Checked = false;
            Extra2.Checked = false;
            Extra3.Checked = false;
            Extra4.Checked = false;
            btnSelectAll.Checked = false;
            btnDownload.Enabled = false;
        }

        private void Downloads_CheckedChanged(object sender, EventArgs e)
        {
            if (Sub1Lec.Checked == false && Sub2Lec.Checked == false && Sub3Lec.Checked == false && Sub4Lec.Checked == false && Sub5Lec.Checked == false && Sub1Lab.Checked == false && Sub2Lab.Checked == false && Sub3Lab.Checked == false && Sub4Lab.Checked == false && Sub5Lab.Checked == false && Extra1.Checked == false && Extra2.Checked == false && Extra3.Checked == false && Extra4.Checked == false)
                btnDownload.Enabled = false;
            else
                btnDownload.Enabled = true;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            /*
            WebClient Client = new WebClient();
            
            if (Sub1Lec.Checked == true)
            {
            Client.DownloadFileAsync(Properties.Settings.Default.Sub1Lec, Properties.Settings.Default.Sub1);
            }
            if (Sub2Lec.Checked == true)
            {
                Client.DownloadFileAsync(Properties.Settings.Default.Sub2Lec, Properties.Settings.Default.Sub2);
            }
            if (Sub3Lec.Checked == true)
            {
                Client.DownloadFileAsync(Properties.Settings.Default.Sub3Lec, Properties.Settings.Default.Sub3);
            }
            if (Sub4Lec.Checked == true)
            {
                Client.DownloadFileAsync(Properties.Settings.Default.Sub4Lec, Properties.Settings.Default.Sub4);
            }
            if (Sub5Lec.Checked == true)
            {
                Client.DownloadFileAsync(Properties.Settings.Default.Sub5Lec, Properties.Settings.Default.Sub5);
            }
            
            
            if (Sub1Lab.Checked == true)
            {
                Client.DownloadFileAsync(Properties.Settings.Default.Sub1Lab, Properties.Settings.Default.Sub1);
            }
            if (Sub2Lab.Checked == true)
            {
                Client.DownloadFileAsync(Properties.Settings.Default.Sub2Lab, Properties.Settings.Default.Sub2);
            }
            if (Sub3Lab.Checked == true)
            {              
                Client.DownloadFileAsync(Properties.Settings.Default.Sub3Lab, Properties.Settings.Default.Sub3);
            }
            if (Sub4Lab.Checked == true)
            {
                Client.DownloadFileAsync(Properties.Settings.Default.Sub4Lab, Properties.Settings.Default.Sub4);
            }
            if (Sub5Lab.Checked == true)
            {
                Client.DownloadFileAsync(Properties.Settings.Default.Sub5Lab, Properties.Settings.Default.Sub5);
            }
            
            
            if (Extra1.Checked == true)
            {
                Client.DownloadFileAsync(Properties.Settings.Default.Extra1Link, Properties.Settings.Default.Extra1);
            }
            if (Extra2.Checked == true)
            {
                Client.DownloadFileAsync(Properties.Settings.Default.Extra2Link, Properties.Settings.Default.Extra2);
            }
            if (Extra3.Checked == true)
            {
                Client.DownloadFileAsync(Properties.Settings.Default.Extra3Link, Properties.Settings.Default.Extra3);
            }
            if (Extra4.Checked == true)
            {
                Client.DownloadFileAsync(Properties.Settings.Default.Extra4Link, Properties.Settings.Default.Extra4);
            }
            */
        }

        private void btnSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSelectAll.Checked == true)
            {
                Sub1Lec.Checked = true;
                Sub2Lec.Checked = true;
                Sub3Lec.Checked = true;
                Sub4Lec.Checked = true;
                Sub5Lec.Checked = true;
                Sub1Lab.Checked = true;
                Sub2Lab.Checked = true;
                Sub3Lab.Checked = true;
                Sub4Lab.Checked = true;
                Sub5Lab.Checked = true;
                Extra1.Checked = true;
                Extra2.Checked = true;
                Extra3.Checked = true;
                Extra4.Checked = true;
            }
            else
            {
                Sub1Lec.Checked = false;
                Sub2Lec.Checked = false;
                Sub3Lec.Checked = false;
                Sub4Lec.Checked = false;
                Sub5Lec.Checked = false;
                Sub1Lab.Checked = false;
                Sub2Lab.Checked = false;
                Sub3Lab.Checked = false;
                Sub4Lab.Checked = false;
                Sub5Lab.Checked = false;
                Extra1.Checked = false;
                Extra2.Checked = false;
                Extra3.Checked = false;
                Extra4.Checked = false;
            }
        }

        // Others Tab
        private void Others_Enter(object sender, EventArgs e)
        {
            CellValue = "";
            btnOpenLink.Enabled = false;
            btnCopyLink.Enabled = false;
            btnAdd.Enabled = false;
        }

        private void SetOthersCategory(object sender, EventArgs e)
        {
            OtherCategory = ActiveControl.Text;
            btnClear.Enabled = true;
            if (txtOtherName.Text != "" && txtOtherLink.Text.StartsWith("http://www.") == true)
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;
        }

        private void btnClearOthersData_Click(object sender, EventArgs e)
        {
            txtOtherLink.Text = "http://";
            txtOtherComment.Text = "";
            txtOtherName.Text = "";
            txtOtherAuthor.Text = "";
            btnOtherCategoryExtra.Checked = false;
            btnOtherCategoryLab.Checked = false;
            btnOtherCategoryLec.Checked = false;
            btnOtherCategoryOther.Checked = false;
            OtherCategory = "";
            lblOtherName.ForeColor = Color.Black;
            lblOtherCategory.ForeColor = Color.Black;
            lblOtherLink.ForeColor = Color.Black;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtOtherName.Text == "")
            {
                lblOtherName.ForeColor = Color.Red;
            }
            else
            {
                lblOtherLink.ForeColor = Color.Black;
                if (OtherCategory == "")
                {
                    lblOtherCategory.ForeColor = Color.Red;
                }

                else
                {
                    lblOtherName.ForeColor = Color.Black;
                    if (txtOtherLink.Text.StartsWith("http://www.") != true)
                    {
                        lblOtherLink.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblOtherCategory.ForeColor = Color.Black;
                        DBAccess AddOthers = new DBAccess();
                        if (AddOthers.AddOther(txtOtherAuthor.Text, txtOtherName.Text, OtherCategory, txtOtherLink.Text, txtOtherComment.Text))
                        {
                            MessageFrm ShowMessage = new MessageFrm();
                            ShowMessage.Title = "Information";
                            ShowMessage.Content = "The file has been successfully added.";
                            ShowMessage.ShowDialog();
                        }
                        else
                        {
                            MessageFrm ShowMessage = new MessageFrm();
                            ShowMessage.Title = "Error";
                            ShowMessage.Content = "Error adding file.\n\nDetails:\n" + AddOthers.error;
                            ShowMessage.ShowDialog();
                        }
                    }
                }
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            DataViewer.DataSource = dataListBindingSource;
            this.dataListTableAdapter.Fill(this.studyMateDS.DataList);

            btnCopyLink.ForeColor = Color.Orange;
            btnCopyLink.Text = "Copy Link";
            btnGet.Text = "Refresh";
        }

        private void DataViewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellValue = DataViewer.SelectedCells[0].Value.ToString();

            if (CellValue.StartsWith("http://") == true)
            {
                btnOpenLink.Enabled = true;
                btnCopyLink.ForeColor = Color.Orange;
                btnCopyLink.Text = "Copy Link";
                btnCopyLink.Enabled = true;
            }
            else
            {
                btnCopyLink.Text = "Copy Link";
                btnOpenLink.Enabled = false;
                btnCopyLink.Enabled = false;
            }
        }

        private void btnCopyOther_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValue);
            btnCopyLink.ForeColor = Color.Green;
            btnCopyLink.Text = "Copied";
        }

        private void btnOpenOther_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(CellValue);
        }

        private void txtOtherLink_TextChanged(object sender, EventArgs e)
        {
            if (txtOtherName.Text != "" && OtherCategory != "" && txtOtherLink.Text.StartsWith("http://www.") == true && txtOtherLink.Text.Contains(".com") == true)
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;

            if (txtOtherLink.Text.StartsWith("http://") != true)
                txtOtherLink.Text = "http://";
        }

        private void txtOtherName_TextChanged(object sender, EventArgs e)
        {
            if (OtherCategory != "" && txtOtherLink.Text.StartsWith("http://www.") == true)
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;
        }

        // AdminPanel Tab
        private void tabAdminPanel_Enter(object sender, EventArgs e)
        {
            LoginFrm LogIn = new LoginFrm();
            LogIn.ShowDialog();
            if (Properties.Settings.Default.UserName == "")
            {
                tabMain.SelectedTab = tabUpdates;
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            new SignupFrm().ShowDialog();
        }

        private void btnCloseAdminPanel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserName = "";
            tabMain.SelectedTab = tabUpdates;
        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            new EditPasswordFrm().ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RegistryKey StudyMate = Registry.LocalMachine.OpenSubKey("SOFTWARE", true);
            StudyMate.DeleteSubKey("StudyMate");

            if (StartWithWindowsMenu.Checked != false)
            {
                RegistryKey StartWithWindows = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                StartWithWindows.DeleteValue("StudyMate");
            }

            Properties.Settings.Default.Reset();
            Application.Exit();
        }

        // MainMenu
        private void AboutStudyMateMenu_Click(object sender, EventArgs e)
        {
            new AboutFrm().ShowDialog();
        }

        private void ContentsMenu_Click(object sender, EventArgs e)
        {
            new HelpFrm().ShowDialog();
        }

        private void ReportABugMenu_Click(object sender, EventArgs e)
        {
             new ReportABugFrm().ShowDialog();
        }

        private void ChangelogMenu_Click(object sender, EventArgs e)
        {
            new ChangelogFrm().ShowDialog();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            TrayIcon.Visible = false;
            Application.Exit();
        }

        private void CloseMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ShowInTaskbar = false;
            TrayIcon.Visible = true;
        }

        private void DefaultOptionsMenu_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "CloseToTray", "false", RegistryValueKind.String);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "MinimizeToTray", "false", RegistryValueKind.String);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "StartWithWindows", "false", RegistryValueKind.String);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "AlwaysShowTrayIcon", "false", RegistryValueKind.String);
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\StudyMate", "AutoUpdateCheck", "false", RegistryValueKind.String);

                if (StartWithWindowsMenu.Checked != false)
                {
                    RegistryKey StartWithWindows = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    StartWithWindows.DeleteValue("StudyMate");
                }
            }
            finally
            {
                CloseToTrayMenu.Checked = false;
                MinimizeToTrayMenu.Checked = false;
                StartWithWindowsMenu.Checked = false;
                AlwaysShowTrayIconMenu.Checked = false;
                AutoUpdateCheckMenu.Checked = false;
            }
        }

        private void CheckForUpdatesMenu_Click(object sender, EventArgs e)
        {
            new CheckForUpdateFrm().ShowDialog();
        }

        private void WebsiteMenu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.Website.ToString());
        }

        private void StartWithWindowsMenu_Click(object sender, EventArgs e)
        {
            if (StartWithWindowsMenu.Checked == false)
            {
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "StudyMate", Application.ExecutablePath);
                StartWithWindowsMenu.Checked = true;
            }
            else
            {
                RegistryKey StartWithWindows = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                StartWithWindows.DeleteValue("StudyMate");
                StartWithWindowsMenu.Checked = false;
            }
        }

        private void MinimizeToTrayMenu_Click(object sender, EventArgs e)
        {
            if (MinimizeToTrayMenu.Checked == false)
            {
                MinimizeToTrayMenu.Checked = true;
            }
            else
            {
                MinimizeToTrayMenu.Checked = false;
            }
        }

        private void CloseToTrayMenu_Click(object sender, EventArgs e)
        {
            if (CloseToTrayMenu.Checked == false)
            {
                CloseToTrayMenu.Checked = true;
            }
            else
            {
                CloseToTrayMenu.Checked = false;
            }
        }

        private void AutoUpdateCheckMenu_Click(object sender, EventArgs e)
        {
            if (AutoUpdateCheckMenu.Checked == false)
            {
                AutoUpdateCheckMenu.Checked = true;
            }
            else
            {
                AutoUpdateCheckMenu.Checked = false;
            }
        }

        private void AlwaysShowTrayIconMenu_Click(object sender, EventArgs e)
        {
            if (AlwaysShowTrayIconMenu.Checked == false)
            {
                TrayIcon.Visible = true;
                AlwaysShowTrayIconMenu.Checked = true;
            }
            else
            {
                TrayIcon.Visible = false;
                AlwaysShowTrayIconMenu.Checked = false;
            }
        }

        // TrayIconMenu
        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            OpenStudyMateContextMenu.PerformClick();
        }

        private void OpenStudyMateContextMenu_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;

            if (AlwaysShowTrayIconMenu.Checked == false)
                TrayIcon.Visible = false;
        }

        private void ExitContextMenu_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Application.Exit();
        }

        private void CheckForContentUpdatesMenu_Click(object sender, EventArgs e)
        {
            this.Show();
            tabMain.SelectedTab = tabUpdates;
        }

    }
}
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyMate
{
    public partial class LoginFrm : Form
    {
        bool LoggedIn = false;

        public LoginFrm()
        {
            InitializeComponent();
        }
        
        private void LoginFrm_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void LoginFrm_Shown(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")
            {
                lblUserName.ForeColor = Color.Green;
            }
            else
            {
                if (txtPassword.Text != "")
                    lblUserName.ForeColor = Color.Red;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                lblPassword.ForeColor = Color.Green;
            }
            else
            {
                if(txtUserName.Text != "")
                    lblPassword.ForeColor = Color.Red;
            }
        }

        private void LoginEnable_ForeColorChanged(object sender, EventArgs e)
        {
            if (lblUserName.ForeColor == Color.Green && lblPassword.ForeColor == Color.Green)
                btnLogin.Enabled = true;
            else
                btnLogin.Enabled = false;
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            bg.CancelAsync();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bg.RunWorkerAsync();
        }

        private void bg_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (bg.CancellationPending == true)
            {
                e.Cancel = true;
                this.Close();
            }
            else
            {
                DBAccess Login = new DBAccess();
                Login.LoginUserName = txtUserName.Text;
                Login.LoginPassword = txtPassword.Text;
                if (Login.LogIn() == false)
                    LoggedIn = false;
                else
                    LoggedIn = true;
            }
        }

        private void bg_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (LoggedIn == false)
            {
                MessageFrm ShowMessage = new MessageFrm();
                ShowMessage.Title = "Error";
                ShowMessage.Content = "Incorrect Username or Password.";
                ShowMessage.ShowDialog();

                txtPassword.Text = "";
                lblPassword.ForeColor = Color.Red;
            }
            else
            {
                Properties.Settings.Default.UserName = txtUserName.Text;
                this.Close();
            }
        }
    }
}
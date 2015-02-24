using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyMate
{
    public partial class SignupFrm : Form
    {
        public SignupFrm()
        {
            InitializeComponent();
        }

        private void SignupFrm_Load(object sender, EventArgs e)
        {
            btnSignup.Enabled = false;
        }
        
        private void SignupFrm_Shown(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }
        
        private void txt_TextChanged(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;

            if (txtUserName.Text != "")
                lblUserName.ForeColor = Color.Green;
            else
                if (txtPassword.Text == txtConfirm.Text && txtPassword.Text != "")
                    lblUserName.ForeColor = Color.Red;

            if (txtPassword.Text == txtConfirm.Text && txtPassword.Text != "")
            {
                lblPassword.ForeColor = Color.Green;
                lblConfirm.ForeColor = Color.Green;
            }
            else
            {
                if (txtPassword.Text != txtConfirm.Text && (txtPassword.Text != "" && txtConfirm.Text != ""))
                {
                    lblPassword.ForeColor = Color.Red;
                    lblConfirm.ForeColor = Color.Red;
                }
                else
                {
                    lblPassword.ForeColor = Color.Black;
                    lblConfirm.ForeColor = Color.Black;
                }
            }

            btnSignup.Text = "Signup";
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (btnSignup.Text == "Close")
            {
                this.Close();
            }
            else
            {
                DBAccess Signup = new DBAccess();
                if (Signup.SignUp(txtUserName.Text, txtPassword.Text) == true)
                {
                    MessageFrm ShowMessage = new MessageFrm();
                    ShowMessage.Title = "Information";
                    ShowMessage.Content = txtUserName.Text + " has been Sucessfully registered.";
                    ShowMessage.ShowDialog();

                    btnSignup.Text = "Close";
                    btnCancel.Enabled = false;
                }
                else
                {
                    MessageFrm ShowMessage = new MessageFrm();
                    ShowMessage.Title = "Error";
                    ShowMessage.Content = Signup.error;
                    ShowMessage.ShowDialog();
                }
            }
        }

        private void lblUserName_ForeColorChanged(object sender, EventArgs e)
        {
            if (lblUserName.ForeColor == Color.Green && lblPassword.ForeColor == Color.Green && lblConfirm.ForeColor == Color.Green)
                btnSignup.Enabled = true;
            else
                btnSignup.Enabled = false;
        }

    }
}
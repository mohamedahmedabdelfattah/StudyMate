using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StudyMate
{
    public partial class EditPasswordFrm : Form
    {
        public EditPasswordFrm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePasswordFrm_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            txtOldPassword.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string OldPassword = "";

            DBAccess GetOldPassword = new DBAccess();
            OldPassword = GetOldPassword.Get("SELECT Password FROM UsersList WHERE UserName = '" + @Properties.Settings.Default.UserName + "'", "Password");

            if (txtOldPassword.Text == OldPassword)
            {
                // Set New Password

                SqlConnection Connection = new SqlConnection(Properties.Settings.Default.StudyMateConnectionString);
                SqlCommand Command = new SqlCommand();

                Command = new SqlCommand("UPDATE UsersList SET [Password] = '" + txtConfirmNewPassword.Text + "' WHERE (UserName = '" + @Properties.Settings.Default.UserName + "')", Connection);

                Connection.Open();

                Command.ExecuteNonQuery();

                Connection.Close();

                MessageFrm ShowMessage = new MessageFrm();
                ShowMessage.Title = "Information";
                ShowMessage.Content = "Password Changed Successfully.";
                ShowMessage.ShowDialog();

                btnCancel.Enabled = false;
                this.Close();
            }
            else
            {
                lblOldPassword.ForeColor = Color.Red;
                txtOldPassword.Text = "";
            }
        }

        private void btnSaveEnable_(object sender, EventArgs e)
        {
            if (lblOldPassword.ForeColor == Color.Green && lblNewPassword.ForeColor == Color.Green && lblConfirmNewPassword.ForeColor == Color.Green)
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            if (txtNewPassword.Text == txtConfirmNewPassword.Text && txtNewPassword.Text != "")
            {
                lblNewPassword.ForeColor = Color.Green;
                lblConfirmNewPassword.ForeColor = Color.Green;
                if (txtOldPassword.Text != "")
                    lblOldPassword.ForeColor = Color.Green;
                else
                    lblOldPassword.ForeColor = Color.Red;
            }
            else
            {
                if (txtNewPassword.Text != txtConfirmNewPassword.Text && (txtNewPassword.Text != "" && txtConfirmNewPassword.Text != ""))
                {
                    lblNewPassword.ForeColor = Color.Red;
                    lblConfirmNewPassword.ForeColor = Color.Red;
                    if (txtOldPassword.Text != "")
                        lblOldPassword.ForeColor = Color.Green;
                    else
                        lblOldPassword.ForeColor = Color.Black;

                }
                else
                {
                    lblNewPassword.ForeColor = Color.Black;
                    lblConfirmNewPassword.ForeColor = Color.Black;
                }
            }
        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            if (txtOldPassword.Text == "")
            {
                if (lblNewPassword.ForeColor == Color.Green)
                    lblOldPassword.ForeColor = Color.Red;
                else
                    lblOldPassword.ForeColor = Color.Black;
            }
            else
            {
                lblOldPassword.ForeColor = Color.Green;
            }
        }

        private void EditPasswordFrm_Shown(object sender, EventArgs e)
        {
            txtOldPassword.Focus();
        }

    }
}
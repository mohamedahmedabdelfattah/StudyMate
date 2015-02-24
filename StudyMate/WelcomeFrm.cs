using System;
using System.Windows.Forms;

namespace StudyMate
{
    public partial class WelcomeFrm : Form
    {
        public WelcomeFrm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WelcomeFrm_Load(object sender, EventArgs e)
        {
            this.Text = "StudyMate - Hello, " + Environment.UserName;
        }
    }
}
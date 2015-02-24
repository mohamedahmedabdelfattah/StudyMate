using System;
using System.Windows.Forms;

namespace StudyMate
{
    public partial class AboutFrm : Form
    {
        public AboutFrm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutFrm_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Application.ProductVersion;
        }
    }
}
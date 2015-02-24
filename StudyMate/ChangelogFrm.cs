using System;
using System.Windows.Forms;

namespace StudyMate
{
    public partial class ChangelogFrm : Form
    {
        public ChangelogFrm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangelogFrm_Shown(object sender, EventArgs e)
        {
            txtHelp.Focus();
        }
    }
}
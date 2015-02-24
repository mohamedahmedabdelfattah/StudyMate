using System;
using System.Windows.Forms;

namespace StudyMate
{
    public partial class HelpFrm : Form
    {
        public HelpFrm()
        {
            InitializeComponent();
        }

        private void HelpFrm_Shown(object sender, EventArgs e)
        {
            txtHelp.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
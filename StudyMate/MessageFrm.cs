using System;
using System.Media;
using System.Windows.Forms;

namespace StudyMate
{
    public partial class MessageFrm : Form
    {
        string _Title,_Content;

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        public string Content
        {
            get { return _Content; }
            set { _Content = value; }
        }

        public MessageFrm()
        {
            InitializeComponent();
        }

        private void MessageFrm_Load(object sender, EventArgs e)
        {
            this.Text = "StudyMate - " + _Title ;
            lblMessage.Text = _Content;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MessageFrm_Shown(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"C:\WINDOWS\Media\notify.wav");
            sound.Play();
            sound.Dispose();
        }
    }
}
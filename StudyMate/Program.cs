using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace StudyMate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool onlyInstance = false;
            Mutex mutex = new Mutex(true, @"Local\"+"78296522-6302-4263-ac2c-a7efe36c8eaa", out onlyInstance);
            if (!onlyInstance)
            {
                MessageFrm ShowMessage = new MessageFrm();
                ShowMessage.Title = "Warning";
                ShowMessage.Content = "StudyMate is already running.";
                ShowMessage.StartPosition = FormStartPosition.CenterScreen;
                ShowMessage.ShowDialog();
                return;
            }
            else
            {
                Application.Run(new MainFrm());
                GC.KeepAlive(mutex);
            }
        }
    }
}
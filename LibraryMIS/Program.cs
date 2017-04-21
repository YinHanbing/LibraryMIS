using System;
using System.Windows.Forms;

namespace LibraryMIS
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

            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            formLogin.Dispose();
            if (Common.CGlobal.userName == "") return;
            Application.Run(new FormMain());
        }
    }
}

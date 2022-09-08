using System;
using System.Windows.Forms;
using YesilEvCodeFirst.UIWinForm.AdminSayfalari;

namespace YesilEvCodeFirst.UIWinForm
{

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new SignInSignUpForm());
            //Application.Run(new AdminSayfasi());
        }
    }
}

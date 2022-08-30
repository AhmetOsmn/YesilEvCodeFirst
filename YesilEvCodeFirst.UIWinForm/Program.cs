using System;
using System.Windows.Forms;
using YesilEvCodeFirst.UIWinForm.Raporlar;

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
            Application.Run(new Rapor01Form());
        }
    }
}

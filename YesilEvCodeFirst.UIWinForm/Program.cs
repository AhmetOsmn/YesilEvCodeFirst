using System;
using System.Windows.Forms;
using YesilEvCodeFirst.UIWinForm.Raporlar;

namespace YesilEvCodeFirst.UIWinForm
{
    // todo: UI kisminda urun ekle-duzenle sayfasina tiklandiginda sol menu gelmiyor.
    // todo: Kullanici urun ekleme yaparken fotograf eklerse, o fotograftaki icerikler ile eklenen urun arasinda nasil iliski kurulacak?
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
            //Application.Run(new Form1());
            Application.Run(new UserSayfasi());
        }
    }
}

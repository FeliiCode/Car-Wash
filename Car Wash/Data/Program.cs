using System;
using System.Windows.Forms;

namespace Car_Wash.Koneksi
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu()); // pastikan ini
        }
    }
}

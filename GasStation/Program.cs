using System;
using System.Windows.Forms;

namespace GasStation
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserSelection());
            //Application.Run(new Authentication());
            //Application.Run(new MainPage());
            //Application.Run(new CashReceipt());
            //Application.Run(new Refueling());
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
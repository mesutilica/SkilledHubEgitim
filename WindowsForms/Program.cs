using System;
using System.Windows.Forms;

namespace WindowsForms
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
            Application.Run(new Form7()); // windows forms projesi çalıştığında hangi formun açılacağını buradan ayarlıyoruz.
        }
    }
}

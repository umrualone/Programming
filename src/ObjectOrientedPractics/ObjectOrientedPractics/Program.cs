using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View;

namespace ObjectOrientedPractics
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Serializer.IsCreateFolderAndFile();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

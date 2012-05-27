using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OsModel.Processes;

namespace OsModel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Core.StartOperatingSystem();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

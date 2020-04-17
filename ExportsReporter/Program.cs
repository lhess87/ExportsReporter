using ExportsReporter.Presenters;
using ExportsReporter.Views;
using System;
using System.Windows.Forms;

namespace ExportsReporter
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
            ExportsReportView exportsReportView =new ExportsReportView();
            exportsReportView.Init();
            Application.Run(exportsReportView);
        }
    }
}

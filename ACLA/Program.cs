using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACLA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ApplicationOnThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ACLAmainForm());
        }
        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var message = String.Format("Oooopss.. Something went wrong. Details below:\r\n\n" +
                                        "{0}\r\n\n" +
                                        "Please check the input data and make sure you're connected to Objectovity intranet.",
                ((Exception)e.ExceptionObject).Message);

            MessageBox.Show(message, "Unhandled error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs e)
        {
            var message = String.Format("Oooopss.. Something went wrong. Details below:\r\n\n" +
                                        "{0}\r\n\n" +
                                        "Please check the input data and make sure you're connected to Objectovity intranet.",
                e.Exception.Message);

            MessageBox.Show(message, "Nieoczekiwany błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

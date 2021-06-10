using System;
using System.Threading;
using System.Windows.Forms;

namespace Quiccent
{
    static class Program
    {
        static Mutex Mutex = new Mutex(false, "QuiccentByDavidBennett");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var mainForm = new Form1();
                Application.Run();
            }
            else
            {
                MessageBox.Show("Quiccent is already running in another instance.");
            }
        }
    }
}

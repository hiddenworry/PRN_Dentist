using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp;

namespace frmLogin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

<<<<<<< HEAD
            Application.Run(new frmHomeStaff());

            //Application.Run(new frmHomeDoctor());
=======

            Application.Run(new frmLogin());

            

>>>>>>> 42cc2ba450d82ce0b28a1449cbf15841d63a84f6

        }
    }
}

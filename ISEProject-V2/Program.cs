using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISEProject_V2.UserControls;

namespace ISEProject_V2
{
    static class Program
    {
        //89, 142, 244
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GODashboard());
            //Application.Run(new formSignIn());
          // Application.Run(new SupplierDashBoard());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Project_III_GUI
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
            Application.Run(new LoginPage());
            Application.Run(new TableA1ChefView());
            Application.Run(new TableA1());
            Application.Run(new Waiter_s_View());   
            Application.Run(new OrderCart());
        }
    }
}

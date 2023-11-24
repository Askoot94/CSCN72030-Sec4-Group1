using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using System.IO;

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
            Order newOrder = new Order("testing");

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new TableA1());
            // Application.Run(new Waiter_s_View());   
            // Application.Run(new LoginPage());   
            //Application.Run(new OrderCart());

        }
    }
}

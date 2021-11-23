using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiColorModernUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



         


            //Check if there is SQL server or not

            if (File.Exists($"{Application.StartupPath}/ConnectionDB.dat"))
            {
                // Connection file already saved
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainCard());
            }
            else
            {
                // you need to login or create database

                //show login Card with option for create new database

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginCard());


            }


        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libre_Update
{
    static class Program
    {
        public static string connection_string;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Libre_Engine.DatabasePackageControl.GetName();
           // Libre_Engine.VarHold.AssignName();
            Application.Run(new Home());
          
        }
    }
}

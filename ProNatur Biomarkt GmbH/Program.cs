﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //  * nicht mit loadingScreen beginnen
            //  Application.Run(new Form_loadingScreen());
            //  Application.Run(new Form_main());

            //  * sondern hiermitn
            Application.Run(new Form_product());
        }
    }
}

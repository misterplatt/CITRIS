﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CITRIS_Screen_Selector_Drag_and_Drop
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
            Application.Run(new ScreenSelector());
        }
    }
}
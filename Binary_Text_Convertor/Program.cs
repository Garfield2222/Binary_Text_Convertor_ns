using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Binary_Text_Convertor
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
            Application.Run(new Binary_And_Text_Conversion());
        }
    }
}

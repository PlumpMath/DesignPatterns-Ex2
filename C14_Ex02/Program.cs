using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace C14_Ex02
{
    public static class Program
    {// $G$ THE-001 (-20) your grade on diagrams document - 69. please see comments inside the document. (40% of your grade).
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace Workshop1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [ExcludeFromCodeCoverage]
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pruebas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /// Esto es una prueba de como se ven los cambios
            Application.AddMessageFilter();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
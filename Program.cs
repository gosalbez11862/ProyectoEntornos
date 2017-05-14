// ***********************************************************************
// Assembly         : NavajaSuiza
// Author           : Carlos
// Created          : 04-09-2017
//
// Last Modified By : Carlos
// Last Modified On : 05-14-2017
// ***********************************************************************
// <copyright file="Program.cs">
//
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Windows.Forms;

namespace NavajaSuiza
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

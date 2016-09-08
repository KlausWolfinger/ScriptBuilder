﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Script_Builder
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (Environment.Version.Major < 2 || Environment.Version.MajorRevision < 0 || Environment.Version.Build < 50727 || Environment.Version.MinorRevision < 3053)
            {
                //MessageBox.Show("Es ist nicht die richtige .Net-Framework Version Installiert.\r\n\r\nInstalliert: " + Environment.Version.ToString() + "\r\nBenötigt: 2.0.50727.3053 (Framework 3.5 SP1)", "Falsche .Net-Framework Version", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("You don't have the correct .Net-Framework version installed.\r\n\r\nInstalled version: " + Environment.Version.ToString() + "\r\nRequired version: 2.0.50727.3053 (Framework 3.5 SP1)", "Wrong .Net-Framework Version", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm(args));
        }
    }
}

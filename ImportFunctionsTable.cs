using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/**************************************
 * Tabelle:
 * - importierte XLSX/CSV in Tabelle einlesen
 * - Encoding bestimmen
 * - Kopfzeile erstellen
 * - Spalten erstellen
 * - Daten in Tabelle schreiben
 * - Daten an Ausgabe weiterreichen
 * - Tabelle exportieren in XLSX/CSV
 *************************************/

namespace Script_Builder
{
    class ImportFunctionsTable
    {
        // Variabeln

        // Tabelle einlesen
        private void importTable()
        {

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            string Pfad = string.Empty;
            string encoding = "test";

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Pfad = openFileDialog1.FileName;
                encoding = GetEncoding(Pfad);
            }

            MessageBox.Show(encoding + "\n", "EncodingSpaß", MessageBoxButtons.OK);
        }*/

        // Dateiencoding feststellen
        public static Encoding getEncoding(string filename)
        {
            // Read the BOM
            var bom = new byte[4];
            using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }

            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            return Encoding.ASCII;
        }

        // Kopfzeile auslesen
        private void setHeadline()
        {

        }

        // Tabelle exportieren
        private void exportTable()
        {

        }

        // Importierte Tabelle an Ausgabe geben
        private void exportTableToWindow()
        {

        }

    }
}

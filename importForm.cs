using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Script_Builder
{
    public enum ImportType
    {
        File
    }

    public partial class importForm : Form
    {
        private mainForm mainForm;

        public importForm(mainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            string startPath;
            switch (mainForm.programOptions.GetOptions("StartPathType").Value)
            {
                case "GroupsLast":
                    startPath = "StartPathTable";
                    break;
                default:
                    startPath = "StartPath";
                    break;
            }
            importFile.Text = mainForm.programOptions.GetOptions(startPath).Value;
        }

        public string importFilePath
        {
            get
            {
                return importFile.Text;
            }
        }

        public bool firstRowHeader
        {
            get
            {
                return firstRowHeaders.Checked;
            }
        }

        public ImportType ImportType
        {
            get
            {
                return ImportType.File;
            }
        }


        public char[] SeparatorChar
        {
            get
            {
                if (radKomma.Checked)
                    return new char[] { ',' };
                else if (radSemikolon.Checked)
                    return new char[] { ';' };
                else if (radTab.Checked)
                    return new char[] { '\t' };
                else if (radPipe.Checked)
                    return new char[] { '|' };
                else if (radSpace.Checked)
                    return new char[] { ' ' };
                else //radCustom.Checked
                    return txtCustom.Text.ToCharArray();
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            string startPath;
            OpenFileDialog openImportFile = new OpenFileDialog();
            switch (mainForm.programOptions.GetOptions("StartPathType").Value)
            {
                case "GroupsLast":
                    startPath = "StartPathTable";
                    break;
                default:
                    startPath = "StartPath";
                    break;
            }
            if (importFile.Text != "")
                openImportFile.InitialDirectory = Path.GetDirectoryName(importFile.Text + "\\");
            else
                openImportFile.InitialDirectory = mainForm.programOptions.GetOptions(startPath).Value;
            openImportFile.AddExtension = true;
            openImportFile.CheckFileExists = true;
            openImportFile.CheckPathExists = true;
            openImportFile.Multiselect = false;
            openImportFile.ShowReadOnly = false;
            openImportFile.SupportMultiDottedExtensions = true;
            openImportFile.ValidateNames = true;

            if(radFiletypeXLSX.Checked == true)
            {
                openImportFile.DefaultExt = "xlsx";
                openImportFile.Filter = mainForm.programmStrings.GetString("filterXLSX");
                openImportFile.Filter += "|" + mainForm.programmStrings.GetString("filterAllFiles");
            } else if(radFiletypeCSV.Checked == true)
            {
                openImportFile.DefaultExt = "csv";
                openImportFile.Filter = mainForm.programmStrings.GetString("filterCSV");
                openImportFile.Filter += "|" + mainForm.programmStrings.GetString("filterTXT");
                openImportFile.Filter += "|" + mainForm.programmStrings.GetString("filterAllFiles");
            }
            else
            {
                openImportFile.DefaultExt = "*";
                openImportFile.Filter = mainForm.programmStrings.GetString("filterXLSX");
                openImportFile.Filter += "|" + mainForm.programmStrings.GetString("filterCSV");
                openImportFile.Filter += "|" + mainForm.programmStrings.GetString("filterTXT");
                openImportFile.Filter += "|" + mainForm.programmStrings.GetString("filterAllFiles");
            }
            
            openImportFile.FilterIndex = 1;
            openImportFile.Title = mainForm.programmStrings.GetString("textImportTableFrom");
            DialogResult result = openImportFile.ShowDialog();
            if (result == DialogResult.Cancel) return;
            importFile.Text = openImportFile.FileName.ToString();
            mainForm.CurrentPath = Path.GetDirectoryName(openImportFile.FileName);
            if (mainForm.programOptions.GetOptions("StartPathType").Value != "AlwaysSame")
                mainForm.programOptions.SetOptions(startPath, mainForm.CurrentPath);
        }

        private void txtCustom_TextChanged(object sender, EventArgs e)
        {
            if (txtCustom.TextLength > 1)
                txtCustom.Text = txtCustom.Text.Remove(1);
        }

        private void radCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (radCustom.Checked == true)
                txtCustom.Enabled = true;
            else
                txtCustom.Enabled = false;
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            if (radCustom.Checked && txtCustom.TextLength != 1)
            {
                MessageBox.Show(mainForm.programmStrings.GetString("textCustomSeperator"), mainForm.programmStrings.GetString("textImportTable"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!File.Exists(importFile.Text))
            {
                MessageBox.Show(mainForm.programmStrings.GetString("textFileDontExits"), mainForm.programmStrings.GetString("textImportTable"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void importFile_TextChanged(object sender, EventArgs e)
        {
            mainForm.CurrentPath = Path.GetFullPath(importFile.Text);
        }

        private void radFiletypeXLSXChanged(object sender, EventArgs e)
        {
            if (radFiletypeXLSX.Checked == true)
            {
                groupBox1.Enabled = false;
            }else
            {
                groupBox1.Enabled = true;
            }
        }

        private void radFiletypeCSVChanged(object sender, EventArgs e)
        {
            if (radFiletypeCSV.Checked == true)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

    }
}

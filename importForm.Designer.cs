namespace Script_Builder
{
    partial class importForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(importForm));
            this.importButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.importFile = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTab = new System.Windows.Forms.RadioButton();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.radCustom = new System.Windows.Forms.RadioButton();
            this.radPipe = new System.Windows.Forms.RadioButton();
            this.radSpace = new System.Windows.Forms.RadioButton();
            this.radSemikolon = new System.Windows.Forms.RadioButton();
            this.radKomma = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.firstRowHeaders = new System.Windows.Forms.CheckBox();
            this.fileformat = new System.Windows.Forms.GroupBox();
            this.radFiletypeCSV = new System.Windows.Forms.RadioButton();
            this.radFiletypeXLSX = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.fileformat.SuspendLayout();
            this.SuspendLayout();
            // 
            // importButton
            // 
            resources.ApplyResources(this.importButton, "importButton");
            this.importButton.Name = "importButton";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // importFile
            // 
            resources.ApplyResources(this.importFile, "importFile");
            this.importFile.Name = "importFile";
            this.importFile.TextChanged += new System.EventHandler(this.importFile_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radTab);
            this.groupBox1.Controls.Add(this.txtCustom);
            this.groupBox1.Controls.Add(this.radCustom);
            this.groupBox1.Controls.Add(this.radPipe);
            this.groupBox1.Controls.Add(this.radSpace);
            this.groupBox1.Controls.Add(this.radSemikolon);
            this.groupBox1.Controls.Add(this.radKomma);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enabled = true;
            // 
            // radTab
            // 
            resources.ApplyResources(this.radTab, "radTab");
            this.radTab.Name = "radTab";
            this.radTab.UseVisualStyleBackColor = true;
            // 
            // txtCustom
            // 
            resources.ApplyResources(this.txtCustom, "txtCustom");
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.TextChanged += new System.EventHandler(this.txtCustom_TextChanged);
            // 
            // radCustom
            // 
            resources.ApplyResources(this.radCustom, "radCustom");
            this.radCustom.Name = "radCustom";
            this.radCustom.UseVisualStyleBackColor = true;
            this.radCustom.CheckedChanged += new System.EventHandler(this.radCustom_CheckedChanged);
            // 
            // radPipe
            // 
            resources.ApplyResources(this.radPipe, "radPipe");
            this.radPipe.Name = "radPipe";
            this.radPipe.UseVisualStyleBackColor = true;
            // 
            // radSpace
            // 
            resources.ApplyResources(this.radSpace, "radSpace");
            this.radSpace.Name = "radSpace";
            this.radSpace.UseVisualStyleBackColor = true;
            // 
            // radSemikolon
            // 
            resources.ApplyResources(this.radSemikolon, "radSemikolon");
            this.radSemikolon.Checked = true;
            this.radSemikolon.Name = "radSemikolon";
            this.radSemikolon.TabStop = true;
            this.radSemikolon.UseVisualStyleBackColor = true;
            // 
            // radKomma
            // 
            resources.ApplyResources(this.radKomma, "radKomma");
            this.radKomma.Name = "radKomma";
            this.radKomma.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.browseButton);
            this.groupBox3.Controls.Add(this.importFile);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // browseButton
            // 
            resources.ApplyResources(this.browseButton, "browseButton");
            this.browseButton.Name = "browseButton";
            this.toolTip1.SetToolTip(this.browseButton, resources.GetString("browseButton.ToolTip"));
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // firstRowHeaders
            // 
            resources.ApplyResources(this.firstRowHeaders, "firstRowHeaders");
            this.firstRowHeaders.Checked = true;
            this.firstRowHeaders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.firstRowHeaders.Name = "firstRowHeaders";
            this.firstRowHeaders.UseVisualStyleBackColor = true;
            // 
            // fileformat
            // 
            this.fileformat.Controls.Add(this.radFiletypeCSV);
            this.fileformat.Controls.Add(this.radFiletypeXLSX);
            resources.ApplyResources(this.fileformat, "fileformat");
            this.fileformat.Name = "fileformat";
            this.fileformat.TabStop = false;
            this.fileformat.Enabled = false;
            // 
            // radFiletypeCSV
            // 
            resources.ApplyResources(this.radFiletypeCSV, "radFiletypeCSV");
            this.radFiletypeCSV.Name = "radFiletypeCSV";
            this.radFiletypeCSV.TabStop = true;
            this.toolTip1.SetToolTip(this.radFiletypeCSV, resources.GetString("radFiletypeCSV.ToolTip"));
            this.radFiletypeCSV.UseVisualStyleBackColor = true;
            // Temporär Standard
            this.radFiletypeCSV.Checked = true;
            // 
            // radFiletypeXLSX
            // 
            resources.ApplyResources(this.radFiletypeXLSX, "radFiletypeXLSX");
            //this.radFiletypeXLSX.Checked = true;
            this.radFiletypeXLSX.Name = "radFiletypeXLSX";
            this.radFiletypeXLSX.TabStop = true;
            this.toolTip1.SetToolTip(this.radFiletypeXLSX, resources.GetString("radFiletypeXLSX.ToolTip"));
            this.radFiletypeXLSX.UseVisualStyleBackColor = true;
            this.radFiletypeXLSX.CheckedChanged += new System.EventHandler(this.radFiletypeXLSXChanged);
            // 
            // importForm
            // 
            this.AcceptButton = this.importButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ControlBox = false;
            this.Controls.Add(this.fileformat);
            this.Controls.Add(this.firstRowHeaders);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.importButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "importForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.fileformat.ResumeLayout(false);
            this.fileformat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustom;
        private System.Windows.Forms.RadioButton radCustom;
        private System.Windows.Forms.RadioButton radPipe;
        private System.Windows.Forms.RadioButton radSpace;
        private System.Windows.Forms.RadioButton radSemikolon;
        private System.Windows.Forms.RadioButton radKomma;
        private System.Windows.Forms.RadioButton radTab;
        private System.Windows.Forms.TextBox importFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox firstRowHeaders;
        private System.Windows.Forms.GroupBox fileformat;
        private System.Windows.Forms.RadioButton radFiletypeCSV;
        private System.Windows.Forms.RadioButton radFiletypeXLSX;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
﻿namespace Script_Builder
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgrExcelContents = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvVorlageSelect = new System.Windows.Forms.TreeView();
            this.cxmVorlageSelect = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.vorlageVerwaltenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlFileProperties = new System.Windows.Forms.Panel();
            this.btnSerialWizard = new System.Windows.Forms.Button();
            this.btnNodeCancel = new System.Windows.Forms.Button();
            this.btnNodeChange = new System.Windows.Forms.Button();
            this.txtNodeName = new System.Windows.Forms.TextBox();
            this.lblNodeName = new System.Windows.Forms.Label();
            this.cboNodeFileFormat = new System.Windows.Forms.ComboBox();
            this.lblFileFormat = new System.Windows.Forms.Label();
            this.btnNodeBrowseFilePath = new System.Windows.Forms.Button();
            this.txtNodePath = new System.Windows.Forms.TextBox();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.dateiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.vorlagenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tabelleMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.makrosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupDefaultHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.headerOldFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.headerNewFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.hilfeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.cxmTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmTextMenuSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAddVariable = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsmEditName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddSerial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddContent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddSingle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddMultiple = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddSerialBlock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangeOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOrderUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOrderDown = new System.Windows.Forms.ToolStripMenuItem();
            this.picErrorName = new System.Windows.Forms.PictureBox();
            this.createOutputFile = new System.Windows.Forms.ToolStripMenuItem();
            this.showOutputLog = new System.Windows.Forms.ToolStripMenuItem();
            this.options = new System.Windows.Forms.ToolStripMenuItem();
            this.beenden = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.vorlagenImport = new System.Windows.Forms.ToolStripMenuItem();
            this.vorlagenExport = new System.Windows.Forms.ToolStripMenuItem();
            this.docConvert = new System.Windows.Forms.ToolStripMenuItem();
            this.checkTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.createIfBlock = new System.Windows.Forms.ToolStripMenuItem();
            this.checkComplexVariable = new System.Windows.Forms.ToolStripMenuItem();
            this.excelTableImport = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTableImport = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTableExport = new System.Windows.Forms.ToolStripMenuItem();
            this.spalteHinzu = new System.Windows.Forms.ToolStripMenuItem();
            this.spalteEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTable = new System.Windows.Forms.ToolStripMenuItem();
            this.firstRowHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.openScriptingDoku = new System.Windows.Forms.ToolStripMenuItem();
            this.infoPageShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTextCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTextCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTextPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.beispieleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrExcelContents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cxmVorlageSelect.SuspendLayout();
            this.pnlFileProperties.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.cxmTextBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorName)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.splitContainer, "splitContainer");
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer.Panel1.Controls.Add(this.dgrExcelContents);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer.TabStop = false;
            // 
            // dgrExcelContents
            // 
            this.dgrExcelContents.AllowUserToOrderColumns = true;
            this.dgrExcelContents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgrExcelContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgrExcelContents, "dgrExcelContents");
            this.dgrExcelContents.Name = "dgrExcelContents";
            this.dgrExcelContents.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrExcelContents_ColumnHeaderMouseClick);
            this.dgrExcelContents.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgrExcelContents_RowPostPaint);
            this.dgrExcelContents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgrExcelContents_KeyPress);
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvVorlageSelect);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlFileProperties);
            // 
            // trvVorlageSelect
            // 
            this.trvVorlageSelect.ContextMenuStrip = this.cxmVorlageSelect;
            resources.ApplyResources(this.trvVorlageSelect, "trvVorlageSelect");
            this.trvVorlageSelect.FullRowSelect = true;
            this.trvVorlageSelect.HideSelection = false;
            this.trvVorlageSelect.ImageList = this.imageList1;
            this.trvVorlageSelect.ItemHeight = 20;
            this.trvVorlageSelect.Name = "trvVorlageSelect";
            this.trvVorlageSelect.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.trvVorlageSelect_AfterLabelEdit);
            this.trvVorlageSelect.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvVorlageSelect_BeforeSelect);
            this.trvVorlageSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trvVorlageSelect_KeyPress);
            this.trvVorlageSelect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trvVorlageSelect_MouseDown);
            // 
            // cxmVorlageSelect
            // 
            this.cxmVorlageSelect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEditName,
            this.tsmRemove,
            this.toolStripSeparator10,
            this.tsmAddFile,
            this.tsmAddSerial,
            this.tsmAddContent,
            this.toolStripSeparator11,
            this.tsmChangeOrder});
            this.cxmVorlageSelect.Name = "cxmVorlageSelect";
            this.cxmVorlageSelect.OwnerItem = this.vorlageVerwaltenToolStripMenuItem;
            this.cxmVorlageSelect.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            resources.ApplyResources(this.cxmVorlageSelect, "cxmVorlageSelect");
            this.cxmVorlageSelect.Opening += new System.ComponentModel.CancelEventHandler(this.cxmVorlageSelect_Opening);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            resources.ApplyResources(this.toolStripSeparator11, "toolStripSeparator11");
            // 
            // vorlageVerwaltenToolStripMenuItem
            // 
            this.vorlageVerwaltenToolStripMenuItem.DropDown = this.cxmVorlageSelect;
            this.vorlageVerwaltenToolStripMenuItem.Name = "vorlageVerwaltenToolStripMenuItem";
            resources.ApplyResources(this.vorlageVerwaltenToolStripMenuItem, "vorlageVerwaltenToolStripMenuItem");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "select_header.png");
            this.imageList1.Images.SetKeyName(1, "select_body.png");
            this.imageList1.Images.SetKeyName(2, "select_footer.png");
            this.imageList1.Images.SetKeyName(3, "new-templatefile.png");
            this.imageList1.Images.SetKeyName(4, "new-templateserial.png");
            this.imageList1.Images.SetKeyName(5, "serial_header.png");
            // 
            // pnlFileProperties
            // 
            this.pnlFileProperties.Controls.Add(this.picErrorName);
            this.pnlFileProperties.Controls.Add(this.btnSerialWizard);
            this.pnlFileProperties.Controls.Add(this.btnNodeCancel);
            this.pnlFileProperties.Controls.Add(this.btnNodeChange);
            this.pnlFileProperties.Controls.Add(this.txtNodeName);
            this.pnlFileProperties.Controls.Add(this.lblNodeName);
            this.pnlFileProperties.Controls.Add(this.cboNodeFileFormat);
            this.pnlFileProperties.Controls.Add(this.lblFileFormat);
            this.pnlFileProperties.Controls.Add(this.btnNodeBrowseFilePath);
            this.pnlFileProperties.Controls.Add(this.txtNodePath);
            this.pnlFileProperties.Controls.Add(this.lblSavePath);
            resources.ApplyResources(this.pnlFileProperties, "pnlFileProperties");
            this.pnlFileProperties.Name = "pnlFileProperties";
            // 
            // btnSerialWizard
            // 
            resources.ApplyResources(this.btnSerialWizard, "btnSerialWizard");
            this.btnSerialWizard.Name = "btnSerialWizard";
            this.btnSerialWizard.UseVisualStyleBackColor = true;
            this.btnSerialWizard.Click += new System.EventHandler(this.btnSerialWizard_Click);
            // 
            // btnNodeCancel
            // 
            resources.ApplyResources(this.btnNodeCancel, "btnNodeCancel");
            this.btnNodeCancel.Name = "btnNodeCancel";
            this.btnNodeCancel.UseVisualStyleBackColor = true;
            this.btnNodeCancel.Click += new System.EventHandler(this.btnNodeCancel_Click);
            // 
            // btnNodeChange
            // 
            resources.ApplyResources(this.btnNodeChange, "btnNodeChange");
            this.btnNodeChange.Name = "btnNodeChange";
            this.btnNodeChange.UseVisualStyleBackColor = true;
            this.btnNodeChange.Click += new System.EventHandler(this.btnNodeChange_Click);
            // 
            // txtNodeName
            // 
            resources.ApplyResources(this.txtNodeName, "txtNodeName");
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.TextChanged += new System.EventHandler(this.fileProperties_Changed);
            // 
            // lblNodeName
            // 
            resources.ApplyResources(this.lblNodeName, "lblNodeName");
            this.lblNodeName.Name = "lblNodeName";
            // 
            // cboNodeFileFormat
            // 
            this.cboNodeFileFormat.FormattingEnabled = true;
            resources.ApplyResources(this.cboNodeFileFormat, "cboNodeFileFormat");
            this.cboNodeFileFormat.Name = "cboNodeFileFormat";
            this.cboNodeFileFormat.TextChanged += new System.EventHandler(this.fileProperties_Changed);
            // 
            // lblFileFormat
            // 
            resources.ApplyResources(this.lblFileFormat, "lblFileFormat");
            this.lblFileFormat.Name = "lblFileFormat";
            // 
            // btnNodeBrowseFilePath
            // 
            resources.ApplyResources(this.btnNodeBrowseFilePath, "btnNodeBrowseFilePath");
            this.btnNodeBrowseFilePath.Name = "btnNodeBrowseFilePath";
            this.btnNodeBrowseFilePath.UseVisualStyleBackColor = true;
            this.btnNodeBrowseFilePath.Click += new System.EventHandler(this.btnNodeBrowseFilePath_Click);
            // 
            // txtNodePath
            // 
            resources.ApplyResources(this.txtNodePath, "txtNodePath");
            this.txtNodePath.Name = "txtNodePath";
            this.txtNodePath.TextChanged += new System.EventHandler(this.fileProperties_Changed);
            // 
            // lblSavePath
            // 
            resources.ApplyResources(this.lblSavePath, "lblSavePath");
            this.lblSavePath.Name = "lblSavePath";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiMenu,
            this.vorlagenMenu,
            this.tabelleMenuStrip,
            this.makrosMenu,
            this.hilfeMenu});
            resources.ApplyResources(this.mainMenuStrip, "mainMenuStrip");
            this.mainMenuStrip.Name = "mainMenuStrip";
            // 
            // dateiMenu
            // 
            this.dateiMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOutputFile,
            this.showOutputLog,
            this.toolStripSeparator2,
            this.options,
            this.toolStripSeparator3,
            this.beenden});
            this.dateiMenu.Name = "dateiMenu";
            resources.ApplyResources(this.dateiMenu, "dateiMenu");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // vorlagenMenu
            // 
            this.vorlagenMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAll,
            this.toolStripSeparator8,
            this.vorlagenImport,
            this.vorlagenExport,
            this.toolStripSeparator1,
            this.docConvert,
            this.checkTemplate,
            this.createIfBlock,
            this.checkComplexVariable,
            this.toolStripSeparator7,
            this.vorlageVerwaltenToolStripMenuItem});
            this.vorlagenMenu.Name = "vorlagenMenu";
            resources.ApplyResources(this.vorlagenMenu, "vorlagenMenu");
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // tabelleMenuStrip
            // 
            this.tabelleMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelTableImport,
            this.fileTableImport,
            this.fileTableExport,
            this.toolStripSeparator4,
            this.spalteHinzu,
            this.spalteEntfernenToolStripMenuItem,
            this.clearTable,
            this.toolStripSeparator9,
            this.firstRowHeader});
            this.tabelleMenuStrip.Name = "tabelleMenuStrip";
            resources.ApplyResources(this.tabelleMenuStrip, "tabelleMenuStrip");
            this.tabelleMenuStrip.DropDownOpening += new System.EventHandler(this.tabelleMenuStrip_DropDownOpening);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            // 
            // makrosMenu
            // 
            this.makrosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupDefaultHeader,
            this.toolStripSeparator6,
            this.beispieleToolStripMenuItem});
            this.makrosMenu.Name = "makrosMenu";
            resources.ApplyResources(this.makrosMenu, "makrosMenu");
            // 
            // groupDefaultHeader
            // 
            this.groupDefaultHeader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headerOldFormat,
            this.headerNewFormat});
            this.groupDefaultHeader.Name = "groupDefaultHeader";
            resources.ApplyResources(this.groupDefaultHeader, "groupDefaultHeader");
            // 
            // headerOldFormat
            // 
            this.headerOldFormat.Name = "headerOldFormat";
            resources.ApplyResources(this.headerOldFormat, "headerOldFormat");
            this.headerOldFormat.Click += new System.EventHandler(this.loadHeaderFormat_Click);
            // 
            // headerNewFormat
            // 
            this.headerNewFormat.Name = "headerNewFormat";
            resources.ApplyResources(this.headerNewFormat, "headerNewFormat");
            this.headerNewFormat.Click += new System.EventHandler(this.loadHeaderFormat_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // hilfeMenu
            // 
            this.hilfeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openScriptingDoku,
            this.toolStripSeparator12,
            this.infoPageShow});
            this.hilfeMenu.Name = "hilfeMenu";
            resources.ApplyResources(this.hilfeMenu, "hilfeMenu");
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            resources.ApplyResources(this.toolStripSeparator12, "toolStripSeparator12");
            // 
            // cxmTextBox
            // 
            this.cxmTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTextCut,
            this.tsmTextCopy,
            this.tsmTextPaste,
            this.tsmTextMenuSeperator,
            this.tsmAddVariable});
            this.cxmTextBox.Name = "cxmTextBox";
            resources.ApplyResources(this.cxmTextBox, "cxmTextBox");
            this.cxmTextBox.Opening += new System.ComponentModel.CancelEventHandler(this.cxmTextBox_Opening);
            // 
            // tsmTextMenuSeperator
            // 
            this.tsmTextMenuSeperator.Name = "tsmTextMenuSeperator";
            resources.ApplyResources(this.tsmTextMenuSeperator, "tsmTextMenuSeperator");
            // 
            // tsmAddVariable
            // 
            this.tsmAddVariable.Name = "tsmAddVariable";
            resources.ApplyResources(this.tsmAddVariable, "tsmAddVariable");
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.splitContainer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.progressBar});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            resources.ApplyResources(this.statusLabel, "statusLabel");
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Step = 1;
            // 
            // tsmEditName
            // 
            this.tsmEditName.Image = global::Script_Builder.Resource1.textfield_rename;
            this.tsmEditName.Name = "tsmEditName";
            resources.ApplyResources(this.tsmEditName, "tsmEditName");
            this.tsmEditName.Click += new System.EventHandler(this.tsmEditName_Click);
            // 
            // tsmRemove
            // 
            this.tsmRemove.Image = global::Script_Builder.Resource1.cross;
            this.tsmRemove.Name = "tsmRemove";
            resources.ApplyResources(this.tsmRemove, "tsmRemove");
            this.tsmRemove.Click += new System.EventHandler(this.tsmRemove_Click);
            // 
            // tsmAddFile
            // 
            this.tsmAddFile.Image = global::Script_Builder.Resource1.new_templatefile;
            this.tsmAddFile.Name = "tsmAddFile";
            resources.ApplyResources(this.tsmAddFile, "tsmAddFile");
            this.tsmAddFile.Click += new System.EventHandler(this.tsmAddFile_Click);
            // 
            // tsmAddSerial
            // 
            this.tsmAddSerial.Image = global::Script_Builder.Resource1.new_templateserial;
            this.tsmAddSerial.Name = "tsmAddSerial";
            resources.ApplyResources(this.tsmAddSerial, "tsmAddSerial");
            this.tsmAddSerial.Click += new System.EventHandler(this.tsmAddSerial_Click);
            // 
            // tsmAddContent
            // 
            this.tsmAddContent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddSingle,
            this.tsmAddMultiple,
            this.tsmAddSerialBlock});
            this.tsmAddContent.Image = global::Script_Builder.Resource1.add_template;
            this.tsmAddContent.Name = "tsmAddContent";
            resources.ApplyResources(this.tsmAddContent, "tsmAddContent");
            // 
            // tsmAddSingle
            // 
            this.tsmAddSingle.Image = global::Script_Builder.Resource1.select_header;
            this.tsmAddSingle.Name = "tsmAddSingle";
            resources.ApplyResources(this.tsmAddSingle, "tsmAddSingle");
            this.tsmAddSingle.Click += new System.EventHandler(this.tsmAddSingle_Click);
            // 
            // tsmAddMultiple
            // 
            this.tsmAddMultiple.Image = global::Script_Builder.Resource1.select_body;
            this.tsmAddMultiple.Name = "tsmAddMultiple";
            resources.ApplyResources(this.tsmAddMultiple, "tsmAddMultiple");
            this.tsmAddMultiple.Click += new System.EventHandler(this.tsmAddMultiple_Click);
            // 
            // tsmAddSerialBlock
            // 
            this.tsmAddSerialBlock.Image = global::Script_Builder.Resource1.serial_header;
            this.tsmAddSerialBlock.Name = "tsmAddSerialBlock";
            resources.ApplyResources(this.tsmAddSerialBlock, "tsmAddSerialBlock");
            this.tsmAddSerialBlock.Click += new System.EventHandler(this.tsmAddSerialBlock_Click);
            // 
            // tsmChangeOrder
            // 
            this.tsmChangeOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOrderUp,
            this.tsmOrderDown});
            this.tsmChangeOrder.Image = global::Script_Builder.Resource1.arrows_updown;
            this.tsmChangeOrder.Name = "tsmChangeOrder";
            resources.ApplyResources(this.tsmChangeOrder, "tsmChangeOrder");
            // 
            // tsmOrderUp
            // 
            this.tsmOrderUp.Image = global::Script_Builder.Resource1.arrow_up2;
            this.tsmOrderUp.Name = "tsmOrderUp";
            resources.ApplyResources(this.tsmOrderUp, "tsmOrderUp");
            this.tsmOrderUp.Click += new System.EventHandler(this.tsmOrderUpDown_Click);
            // 
            // tsmOrderDown
            // 
            this.tsmOrderDown.Image = global::Script_Builder.Resource1.arrow_down2;
            this.tsmOrderDown.Name = "tsmOrderDown";
            resources.ApplyResources(this.tsmOrderDown, "tsmOrderDown");
            this.tsmOrderDown.Click += new System.EventHandler(this.tsmOrderUpDown_Click);
            // 
            // picErrorName
            // 
            resources.ApplyResources(this.picErrorName, "picErrorName");
            this.picErrorName.Image = global::Script_Builder.Resource1.error;
            this.picErrorName.Name = "picErrorName";
            this.picErrorName.TabStop = false;
            this.picErrorName.Click += new System.EventHandler(this.picErrorName_Click);
            // 
            // createOutputFile
            // 
            this.createOutputFile.Image = global::Script_Builder.Resource1.disk;
            resources.ApplyResources(this.createOutputFile, "createOutputFile");
            this.createOutputFile.Name = "createOutputFile";
            this.createOutputFile.Click += new System.EventHandler(this.createOutputFile_Click);
            // 
            // showOutputLog
            // 
            this.showOutputLog.Image = global::Script_Builder.Resource1.blog;
            this.showOutputLog.Name = "showOutputLog";
            resources.ApplyResources(this.showOutputLog, "showOutputLog");
            this.showOutputLog.Click += new System.EventHandler(this.showOutputLog_Click);
            // 
            // options
            // 
            this.options.Image = global::Script_Builder.Resource1.hammer_screwdriver;
            this.options.Name = "options";
            resources.ApplyResources(this.options, "options");
            this.options.Click += new System.EventHandler(this.options_Click);
            // 
            // beenden
            // 
            this.beenden.Image = global::Script_Builder.Resource1.door_in;
            this.beenden.Name = "beenden";
            resources.ApplyResources(this.beenden, "beenden");
            this.beenden.Click += new System.EventHandler(this.beenden_Click);
            // 
            // clearAll
            // 
            this.clearAll.Image = global::Script_Builder.Resource1.page;
            this.clearAll.Name = "clearAll";
            resources.ApplyResources(this.clearAll, "clearAll");
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // vorlagenImport
            // 
            this.vorlagenImport.Image = global::Script_Builder.Resource1.application_get;
            this.vorlagenImport.Name = "vorlagenImport";
            resources.ApplyResources(this.vorlagenImport, "vorlagenImport");
            this.vorlagenImport.Click += new System.EventHandler(this.vorlagenImport_Click);
            // 
            // vorlagenExport
            // 
            this.vorlagenExport.Image = global::Script_Builder.Resource1.application_put;
            this.vorlagenExport.Name = "vorlagenExport";
            resources.ApplyResources(this.vorlagenExport, "vorlagenExport");
            this.vorlagenExport.Click += new System.EventHandler(this.vorlagenExport_Click);
            // 
            // docConvert
            // 
            resources.ApplyResources(this.docConvert, "docConvert");
            this.docConvert.Image = global::Script_Builder.Resource1.doc_convert;
            this.docConvert.Name = "docConvert";
            this.docConvert.Click += new System.EventHandler(this.docConvert_Click);
            // 
            // checkTemplate
            // 
            this.checkTemplate.CheckOnClick = true;
            this.checkTemplate.Image = global::Script_Builder.Resource1.check_template_off;
            this.checkTemplate.Name = "checkTemplate";
            resources.ApplyResources(this.checkTemplate, "checkTemplate");
            this.checkTemplate.CheckedChanged += new System.EventHandler(this.checkTemplate_CheckedChanged);
            // 
            // createIfBlock
            // 
            this.createIfBlock.Image = global::Script_Builder.Resource1.tag_if;
            this.createIfBlock.Name = "createIfBlock";
            resources.ApplyResources(this.createIfBlock, "createIfBlock");
            this.createIfBlock.Click += new System.EventHandler(this.createIfBlock_Click);
            // 
            // checkComplexVariable
            // 
            this.checkComplexVariable.Image = global::Script_Builder.Resource1.check_complex_variable;
            this.checkComplexVariable.Name = "checkComplexVariable";
            resources.ApplyResources(this.checkComplexVariable, "checkComplexVariable");
            this.checkComplexVariable.Click += new System.EventHandler(this.checkComplexVariable_Click);
            // 
            // excelTableImport
            // 
            this.excelTableImport.Image = global::Script_Builder.Resource1.doc_excel_table;
            this.excelTableImport.Name = "excelTableImport";
            resources.ApplyResources(this.excelTableImport, "excelTableImport");
            this.excelTableImport.Click += new System.EventHandler(this.excelTableImport_Click);
            // 
            // fileTableImport
            // 
            this.fileTableImport.Image = global::Script_Builder.Resource1.table_import;
            this.fileTableImport.Name = "fileTableImport";
            resources.ApplyResources(this.fileTableImport, "fileTableImport");
            this.fileTableImport.Click += new System.EventHandler(this.fileTableImport_Click);
            // 
            // fileTableExport
            // 
            this.fileTableExport.Image = global::Script_Builder.Resource1.table_export;
            this.fileTableExport.Name = "fileTableExport";
            resources.ApplyResources(this.fileTableExport, "fileTableExport");
            this.fileTableExport.Click += new System.EventHandler(this.fileTableExport_Click);
            // 
            // spalteHinzu
            // 
            this.spalteHinzu.Image = global::Script_Builder.Resource1.add;
            this.spalteHinzu.Name = "spalteHinzu";
            resources.ApplyResources(this.spalteHinzu, "spalteHinzu");
            this.spalteHinzu.Click += new System.EventHandler(this.spalteHinzuToolStripMenuItem_Click);
            // 
            // spalteEntfernenToolStripMenuItem
            // 
            this.spalteEntfernenToolStripMenuItem.Image = global::Script_Builder.Resource1.minus;
            this.spalteEntfernenToolStripMenuItem.Name = "spalteEntfernenToolStripMenuItem";
            resources.ApplyResources(this.spalteEntfernenToolStripMenuItem, "spalteEntfernenToolStripMenuItem");
            // 
            // clearTable
            // 
            this.clearTable.Image = global::Script_Builder.Resource1.cross;
            this.clearTable.Name = "clearTable";
            resources.ApplyResources(this.clearTable, "clearTable");
            this.clearTable.Click += new System.EventHandler(this.clearTable_Click);
            // 
            // firstRowHeader
            // 
            this.firstRowHeader.Image = global::Script_Builder.Resource1.useFirstRow;
            this.firstRowHeader.Name = "firstRowHeader";
            resources.ApplyResources(this.firstRowHeader, "firstRowHeader");
            this.firstRowHeader.Click += new System.EventHandler(this.firstRowHeader_Click);
            // 
            // openScriptingDoku
            // 
            this.openScriptingDoku.Image = global::Script_Builder.Resource1.Actions_help_contents_icon;
            this.openScriptingDoku.Name = "openScriptingDoku";
            resources.ApplyResources(this.openScriptingDoku, "openScriptingDoku");
            this.openScriptingDoku.Click += new System.EventHandler(this.openScriptingDoku_Click);
            // 
            // infoPageShow
            // 
            this.infoPageShow.Image = global::Script_Builder.Resource1.exclamation;
            this.infoPageShow.Name = "infoPageShow";
            resources.ApplyResources(this.infoPageShow, "infoPageShow");
            this.infoPageShow.Click += new System.EventHandler(this.infoPageShow_Click);
            // 
            // tsmTextCut
            // 
            this.tsmTextCut.Image = global::Script_Builder.Resource1.cut;
            this.tsmTextCut.Name = "tsmTextCut";
            resources.ApplyResources(this.tsmTextCut, "tsmTextCut");
            this.tsmTextCut.Click += new System.EventHandler(this.tsmTextCutCopy_Click);
            // 
            // tsmTextCopy
            // 
            this.tsmTextCopy.Image = global::Script_Builder.Resource1.page_copy;
            this.tsmTextCopy.Name = "tsmTextCopy";
            resources.ApplyResources(this.tsmTextCopy, "tsmTextCopy");
            this.tsmTextCopy.Click += new System.EventHandler(this.tsmTextCutCopy_Click);
            // 
            // tsmTextPaste
            // 
            this.tsmTextPaste.Image = global::Script_Builder.Resource1.paste;
            this.tsmTextPaste.Name = "tsmTextPaste";
            resources.ApplyResources(this.tsmTextPaste, "tsmTextPaste");
            this.tsmTextPaste.Click += new System.EventHandler(this.tsmTextPaste_Click);
            // 
            // beispieleToolStripMenuItem
            // 
            this.beispieleToolStripMenuItem.Name = "beispieleToolStripMenuItem";
            resources.ApplyResources(this.beispieleToolStripMenuItem, "beispieleToolStripMenuItem");
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mainMenuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "mainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrExcelContents)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cxmVorlageSelect.ResumeLayout(false);
            this.pnlFileProperties.ResumeLayout(false);
            this.pnlFileProperties.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.cxmTextBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem dateiMenu;
        private System.Windows.Forms.ToolStripMenuItem tabelleMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem makrosMenu;
        private System.Windows.Forms.ToolStripMenuItem hilfeMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem createOutputFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem options;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem beenden;
        private System.Windows.Forms.ToolStripMenuItem excelTableImport;
        private System.Windows.Forms.ToolStripMenuItem groupDefaultHeader;
        private System.Windows.Forms.ToolStripMenuItem headerOldFormat;
        private System.Windows.Forms.ToolStripMenuItem headerNewFormat;
        private System.Windows.Forms.ToolStripMenuItem openScriptingDoku;
        private System.Windows.Forms.ToolStripMenuItem infoPageShow;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dgrExcelContents;
        private System.Windows.Forms.ToolStripMenuItem spalteHinzu;
        private System.Windows.Forms.ToolStripMenuItem clearTable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem fileTableImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripMenuItem clearAll;
        private System.Windows.Forms.ToolStripMenuItem docConvert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem firstRowHeader;
        private System.Windows.Forms.ToolStripMenuItem vorlagenMenu;
        private System.Windows.Forms.ToolStripMenuItem vorlagenExport;
        private System.Windows.Forms.ToolStripMenuItem vorlagenImport;
        private System.Windows.Forms.ToolStripMenuItem fileTableExport;
        private System.Windows.Forms.ToolStripMenuItem checkTemplate;
        private System.Windows.Forms.ToolStripMenuItem createIfBlock;
        private System.Windows.Forms.ToolStripMenuItem checkComplexVariable;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trvVorlageSelect;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip cxmVorlageSelect;
        private System.Windows.Forms.ToolStripMenuItem tsmEditName;
        private System.Windows.Forms.ToolStripMenuItem tsmRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem tsmAddFile;
        private System.Windows.Forms.ToolStripMenuItem tsmAddContent;
        private System.Windows.Forms.ToolStripMenuItem tsmAddSingle;
        private System.Windows.Forms.ToolStripMenuItem tsmAddMultiple;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem tsmChangeOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmOrderUp;
        private System.Windows.Forms.ToolStripMenuItem tsmOrderDown;
        private System.Windows.Forms.Panel pnlFileProperties;
        private System.Windows.Forms.ComboBox cboNodeFileFormat;
        private System.Windows.Forms.Label lblFileFormat;
        private System.Windows.Forms.Button btnNodeBrowseFilePath;
        private System.Windows.Forms.TextBox txtNodePath;
        private System.Windows.Forms.Label lblSavePath;
        private System.Windows.Forms.TextBox txtNodeName;
        private System.Windows.Forms.Label lblNodeName;
        private System.Windows.Forms.Button btnNodeCancel;
        private System.Windows.Forms.Button btnNodeChange;
        private System.Windows.Forms.ToolStripMenuItem showOutputLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem vorlageVerwaltenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cxmTextBox;
        private System.Windows.Forms.ToolStripMenuItem tsmTextCut;
        private System.Windows.Forms.ToolStripMenuItem tsmTextCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmTextPaste;
        private System.Windows.Forms.ToolStripSeparator tsmTextMenuSeperator;
        private System.Windows.Forms.ToolStripMenuItem tsmAddVariable;
        private System.Windows.Forms.ToolStripMenuItem tsmAddSerial;
        private System.Windows.Forms.Button btnSerialWizard;
        private System.Windows.Forms.ToolStripMenuItem tsmAddSerialBlock;
        private System.Windows.Forms.PictureBox picErrorName;
        private System.Windows.Forms.ToolStripMenuItem spalteEntfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem beispieleToolStripMenuItem;
    }
}


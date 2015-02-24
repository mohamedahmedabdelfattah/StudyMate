namespace StudyMate
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.tabOthers = new System.Windows.Forms.TabPage();
            this.groupUpload = new System.Windows.Forms.GroupBox();
            this.txtOtherName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtOtherAuthor = new System.Windows.Forms.TextBox();
            this.txtOtherLink = new System.Windows.Forms.TextBox();
            this.lblOtherName = new System.Windows.Forms.Label();
            this.txtOtherComment = new System.Windows.Forms.TextBox();
            this.btnOtherCategoryOther = new System.Windows.Forms.RadioButton();
            this.lblOtherAuthor = new System.Windows.Forms.Label();
            this.btnOtherCategoryExtra = new System.Windows.Forms.RadioButton();
            this.lblOtherLink = new System.Windows.Forms.Label();
            this.btnOtherCategoryLab = new System.Windows.Forms.RadioButton();
            this.lblOtherComment = new System.Windows.Forms.Label();
            this.btnOtherCategoryLec = new System.Windows.Forms.RadioButton();
            this.lblOtherCategory = new System.Windows.Forms.Label();
            this.groupDownload = new System.Windows.Forms.GroupBox();
            this.DataViewer = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studyMateDS = new StudyMate.StudyMateDS();
            this.btnOpenLink = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnCopyLink = new System.Windows.Forms.Button();
            this.tabUpdates = new System.Windows.Forms.TabPage();
            this.UpdateProgress = new System.Windows.Forms.ProgressBar();
            this.UpdatesViewer = new System.Windows.Forms.DataGridView();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.btnDownload = new System.Windows.Forms.Button();
            this.groupLec = new System.Windows.Forms.GroupBox();
            this.lblExtras = new System.Windows.Forms.Label();
            this.lblLabs = new System.Windows.Forms.Label();
            this.lblLectures = new System.Windows.Forms.Label();
            this.btnSelectAll = new System.Windows.Forms.CheckBox();
            this.Extra4 = new System.Windows.Forms.CheckBox();
            this.Sub5Lab = new System.Windows.Forms.CheckBox();
            this.Extra3 = new System.Windows.Forms.CheckBox();
            this.Sub5Lec = new System.Windows.Forms.CheckBox();
            this.Extra2 = new System.Windows.Forms.CheckBox();
            this.Sub4Lab = new System.Windows.Forms.CheckBox();
            this.Extra1 = new System.Windows.Forms.CheckBox();
            this.Sub4Lec = new System.Windows.Forms.CheckBox();
            this.Sub3Lab = new System.Windows.Forms.CheckBox();
            this.Sub3Lec = new System.Windows.Forms.CheckBox();
            this.Sub2Lab = new System.Windows.Forms.CheckBox();
            this.Sub2Lec = new System.Windows.Forms.CheckBox();
            this.Sub1Lab = new System.Windows.Forms.CheckBox();
            this.Sub1Lec = new System.Windows.Forms.CheckBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabAdminPanel = new System.Windows.Forms.TabPage();
            this.btnCloseAdminPanel = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnEditPassword = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.StudyMateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArabicLanguageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EnglishLanguageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToTrayMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MinimizeToTrayMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StartWithWindowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AlwaysShowTrayIconMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoUpdateCheckMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultOptionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.WebsiteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ContentsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangelogMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ReportABugMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckForUpdatesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutStudyMateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenStudyMateContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckForContentUpdatesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.bgAutoUpdateCheck = new System.ComponentModel.BackgroundWorker();
            this.bgAdvisor = new System.ComponentModel.BackgroundWorker();
            this.dataListTableAdapter = new StudyMate.StudyMateDSTableAdapters.DataListTableAdapter();
            this.tabOthers.SuspendLayout();
            this.groupUpload.SuspendLayout();
            this.groupDownload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyMateDS)).BeginInit();
            this.tabUpdates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatesViewer)).BeginInit();
            this.tabGeneral.SuspendLayout();
            this.groupLec.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabAdminPanel.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.TrayIconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOthers
            // 
            this.tabOthers.BackColor = System.Drawing.Color.Transparent;
            this.tabOthers.Controls.Add(this.groupUpload);
            this.tabOthers.Controls.Add(this.groupDownload);
            this.tabOthers.Location = new System.Drawing.Point(4, 26);
            this.tabOthers.Name = "tabOthers";
            this.tabOthers.Padding = new System.Windows.Forms.Padding(3);
            this.tabOthers.Size = new System.Drawing.Size(583, 393);
            this.tabOthers.TabIndex = 5;
            this.tabOthers.Text = "Others";
            this.tabOthers.UseVisualStyleBackColor = true;
            this.tabOthers.Enter += new System.EventHandler(this.Others_Enter);
            // 
            // groupUpload
            // 
            this.groupUpload.Controls.Add(this.txtOtherName);
            this.groupUpload.Controls.Add(this.btnAdd);
            this.groupUpload.Controls.Add(this.btnClear);
            this.groupUpload.Controls.Add(this.txtOtherAuthor);
            this.groupUpload.Controls.Add(this.txtOtherLink);
            this.groupUpload.Controls.Add(this.lblOtherName);
            this.groupUpload.Controls.Add(this.txtOtherComment);
            this.groupUpload.Controls.Add(this.btnOtherCategoryOther);
            this.groupUpload.Controls.Add(this.lblOtherAuthor);
            this.groupUpload.Controls.Add(this.btnOtherCategoryExtra);
            this.groupUpload.Controls.Add(this.lblOtherLink);
            this.groupUpload.Controls.Add(this.btnOtherCategoryLab);
            this.groupUpload.Controls.Add(this.lblOtherComment);
            this.groupUpload.Controls.Add(this.btnOtherCategoryLec);
            this.groupUpload.Controls.Add(this.lblOtherCategory);
            this.groupUpload.Location = new System.Drawing.Point(8, 6);
            this.groupUpload.Name = "groupUpload";
            this.groupUpload.Size = new System.Drawing.Size(566, 197);
            this.groupUpload.TabIndex = 41;
            this.groupUpload.TabStop = false;
            this.groupUpload.Text = "Upload";
            // 
            // txtOtherName
            // 
            this.txtOtherName.Location = new System.Drawing.Point(113, 17);
            this.txtOtherName.Name = "txtOtherName";
            this.txtOtherName.Size = new System.Drawing.Size(322, 25);
            this.txtOtherName.TabIndex = 38;
            this.txtOtherName.TextChanged += new System.EventHandler(this.txtOtherName_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("BatmanForeverAlternate", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Orange;
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(451, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 25);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("BatmanForeverAlternate", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnClear.ForeColor = System.Drawing.Color.Orange;
            this.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClear.Location = new System.Drawing.Point(451, 109);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 25);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClearOthersData_Click);
            // 
            // txtOtherAuthor
            // 
            this.txtOtherAuthor.Location = new System.Drawing.Point(113, 47);
            this.txtOtherAuthor.Name = "txtOtherAuthor";
            this.txtOtherAuthor.Size = new System.Drawing.Size(322, 25);
            this.txtOtherAuthor.TabIndex = 26;
            // 
            // txtOtherLink
            // 
            this.txtOtherLink.Location = new System.Drawing.Point(112, 103);
            this.txtOtherLink.Name = "txtOtherLink";
            this.txtOtherLink.Size = new System.Drawing.Size(323, 25);
            this.txtOtherLink.TabIndex = 27;
            this.txtOtherLink.Text = "http://";
            this.txtOtherLink.TextChanged += new System.EventHandler(this.txtOtherLink_TextChanged);
            // 
            // lblOtherName
            // 
            this.lblOtherName.AutoSize = true;
            this.lblOtherName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOtherName.Location = new System.Drawing.Point(34, 20);
            this.lblOtherName.Name = "lblOtherName";
            this.lblOtherName.Size = new System.Drawing.Size(52, 17);
            this.lblOtherName.TabIndex = 37;
            this.lblOtherName.Text = "Name *";
            // 
            // txtOtherComment
            // 
            this.txtOtherComment.Location = new System.Drawing.Point(113, 133);
            this.txtOtherComment.Multiline = true;
            this.txtOtherComment.Name = "txtOtherComment";
            this.txtOtherComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOtherComment.Size = new System.Drawing.Size(322, 54);
            this.txtOtherComment.TabIndex = 28;
            // 
            // btnOtherCategoryOther
            // 
            this.btnOtherCategoryOther.AutoSize = true;
            this.btnOtherCategoryOther.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOtherCategoryOther.Location = new System.Drawing.Point(376, 75);
            this.btnOtherCategoryOther.Name = "btnOtherCategoryOther";
            this.btnOtherCategoryOther.Size = new System.Drawing.Size(59, 21);
            this.btnOtherCategoryOther.TabIndex = 36;
            this.btnOtherCategoryOther.TabStop = true;
            this.btnOtherCategoryOther.Text = "Other";
            this.btnOtherCategoryOther.UseVisualStyleBackColor = true;
            this.btnOtherCategoryOther.CheckedChanged += new System.EventHandler(this.SetOthersCategory);
            // 
            // lblOtherAuthor
            // 
            this.lblOtherAuthor.AutoSize = true;
            this.lblOtherAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOtherAuthor.Location = new System.Drawing.Point(34, 49);
            this.lblOtherAuthor.Name = "lblOtherAuthor";
            this.lblOtherAuthor.Size = new System.Drawing.Size(47, 17);
            this.lblOtherAuthor.TabIndex = 29;
            this.lblOtherAuthor.Text = "Author";
            // 
            // btnOtherCategoryExtra
            // 
            this.btnOtherCategoryExtra.AutoSize = true;
            this.btnOtherCategoryExtra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOtherCategoryExtra.Location = new System.Drawing.Point(290, 77);
            this.btnOtherCategoryExtra.Name = "btnOtherCategoryExtra";
            this.btnOtherCategoryExtra.Size = new System.Drawing.Size(55, 21);
            this.btnOtherCategoryExtra.TabIndex = 35;
            this.btnOtherCategoryExtra.TabStop = true;
            this.btnOtherCategoryExtra.Text = "Extra";
            this.btnOtherCategoryExtra.UseVisualStyleBackColor = true;
            this.btnOtherCategoryExtra.CheckedChanged += new System.EventHandler(this.SetOthersCategory);
            // 
            // lblOtherLink
            // 
            this.lblOtherLink.AutoSize = true;
            this.lblOtherLink.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOtherLink.Location = new System.Drawing.Point(34, 107);
            this.lblOtherLink.Name = "lblOtherLink";
            this.lblOtherLink.Size = new System.Drawing.Size(39, 17);
            this.lblOtherLink.TabIndex = 30;
            this.lblOtherLink.Text = "Link *";
            // 
            // btnOtherCategoryLab
            // 
            this.btnOtherCategoryLab.AutoSize = true;
            this.btnOtherCategoryLab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOtherCategoryLab.Location = new System.Drawing.Point(212, 77);
            this.btnOtherCategoryLab.Name = "btnOtherCategoryLab";
            this.btnOtherCategoryLab.Size = new System.Drawing.Size(47, 21);
            this.btnOtherCategoryLab.TabIndex = 34;
            this.btnOtherCategoryLab.TabStop = true;
            this.btnOtherCategoryLab.Text = "Lab";
            this.btnOtherCategoryLab.UseVisualStyleBackColor = true;
            this.btnOtherCategoryLab.CheckedChanged += new System.EventHandler(this.SetOthersCategory);
            // 
            // lblOtherComment
            // 
            this.lblOtherComment.AutoSize = true;
            this.lblOtherComment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOtherComment.Location = new System.Drawing.Point(34, 136);
            this.lblOtherComment.Name = "lblOtherComment";
            this.lblOtherComment.Size = new System.Drawing.Size(64, 17);
            this.lblOtherComment.TabIndex = 31;
            this.lblOtherComment.Text = "Comment";
            // 
            // btnOtherCategoryLec
            // 
            this.btnOtherCategoryLec.AutoSize = true;
            this.btnOtherCategoryLec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOtherCategoryLec.Location = new System.Drawing.Point(113, 77);
            this.btnOtherCategoryLec.Name = "btnOtherCategoryLec";
            this.btnOtherCategoryLec.Size = new System.Drawing.Size(68, 21);
            this.btnOtherCategoryLec.TabIndex = 33;
            this.btnOtherCategoryLec.TabStop = true;
            this.btnOtherCategoryLec.Text = "Lecture";
            this.btnOtherCategoryLec.UseVisualStyleBackColor = true;
            this.btnOtherCategoryLec.CheckedChanged += new System.EventHandler(this.SetOthersCategory);
            // 
            // lblOtherCategory
            // 
            this.lblOtherCategory.AutoSize = true;
            this.lblOtherCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOtherCategory.Location = new System.Drawing.Point(34, 78);
            this.lblOtherCategory.Name = "lblOtherCategory";
            this.lblOtherCategory.Size = new System.Drawing.Size(70, 17);
            this.lblOtherCategory.TabIndex = 32;
            this.lblOtherCategory.Text = "Category *";
            // 
            // groupDownload
            // 
            this.groupDownload.Controls.Add(this.DataViewer);
            this.groupDownload.Controls.Add(this.btnOpenLink);
            this.groupDownload.Controls.Add(this.btnGet);
            this.groupDownload.Controls.Add(this.btnCopyLink);
            this.groupDownload.Location = new System.Drawing.Point(8, 202);
            this.groupDownload.Name = "groupDownload";
            this.groupDownload.Size = new System.Drawing.Size(566, 184);
            this.groupDownload.TabIndex = 42;
            this.groupDownload.TabStop = false;
            this.groupDownload.Text = "Download";
            // 
            // DataViewer
            // 
            this.DataViewer.AllowUserToAddRows = false;
            this.DataViewer.AllowUserToDeleteRows = false;
            this.DataViewer.AllowUserToResizeRows = false;
            this.DataViewer.AutoGenerateColumns = false;
            this.DataViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataViewer.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.linkDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.DataViewer.DataSource = this.dataListBindingSource;
            this.DataViewer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataViewer.GridColor = System.Drawing.SystemColors.Control;
            this.DataViewer.Location = new System.Drawing.Point(42, 18);
            this.DataViewer.MultiSelect = false;
            this.DataViewer.Name = "DataViewer";
            this.DataViewer.ReadOnly = true;
            this.DataViewer.RowHeadersVisible = false;
            this.DataViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataViewer.ShowCellErrors = false;
            this.DataViewer.ShowCellToolTips = false;
            this.DataViewer.ShowEditingIcon = false;
            this.DataViewer.ShowRowErrors = false;
            this.DataViewer.Size = new System.Drawing.Size(388, 158);
            this.DataViewer.TabIndex = 10;
            this.DataViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewer_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 72;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 90;
            // 
            // linkDataGridViewTextBoxColumn
            // 
            this.linkDataGridViewTextBoxColumn.DataPropertyName = "Link";
            this.linkDataGridViewTextBoxColumn.HeaderText = "Link";
            this.linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
            this.linkDataGridViewTextBoxColumn.ReadOnly = true;
            this.linkDataGridViewTextBoxColumn.Width = 59;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorDataGridViewTextBoxColumn.Width = 76;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Width = 93;
            // 
            // dataListBindingSource
            // 
            this.dataListBindingSource.DataMember = "DataList";
            this.dataListBindingSource.DataSource = this.studyMateDS;
            // 
            // studyMateDS
            // 
            this.studyMateDS.DataSetName = "StudyMateDS";
            this.studyMateDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOpenLink
            // 
            this.btnOpenLink.Font = new System.Drawing.Font("BatmanForeverAlternate", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnOpenLink.ForeColor = System.Drawing.Color.Orange;
            this.btnOpenLink.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpenLink.Location = new System.Drawing.Point(446, 124);
            this.btnOpenLink.Name = "btnOpenLink";
            this.btnOpenLink.Size = new System.Drawing.Size(87, 25);
            this.btnOpenLink.TabIndex = 12;
            this.btnOpenLink.Text = "Open";
            this.btnOpenLink.UseVisualStyleBackColor = true;
            this.btnOpenLink.Click += new System.EventHandler(this.btnOpenOther_Click);
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("BatmanForeverAlternate", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGet.ForeColor = System.Drawing.Color.Orange;
            this.btnGet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGet.Location = new System.Drawing.Point(446, 46);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(87, 25);
            this.btnGet.TabIndex = 7;
            this.btnGet.Text = "Search";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnCopyLink
            // 
            this.btnCopyLink.Font = new System.Drawing.Font("BatmanForeverAlternate", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCopyLink.ForeColor = System.Drawing.Color.Orange;
            this.btnCopyLink.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCopyLink.Location = new System.Drawing.Point(446, 85);
            this.btnCopyLink.Name = "btnCopyLink";
            this.btnCopyLink.Size = new System.Drawing.Size(87, 25);
            this.btnCopyLink.TabIndex = 11;
            this.btnCopyLink.Text = "Copy";
            this.btnCopyLink.UseVisualStyleBackColor = true;
            this.btnCopyLink.Click += new System.EventHandler(this.btnCopyOther_Click);
            // 
            // tabUpdates
            // 
            this.tabUpdates.BackColor = System.Drawing.Color.Transparent;
            this.tabUpdates.Controls.Add(this.UpdateProgress);
            this.tabUpdates.Controls.Add(this.UpdatesViewer);
            this.tabUpdates.Location = new System.Drawing.Point(4, 26);
            this.tabUpdates.Name = "tabUpdates";
            this.tabUpdates.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdates.Size = new System.Drawing.Size(583, 393);
            this.tabUpdates.TabIndex = 1;
            this.tabUpdates.Text = "Advisor";
            this.tabUpdates.UseVisualStyleBackColor = true;
            this.tabUpdates.Enter += new System.EventHandler(this.tabUpdates_Enter);
            // 
            // UpdateProgress
            // 
            this.UpdateProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UpdateProgress.Location = new System.Drawing.Point(75, 185);
            this.UpdateProgress.MarqueeAnimationSpeed = 10;
            this.UpdateProgress.Name = "UpdateProgress";
            this.UpdateProgress.Size = new System.Drawing.Size(432, 22);
            this.UpdateProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.UpdateProgress.TabIndex = 1;
            // 
            // UpdatesViewer
            // 
            this.UpdatesViewer.AllowUserToAddRows = false;
            this.UpdatesViewer.AllowUserToDeleteRows = false;
            this.UpdatesViewer.AllowUserToResizeRows = false;
            this.UpdatesViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.UpdatesViewer.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.UpdatesViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpdatesViewer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UpdatesViewer.GridColor = System.Drawing.SystemColors.Control;
            this.UpdatesViewer.Location = new System.Drawing.Point(97, 117);
            this.UpdatesViewer.MultiSelect = false;
            this.UpdatesViewer.Name = "UpdatesViewer";
            this.UpdatesViewer.ReadOnly = true;
            this.UpdatesViewer.RowHeadersVisible = false;
            this.UpdatesViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.UpdatesViewer.ShowCellErrors = false;
            this.UpdatesViewer.ShowCellToolTips = false;
            this.UpdatesViewer.ShowEditingIcon = false;
            this.UpdatesViewer.ShowRowErrors = false;
            this.UpdatesViewer.Size = new System.Drawing.Size(388, 158);
            this.UpdatesViewer.TabIndex = 11;
            this.UpdatesViewer.Visible = false;
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.Color.Transparent;
            this.tabGeneral.Controls.Add(this.btnDownload);
            this.tabGeneral.Controls.Add(this.groupLec);
            this.tabGeneral.Location = new System.Drawing.Point(4, 26);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(583, 393);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            this.tabGeneral.Enter += new System.EventHandler(this.tabGeneral_Enter);
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("BatmanForeverAlternate", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.Orange;
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDownload.Location = new System.Drawing.Point(190, 273);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(203, 40);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = " Download";
            this.btnDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // groupLec
            // 
            this.groupLec.Controls.Add(this.lblExtras);
            this.groupLec.Controls.Add(this.lblLabs);
            this.groupLec.Controls.Add(this.lblLectures);
            this.groupLec.Controls.Add(this.btnSelectAll);
            this.groupLec.Controls.Add(this.Extra4);
            this.groupLec.Controls.Add(this.Sub5Lab);
            this.groupLec.Controls.Add(this.Extra3);
            this.groupLec.Controls.Add(this.Sub5Lec);
            this.groupLec.Controls.Add(this.Extra2);
            this.groupLec.Controls.Add(this.Sub4Lab);
            this.groupLec.Controls.Add(this.Extra1);
            this.groupLec.Controls.Add(this.Sub4Lec);
            this.groupLec.Controls.Add(this.Sub3Lab);
            this.groupLec.Controls.Add(this.Sub3Lec);
            this.groupLec.Controls.Add(this.Sub2Lab);
            this.groupLec.Controls.Add(this.Sub2Lec);
            this.groupLec.Controls.Add(this.Sub1Lab);
            this.groupLec.Controls.Add(this.Sub1Lec);
            this.groupLec.Location = new System.Drawing.Point(47, 79);
            this.groupLec.Name = "groupLec";
            this.groupLec.Size = new System.Drawing.Size(488, 188);
            this.groupLec.TabIndex = 4;
            this.groupLec.TabStop = false;
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtras.ForeColor = System.Drawing.Color.Gray;
            this.lblExtras.Location = new System.Drawing.Point(34, 125);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(46, 17);
            this.lblExtras.TabIndex = 12;
            this.lblExtras.Text = "Extras";
            // 
            // lblLabs
            // 
            this.lblLabs.AutoSize = true;
            this.lblLabs.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabs.ForeColor = System.Drawing.Color.Gray;
            this.lblLabs.Location = new System.Drawing.Point(34, 74);
            this.lblLabs.Name = "lblLabs";
            this.lblLabs.Size = new System.Drawing.Size(37, 17);
            this.lblLabs.TabIndex = 11;
            this.lblLabs.Text = "Labs";
            // 
            // lblLectures
            // 
            this.lblLectures.AutoSize = true;
            this.lblLectures.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectures.ForeColor = System.Drawing.Color.Gray;
            this.lblLectures.Location = new System.Drawing.Point(34, 23);
            this.lblLectures.Name = "lblLectures";
            this.lblLectures.Size = new System.Drawing.Size(59, 17);
            this.lblLectures.TabIndex = 10;
            this.lblLectures.Text = "Lectures";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.AutoSize = true;
            this.btnSelectAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelectAll.Location = new System.Drawing.Point(403, 161);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(79, 21);
            this.btnSelectAll.TabIndex = 9;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.CheckedChanged += new System.EventHandler(this.btnSelectAll_CheckedChanged);
            // 
            // Extra4
            // 
            this.Extra4.AutoSize = true;
            this.Extra4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Extra4.Location = new System.Drawing.Point(297, 145);
            this.Extra4.Name = "Extra4";
            this.Extra4.Size = new System.Drawing.Size(63, 21);
            this.Extra4.TabIndex = 8;
            this.Extra4.Text = "Extra4";
            this.Extra4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Extra4.UseVisualStyleBackColor = true;
            this.Extra4.CheckedChanged += new System.EventHandler(this.Downloads_CheckedChanged);
            // 
            // Sub5Lab
            // 
            this.Sub5Lab.AutoSize = true;
            this.Sub5Lab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sub5Lab.Location = new System.Drawing.Point(379, 94);
            this.Sub5Lab.Name = "Sub5Lab";
            this.Sub5Lab.Size = new System.Drawing.Size(76, 21);
            this.Sub5Lab.TabIndex = 4;
            this.Sub5Lab.Text = "Subject5";
            this.Sub5Lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sub5Lab.UseVisualStyleBackColor = true;
            this.Sub5Lab.CheckedChanged += new System.EventHandler(this.Downloads_CheckedChanged);
            // 
            // Extra3
            // 
            this.Extra3.AutoSize = true;
            this.Extra3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Extra3.Location = new System.Drawing.Point(215, 145);
            this.Extra3.Name = "Extra3";
            this.Extra3.Size = new System.Drawing.Size(63, 21);
            this.Extra3.TabIndex = 7;
            this.Extra3.Text = "Extra3";
            this.Extra3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Extra3.UseVisualStyleBackColor = true;
            this.Extra3.CheckedChanged += new System.EventHandler(this.Downloads_CheckedChanged);
            // 
            // Sub5Lec
            // 
            this.Sub5Lec.AutoSize = true;
            this.Sub5Lec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sub5Lec.Location = new System.Drawing.Point(379, 43);
            this.Sub5Lec.Name = "Sub5Lec";
            this.Sub5Lec.Size = new System.Drawing.Size(76, 21);
            this.Sub5Lec.TabIndex = 4;
            this.Sub5Lec.Text = "Subject5";
            this.Sub5Lec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sub5Lec.UseVisualStyleBackColor = true;
            this.Sub5Lec.CheckedChanged += new System.EventHandler(this.Downloads_CheckedChanged);
            // 
            // Extra2
            // 
            this.Extra2.AutoSize = true;
            this.Extra2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Extra2.Location = new System.Drawing.Point(133, 145);
            this.Extra2.Name = "Extra2";
            this.Extra2.Size = new System.Drawing.Size(63, 21);
            this.Extra2.TabIndex = 6;
            this.Extra2.Text = "Extra2";
            this.Extra2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Extra2.UseVisualStyleBackColor = true;
            this.Extra2.CheckedChanged += new System.EventHandler(this.Downloads_CheckedChanged);
            // 
            // Sub4Lab
            // 
            this.Sub4Lab.AutoSize = true;
            this.Sub4Lab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sub4Lab.Location = new System.Drawing.Point(297, 94);
            this.Sub4Lab.Name = "Sub4Lab";
            this.Sub4Lab.Size = new System.Drawing.Size(76, 21);
            this.Sub4Lab.TabIndex = 3;
            this.Sub4Lab.Text = "Subject4";
            this.Sub4Lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sub4Lab.UseVisualStyleBackColor = true;
            this.Sub4Lab.CheckedChanged += new System.EventHandler(this.Downloads_CheckedChanged);
            // 
            // Extra1
            // 
            this.Extra1.AutoSize = true;
            this.Extra1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Extra1.Location = new System.Drawing.Point(51, 145);
            this.Extra1.Name = "Extra1";
            this.Extra1.Size = new System.Drawing.Size(63, 21);
            this.Extra1.TabIndex = 5;
            this.Extra1.Text = "Extra1";
            this.Extra1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Extra1.UseVisualStyleBackColor = true;
            this.Extra1.CheckedChanged += new System.EventHandler(this.Downloads_CheckedChanged);
            // 
            // Sub4Lec
            // 
            this.Sub4Lec.AutoSize = true;
            this.Sub4Lec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sub4Lec.Location = new System.Drawing.Point(297, 43);
            this.Sub4Lec.Name = "Sub4Lec";
            this.Sub4Lec.Size = new System.Drawing.Size(76, 21);
            this.Sub4Lec.TabIndex = 3;
            this.Sub4Lec.Text = "Subject4";
            this.Sub4Lec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sub4Lec.UseVisualStyleBackColor = true;
            this.Sub4Lec.CheckedChanged += new System.EventHandler(this.Downloads_CheckedChanged);
            // 
            // Sub3Lab
            // 
            this.Sub3Lab.AutoSize = true;
            this.Sub3Lab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sub3Lab.Location = new System.Drawing.Point(215, 94);
            this.Sub3Lab.Name = "Sub3Lab";
            this.Sub3Lab.Size = new System.Drawing.Size(76, 21);
            this.Sub3Lab.TabIndex = 2;
            this.Sub3Lab.Text = "Subject3";
            this.Sub3Lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sub3Lab.UseVisualStyleBackColor = true;
            this.Sub3Lab.CheckedChanged += new System.EventHandler(this.Downloads_CheckedChanged);
            // 
            // Sub3Lec
            // 
            this.Sub3Lec.AutoSize = true;
            this.Sub3Lec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sub3Lec.Location = new System.Drawing.Point(215, 43);
            this.Sub3Lec.Name = "Sub3Lec";
            this.Sub3Lec.Size = new System.Drawing.Size(76, 21);
            this.Sub3Lec.TabIndex = 2;
            this.Sub3Lec.Text = "Subject3";
            this.Sub3Lec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sub3Lec.UseVisualStyleBackColor = true;
            this.Sub3Lec.CheckedChanged += new System.EventHandler(this.Downloads_CheckedChanged);
            // 
            // Sub2Lab
            // 
            this.Sub2Lab.AutoSize = true;
            this.Sub2Lab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sub2Lab.Location = new System.Drawing.Point(133, 94);
            this.Sub2Lab.Name = "Sub2Lab";
            this.Sub2Lab.Size = new System.Drawing.Size(76, 21);
            this.Sub2Lab.TabIndex = 1;
            this.Sub2Lab.Text = "Subject2";
            this.Sub2Lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sub2Lab.UseVisualStyleBackColor = true;
            this.Sub2Lab.CheckedChanged += new System.EventHandler(this.Downloads_CheckedChanged);
            // 
            // Sub2Lec
            // 
            this.Sub2Lec.AutoSize = true;
            this.Sub2Lec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sub2Lec.Location = new System.Drawing.Point(133, 43);
            this.Sub2Lec.Name = "Sub2Lec";
            this.Sub2Lec.Size = new System.Drawing.Size(76, 21);
            this.Sub2Lec.TabIndex = 1;
            this.Sub2Lec.Text = "Subject2";
            this.Sub2Lec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sub2Lec.UseVisualStyleBackColor = true;
            this.Sub2Lec.CheckedChanged += new System.EventHandler(this.Downloads_CheckedChanged);
            // 
            // Sub1Lab
            // 
            this.Sub1Lab.AutoSize = true;
            this.Sub1Lab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sub1Lab.Location = new System.Drawing.Point(51, 94);
            this.Sub1Lab.Name = "Sub1Lab";
            this.Sub1Lab.Size = new System.Drawing.Size(76, 21);
            this.Sub1Lab.TabIndex = 0;
            this.Sub1Lab.Text = "Subject1";
            this.Sub1Lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sub1Lab.UseVisualStyleBackColor = true;
            this.Sub1Lab.CheckedChanged += new System.EventHandler(this.Downloads_CheckedChanged);
            // 
            // Sub1Lec
            // 
            this.Sub1Lec.AutoSize = true;
            this.Sub1Lec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sub1Lec.Location = new System.Drawing.Point(51, 43);
            this.Sub1Lec.Name = "Sub1Lec";
            this.Sub1Lec.Size = new System.Drawing.Size(76, 21);
            this.Sub1Lec.TabIndex = 0;
            this.Sub1Lec.Text = "Subject1";
            this.Sub1Lec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sub1Lec.UseVisualStyleBackColor = true;
            this.Sub1Lec.CheckedChanged += new System.EventHandler(this.Downloads_CheckedChanged);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabUpdates);
            this.tabMain.Controls.Add(this.tabGeneral);
            this.tabMain.Controls.Add(this.tabOthers);
            this.tabMain.Controls.Add(this.tabAdminPanel);
            this.tabMain.Location = new System.Drawing.Point(5, 27);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(591, 423);
            this.tabMain.TabIndex = 7;
            // 
            // tabAdminPanel
            // 
            this.tabAdminPanel.BackColor = System.Drawing.Color.Transparent;
            this.tabAdminPanel.Controls.Add(this.btnCloseAdminPanel);
            this.tabAdminPanel.Controls.Add(this.btnNewUser);
            this.tabAdminPanel.Controls.Add(this.btnEditPassword);
            this.tabAdminPanel.Controls.Add(this.btnReset);
            this.tabAdminPanel.Location = new System.Drawing.Point(4, 26);
            this.tabAdminPanel.Name = "tabAdminPanel";
            this.tabAdminPanel.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminPanel.Size = new System.Drawing.Size(583, 393);
            this.tabAdminPanel.TabIndex = 2;
            this.tabAdminPanel.Text = "Admin Panel";
            this.tabAdminPanel.UseVisualStyleBackColor = true;
            this.tabAdminPanel.Enter += new System.EventHandler(this.tabAdminPanel_Enter);
            // 
            // btnCloseAdminPanel
            // 
            this.btnCloseAdminPanel.Font = new System.Drawing.Font("BatmanForeverAlternate", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCloseAdminPanel.ForeColor = System.Drawing.Color.Orange;
            this.btnCloseAdminPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCloseAdminPanel.Location = new System.Drawing.Point(64, 362);
            this.btnCloseAdminPanel.Name = "btnCloseAdminPanel";
            this.btnCloseAdminPanel.Size = new System.Drawing.Size(82, 25);
            this.btnCloseAdminPanel.TabIndex = 41;
            this.btnCloseAdminPanel.Text = "Close";
            this.btnCloseAdminPanel.UseVisualStyleBackColor = true;
            this.btnCloseAdminPanel.Click += new System.EventHandler(this.btnCloseAdminPanel_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Font = new System.Drawing.Font("BatmanForeverAlternate", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnNewUser.ForeColor = System.Drawing.Color.Orange;
            this.btnNewUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewUser.Location = new System.Drawing.Point(322, 362);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(109, 25);
            this.btnNewUser.TabIndex = 18;
            this.btnNewUser.Text = "New User";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnEditPassword
            // 
            this.btnEditPassword.Font = new System.Drawing.Font("BatmanForeverAlternate", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnEditPassword.ForeColor = System.Drawing.Color.Orange;
            this.btnEditPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditPassword.Location = new System.Drawing.Point(152, 362);
            this.btnEditPassword.Name = "btnEditPassword";
            this.btnEditPassword.Size = new System.Drawing.Size(164, 25);
            this.btnEditPassword.TabIndex = 20;
            this.btnEditPassword.Text = "Edit Password";
            this.btnEditPassword.UseVisualStyleBackColor = true;
            this.btnEditPassword.Click += new System.EventHandler(this.btnEditPassword_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("BatmanForeverAlternate", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnReset.ForeColor = System.Drawing.Color.Orange;
            this.btnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReset.Location = new System.Drawing.Point(437, 362);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 25);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.AllowMerge = false;
            this.MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StudyMateMenu,
            this.OptionsMenu,
            this.HelpMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenu.ShowItemToolTips = true;
            this.MainMenu.Size = new System.Drawing.Size(600, 24);
            this.MainMenu.TabIndex = 17;
            // 
            // StudyMateMenu
            // 
            this.StudyMateMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseMenu,
            this.ExitMenu});
            this.StudyMateMenu.Name = "StudyMateMenu";
            this.StudyMateMenu.ShowShortcutKeys = false;
            this.StudyMateMenu.Size = new System.Drawing.Size(37, 20);
            this.StudyMateMenu.Text = "&File";
            // 
            // CloseMenu
            // 
            this.CloseMenu.Image = ((System.Drawing.Image)(resources.GetObject("CloseMenu.Image")));
            this.CloseMenu.Name = "CloseMenu";
            this.CloseMenu.Size = new System.Drawing.Size(102, 22);
            this.CloseMenu.Text = "Close";
            this.CloseMenu.ToolTipText = "Close To Tray";
            this.CloseMenu.Click += new System.EventHandler(this.CloseMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Image = ((System.Drawing.Image)(resources.GetObject("ExitMenu.Image")));
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(102, 22);
            this.ExitMenu.Text = "Exit";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // OptionsMenu
            // 
            this.OptionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.CloseToTrayMenu,
            this.MinimizeToTrayMenu,
            this.StartWithWindowsMenu,
            this.AlwaysShowTrayIconMenu,
            this.AutoUpdateCheckMenu,
            this.DefaultOptionsMenu});
            this.OptionsMenu.Name = "OptionsMenu";
            this.OptionsMenu.ShowShortcutKeys = false;
            this.OptionsMenu.Size = new System.Drawing.Size(61, 20);
            this.OptionsMenu.Text = "&Settings";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.AutoSize = false;
            this.languageToolStripMenuItem.AutoToolTip = true;
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArabicLanguageMenu,
            this.EnglishLanguageMenu});
            this.languageToolStripMenuItem.Enabled = false;
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // ArabicLanguageMenu
            // 
            this.ArabicLanguageMenu.AutoSize = false;
            this.ArabicLanguageMenu.AutoToolTip = true;
            this.ArabicLanguageMenu.Name = "ArabicLanguageMenu";
            this.ArabicLanguageMenu.Size = new System.Drawing.Size(152, 22);
            this.ArabicLanguageMenu.Text = "Arabic";
            // 
            // EnglishLanguageMenu
            // 
            this.EnglishLanguageMenu.AutoSize = false;
            this.EnglishLanguageMenu.AutoToolTip = true;
            this.EnglishLanguageMenu.Name = "EnglishLanguageMenu";
            this.EnglishLanguageMenu.Size = new System.Drawing.Size(152, 22);
            this.EnglishLanguageMenu.Text = "English";
            // 
            // CloseToTrayMenu
            // 
            this.CloseToTrayMenu.AutoSize = false;
            this.CloseToTrayMenu.AutoToolTip = true;
            this.CloseToTrayMenu.Name = "CloseToTrayMenu";
            this.CloseToTrayMenu.Size = new System.Drawing.Size(202, 22);
            this.CloseToTrayMenu.Text = "Close To Tray";
            this.CloseToTrayMenu.Click += new System.EventHandler(this.CloseToTrayMenu_Click);
            // 
            // MinimizeToTrayMenu
            // 
            this.MinimizeToTrayMenu.AutoSize = false;
            this.MinimizeToTrayMenu.AutoToolTip = true;
            this.MinimizeToTrayMenu.Name = "MinimizeToTrayMenu";
            this.MinimizeToTrayMenu.Size = new System.Drawing.Size(202, 22);
            this.MinimizeToTrayMenu.Text = "Minimize To Tray";
            this.MinimizeToTrayMenu.Click += new System.EventHandler(this.MinimizeToTrayMenu_Click);
            // 
            // StartWithWindowsMenu
            // 
            this.StartWithWindowsMenu.AutoSize = false;
            this.StartWithWindowsMenu.AutoToolTip = true;
            this.StartWithWindowsMenu.Name = "StartWithWindowsMenu";
            this.StartWithWindowsMenu.Size = new System.Drawing.Size(202, 22);
            this.StartWithWindowsMenu.Text = "Start With Windows";
            this.StartWithWindowsMenu.Click += new System.EventHandler(this.StartWithWindowsMenu_Click);
            // 
            // AlwaysShowTrayIconMenu
            // 
            this.AlwaysShowTrayIconMenu.AutoSize = false;
            this.AlwaysShowTrayIconMenu.Name = "AlwaysShowTrayIconMenu";
            this.AlwaysShowTrayIconMenu.Size = new System.Drawing.Size(202, 22);
            this.AlwaysShowTrayIconMenu.Text = "Always Show Tray Icon";
            this.AlwaysShowTrayIconMenu.Click += new System.EventHandler(this.AlwaysShowTrayIconMenu_Click);
            // 
            // AutoUpdateCheckMenu
            // 
            this.AutoUpdateCheckMenu.AutoSize = false;
            this.AutoUpdateCheckMenu.AutoToolTip = true;
            this.AutoUpdateCheckMenu.Name = "AutoUpdateCheckMenu";
            this.AutoUpdateCheckMenu.Size = new System.Drawing.Size(202, 22);
            this.AutoUpdateCheckMenu.Text = "Auto Check For Updates";
            this.AutoUpdateCheckMenu.Click += new System.EventHandler(this.AutoUpdateCheckMenu_Click);
            // 
            // DefaultOptionsMenu
            // 
            this.DefaultOptionsMenu.Image = ((System.Drawing.Image)(resources.GetObject("DefaultOptionsMenu.Image")));
            this.DefaultOptionsMenu.Name = "DefaultOptionsMenu";
            this.DefaultOptionsMenu.Size = new System.Drawing.Size(199, 22);
            this.DefaultOptionsMenu.Text = "StudyMate - Default";
            this.DefaultOptionsMenu.Click += new System.EventHandler(this.DefaultOptionsMenu_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WebsiteMenu,
            this.ContentsMenu,
            this.ChangelogMenu,
            this.toolStripSeparator1,
            this.ReportABugMenu,
            this.CheckForUpdatesMenu,
            this.toolStripSeparator5,
            this.AboutStudyMateMenu});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.ShowShortcutKeys = false;
            this.HelpMenu.Size = new System.Drawing.Size(43, 20);
            this.HelpMenu.Text = "&Help";
            // 
            // WebsiteMenu
            // 
            this.WebsiteMenu.Image = ((System.Drawing.Image)(resources.GetObject("WebsiteMenu.Image")));
            this.WebsiteMenu.Name = "WebsiteMenu";
            this.WebsiteMenu.Size = new System.Drawing.Size(171, 22);
            this.WebsiteMenu.Text = "Website";
            this.WebsiteMenu.Click += new System.EventHandler(this.WebsiteMenu_Click);
            // 
            // ContentsMenu
            // 
            this.ContentsMenu.Image = ((System.Drawing.Image)(resources.GetObject("ContentsMenu.Image")));
            this.ContentsMenu.Name = "ContentsMenu";
            this.ContentsMenu.Size = new System.Drawing.Size(171, 22);
            this.ContentsMenu.Text = "Contents";
            this.ContentsMenu.Click += new System.EventHandler(this.ContentsMenu_Click);
            // 
            // ChangelogMenu
            // 
            this.ChangelogMenu.Image = ((System.Drawing.Image)(resources.GetObject("ChangelogMenu.Image")));
            this.ChangelogMenu.Name = "ChangelogMenu";
            this.ChangelogMenu.Size = new System.Drawing.Size(171, 22);
            this.ChangelogMenu.Text = "Changelog";
            this.ChangelogMenu.Click += new System.EventHandler(this.ChangelogMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // ReportABugMenu
            // 
            this.ReportABugMenu.Image = ((System.Drawing.Image)(resources.GetObject("ReportABugMenu.Image")));
            this.ReportABugMenu.Name = "ReportABugMenu";
            this.ReportABugMenu.Size = new System.Drawing.Size(171, 22);
            this.ReportABugMenu.Text = "Report A Bug";
            this.ReportABugMenu.Click += new System.EventHandler(this.ReportABugMenu_Click);
            // 
            // CheckForUpdatesMenu
            // 
            this.CheckForUpdatesMenu.Image = ((System.Drawing.Image)(resources.GetObject("CheckForUpdatesMenu.Image")));
            this.CheckForUpdatesMenu.Name = "CheckForUpdatesMenu";
            this.CheckForUpdatesMenu.Size = new System.Drawing.Size(171, 22);
            this.CheckForUpdatesMenu.Text = "Check For Updates";
            this.CheckForUpdatesMenu.Click += new System.EventHandler(this.CheckForUpdatesMenu_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(168, 6);
            // 
            // AboutStudyMateMenu
            // 
            this.AboutStudyMateMenu.Image = ((System.Drawing.Image)(resources.GetObject("AboutStudyMateMenu.Image")));
            this.AboutStudyMateMenu.Name = "AboutStudyMateMenu";
            this.AboutStudyMateMenu.Size = new System.Drawing.Size(171, 22);
            this.AboutStudyMateMenu.Text = "About StudyMate";
            this.AboutStudyMateMenu.Click += new System.EventHandler(this.AboutStudyMateMenu_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayIconContextMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "StudyMate";
            this.TrayIcon.DoubleClick += new System.EventHandler(this.TrayIcon_DoubleClick);
            // 
            // TrayIconContextMenu
            // 
            this.TrayIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenStudyMateContextMenu,
            this.CheckForContentUpdatesMenu,
            this.toolStripSeparator2,
            this.ExitContextMenu});
            this.TrayIconContextMenu.Name = "contextMenuStrip1";
            this.TrayIconContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TrayIconContextMenu.Size = new System.Drawing.Size(217, 76);
            // 
            // OpenStudyMateContextMenu
            // 
            this.OpenStudyMateContextMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenStudyMateContextMenu.Image = ((System.Drawing.Image)(resources.GetObject("OpenStudyMateContextMenu.Image")));
            this.OpenStudyMateContextMenu.Name = "OpenStudyMateContextMenu";
            this.OpenStudyMateContextMenu.Size = new System.Drawing.Size(216, 22);
            this.OpenStudyMateContextMenu.Text = "StudyMate";
            this.OpenStudyMateContextMenu.Click += new System.EventHandler(this.OpenStudyMateContextMenu_Click);
            // 
            // CheckForContentUpdatesMenu
            // 
            this.CheckForContentUpdatesMenu.Name = "CheckForContentUpdatesMenu";
            this.CheckForContentUpdatesMenu.Size = new System.Drawing.Size(216, 22);
            this.CheckForContentUpdatesMenu.Text = "Check For Content Updates";
            this.CheckForContentUpdatesMenu.Click += new System.EventHandler(this.CheckForContentUpdatesMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // ExitContextMenu
            // 
            this.ExitContextMenu.Image = ((System.Drawing.Image)(resources.GetObject("ExitContextMenu.Image")));
            this.ExitContextMenu.Name = "ExitContextMenu";
            this.ExitContextMenu.Size = new System.Drawing.Size(216, 22);
            this.ExitContextMenu.Text = "Exit";
            this.ExitContextMenu.Click += new System.EventHandler(this.ExitContextMenu_Click);
            // 
            // bgAutoUpdateCheck
            // 
            this.bgAutoUpdateCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgAutoUpdateCheck_DoWork);
            this.bgAutoUpdateCheck.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgAutoUpdateCheck_RunWorkerCompleted);
            // 
            // bgAdvisor
            // 
            this.bgAdvisor.WorkerSupportsCancellation = true;
            this.bgAdvisor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgAdvisor_DoWork);
            this.bgAdvisor.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgAdvisor_RunWorkerCompleted);
            // 
            // dataListTableAdapter
            // 
            this.dataListTableAdapter.ClearBeforeFill = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 455);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudyMate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Shown += new System.EventHandler(this.MainFrm_Shown);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MainFrm_HelpRequested);
            this.Resize += new System.EventHandler(this.MainFrm_Resize);
            this.tabOthers.ResumeLayout(false);
            this.groupUpload.ResumeLayout(false);
            this.groupUpload.PerformLayout();
            this.groupDownload.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyMateDS)).EndInit();
            this.tabUpdates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UpdatesViewer)).EndInit();
            this.tabGeneral.ResumeLayout(false);
            this.groupLec.ResumeLayout(false);
            this.groupLec.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabAdminPanel.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.TrayIconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabOthers;
        private System.Windows.Forms.TabPage tabUpdates;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.GroupBox groupLec;
        private System.Windows.Forms.CheckBox Sub5Lec;
        private System.Windows.Forms.CheckBox Sub4Lec;
        private System.Windows.Forms.CheckBox Sub3Lec;
        private System.Windows.Forms.CheckBox Sub2Lec;
        private System.Windows.Forms.CheckBox Sub1Lec;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabAdminPanel;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.DataGridView DataViewer;
        private System.Windows.Forms.Button btnCopyLink;
        private System.Windows.Forms.Button btnOpenLink;
        private StudyMate.StudyMateDS studyMateDS;
        private StudyMate.StudyMateDSTableAdapters.DataListTableAdapter dataListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataListBindingSource;
        private System.Windows.Forms.CheckBox Extra4;
        private System.Windows.Forms.CheckBox Extra3;
        private System.Windows.Forms.CheckBox Extra2;
        private System.Windows.Forms.CheckBox Extra1;
        private System.Windows.Forms.CheckBox Sub5Lab;
        private System.Windows.Forms.CheckBox Sub4Lab;
        private System.Windows.Forms.CheckBox Sub3Lab;
        private System.Windows.Forms.CheckBox Sub2Lab;
        private System.Windows.Forms.CheckBox Sub1Lab;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtOtherName;
        private System.Windows.Forms.Label lblOtherName;
        private System.Windows.Forms.RadioButton btnOtherCategoryOther;
        private System.Windows.Forms.RadioButton btnOtherCategoryExtra;
        private System.Windows.Forms.RadioButton btnOtherCategoryLab;
        private System.Windows.Forms.RadioButton btnOtherCategoryLec;
        private System.Windows.Forms.Label lblOtherCategory;
        private System.Windows.Forms.Label lblOtherComment;
        private System.Windows.Forms.Label lblOtherLink;
        private System.Windows.Forms.Label lblOtherAuthor;
        private System.Windows.Forms.TextBox txtOtherComment;
        private System.Windows.Forms.TextBox txtOtherLink;
        private System.Windows.Forms.TextBox txtOtherAuthor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupUpload;
        private System.Windows.Forms.GroupBox groupDownload;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnEditPassword;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem StudyMateMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem ContentsMenu;
        private System.Windows.Forms.ToolStripMenuItem ReportABugMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem AboutStudyMateMenu;
        private System.Windows.Forms.ToolStripMenuItem ChangelogMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArabicLanguageMenu;
        private System.Windows.Forms.ToolStripMenuItem EnglishLanguageMenu;
        private System.Windows.Forms.ToolStripMenuItem WebsiteMenu;
        private System.Windows.Forms.ToolStripMenuItem CheckForUpdatesMenu;
        private System.Windows.Forms.Button btnCloseAdminPanel;
        private System.Windows.Forms.ToolStripMenuItem StartWithWindowsMenu;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenStudyMateContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitContextMenu;
        private System.Windows.Forms.ToolStripMenuItem MinimizeToTrayMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem AutoUpdateCheckMenu;
        private System.Windows.Forms.ToolStripMenuItem CloseToTrayMenu;
        private System.ComponentModel.BackgroundWorker bgAutoUpdateCheck;
        private System.Windows.Forms.ToolStripMenuItem CloseMenu;
        private System.Windows.Forms.ToolStripMenuItem AlwaysShowTrayIconMenu;
        private System.Windows.Forms.ToolStripMenuItem DefaultOptionsMenu;
        private System.Windows.Forms.ProgressBar UpdateProgress;
        private System.ComponentModel.BackgroundWorker bgAdvisor;
        private System.Windows.Forms.CheckBox btnSelectAll;
        private System.Windows.Forms.DataGridView UpdatesViewer;
        private System.Windows.Forms.ToolStripMenuItem CheckForContentUpdatesMenu;
        private System.Windows.Forms.Label lblExtras;
        private System.Windows.Forms.Label lblLabs;
        private System.Windows.Forms.Label lblLectures;

    }
}


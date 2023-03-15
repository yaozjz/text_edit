
namespace textEdit
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fileStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.filePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.nowLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.codingName = new System.Windows.Forms.ToolStripStatusLabel();
            this.FontStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSave = new System.Windows.Forms.ToolStripMenuItem();
            this.otherSave = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.search = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearNullLine = new System.Windows.Forms.ToolStripMenuItem();
            this.TextTrim = new System.Windows.Forms.ToolStripMenuItem();
            this.ParaFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearAllSpace = new System.Windows.Forms.ToolStripMenuItem();
            this.格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoEnter = new System.Windows.Forms.ToolStripMenuItem();
            this.TitelSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.linesIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveDuanWei = new System.Windows.Forms.Button();
            this.DuanWei = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usualTitle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckedTitle = new System.Windows.Forms.Button();
            this.TitleIsAlone = new System.Windows.Forms.CheckBox();
            this.TitleRule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainText = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyText = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteText = new System.Windows.Forms.ToolStripMenuItem();
            this.去除空行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.去除开头与结尾空格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动整理段落ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStatus,
            this.filePath,
            this.nowLine,
            this.codingName,
            this.FontStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 624);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1208, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fileStatus
            // 
            this.fileStatus.Name = "fileStatus";
            this.fileStatus.Size = new System.Drawing.Size(56, 17);
            this.fileStatus.Text = "文件路径";
            // 
            // filePath
            // 
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(1016, 17);
            this.filePath.Spring = true;
            this.filePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nowLine
            // 
            this.nowLine.Margin = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.nowLine.Name = "nowLine";
            this.nowLine.Size = new System.Drawing.Size(39, 17);
            this.nowLine.Text = "第n行";
            // 
            // codingName
            // 
            this.codingName.Name = "codingName";
            this.codingName.Size = new System.Drawing.Size(35, 17);
            this.codingName.Text = "utf-8";
            // 
            // FontStatus
            // 
            this.FontStatus.Name = "FontStatus";
            this.FontStatus.Size = new System.Drawing.Size(32, 17);
            this.FontStatus.Text = "字体";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.操作ToolStripMenuItem,
            this.格式ToolStripMenuItem,
            this.about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1208, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.quickSave,
            this.otherSave,
            this.exit});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.ShortcutKeyDisplayString = "Ctrl+O";
            this.openFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFile.Size = new System.Drawing.Size(190, 22);
            this.openFile.Text = "打开文件";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // quickSave
            // 
            this.quickSave.Name = "quickSave";
            this.quickSave.ShortcutKeyDisplayString = "Ctrl+S";
            this.quickSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.quickSave.Size = new System.Drawing.Size(190, 22);
            this.quickSave.Text = "快速保存";
            this.quickSave.Click += new System.EventHandler(this.quickSave_Click);
            // 
            // otherSave
            // 
            this.otherSave.Name = "otherSave";
            this.otherSave.ShortcutKeyDisplayString = "Ctrl+Shift+S";
            this.otherSave.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.otherSave.Size = new System.Drawing.Size(190, 22);
            this.otherSave.Text = "另存为";
            this.otherSave.Click += new System.EventHandler(this.otherSave_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.exit.Size = new System.Drawing.Size(190, 22);
            this.exit.Text = "退出";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.search,
            this.ClearNullLine,
            this.TextTrim,
            this.ParaFormat,
            this.ClearAllSpace});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // search
            // 
            this.search.Name = "search";
            this.search.ShortcutKeyDisplayString = "Ctrl+F";
            this.search.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.search.Size = new System.Drawing.Size(205, 22);
            this.search.Text = "搜索";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // ClearNullLine
            // 
            this.ClearNullLine.Name = "ClearNullLine";
            this.ClearNullLine.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ClearNullLine.Size = new System.Drawing.Size(205, 22);
            this.ClearNullLine.Text = "去除空行";
            this.ClearNullLine.Click += new System.EventHandler(this.ClearNullLine_Click);
            // 
            // TextTrim
            // 
            this.TextTrim.Name = "TextTrim";
            this.TextTrim.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.TextTrim.Size = new System.Drawing.Size(205, 22);
            this.TextTrim.Text = "去除开头与结尾空格";
            this.TextTrim.Click += new System.EventHandler(this.TextTrim_Click);
            // 
            // ParaFormat
            // 
            this.ParaFormat.Name = "ParaFormat";
            this.ParaFormat.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.ParaFormat.Size = new System.Drawing.Size(205, 22);
            this.ParaFormat.Text = "整理段落";
            this.ParaFormat.Click += new System.EventHandler(this.ParaFormat_Click);
            // 
            // ClearAllSpace
            // 
            this.ClearAllSpace.Name = "ClearAllSpace";
            this.ClearAllSpace.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.ClearAllSpace.Size = new System.Drawing.Size(205, 22);
            this.ClearAllSpace.Text = "去除所有空格";
            this.ClearAllSpace.Click += new System.EventHandler(this.ClearAllSpace_Click);
            // 
            // 格式ToolStripMenuItem
            // 
            this.格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontSetting,
            this.AutoEnter,
            this.TitelSetting});
            this.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
            this.格式ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.格式ToolStripMenuItem.Text = "格式";
            // 
            // FontSetting
            // 
            this.FontSetting.Name = "FontSetting";
            this.FontSetting.Size = new System.Drawing.Size(180, 22);
            this.FontSetting.Text = "字体";
            this.FontSetting.Click += new System.EventHandler(this.FontSetting_Click);
            // 
            // AutoEnter
            // 
            this.AutoEnter.Name = "AutoEnter";
            this.AutoEnter.Size = new System.Drawing.Size(180, 22);
            this.AutoEnter.Text = "自动换行";
            this.AutoEnter.CheckedChanged += new System.EventHandler(this.AutoEnter_CheckedChanged);
            this.AutoEnter.Click += new System.EventHandler(this.AutoEnter_Click);
            // 
            // TitelSetting
            // 
            this.TitelSetting.Name = "TitelSetting";
            this.TitelSetting.Size = new System.Drawing.Size(180, 22);
            this.TitelSetting.Text = "目录检索规则";
            this.TitelSetting.Click += new System.EventHandler(this.TitelSetting_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(44, 21);
            this.about.Text = "关于";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.GrayText;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mainText);
            this.splitContainer1.Size = new System.Drawing.Size(1208, 597);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linesIndex,
            this.titleNames});
            this.dataGridView1.Location = new System.Drawing.Point(0, 185);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(219, 409);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // linesIndex
            // 
            this.linesIndex.FillWeight = 50.76142F;
            this.linesIndex.HeaderText = "行";
            this.linesIndex.MinimumWidth = 30;
            this.linesIndex.Name = "linesIndex";
            this.linesIndex.ReadOnly = true;
            // 
            // titleNames
            // 
            this.titleNames.FillWeight = 149.2386F;
            this.titleNames.HeaderText = "章节名称";
            this.titleNames.MinimumWidth = 6;
            this.titleNames.Name = "titleNames";
            this.titleNames.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.saveDuanWei);
            this.panel1.Controls.Add(this.DuanWei);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.usualTitle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CheckedTitle);
            this.panel1.Controls.Add(this.TitleIsAlone);
            this.panel1.Controls.Add(this.TitleRule);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 182);
            this.panel1.TabIndex = 0;
            // 
            // saveDuanWei
            // 
            this.saveDuanWei.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveDuanWei.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveDuanWei.Location = new System.Drawing.Point(143, 152);
            this.saveDuanWei.Margin = new System.Windows.Forms.Padding(0);
            this.saveDuanWei.MinimumSize = new System.Drawing.Size(43, 23);
            this.saveDuanWei.Name = "saveDuanWei";
            this.saveDuanWei.Size = new System.Drawing.Size(71, 23);
            this.saveDuanWei.TabIndex = 8;
            this.saveDuanWei.TabStop = false;
            this.saveDuanWei.Text = "保存";
            this.saveDuanWei.UseVisualStyleBackColor = true;
            this.saveDuanWei.Click += new System.EventHandler(this.saveDuanWei_Click);
            // 
            // DuanWei
            // 
            this.DuanWei.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DuanWei.Location = new System.Drawing.Point(2, 123);
            this.DuanWei.Name = "DuanWei";
            this.DuanWei.Size = new System.Drawing.Size(212, 26);
            this.DuanWei.TabIndex = 7;
            this.DuanWei.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "段落结尾形式：";
            // 
            // usualTitle
            // 
            this.usualTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usualTitle.FormattingEnabled = true;
            this.usualTitle.Location = new System.Drawing.Point(72, 63);
            this.usualTitle.Name = "usualTitle";
            this.usualTitle.Size = new System.Drawing.Size(140, 28);
            this.usualTitle.TabIndex = 5;
            this.usualTitle.SelectedIndexChanged += new System.EventHandler(this.usualTitle_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "常见形式：";
            // 
            // CheckedTitle
            // 
            this.CheckedTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckedTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckedTitle.Location = new System.Drawing.Point(143, 36);
            this.CheckedTitle.Margin = new System.Windows.Forms.Padding(0);
            this.CheckedTitle.MinimumSize = new System.Drawing.Size(43, 23);
            this.CheckedTitle.Name = "CheckedTitle";
            this.CheckedTitle.Size = new System.Drawing.Size(71, 23);
            this.CheckedTitle.TabIndex = 3;
            this.CheckedTitle.TabStop = false;
            this.CheckedTitle.Text = "检查";
            this.CheckedTitle.UseVisualStyleBackColor = true;
            this.CheckedTitle.Click += new System.EventHandler(this.CheckedTitle_Click);
            // 
            // TitleIsAlone
            // 
            this.TitleIsAlone.AutoSize = true;
            this.TitleIsAlone.Checked = true;
            this.TitleIsAlone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TitleIsAlone.Location = new System.Drawing.Point(6, 35);
            this.TitleIsAlone.Name = "TitleIsAlone";
            this.TitleIsAlone.Size = new System.Drawing.Size(140, 24);
            this.TitleIsAlone.TabIndex = 2;
            this.TitleIsAlone.TabStop = false;
            this.TitleIsAlone.Text = "章节名为独立一行";
            this.TitleIsAlone.UseVisualStyleBackColor = true;
            // 
            // TitleRule
            // 
            this.TitleRule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleRule.Location = new System.Drawing.Point(72, 5);
            this.TitleRule.Name = "TitleRule";
            this.TitleRule.Size = new System.Drawing.Size(142, 26);
            this.TitleRule.TabIndex = 1;
            this.TitleRule.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "目录整理：";
            // 
            // mainText
            // 
            this.mainText.AcceptsTab = true;
            this.mainText.ContextMenuStrip = this.contextMenuStrip1;
            this.mainText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainText.Location = new System.Drawing.Point(0, 0);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(986, 597);
            this.mainText.TabIndex = 0;
            this.mainText.Text = "";
            this.mainText.WordWrap = false;
            this.mainText.TextChanged += new System.EventHandler(this.mainText_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyText,
            this.PasteText,
            this.去除空行ToolStripMenuItem,
            this.去除开头与结尾空格ToolStripMenuItem,
            this.自动整理段落ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 114);
            // 
            // CopyText
            // 
            this.CopyText.Name = "CopyText";
            this.CopyText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyText.Size = new System.Drawing.Size(184, 22);
            this.CopyText.Text = "复制";
            this.CopyText.Click += new System.EventHandler(this.CopyText_Click);
            // 
            // PasteText
            // 
            this.PasteText.Name = "PasteText";
            this.PasteText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteText.Size = new System.Drawing.Size(184, 22);
            this.PasteText.Text = "粘贴";
            this.PasteText.Click += new System.EventHandler(this.PasteText_Click);
            // 
            // 去除空行ToolStripMenuItem
            // 
            this.去除空行ToolStripMenuItem.Name = "去除空行ToolStripMenuItem";
            this.去除空行ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.去除空行ToolStripMenuItem.Text = "去除空行";
            this.去除空行ToolStripMenuItem.Click += new System.EventHandler(this.ClearNullLine_Click);
            // 
            // 去除开头与结尾空格ToolStripMenuItem
            // 
            this.去除开头与结尾空格ToolStripMenuItem.Name = "去除开头与结尾空格ToolStripMenuItem";
            this.去除开头与结尾空格ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.去除开头与结尾空格ToolStripMenuItem.Text = "去除开头与结尾空格";
            this.去除开头与结尾空格ToolStripMenuItem.Click += new System.EventHandler(this.TextTrim_Click);
            // 
            // 自动整理段落ToolStripMenuItem
            // 
            this.自动整理段落ToolStripMenuItem.Name = "自动整理段落ToolStripMenuItem";
            this.自动整理段落ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.自动整理段落ToolStripMenuItem.Text = "自动整理段落";
            this.自动整理段落ToolStripMenuItem.Click += new System.EventHandler(this.ParaFormat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 646);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小说文本编辑器";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem quickSave;
        private System.Windows.Forms.ToolStripMenuItem otherSave;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripStatusLabel fileStatus;
        private System.Windows.Forms.ToolStripStatusLabel filePath;
        private System.Windows.Forms.ToolStripStatusLabel nowLine;
        private System.Windows.Forms.ToolStripStatusLabel codingName;
        private System.Windows.Forms.ToolStripMenuItem search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn linesIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleRule;
        private System.Windows.Forms.CheckBox TitleIsAlone;
        private System.Windows.Forms.Button CheckedTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox usualTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DuanWei;
        private System.Windows.Forms.Button saveDuanWei;
        private System.Windows.Forms.ToolStripMenuItem FontSetting;
        private System.Windows.Forms.ToolStripMenuItem AutoEnter;
        private System.Windows.Forms.ToolStripStatusLabel FontStatus;
        private System.Windows.Forms.ToolStripMenuItem ClearNullLine;
        private System.Windows.Forms.ToolStripMenuItem TextTrim;
        private System.Windows.Forms.ToolStripMenuItem ClearAllSpace;
        private System.Windows.Forms.ToolStripMenuItem ParaFormat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox mainText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CopyText;
        private System.Windows.Forms.ToolStripMenuItem PasteText;
        private System.Windows.Forms.ToolStripMenuItem 去除空行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 去除开头与结尾空格ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动整理段落ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TitelSetting;
    }
}


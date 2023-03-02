
namespace text_edit
{
    partial class mainFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrom));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openText = new System.Windows.Forms.ToolStripMenuItem();
            this.快速保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveText = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchText = new System.Windows.Forms.ToolStripMenuItem();
            this.geShiSet = new System.Windows.Forms.ToolStripMenuItem();
            this.autoEnter = new System.Windows.Forms.ToolStripMenuItem();
            this.文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.去除文本中的空行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.去除所有空白字符ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.去除每行的开尾空格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoParagraph = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenBt = new System.Windows.Forms.ToolStripButton();
            this.saveBt = new System.Windows.Forms.ToolStripButton();
            this.searchBt = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.exitBt = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.filePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.Now_index = new System.Windows.Forms.ToolStripStatusLabel();
            this.coding_fun = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_font = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.saveJuMo = new System.Windows.Forms.Button();
            this.DuanMo = new System.Windows.Forms.TextBox();
            this.aloneLine = new System.Windows.Forms.CheckBox();
            this.insertTileRule = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.usualTitle = new System.Windows.Forms.ComboBox();
            this.makeTitle = new System.Windows.Forms.Button();
            this.checkTitle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.unitFromat_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearMessage = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearLineN = new System.Windows.Forms.ToolStripMenuItem();
            this.去除所有空白字符ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTN = new System.Windows.Forms.ToolStripMenuItem();
            this.去除空行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动整理段落ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.操作ToolStripMenuItem,
            this.文本ToolStripMenuItem,
            this.aboutBt});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1091, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openText,
            this.快速保存ToolStripMenuItem,
            this.saveText,
            this.exitSystem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // openText
            // 
            this.openText.Name = "openText";
            this.openText.ShortcutKeyDisplayString = "Ctrl+O";
            this.openText.Size = new System.Drawing.Size(180, 22);
            this.openText.Text = "打开文本";
            this.openText.Click += new System.EventHandler(this.openText_Click);
            // 
            // 快速保存ToolStripMenuItem
            // 
            this.快速保存ToolStripMenuItem.Name = "快速保存ToolStripMenuItem";
            this.快速保存ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.快速保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.快速保存ToolStripMenuItem.Tag = "";
            this.快速保存ToolStripMenuItem.Text = "快速保存";
            this.快速保存ToolStripMenuItem.Click += new System.EventHandler(this.saveBt_Click);
            // 
            // saveText
            // 
            this.saveText.Name = "saveText";
            this.saveText.Size = new System.Drawing.Size(180, 22);
            this.saveText.Text = "另存文本";
            this.saveText.Click += new System.EventHandler(this.saveText_Click);
            // 
            // exitSystem
            // 
            this.exitSystem.Name = "exitSystem";
            this.exitSystem.Size = new System.Drawing.Size(180, 22);
            this.exitSystem.Text = "退出";
            this.exitSystem.Click += new System.EventHandler(this.exitSystem_Click);
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchText,
            this.geShiSet,
            this.autoEnter});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // searchText
            // 
            this.searchText.Name = "searchText";
            this.searchText.ShortcutKeyDisplayString = "Ctrl+F";
            this.searchText.Size = new System.Drawing.Size(143, 22);
            this.searchText.Text = "查找";
            this.searchText.Click += new System.EventHandler(this.searchText_Click);
            // 
            // geShiSet
            // 
            this.geShiSet.Name = "geShiSet";
            this.geShiSet.Size = new System.Drawing.Size(143, 22);
            this.geShiSet.Text = "字体";
            this.geShiSet.Click += new System.EventHandler(this.geShiSet_Click);
            // 
            // autoEnter
            // 
            this.autoEnter.Checked = true;
            this.autoEnter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoEnter.Name = "autoEnter";
            this.autoEnter.Size = new System.Drawing.Size(143, 22);
            this.autoEnter.Text = "自动换行";
            this.autoEnter.CheckedChanged += new System.EventHandler(this.autoEnter_CheckedChanged);
            this.autoEnter.Click += new System.EventHandler(this.autoEnter_Click);
            // 
            // 文本ToolStripMenuItem
            // 
            this.文本ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.去除文本中的空行ToolStripMenuItem,
            this.去除所有空白字符ToolStripMenuItem,
            this.去除每行的开尾空格ToolStripMenuItem,
            this.autoParagraph});
            this.文本ToolStripMenuItem.Name = "文本ToolStripMenuItem";
            this.文本ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文本ToolStripMenuItem.Text = "文本";
            // 
            // 去除文本中的空行ToolStripMenuItem
            // 
            this.去除文本中的空行ToolStripMenuItem.Name = "去除文本中的空行ToolStripMenuItem";
            this.去除文本中的空行ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.去除文本中的空行ToolStripMenuItem.Text = "去除文本中的空行";
            this.去除文本中的空行ToolStripMenuItem.Click += new System.EventHandler(this.clearNullLine_Click);
            // 
            // 去除所有空白字符ToolStripMenuItem
            // 
            this.去除所有空白字符ToolStripMenuItem.Name = "去除所有空白字符ToolStripMenuItem";
            this.去除所有空白字符ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.去除所有空白字符ToolStripMenuItem.Text = "去除所有空白字符";
            // 
            // 去除每行的开尾空格ToolStripMenuItem
            // 
            this.去除每行的开尾空格ToolStripMenuItem.Name = "去除每行的开尾空格ToolStripMenuItem";
            this.去除每行的开尾空格ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.去除每行的开尾空格ToolStripMenuItem.Text = "去除每行的开、尾空格";
            this.去除每行的开尾空格ToolStripMenuItem.Click += new System.EventHandler(this.clearLineN_Click);
            // 
            // autoParagraph
            // 
            this.autoParagraph.Name = "autoParagraph";
            this.autoParagraph.Size = new System.Drawing.Size(196, 22);
            this.autoParagraph.Text = "自动整理段落";
            this.autoParagraph.Click += new System.EventHandler(this.autoParagraph_Click);
            // 
            // aboutBt
            // 
            this.aboutBt.Name = "aboutBt";
            this.aboutBt.Size = new System.Drawing.Size(44, 21);
            this.aboutBt.Text = "关于";
            this.aboutBt.Click += new System.EventHandler(this.aboutBt_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenBt,
            this.saveBt,
            this.searchBt,
            this.toolStripButton1,
            this.exitBt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1091, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenBt
            // 
            this.OpenBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenBt.Image = global::text_edit.Properties.Resources.icon_open;
            this.OpenBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenBt.Name = "OpenBt";
            this.OpenBt.Size = new System.Drawing.Size(23, 22);
            this.OpenBt.Text = "打开文件";
            this.OpenBt.Click += new System.EventHandler(this.openText_Click);
            // 
            // saveBt
            // 
            this.saveBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveBt.Image = global::text_edit.Properties.Resources.saveBlue;
            this.saveBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBt.Name = "saveBt";
            this.saveBt.Size = new System.Drawing.Size(23, 22);
            this.saveBt.Text = "快速保存";
            this.saveBt.Click += new System.EventHandler(this.saveBt_Click);
            // 
            // searchBt
            // 
            this.searchBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchBt.Image = global::text_edit.Properties.Resources.search_icon;
            this.searchBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchBt.Name = "searchBt";
            this.searchBt.Size = new System.Drawing.Size(23, 22);
            this.searchBt.Text = "查找";
            this.searchBt.Click += new System.EventHandler(this.searchText_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::text_edit.Properties.Resources.设_置;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "字体设置";
            this.toolStripButton1.Click += new System.EventHandler(this.geShiSet_Click);
            // 
            // exitBt
            // 
            this.exitBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitBt.Image = global::text_edit.Properties.Resources.exit;
            this.exitBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitBt.Name = "exitBt";
            this.exitBt.Size = new System.Drawing.Size(23, 22);
            this.exitBt.Text = "退出";
            this.exitBt.Click += new System.EventHandler(this.exitSystem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.filePath,
            this.Now_index,
            this.coding_fun,
            this.txt_font});
            this.statusStrip1.Location = new System.Drawing.Point(0, 598);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1091, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "文件路径：";
            // 
            // filePath
            // 
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(843, 17);
            this.filePath.Spring = true;
            this.filePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Now_index
            // 
            this.Now_index.Name = "Now_index";
            this.Now_index.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Now_index.Size = new System.Drawing.Size(49, 17);
            this.Now_index.Text = "第n行";
            // 
            // coding_fun
            // 
            this.coding_fun.Name = "coding_fun";
            this.coding_fun.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.coding_fun.Size = new System.Drawing.Size(62, 17);
            this.coding_fun.Text = "UTF-8";
            // 
            // txt_font
            // 
            this.txt_font.Name = "txt_font";
            this.txt_font.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txt_font.Size = new System.Drawing.Size(52, 17);
            this.txt_font.Text = "字体";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1091, 548);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.clearMessage);
            this.panel1.Controls.Add(this.messageBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 548);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.saveJuMo);
            this.panel2.Controls.Add(this.DuanMo);
            this.panel2.Controls.Add(this.aloneLine);
            this.panel2.Controls.Add(this.insertTileRule);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.usualTitle);
            this.panel2.Controls.Add(this.makeTitle);
            this.panel2.Controls.Add(this.checkTitle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.unitFromat_txt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 354);
            this.panel2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "段落结尾形式：";
            // 
            // saveJuMo
            // 
            this.saveJuMo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveJuMo.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveJuMo.Location = new System.Drawing.Point(137, 314);
            this.saveJuMo.Name = "saveJuMo";
            this.saveJuMo.Size = new System.Drawing.Size(60, 24);
            this.saveJuMo.TabIndex = 10;
            this.saveJuMo.Text = "保存";
            this.saveJuMo.UseVisualStyleBackColor = true;
            this.saveJuMo.Click += new System.EventHandler(this.saveJuMo_Click);
            // 
            // DuanMo
            // 
            this.DuanMo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DuanMo.Location = new System.Drawing.Point(3, 282);
            this.DuanMo.Name = "DuanMo";
            this.DuanMo.Size = new System.Drawing.Size(194, 26);
            this.DuanMo.TabIndex = 9;
            // 
            // aloneLine
            // 
            this.aloneLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aloneLine.AutoSize = true;
            this.aloneLine.Checked = true;
            this.aloneLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aloneLine.Location = new System.Drawing.Point(16, 77);
            this.aloneLine.Name = "aloneLine";
            this.aloneLine.Size = new System.Drawing.Size(182, 24);
            this.aloneLine.TabIndex = 8;
            this.aloneLine.Text = "章节与章节名为独立一行";
            this.aloneLine.UseVisualStyleBackColor = true;
            // 
            // insertTileRule
            // 
            this.insertTileRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insertTileRule.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.insertTileRule.Location = new System.Drawing.Point(140, 191);
            this.insertTileRule.Name = "insertTileRule";
            this.insertTileRule.Size = new System.Drawing.Size(60, 24);
            this.insertTileRule.TabIndex = 7;
            this.insertTileRule.Text = "填入";
            this.insertTileRule.UseVisualStyleBackColor = true;
            this.insertTileRule.Click += new System.EventHandler(this.insertTileRule_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "常见形式\r\n";
            // 
            // usualTitle
            // 
            this.usualTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usualTitle.FormattingEnabled = true;
            this.usualTitle.Location = new System.Drawing.Point(71, 154);
            this.usualTitle.Name = "usualTitle";
            this.usualTitle.Size = new System.Drawing.Size(127, 28);
            this.usualTitle.TabIndex = 5;
            // 
            // makeTitle
            // 
            this.makeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.makeTitle.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.makeTitle.Location = new System.Drawing.Point(113, 109);
            this.makeTitle.Name = "makeTitle";
            this.makeTitle.Size = new System.Drawing.Size(85, 24);
            this.makeTitle.TabIndex = 4;
            this.makeTitle.Text = "一键整理";
            this.makeTitle.UseVisualStyleBackColor = true;
            this.makeTitle.Click += new System.EventHandler(this.makeTitle_Click);
            // 
            // checkTitle
            // 
            this.checkTitle.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkTitle.Location = new System.Drawing.Point(7, 109);
            this.checkTitle.Name = "checkTitle";
            this.checkTitle.Size = new System.Drawing.Size(49, 24);
            this.checkTitle.TabIndex = 3;
            this.checkTitle.Text = "检查";
            this.checkTitle.UseVisualStyleBackColor = true;
            this.checkTitle.Click += new System.EventHandler(this.checkTitle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "章节标题形式(正则表达式)";
            // 
            // unitFromat_txt
            // 
            this.unitFromat_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitFromat_txt.Location = new System.Drawing.Point(4, 45);
            this.unitFromat_txt.Name = "unitFromat_txt";
            this.unitFromat_txt.Size = new System.Drawing.Size(195, 26);
            this.unitFromat_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "目录整理";
            // 
            // clearMessage
            // 
            this.clearMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearMessage.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearMessage.Location = new System.Drawing.Point(3, 360);
            this.clearMessage.Margin = new System.Windows.Forms.Padding(0);
            this.clearMessage.Name = "clearMessage";
            this.clearMessage.Size = new System.Drawing.Size(203, 26);
            this.clearMessage.TabIndex = 10;
            this.clearMessage.TabStop = false;
            this.clearMessage.Text = "清除记录";
            this.clearMessage.UseVisualStyleBackColor = true;
            this.clearMessage.Click += new System.EventHandler(this.clearMessage_Click);
            // 
            // messageBox
            // 
            this.messageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageBox.BackColor = System.Drawing.SystemColors.Window;
            this.messageBox.CausesValidation = false;
            this.messageBox.Location = new System.Drawing.Point(3, 389);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageBox.Size = new System.Drawing.Size(200, 155);
            this.messageBox.TabIndex = 10;
            this.messageBox.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(882, 548);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLineN,
            this.去除所有空白字符ToolStripMenuItem1,
            this.clearTN,
            this.去除空行ToolStripMenuItem,
            this.自动整理段落ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 114);
            // 
            // clearLineN
            // 
            this.clearLineN.Name = "clearLineN";
            this.clearLineN.Size = new System.Drawing.Size(208, 22);
            this.clearLineN.Text = "去除当前行空白字符";
            this.clearLineN.Click += new System.EventHandler(this.clearLineN_Click);
            // 
            // 去除所有空白字符ToolStripMenuItem1
            // 
            this.去除所有空白字符ToolStripMenuItem1.Name = "去除所有空白字符ToolStripMenuItem1";
            this.去除所有空白字符ToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
            this.去除所有空白字符ToolStripMenuItem1.Text = "去除所有空白字符";
            this.去除所有空白字符ToolStripMenuItem1.Click += new System.EventHandler(this.clearNull_Click);
            // 
            // clearTN
            // 
            this.clearTN.Name = "clearTN";
            this.clearTN.Size = new System.Drawing.Size(208, 22);
            this.clearTN.Text = "去除开头与尾部空白字符";
            this.clearTN.Click += new System.EventHandler(this.clearTN_Click);
            // 
            // 去除空行ToolStripMenuItem
            // 
            this.去除空行ToolStripMenuItem.Name = "去除空行ToolStripMenuItem";
            this.去除空行ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.去除空行ToolStripMenuItem.Text = "去除空行";
            this.去除空行ToolStripMenuItem.Click += new System.EventHandler(this.clearNullLine_Click);
            // 
            // 自动整理段落ToolStripMenuItem
            // 
            this.自动整理段落ToolStripMenuItem.Name = "自动整理段落ToolStripMenuItem";
            this.自动整理段落ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.自动整理段落ToolStripMenuItem.Text = "自动整理段落";
            this.自动整理段落ToolStripMenuItem.Click += new System.EventHandler(this.autoParagraph_Click);
            // 
            // mainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 620);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文本编辑器";
            this.Activated += new System.EventHandler(this.mainFrom_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainFrom_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openText;
        private System.Windows.Forms.ToolStripMenuItem saveText;
        private System.Windows.Forms.ToolStripMenuItem exitSystem;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchText;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenBt;
        private System.Windows.Forms.ToolStripButton searchBt;
        private System.Windows.Forms.ToolStripButton saveBt;
        private System.Windows.Forms.ToolStripButton exitBt;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearMessage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel filePath;
        private System.Windows.Forms.ToolStripStatusLabel Now_index;
        private System.Windows.Forms.ToolStripMenuItem geShiSet;
        private System.Windows.Forms.ToolStripStatusLabel coding_fun;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripStatusLabel txt_font;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem 快速保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutBt;
        private System.Windows.Forms.ToolStripMenuItem autoEnter;
        public System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.ToolStripMenuItem 文本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 去除文本中的空行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 去除所有空白字符ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearLineN;
        private System.Windows.Forms.ToolStripMenuItem 去除所有空白字符ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearTN;
        private System.Windows.Forms.ToolStripMenuItem 去除每行的开尾空格ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 去除空行ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem autoParagraph;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unitFromat_txt;
        private System.Windows.Forms.Button checkTitle;
        private System.Windows.Forms.Button makeTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox usualTitle;
        private System.Windows.Forms.Button insertTileRule;
        private System.Windows.Forms.ToolStripMenuItem 自动整理段落ToolStripMenuItem;
        private System.Windows.Forms.CheckBox aloneLine;
        private System.Windows.Forms.Button saveJuMo;
        private System.Windows.Forms.TextBox DuanMo;
        private System.Windows.Forms.Label label4;
    }
}


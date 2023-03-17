
namespace textEdit
{
    partial class TitelRuleSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RuleShow = new System.Windows.Forms.DataGridView();
            this.ruleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruleValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SaveData = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteLine = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RuleShow)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RuleShow, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(579, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 36);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "章节标题的检索方式。配置文件为根目录下的.config文件";
            // 
            // RuleShow
            // 
            this.RuleShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RuleShow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RuleShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.RuleShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RuleShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ruleName,
            this.ruleValue});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RuleShow.DefaultCellStyle = dataGridViewCellStyle14;
            this.RuleShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RuleShow.Location = new System.Drawing.Point(3, 45);
            this.RuleShow.MultiSelect = false;
            this.RuleShow.Name = "RuleShow";
            this.RuleShow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.RuleShow.RowTemplate.Height = 23;
            this.RuleShow.Size = new System.Drawing.Size(573, 371);
            this.RuleShow.TabIndex = 2;
            this.RuleShow.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RuleShow_CellMouseUp);
            // 
            // ruleName
            // 
            this.ruleName.FillWeight = 50F;
            this.ruleName.HeaderText = "规则名称";
            this.ruleName.Name = "ruleName";
            // 
            // ruleValue
            // 
            this.ruleValue.FillWeight = 98.47716F;
            this.ruleValue.HeaderText = "规则内容(正则表达式)";
            this.ruleValue.Name = "ruleValue";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SaveData);
            this.panel2.Controls.Add(this.cancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 419);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 31);
            this.panel2.TabIndex = 3;
            // 
            // SaveData
            // 
            this.SaveData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveData.Location = new System.Drawing.Point(420, 5);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(75, 23);
            this.SaveData.TabIndex = 1;
            this.SaveData.Text = "保存";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Location = new System.Drawing.Point(501, 5);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.DeleteLine});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // DeleteLine
            // 
            this.DeleteLine.Name = "DeleteLine";
            this.DeleteLine.Size = new System.Drawing.Size(180, 22);
            this.DeleteLine.Text = "删除该行";
            this.DeleteLine.Click += new System.EventHandler(this.DeleteLine_Click);
            // 
            // TitelRuleSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "TitelRuleSetting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "章节标题检索规则";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TitelRuleSetting_KeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RuleShow)).EndInit();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RuleShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruleValue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ToolStripMenuItem DeleteLine;
    }
}
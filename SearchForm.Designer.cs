
namespace textEdit
{
    partial class SearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.ChangeText = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.OnRe = new System.Windows.Forms.CheckBox();
            this.OnChange = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toUP = new System.Windows.Forms.RadioButton();
            this.toDown = new System.Windows.Forms.RadioButton();
            this.AllChange = new System.Windows.Forms.Button();
            this.ExitSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "查找：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "替换：";
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(69, 5);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(230, 26);
            this.SearchText.TabIndex = 2;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // ChangeText
            // 
            this.ChangeText.Location = new System.Drawing.Point(69, 41);
            this.ChangeText.Name = "ChangeText";
            this.ChangeText.Size = new System.Drawing.Size(230, 26);
            this.ChangeText.TabIndex = 3;
            // 
            // Search
            // 
            this.Search.Enabled = false;
            this.Search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Search.Location = new System.Drawing.Point(305, 5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 4;
            this.Search.Text = "查找";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Change
            // 
            this.Change.Enabled = false;
            this.Change.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Change.Location = new System.Drawing.Point(305, 45);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(75, 23);
            this.Change.TabIndex = 5;
            this.Change.Text = "替换";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // OnRe
            // 
            this.OnRe.AutoSize = true;
            this.OnRe.Location = new System.Drawing.Point(12, 84);
            this.OnRe.Name = "OnRe";
            this.OnRe.Size = new System.Drawing.Size(84, 24);
            this.OnRe.TabIndex = 6;
            this.OnRe.Text = "使用正则";
            this.OnRe.UseVisualStyleBackColor = true;
            // 
            // OnChange
            // 
            this.OnChange.AutoSize = true;
            this.OnChange.Location = new System.Drawing.Point(12, 123);
            this.OnChange.Name = "OnChange";
            this.OnChange.Size = new System.Drawing.Size(84, 24);
            this.OnChange.TabIndex = 7;
            this.OnChange.Text = "开启替换";
            this.OnChange.UseVisualStyleBackColor = true;
            this.OnChange.CheckedChanged += new System.EventHandler(this.OnChange_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toDown);
            this.groupBox1.Controls.Add(this.toUP);
            this.groupBox1.Location = new System.Drawing.Point(130, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 63);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "方向";
            // 
            // toUP
            // 
            this.toUP.AutoSize = true;
            this.toUP.Location = new System.Drawing.Point(10, 27);
            this.toUP.Name = "toUP";
            this.toUP.Size = new System.Drawing.Size(55, 24);
            this.toUP.TabIndex = 0;
            this.toUP.Text = "向上";
            this.toUP.UseVisualStyleBackColor = true;
            // 
            // toDown
            // 
            this.toDown.AutoSize = true;
            this.toDown.Checked = true;
            this.toDown.Location = new System.Drawing.Point(95, 27);
            this.toDown.Name = "toDown";
            this.toDown.Size = new System.Drawing.Size(55, 24);
            this.toDown.TabIndex = 1;
            this.toDown.TabStop = true;
            this.toDown.Text = "向下";
            this.toDown.UseVisualStyleBackColor = true;
            // 
            // AllChange
            // 
            this.AllChange.Enabled = false;
            this.AllChange.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AllChange.Location = new System.Drawing.Point(305, 85);
            this.AllChange.Name = "AllChange";
            this.AllChange.Size = new System.Drawing.Size(75, 23);
            this.AllChange.TabIndex = 9;
            this.AllChange.Text = "全部替换";
            this.AllChange.UseVisualStyleBackColor = true;
            this.AllChange.Click += new System.EventHandler(this.AllChange_Click);
            // 
            // ExitSearch
            // 
            this.ExitSearch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitSearch.Location = new System.Drawing.Point(305, 124);
            this.ExitSearch.Name = "ExitSearch";
            this.ExitSearch.Size = new System.Drawing.Size(75, 23);
            this.ExitSearch.TabIndex = 10;
            this.ExitSearch.Text = "退出";
            this.ExitSearch.UseVisualStyleBackColor = true;
            this.ExitSearch.Click += new System.EventHandler(this.ExitSearch_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 164);
            this.Controls.Add(this.ExitSearch);
            this.Controls.Add(this.AllChange);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OnChange);
            this.Controls.Add(this.OnRe);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ChangeText);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "搜索";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ChangeText;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.CheckBox OnRe;
        private System.Windows.Forms.CheckBox OnChange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton toDown;
        private System.Windows.Forms.RadioButton toUP;
        private System.Windows.Forms.Button AllChange;
        private System.Windows.Forms.Button ExitSearch;
        public System.Windows.Forms.TextBox SearchText;
    }
}
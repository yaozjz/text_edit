
namespace text_edit
{
    partial class searchAndChange
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
            this.onChange = new System.Windows.Forms.CheckBox();
            this.searchRulu = new System.Windows.Forms.TextBox();
            this.changeTxt = new System.Windows.Forms.TextBox();
            this.searchTxt = new System.Windows.Forms.Button();
            this.oneChange = new System.Windows.Forms.Button();
            this.allChange = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDown = new System.Windows.Forms.RadioButton();
            this.rbUP = new System.Windows.Forms.RadioButton();
            this.zeZeOn = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "查找：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "替换：";
            // 
            // onChange
            // 
            this.onChange.AutoSize = true;
            this.onChange.Location = new System.Drawing.Point(12, 132);
            this.onChange.Name = "onChange";
            this.onChange.Size = new System.Drawing.Size(84, 24);
            this.onChange.TabIndex = 4;
            this.onChange.Text = "开启替换";
            this.onChange.UseVisualStyleBackColor = true;
            this.onChange.CheckedChanged += new System.EventHandler(this.onChange_CheckedChanged);
            // 
            // searchRulu
            // 
            this.searchRulu.Location = new System.Drawing.Point(61, 7);
            this.searchRulu.Name = "searchRulu";
            this.searchRulu.Size = new System.Drawing.Size(295, 26);
            this.searchRulu.TabIndex = 6;
            this.searchRulu.TextChanged += new System.EventHandler(this.searchRulu_TextChanged);
            // 
            // changeTxt
            // 
            this.changeTxt.Location = new System.Drawing.Point(61, 60);
            this.changeTxt.Name = "changeTxt";
            this.changeTxt.Size = new System.Drawing.Size(295, 26);
            this.changeTxt.TabIndex = 7;
            // 
            // searchTxt
            // 
            this.searchTxt.Enabled = false;
            this.searchTxt.Font = new System.Drawing.Font("华文细黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchTxt.Location = new System.Drawing.Point(376, 10);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(75, 23);
            this.searchTxt.TabIndex = 8;
            this.searchTxt.Text = "查找";
            this.searchTxt.UseVisualStyleBackColor = true;
            this.searchTxt.Click += new System.EventHandler(this.searchTxt_Click);
            // 
            // oneChange
            // 
            this.oneChange.Enabled = false;
            this.oneChange.Font = new System.Drawing.Font("华文细黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.oneChange.Location = new System.Drawing.Point(376, 50);
            this.oneChange.Name = "oneChange";
            this.oneChange.Size = new System.Drawing.Size(75, 23);
            this.oneChange.TabIndex = 9;
            this.oneChange.Text = "替换";
            this.oneChange.UseVisualStyleBackColor = true;
            this.oneChange.Click += new System.EventHandler(this.oneChange_Click);
            // 
            // allChange
            // 
            this.allChange.Enabled = false;
            this.allChange.Font = new System.Drawing.Font("华文细黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.allChange.Location = new System.Drawing.Point(376, 92);
            this.allChange.Name = "allChange";
            this.allChange.Size = new System.Drawing.Size(75, 23);
            this.allChange.TabIndex = 10;
            this.allChange.Text = "全部替换";
            this.allChange.UseVisualStyleBackColor = true;
            this.allChange.Click += new System.EventHandler(this.allChange_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("华文细黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Location = new System.Drawing.Point(376, 133);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "退出";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDown);
            this.groupBox1.Controls.Add(this.rbUP);
            this.groupBox1.Location = new System.Drawing.Point(144, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 66);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "方向";
            // 
            // rbDown
            // 
            this.rbDown.AutoSize = true;
            this.rbDown.Checked = true;
            this.rbDown.Location = new System.Drawing.Point(113, 27);
            this.rbDown.Name = "rbDown";
            this.rbDown.Size = new System.Drawing.Size(55, 24);
            this.rbDown.TabIndex = 1;
            this.rbDown.TabStop = true;
            this.rbDown.Text = "向下";
            this.rbDown.UseVisualStyleBackColor = true;
            // 
            // rbUP
            // 
            this.rbUP.AutoSize = true;
            this.rbUP.Location = new System.Drawing.Point(18, 27);
            this.rbUP.Name = "rbUP";
            this.rbUP.Size = new System.Drawing.Size(55, 24);
            this.rbUP.TabIndex = 0;
            this.rbUP.TabStop = true;
            this.rbUP.Text = "向上";
            this.rbUP.UseVisualStyleBackColor = true;
            // 
            // zeZeOn
            // 
            this.zeZeOn.AutoSize = true;
            this.zeZeOn.Location = new System.Drawing.Point(12, 102);
            this.zeZeOn.Name = "zeZeOn";
            this.zeZeOn.Size = new System.Drawing.Size(84, 24);
            this.zeZeOn.TabIndex = 13;
            this.zeZeOn.Text = "使用正则";
            this.zeZeOn.UseVisualStyleBackColor = true;
            // 
            // searchAndChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 170);
            this.Controls.Add(this.zeZeOn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.allChange);
            this.Controls.Add(this.oneChange);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.changeTxt);
            this.Controls.Add(this.searchRulu);
            this.Controls.Add(this.onChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "searchAndChange";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "查找与替换";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.searchAndChange_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox onChange;
        private System.Windows.Forms.TextBox changeTxt;
        private System.Windows.Forms.Button searchTxt;
        private System.Windows.Forms.Button oneChange;
        private System.Windows.Forms.Button allChange;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDown;
        private System.Windows.Forms.RadioButton rbUP;
        private System.Windows.Forms.CheckBox zeZeOn;
        public System.Windows.Forms.TextBox searchRulu;
    }
}
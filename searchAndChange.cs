using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace text_edit
{
    public partial class searchAndChange : Form
    {
        public searchAndChange()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void searchAndChange_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void onChange_CheckedChanged(object sender, EventArgs e)
        {
            if (onChange.Checked)
            {
                oneChange.Enabled = true;
                allChange.Enabled = true;
            }
            else
            {
                oneChange.Enabled = false;
                allChange.Enabled = false;
            }
        }
        private void searchRulu_TextChanged(object sender, EventArgs e)
        {
            if (searchRulu.Text != "")
            {
                searchTxt.Enabled = true;
            }
            else
                searchTxt.Enabled = false;
        }
        private void seeks(string str)
        {
            string s_mod;
            if (rbDown.Checked)
                s_mod = rbDown.Text;
            else
                s_mod = rbUP.Text;
            MessageBox.Show(string.Format("{0}查找完毕，没有查找到\"{1}\"!", s_mod, str), "提醒", MessageBoxButtons.OK);
        }

        //正则查找
        private string reFind(RichTextBox rtb, string rule)
        {
            int start_point = rtb.SelectionStart;
            string sub_text;
            if (rbUP.Checked)
                sub_text = rtb.Text.Substring(0, start_point);
            else
            {
                //检查选中状态
                if (rtb.SelectedText.Length > 0)
                    //开始查找位置应该后移
                    start_point += rtb.SelectedText.Length;
                sub_text = rtb.Text.Substring(start_point, rtb.Text.Length - start_point);
            }
            return re.Match(sub_text, rule);

        }
        //获取查找的关键词
        private string getKeyWord(RichTextBox rtb)
        {
            if (zeZeOn.Checked)
                return reFind(rtb, searchRulu.Text);
            else
                return searchRulu.Text;
        }
        //===========参数==============//
        //===========END=================//

        private void searchTxt_Click(object sender, EventArgs e)
        {
            mainFrom f1 = (mainFrom)this.Owner;
            RichTextBox rtb = f1.RBT;
            //获取查找的关键词
            string keyWord = getKeyWord(rtb);
            if (keyWord != "")
            {
                //循环查找
                if (rbUP.Checked)
                    FindUp(rtb, keyWord);
                else
                    FindDown(rtb, keyWord);
                rtb.Focus();
            }
            else
                MessageBox.Show("没有找到匹配项", "提示");
        }

        private void oneChange_Click(object sender, EventArgs e)
        {
            //单次替换
            mainFrom f1 = (mainFrom)this.Owner;
            RichTextBox rtb = f1.RBT;
            string keyWord = "";
            if (searchTxt.Enabled)
            {
                if (rtb.SelectedText.Length > 0)
                {
                    //查找的关键词
                    //如果开启了正则表达式检测模式，则应该确定选中内容是否匹配表达式
                    if (zeZeOn.Checked)
                        keyWord = re.Match(rtb.SelectedText, searchRulu.Text);
                    else
                        keyWord = searchRulu.Text;
                    //判定关键词是否匹配，不匹配应该开启搜索模式
                    if (!rtb.SelectedText.Equals(keyWord, StringComparison.OrdinalIgnoreCase))
                        searchTxt_Click(sender, e);
                }
                else
                    searchTxt_Click(sender, e);
                //替换
                if (rtb.SelectedText.Length > 0)
                    rtb.SelectedText = changeTxt.Text;
            }
            else
                MessageBox.Show("请填写要替换的内容!", "警告", MessageBoxButtons.OK);
        }

        private void allChange_Click(object sender, EventArgs e)
        {
            //全部替换
            mainFrom f1 = (mainFrom)this.Owner;
            RichTextBox rtb = f1.RBT;
            //如果使用了正则表达式，应该找出全部的匹配项
            if (zeZeOn.Checked)
            {
                foreach (Match ma in Regex.Matches(rtb.Text, searchRulu.Text))
                {
                    string keyWord = ma.Value;
                    rtb.Text = rtb.Text.Replace(keyWord, changeTxt.Text);
                }
            }
            else
            {
                rtb.Text = rtb.Text.Replace(searchRulu.Text, changeTxt.Text);
            }
        }

        //查找替换函数
        //
        //向上搜索
        private void FindUp(RichTextBox rtb, string keyWord)
        {
            //获取当前光标位置
            int focus_index = rtb.SelectionStart;
            int index = rtb.Find(keyWord, 0, focus_index, RichTextBoxFinds.Reverse);
            if (index > -1)
            {
                rtb.SelectionStart = index;
                rtb.SelectionLength = keyWord.Length;
            }
            else
                seeks(keyWord);
        }
        //向下搜索
        private void FindDown(RichTextBox rtb, string keyWord)
        {
            //获取当前光标位置
            int focus_index = rtb.SelectionStart;
            //检查选中状态
            if (rtb.SelectedText.Length > 0)
                //开始查找位置应该后移
                focus_index += rtb.SelectedText.Length;
            int index = rtb.Find(keyWord, focus_index, RichTextBoxFinds.None);
            if (index > -1)
            {
                rtb.SelectionStart = index;
                rtb.SelectionLength = keyWord.Length;
            }
            else
                seeks(keyWord);

        }

    }
}

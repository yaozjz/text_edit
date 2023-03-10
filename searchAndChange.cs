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

        /// <summary>
        /// 正则查找
        /// </summary>
        /// <param name="rtb">富文本</param>
        /// <param name="rule">正则表达式</param>
        /// <returns>
        /// 返回int：index，开始索引；match；搜索结果。
        /// </returns>
        private Tuple<int, Match> reFind(RichTextBox rtb, string rule)
        {
            int start_point = rtb.SelectionStart;
            //获取全部文本，加快循环速度
            string[] lines = rtb.Lines;
            //获取当前所在行数
            int line_index = rtb.GetLineFromCharIndex(start_point);
            //返回的结果
            Match result = Regex.Match(" ", "0");
            int index = rtb.GetFirstCharIndexFromLine(line_index);
            if (rbUP.Checked)
            {
                //获取截至光标所在的所有文本
                string text = rtb.Text.Substring(0, start_point);
                for (int len = 1; len <= start_point; len++)
                {
                    int start_char_index = start_point - len;
                    string input_text = text.Substring(start_char_index, len);
                    result = Regex.Match(input_text, rule);
                    if (result.Success)
                    {
                        index = start_char_index;
                        break;
                    }
                }
            }
            //向下搜索
            else
            {
                //检查选中状态
                if (rtb.SelectedText.Length > 0)
                    //开始查找位置应该后移
                    start_point += rtb.SelectedText.Length;
                string line = lines[line_index];
                if (line.Length > 0 && start_point + 1 < line.Length)
                {
                    result = Regex.Match(line.Substring(start_point, line.Length - start_point), rule);
                    if (result.Success)
                        index += start_point + result.Index;
                }
                else if (lines.Length > line_index + 1)
                {
                    result = Regex.Match(lines[++line_index], rule);
                    if (result.Success)
                        index = rtb.GetFirstCharIndexFromLine(line_index) + result.Index;
                }
                if (!result.Success)
                {
                    for (int i = line_index; i < lines.Length; i++)
                    {
                        //Console.WriteLine(lines[i]);
                        result = Regex.Match(lines[i], rule);
                        if (result.Success)
                        {
                            index = rtb.GetFirstCharIndexFromLine(i) + result.Index;
                            break;
                        }
                    }
                }
            }
            return new Tuple<int, Match>(index, result);
            //返回关键词的查找结果
        }
        //===========参数==============//
        //===========END=================//

        private void searchTxt_Click(object sender, EventArgs e)
        {
            mainFrom f1 = (mainFrom)this.Owner;
            RichTextBox rtb = f1.RBT;
            //获取查找的关键词
            if (zeZeOn.Checked)
            {
                try
                {
                    Tuple<int, Match> result = reFind(rtb, searchRulu.Text);
                int index = result.Item1;
                Match r = result.Item2;
                if (r.Success)
                {
                    rtb.SelectionStart = index;
                    rtb.SelectionLength = r.Value.Length;
                }
                else
                    MessageBox.Show("没有找到匹配项", "提示");
            }
                catch (Exception ex)
            {
                MessageBox.Show("错误:" + ex.Message);
            }
        }
            else
            {
                //循环查找
                if (rbUP.Checked)
                    FindUp(rtb, searchRulu.Text);
                else
                    FindDown(rtb, searchRulu.Text);
            }
            rtb.Focus();
        }

        private void oneChange_Click(object sender, EventArgs e)
        {
            //单次替换
            mainFrom f1 = (mainFrom)this.Owner;
            RichTextBox rtb = f1.RBT;
            string keyWord;
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
                {
                    rtb.SelectedText = changeTxt.Text;
                }
            }
            else
                MessageBox.Show("请填写要替换的内容!", "警告", MessageBoxButtons.OK);
        }

        private void allChange_Click(object sender, EventArgs e)
        {
            //全部替换
            mainFrom f1 = (mainFrom)this.Owner;
            RichTextBox rtb = f1.RBT;
            if (zeZeOn.Checked)
            {
                StringBuilder sb = new StringBuilder(Regex.Replace(rtb.Text, searchRulu.Text, changeTxt.Text));
                rtb.Text = sb.ToString();
                sb.Clear();
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

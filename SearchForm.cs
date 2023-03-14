using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace textEdit
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        //=======关闭窗体
        private void ExitSearch_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        //======关闭窗体END
        //替换启用
        private void OnChange_CheckedChanged(object sender, EventArgs e)
        {
            Change.Enabled = OnChange.Checked;
            AllChange.Enabled = OnChange.Checked;
        }
        //不允许空白查找
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            if (SearchText.Text != "")
                Search.Enabled = true;
            else
                Search.Enabled = false;
        }
        //查找
        private void Search_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.Owner;
            RichTextBox tb = f1.TB;
            //获取查找的关键词
            string rule = SearchText.Text;
            if (OnRe.Checked)
            {
                //正则查找
                try
                {
                    Tuple<int, Match> r = Find.ReFind(tb, rule, toUP.Checked);
                    int index = r.Item1;
                    Match result = r.Item2;
                    if (result.Success)
                    {
                        //匹配成功
                        tb.SelectionStart = index;
                        tb.SelectionLength = result.Value.Length;
                        tb.ScrollToCaret();
                    }
                    else//匹配失败
                        MessageBox.Show("搜索结束，没有找到匹配项", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误:" + ex.Message);
                }
            }
            //常规查找
            else
            {
                if (toUP.Checked)
                    Find.FindUP(tb, rule);
                else
                    Find.FindDown(tb, rule);
            }
            tb.Focus();
        }
        //单次替换
        private void Change_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.Owner;
            RichTextBox tb = f1.TB;
            string keyWord;
            if (tb.SelectedText.Length > 0)
            {
                //查找的关键词
                //如果开启了正则表达式检测模式，则应该确定选中内容是否匹配表达式
                if (OnRe.Checked)
                    keyWord = Regex.Match(tb.SelectedText, SearchText.Text).Value;
                else
                    keyWord = SearchText.Text;
                //判定关键词是否匹配，不匹配应该开启搜索模式
                if (!tb.SelectedText.Equals(keyWord, StringComparison.OrdinalIgnoreCase))
                    Search_Click(sender, e);
            }
            else
                Search_Click(sender, e);
            //替换
            if (tb.SelectedText.Length > 0)
            {
                tb.SelectedText = ChangeText.Text;
            }

        }
        //全部替换
        private void AllChange_Click(object sender, EventArgs e)
        {
            //全部替换
            Form1 f1 = (Form1)this.Owner;
            RichTextBox tb = f1.TB;
            if (OnRe.Checked)
            {
                StringBuilder sb = new StringBuilder(Regex.Replace(tb.Text, SearchText.Text, ChangeText.Text));
                tb.Text = sb.ToString();
                sb.Clear();
            }
            else
            {
                tb.Text = tb.Text.Replace(SearchText.Text, ChangeText.Text);
            }
        }


    }
}

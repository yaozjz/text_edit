using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace textEdit
{
    class Find
    {
        //正则使用的关键标点符号
        //public static string[] ExcludeList = { "$", "(", ")", "*", "+", ".", "[", "?", @"\", "^", "{", "|" };
        public static List<string> ExcludeList = new List<string> { @"\", "$", "(", ")", "*", "+", ".", "[", "?", "^", "{", "|" };
        public static string GetNoRe(string oldStr)
        {
            string newStr = oldStr;
            foreach (string key in ExcludeList)
            {
                newStr = newStr.Replace(key, @"\" + key);
            }
            return newStr;
        }
        /// <summary>
        /// 正则查找算法
        /// </summary>
        /// <param name="tb">富文本</param>
        /// <param name="rule">查找规则或关键词</param>
        /// <param name="isFindUP">是否为向上搜索</param>
        /// <returns>返回inde为关键词位于textbox的开头的索引以及正则搜索结果Match</returns>
        public static Tuple<int, Match> ReFind(RichTextBox tb, string rule, bool isFindUP)
        {
            int start_point = tb.SelectionStart;
            //按行获取文本，加快循环速度
            string[] lines = tb.Lines;
            //获取当前所在行数
            int line_index = tb.GetLineFromCharIndex(start_point);
            //返回的结果
            Match result = Regex.Match(" ", "0");
            int index = tb.GetFirstCharIndexFromLine(line_index);
            if (isFindUP)
            {
                //获取截至光标所在的所有文本
                string text = tb.Text.Substring(0, start_point);
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
                if (tb.SelectedText.Length > 0)
                    //开始查找位置应该后移
                    start_point += tb.SelectedText.Length;
                //获取从光标开始的后面的所有文本
                string text = tb.Text.Substring(start_point);
                result = Regex.Match(text, rule);
                index = start_point + result.Index;
            }

            return new Tuple<int, Match>(index, result);
        }

        public static void FindUP(RichTextBox rtb, string keyWord)
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
                MessageBox.Show("搜索完毕，没有找到" + keyWord, "提示");
        }

        public static void FindDown(RichTextBox rtb, string keyWord)
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
                MessageBox.Show("搜索完毕，没有找到" + keyWord, "提示");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Configuration;

namespace text_edit
{
    public partial class mainFrom : Form
    {
        public mainFrom()
        {
            InitializeComponent();
            //文本拖拽导入功能
            richTextBox1.AllowDrop = true;
            richTextBox1.DragEnter += new DragEventHandler(richTextBox1_DragEnter);
            richTextBox1.DragDrop += new DragEventHandler(richTextBox1_DragDrop);
            //初始化常见章节套路
            //从文件中读取

            try
            {
                FileStream fs = new FileStream("./rule.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] strArry = line.Split('=');
                    usualRule.Add(strArry[1]);
                    usualTitle.Items.Add(strArry[0]);
                    line = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
            }
            catch
            {
                showMessage("文章规则文件无法索引，请放置rule.txt文件到软件根目录下。");
            }
            //加载段落格式
            DuanMo.Text = ConfigurationManager.AppSettings["DuanMo"];
        }
        //=============参数===========//

        //常用章节名称正则表达式
        private List<string> usualRule = new List<string>();

        //================常用函数=================//
        private void richTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            //处理拖放事件
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }
        private void richTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            //防止多个文件拖拽，只取第一个文件显示
            Array arrayFileName = (Array)e.Data.GetData(DataFormats.FileDrop);
            string strFileName = arrayFileName.GetValue(0).ToString();
            string[] strSlipt = strFileName.Split('.');
            string formatStr = strSlipt[strSlipt.Length - 1];
            if (formatStr == "txt")
                OpenEcode(strFileName);
            else
                showMessage("不支持打开该格式文件");
        }
        //清除日志记录
        private void clearMessage_Click(object sender, EventArgs e)
        {
            messageBox.Text = "";
        }
        //添加信息
        private void showMessage(string msg)
        {
            messageBox.AppendText(msg + "\r\n");
        }

        private void OpenEcode(string fileName)
        {
            filePath.Text = fileName;
            Encoding ecode = TextFormat.GetTextFileEncodingType(fileName);
            coding_fun.Text = ecode.BodyName;
            string[] arr = new string[2] { fileName, coding_fun.Text };
            Thread t = new Thread(ThreadProc);
            t.IsBackground = true;
            t.Start(arr);

        }
        //==========委托
        private void ThreadProc(object arr)
        {
            bool stopFlag = false;
            try
            {
                string[] arrStr = arr as string[];
                //richTextBox1.LoadFile(fileName, RichTextBoxStreamType.PlainText);
                FileStream fs = new FileStream(arrStr[0], FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, Encoding.GetEncoding(arrStr[1]));

                string line = sr.ReadLine();
                StringBuilder sb = new StringBuilder();

                //按行更新
                int maxDisplayline = 1 * 3000; // 1000行
                //清空当前的文本
                this.Invoke((EventHandler)delegate
                {
                    richTextBox1.Text = "";
                    richTextBox1.Focus();
                });

                int i = 0;
                while (line != null)
                {
                    if (stopFlag)
                        return;
                    sb = sb.Append(line + "\n");
                    if (i > 0 && i % maxDisplayline == 0)
                    {
                        this.Invoke((EventHandler)delegate
                        {
                            richTextBox1.AppendText(sb.ToString());
                        });
                        sb.Clear();
                        //maxDisplayline = maxDisplayline * ((int)Math.Sqrt(i / maxDisplayline));
                    }
                    line = sr.ReadLine();
                    i++;
                }
                if (sb.Length > 0)
                {
                    this.Invoke((EventHandler)delegate
                    {
                        richTextBox1.AppendText(sb.ToString());
                    });
                    sb.Clear();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                stopFlag = true;
                this.Invoke((EventHandler)delegate
                {
                    messageBox.AppendText("打开失败，请选择合适的文件。\n错误信息:" + ex.Message + "\r\n");
                });
            }
        }
        //============END
        //刷新当前聚焦的行数
        private void fresh_index()
        {
            int foucusIndex = richTextBox1.SelectionStart;
            Now_index.Text = "第" + (richTextBox1.GetLineFromCharIndex(foucusIndex) + 1) + "行";
        }
        //获取当前字体格式
        private void get_font_set()
        {
            txt_font.Text = richTextBox1.Font.Name + " " + richTextBox1.Font.Size + "pt";
        }
        //路径空白判断
        private bool PathNoNull()
        {
            if (filePath.Text == "")
            {
                //showMessage("当前没有打开任何文件！");
                return false;
            }
            else
            {
                return true;
            }
        }
        //保存
        private void saveTxt()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "文本文件";
            dlg.DefaultExt = ".txt";
            dlg.Filter = "保存当前文本|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string saveFileName = dlg.FileName;
                try
                {
                    FileStream fs = new FileStream(saveFileName, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(coding_fun.Text));
                    sw.Write(richTextBox1.Text);
                    sw.Close();
                    fs.Close();
                    showMessage("已保存到:" + saveFileName);
                    filePath.Text = saveFileName;
                }
                catch (Exception ex)
                {
                    showMessage("Error:" + ex.Message);
                }
            }
        }

        //快速保存
        private void Q_Save_Txt()
        {
            if (filePath.Text != "")
            {
                FileStream fs = new FileStream(filePath.Text, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(coding_fun.Text));
                sw.Write(richTextBox1.Text);
                sw.Close();
                fs.Close();
                showMessage("快速保存完成。");
            }
            else
            {
                saveTxt();
            }
        }
        //查找
        private void SAC_From_opening()
        {
            Form ascForm = Application.OpenForms["searchAndChange"];

            if ((ascForm == null) || (ascForm.IsDisposed))
            {
                searchAndChange sac = new searchAndChange();
                if (richTextBox1.SelectedText.Length > 0)
                    sac.searchRulu.Text = richTextBox1.SelectedText;
                sac.Show(this);
            }
            else
            {
                ascForm.Activate();
                ascForm.WindowState = FormWindowState.Normal;
            }
        }

        /// 快捷键
        private void mainFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                if (e.KeyCode == Keys.S)
                    //ctrl+s 快捷保存
                    Q_Save_Txt();
                else if (e.KeyCode == Keys.F)
                    SAC_From_opening();
                else if (e.KeyCode == Keys.O)
                    openText_Click(sender, e);
            }
        }
        //=========


        //=========
        //
        public RichTextBox RBT
        {
            get { return richTextBox1; }
            set { richTextBox1 = value; }
        }

        //============== END==================//
        private void openText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openTxt = new OpenFileDialog();
            openTxt.Filter = "文本文件|*.txt";
            if (openTxt.ShowDialog() == DialogResult.OK)
            {
                string fileName = openTxt.FileName;
                //打开文件并显示
                OpenEcode(fileName);

            }
            //释放窗口
            openTxt.Dispose();
        }

        private void exitSystem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        //保存文本
        private void saveText_Click(object sender, EventArgs e)
        {
            saveTxt();
        }
        //搜索
        private void searchText_Click(object sender, EventArgs e)
        {
            SAC_From_opening();
        }
        //字体设置
        private void geShiSet_Click(object sender, EventArgs e)
        {
            FontDialog font_set = new FontDialog();
            font_set.ShowColor = true;
            font_set.Font = richTextBox1.Font;
            font_set.Color = richTextBox1.ForeColor;
            if (font_set.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = font_set.Font;
                richTextBox1.ForeColor = font_set.Color;
            }
            font_set.Dispose();
            get_font_set();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            fresh_index();
        }

        //窗体运行事件
        private void mainFrom_Activated(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            fresh_index();
            get_font_set();
        }

        //private void toGB2312_Click(object sender, EventArgs e)
        //{
        //    toUTF8.Checked = false;
        //    toGB18030.Checked = false;
        //    toGB2312.Checked = true;
        //    string Ecoding_func = "gb2312";
        //    if (PathNoNull())
        //        OpenEcode(filePath.Text, Ecoding_func);
        //    else
        //        coding_fun.Text = Ecoding_func;
        //}

        private void saveBt_Click(object sender, EventArgs e)
        {
            Q_Save_Txt();
        }
        //关于
        private void aboutBt_Click(object sender, EventArgs e)
        {
            about ab = new about();
            ab.Show();
        }

        private void clearNullLine_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text = Regex.Replace(richTextBox1.Text, @"((?s)\n\s*\n)", "\n");
            StringBuilder sb = new StringBuilder();
            foreach (string line in richTextBox1.Lines)
            {
                if (line.Length > 0 && !Regex.Match(line, @"^\s*$").Success)
                    sb.Append(line + "\n");
            }
            richTextBox1.Text = sb.ToString();
            sb.Clear();
        }

        private void autoEnter_CheckedChanged(object sender, EventArgs e)
        {
            if (autoEnter.Checked)
                richTextBox1.WordWrap = true;
            else
                richTextBox1.WordWrap = false;
        }

        private void autoEnter_Click(object sender, EventArgs e)
        {
            autoEnter.Checked = !autoEnter.Checked;
        }

        //去除文本中的全部空白
        private void clearNull_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Replace(" ", "");
            richTextBox1.Focus();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //去除粘贴时的文本格式
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true;//屏蔽Ctrl+ V组合按键

                DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Text);
                richTextBox1.Paste(myFormat);
            }
        }

        private void clearTN_Click(object sender, EventArgs e)
        {
            //去除开头结尾的空格
            StringBuilder sb = new StringBuilder();
            foreach (string i in richTextBox1.Lines)
            {
                sb.Append(i.Trim() + "\n");
            }
            richTextBox1.Text = sb.ToString();
            sb.Clear();
        }

        private void clearLineN_Click(object sender, EventArgs e)
        {
            //去除当前行空格
            int focus_index = richTextBox1.SelectionStart;
            int line_index = richTextBox1.GetLineFromCharIndex(focus_index);
            int start_index = richTextBox1.GetFirstCharIndexFromLine(line_index);
            string line = richTextBox1.Lines[line_index];
            //修改当前行内容
            line = line.Replace(" ", "");
            richTextBox1.SelectionStart = start_index;
            richTextBox1.SelectionLength = richTextBox1.Lines[line_index].Length;
            richTextBox1.SelectedText = line;
        }

        private void autoParagraph_Click(object sender, EventArgs e)
        {
            //自动整理段落
            StringBuilder sb = new StringBuilder();
            string duanluo = "";
            if (unitFromat_txt.Text.Length <= 0)
                if (MessageBox.Show("确认已填入章节索引模式？", "提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;
            foreach (string line in richTextBox1.Lines)
            {
                //空行不保留
                if (line.Length <= 0)
                    continue;
                duanluo += line;
                //检查是否为章节列
                Match result = Regex.Match(line, unitFromat_txt.Text);
                if (result.Success && unitFromat_txt.Text != "")
                {
                    string qiege = duanluo.Substring(0, duanluo.Length - line.Length);
                    if (qiege.Length > 0)
                        sb.Append(qiege + "\n");
                    duanluo = "";
                    if (aloneLine.Checked)
                        sb.Append("\n" + line + "\n\n");
                    else
                    {
                        sb.Append("\n" + result.Value + "\n\n" + line.Substring(result.Value.Length));
                    }
                }
                //不是就检查末尾的符号，包括
                else if (Regex.Match(line, DuanMo.Text).Success)
                {
                    sb.Append(duanluo + "\n");
                    duanluo = "";
                }
            }
            richTextBox1.Text = sb.ToString();
            sb.Clear();
        }
        //==============
        //===============
        private void checkTitle_Click(object sender, EventArgs e)
        {
            //检查章节是否正确
            foreach (string i in richTextBox1.Lines)
            {
                //检查行中是否存在章节名称
                string result = re.Match(i, unitFromat_txt.Text);
                if (result != "")
                {
                    if (aloneLine.Checked)
                        showMessage(i);
                    else
                        showMessage(result);
                }
            }
        }

        private void insertTileRule_Click(object sender, EventArgs e)
        {
            //填入常见段落形式
            unitFromat_txt.Text = usualRule[usualTitle.SelectedIndex];
        }
        //一键整理标题
        private void makeTitle_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string line_temp;
            foreach (string line in richTextBox1.Lines)
            {
                line_temp = line;
                //检查行中是否存在章节名称
                Match result = Regex.Match(line, unitFromat_txt.Text);
                if (result.Success)
                {
                    if (aloneLine.Checked)
                        //文章标题单独一行
                        line_temp = "\n" + line + "\n";
                    else
                        //格式错乱，只分割出章节
                        line_temp = "\n" + result.Value + "\n\n" + line.Substring(result.Value.Length);
                }
                sb.Append(line_temp + "\n");
            }
            richTextBox1.Text = sb.ToString();
            sb.Clear();
        }
        //保存段落结尾形式到本地
        private void saveJuMo_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["DuanMo"].Value = DuanMo.Text;
            config.AppSettings.SectionInformation.ForceSave = true;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            showMessage("段落设置保存成功!");
        }
    }
}

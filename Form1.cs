using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace textEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mainText.LanguageOption = RichTextBoxLanguageOptions.UIFonts; //防止中英文字体不一致
            //文本拖拽导入功能
            mainText.AllowDrop = true;
            mainText.DragEnter += new DragEventHandler(mainText_DragEnter);
            mainText.DragDrop += new DragEventHandler(mainText_DragDrop);
            //初始化常见章节套路
            //从文件中读取
            FreshTitleRule();
            //加载段落格式
            DuanWei.Text = Properties.Settings.Default.DuanWei;
        }
        //=============参数===========//

        //常用章节名称正则表达式
        private List<string> ruleList = new List<string>();
        public RichTextBox TB
        {
            get { return mainText; }
            set { mainText = value; }
        }
        //==============参数END==============//
        //规则索引刷新
        private void FreshTitleRule()
        {
            ruleList.Clear();
            usualTitle.Items.Clear();
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                foreach (string keys in config.AppSettings.Settings.AllKeys)
                {
                    ruleList.Add(config.AppSettings.Settings[keys].Value.ToString());
                    usualTitle.Items.Add(keys);
                }
                usualTitle.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("\n这是配置文件引发的错误，建议检查软件的.config文件，确认appSetting的节点为非空。" + ex.Message);
            }
        }
        //拖拽打开
        private void mainText_DragEnter(object sender, DragEventArgs e)
        {
            //处理拖放事件
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }
        private void mainText_DragDrop(object sender, DragEventArgs e)
        {
            //防止多个文件拖拽，只取第一个文件显示
            Array arrayFileName = (Array)e.Data.GetData(DataFormats.FileDrop);
            string strFileName = arrayFileName.GetValue(0).ToString();
            string[] strSlipt = strFileName.Split('.');
            string formatStr = strSlipt[strSlipt.Length - 1];
            if (formatStr == "txt")
                OpenEcode(strFileName);
            else
                MessageBox.Show("不支持打开该格式");
        }
        //===============常用函数===========//
        //刷新当前聚焦的行数
        private void fresh_index()
        {
            int foucusIndex = mainText.SelectionStart;
            nowLine.Text = "第" + (mainText.GetLineFromCharIndex(foucusIndex) + 1) + "行";
        }
        //打开txt文件
        private void OpenEcode(string fileName)
        {
            filePath.Text = fileName;
            Encoding ecode = TextFormat.GetTextFileEncodingType(fileName);
            codingName.Text = ecode.BodyName;
            //文件流
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, Encoding.GetEncoding(ecode.BodyName));

                string line = sr.ReadLine();
                StringBuilder sb = new StringBuilder();
                while (line != null)
                {
                    sb.Append(line + Environment.NewLine);
                    line = sr.ReadLine();
                }
                mainText.Text = sb.ToString();
                sb.Clear();
                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            //清空表格
            dataGridView1.Rows.Clear();
        }
        //正常保存
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
                    StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(codingName.Text));
                    sw.Write(mainText.Text);
                    sw.Close();
                    fs.Close();
                    filePath.Text = saveFileName;
                    fileStatus.Text = "文件路径：";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }
        //快速保存
        private void Q_Save_Txt()
        {
            if (filePath.Text != "")
            {
                FileStream fs = new FileStream(filePath.Text, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(codingName.Text));
                sw.Write(mainText.Text);
                sw.Close();
                fs.Close();
                fileStatus.Text = "文件路径：";
            }
            else
            {
                saveTxt();
            }
        }
        //章节显示
        private void showMessage(int line_index, string ttName)
        {
            string[] msg = { line_index.ToString(), ttName };
            dataGridView1.Rows.Add(msg);
        }
        //获取当前字体格式
        private void get_font_set()
        {
            FontStatus.Text = mainText.Font.Name + " " + mainText.Font.Size + "pt";
        }
        //查找常用函数
        private void SAC_From_Opening()
        {
            Form ascForm = Application.OpenForms["SearchForm"];

            if ((ascForm == null) || (ascForm.IsDisposed))
            {
                SearchForm sac = new SearchForm();
                if (mainText.SelectedText.Length > 0)
                    sac.SearchText.Text = mainText.SelectedText;
                sac.Show(this);
            }
            else
            {
                ascForm.Activate();
                ascForm.WindowState = FormWindowState.Normal;
            }
        }
        //===============常用函数END=========//
        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //打开文件
        private void openFile_Click(object sender, EventArgs e)
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
        //快速保存按钮
        private void quickSave_Click(object sender, EventArgs e)
        {
            Q_Save_Txt();
        }
        //另存为按钮
        private void otherSave_Click(object sender, EventArgs e)
        {
            saveTxt();
        }
        //自动换行设计========
        private void AutoEnter_Click(object sender, EventArgs e)
        {
            AutoEnter.Checked = !AutoEnter.Checked;
        }

        private void AutoEnter_CheckedChanged(object sender, EventArgs e)
        {
            mainText.WordWrap = AutoEnter.Checked;
        }
        //自动换行设计结束========
        //填入常用章节形式
        private void usualTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleRule.Text = ruleList[usualTitle.SelectedIndex];
        }
        //检查章节
        private void CheckedTitle_Click(object sender, EventArgs e)
        {
            //清空表格
            dataGridView1.Rows.Clear();
            //检查章节是否正确
            int i = 0;
            foreach (string line in mainText.Lines)
            {
                //检查行中是否存在章节名称
                Match result = Regex.Match(line, TitleRule.Text);
                if (result.Success)
                {
                    if (TitleIsAlone.Checked)
                        showMessage(i, line);
                    else
                        showMessage(i, result.Value);
                }
                i++;
            }
        }
        //保存段末形式到本地
        private void saveDuanWei_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.DuanWei = DuanWei.Text;
                MessageBox.Show("段落设置保存成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //双击定位章节
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //获取行数
                int select_index = dataGridView1.CurrentRow.Index;
                string index_str = dataGridView1.Rows[select_index].Cells["linesIndex"].Value.ToString();
                try
                {
                    int line_index = int.Parse(index_str);
                    //自动换行后，richtextbox的真实行数不等于原来的行数，因此需要先关掉自动换行，再将光标移动到章节所在行
                    if (mainText.WordWrap)
                        mainText.WordWrap = false;
                    mainText.SelectionStart = mainText.GetFirstCharIndexFromLine(line_index);
                    mainText.Focus();
                    //如果之前是开启了自动换行，则此时应该将变换状态转换回去
                    mainText.WordWrap = AutoEnter.Checked;
                    mainText.ScrollToCaret();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error");
                }
            }
        }
        //窗体激活
        private void Form1_Activated(object sender, EventArgs e)
        {
            mainText.Focus();
            fresh_index();
            get_font_set();
            timer1.Start();
        }
        //刷新当前光标所在行
        private void timer1_Tick(object sender, EventArgs e)
        {
            fresh_index();
        }
        //不作为活动窗口时关闭计时器
        private void Form1_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        //字体设置
        private void FontSetting_Click(object sender, EventArgs e)
        {
            FontDialog font_set = new FontDialog();
            font_set.ShowColor = true;
            font_set.Font = mainText.Font;
            font_set.Color = mainText.ForeColor;
            if (font_set.ShowDialog() == DialogResult.OK)
            {
                mainText.Font = font_set.Font;
                mainText.ForeColor = font_set.Color;
            }
            font_set.Dispose();
            get_font_set();
        }
        //关于
        private void about_Click(object sender, EventArgs e)
        {
            //关于
            about ab = new about();
            ab.Show();
        }
        //去除空行
        private void ClearNullLine_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string line in mainText.Lines)
            {
                if (line.Length > 0 && !Regex.Match(line, @"^\s*$").Success)
                    sb.Append(line + Environment.NewLine);
            }
            mainText.Text = sb.ToString();
            sb.Clear();
        }
        //去除开头结尾的空格
        private void TextTrim_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string i in mainText.Lines)
            {
                //sb.Append(i.Trim() + "\n");
                string temp1 = Regex.Replace(i, @"^\s+", "");
                temp1 = Regex.Replace(temp1, @"\s+$", "");
                sb.Append(temp1 + Environment.NewLine);
            }
            mainText.Text = sb.ToString();
            sb.Clear();
        }
        //自动整理段落
        private void ParaFormat_Click(object sender, EventArgs e)
        {
            //自动整理段落
            StringBuilder sb = new StringBuilder();
            string duanluo = "";
            if (TitleRule.Text.Length <= 0)
                if (MessageBox.Show("确认已填入章节索引模式？", "提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;
            foreach (string line in mainText.Lines)
            {
                //空行不保留
                if (Regex.Match(line, @"^\s*$").Success)
                    continue;
                duanluo += line;
                //检查是否为章节列
                Match result = Regex.Match(line, TitleRule.Text);
                if (result.Success && TitleRule.Text != "")
                {
                    string qiege = duanluo.Substring(0, duanluo.Length - line.Length);
                    if (qiege.Length > 0)
                        sb.Append(qiege + Environment.NewLine);
                    duanluo = "";
                    if (TitleIsAlone.Checked)
                        sb.Append(Environment.NewLine + line + Environment.NewLine + Environment.NewLine);
                    else
                    {
                        sb.Append(Environment.NewLine + result.Value + Environment.NewLine + Environment.NewLine + line.Substring(result.Value.Length));
                    }
                }
                //不是就检查末尾的符号，包括
                else if (Regex.Match(line, DuanWei.Text).Success)
                {
                    sb.Append(duanluo + Environment.NewLine);
                    duanluo = "";
                }
            }
            if (duanluo.Length > 0)
                sb.Append(duanluo);
            mainText.Text = sb.ToString();
            sb.Clear();
        }
        //去除全部空白
        private void ClearAllSpace_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(Regex.Replace(mainText.Text, @"[\t \f]", ""));
            mainText.Text = sb.ToString();
            sb.Clear();
        }

        private void mainText_TextChanged(object sender, EventArgs e)
        {
            fileStatus.Text = "*文件路径：";
        }

        private void search_Click(object sender, EventArgs e)
        {
            SAC_From_Opening();
        }
        //右键复制
        private void CopyText_Click(object sender, EventArgs e)
        {
            mainText.Copy();
        }
        //右键粘贴
        private void PasteText_Click(object sender, EventArgs e)
        {
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Text);
            mainText.Paste(myFormat);
        }
        //设置打开方式
        private void Form1_Load(object sender, EventArgs e)
        {
            string command = Environment.CommandLine;//获取进程命令行参数
            string[] para = command.Split('\"');
            if (para.Length > 3)
            {
                string fileName = para[3];//获取打开的文件的路径
                //下面就可以自己编写代码使用这个pathC参数了
                //FileStream fs = new FileStream(pathC, FileMode.Open, FileAccess.Read);
                OpenEcode(fileName);
            }
        }
        //设置
        private void TitelSetting_Click(object sender, EventArgs e)
        {
            TitelRuleSetting trs = new TitelRuleSetting();
            if (trs.ShowDialog() == DialogResult.OK)
            {
                FreshTitleRule();
                //刷新文本
                TitleRule.Text = ruleList[usualTitle.SelectedIndex];
            }
            trs.Dispose();
        }
        //==

    }
}

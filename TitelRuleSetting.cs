using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textEdit
{
    public partial class TitelRuleSetting : Form
    {
        public TitelRuleSetting()
        {
            InitializeComponent();
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                foreach (string keys in config.AppSettings.Settings.AllKeys)
                {
                    ShowRule(keys, config.AppSettings.Settings[keys].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("配置文件打开出错。" + ex.Message);
            }
        }
        //=========参数
        int index = -1;
        //===========参数END
        //列表更新
        private void ShowRule(string key, string value)
        {
            string[] msg = { key, value };
            RuleShow.Rows.Add(msg);
        }
        //取消
        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        //保存数据
        private void SaveData_Click(object sender, EventArgs e)
        {
            //获取Configuration对象
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            foreach (string keys in config.AppSettings.Settings.AllKeys)
            {
                config.AppSettings.Settings.Remove(keys);
            }
            int rows_count = RuleShow.Rows.Count;
            for (int i = 0; i < rows_count; i++)
            {
                try
                {
                    object _key = RuleShow.Rows[i].Cells[0].Value;
                    object _value = RuleShow.Rows[i].Cells[1].Value;
                    if(_key != null && _value != null)
                    {
                        config.AppSettings.Settings.Add(_key.ToString(), _value.ToString());
                    }
                }
                catch
                {
                    continue;
                }
            }
            //一定要记得保存，写不带参数的config.Save()也可以
            config.Save(ConfigurationSaveMode.Modified);
            //刷新，否则程序读取的还是之前的值（可能已装入内存）
            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show("保存成功！");
            //退出窗口
            this.DialogResult = DialogResult.OK;
        }
        //删除行
        private void DeleteLine_Click(object sender, EventArgs e)
        {
            if(!RuleShow.Rows[index].IsNewRow && index > -1)
            {
                RuleShow.Rows.RemoveAt(index);                
            }
        }
        //右键确定行
        private void RuleShow_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                index = e.RowIndex;
                RuleShow.Rows[index].Selected = true;
                RuleShow.CurrentCell = RuleShow.Rows[index].Cells[0];
                contextMenuStrip1.Show(RuleShow, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
        //快捷键退出
        private void TitelRuleSetting_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                cancel_Click(sender, e);
            }
        }

    }
}

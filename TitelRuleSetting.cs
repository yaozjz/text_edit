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
            catch(Exception ex)
            {
                MessageBox.Show("配置文件打开出错。" + ex.Message);
            }
        }
        private void ShowRule(string key, string value)
        {
            string[] msg = { key, value };
            RuleShow.Rows.Add(msg);
        }
    }
}

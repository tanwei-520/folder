using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace folder
{
    public partial class MonitorFolder : Form
    {
        public MonitorFolder()
        {
            InitializeComponent();
            Cpublic.log.Info("启动监听文件夹菜单");
        }
    }
}

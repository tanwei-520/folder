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
using log4net;
using log4net.Config;


namespace folder
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Cpublic.log.Info("程序启动");
        }

        private void 批量新建文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            NewFolder f = new NewFolder
            {
                MdiParent = this
            };
            f.Show();
        }

        private void 监听文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            MonitorFolder f = new MonitorFolder
            {
                MdiParent = this
            };
            f.Show();
        }

        private void 监听文件夹ToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
           
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cpublic.log.Info("程序关闭");
        }
    }
}

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
using System.Management;

namespace folder
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.ShowInTaskbar = true;
            Cpublic.log.Info("程序启动");
            if (Properties.Settings.Default.id!="TW")
            {
                string s = Properties.Settings.Default.id;
                Cpublic.log.Info(s);
                    MessageBox.Show("注册码错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Environment.Exit(0);
            }
            // Environment.Exit(0);
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
            // f.Dock = DockStyle.Fill;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cpublic.log.Info("程序关闭");
        }

        private void Main_MinimumSizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //隐藏任务栏区图标
                this.ShowInTaskbar = false;
                //图标显示在托盘区
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //把最小化的窗体显示出来
                WindowState = FormWindowState.Normal;
                //激活窗体并赋予焦点
                //ss this.Activate();
                //任务栏区显示图标
                //this.ActiveMdiChild.Close();
                // ActiveMdiChild.WindowState = FormWindowState.Maximized;
                this.ShowInTaskbar = true;
                //托盘区图标隐藏
                notifyIcon1.Visible = true;
            }
            else
            {
                this.Activate();
                //将窗体前置
                this.TopMost = true;
                //解除窗体前置
                this.TopMost = false;
                //任务栏区显示图标
                this.ShowInTaskbar = true;
                //托盘区图标隐藏
                notifyIcon1.Visible = true;
            }
        }

        private void 显示程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            //将窗体显示出来
            WindowState = FormWindowState.Normal;
        }
        private void 退出程序ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // 关闭所有的线程
            Cpublic.log.Info("程序关闭");
            this.Dispose();
            this.Close();
        }

        private void 保持最前ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.保持最前ToolStripMenuItem.Checked)
            {
                //解除窗体前置
                this.TopMost = false;
            }
            else
            {
                //还原窗体显示    
                WindowState = FormWindowState.Normal;
                //焦点激活
                this.Activate();
                //将窗体前置
                this.TopMost = true;
            }
        }

        private void 批量重命名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Remname f = new Remname
            {
                MdiParent = this
            };
            f.Show();
        }

        private void 生成文件清单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Inventory f = new Inventory
            {
                MdiParent = this
            };
            f.Show();
        }

        private void pDF文件识别ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Pdfident f = new Pdfident
            {
                MdiParent = this
            };
            f.Show();
        }

        private void pDF识别区域调试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Preview f = new Preview
            {
                MdiParent = this
            };
            f.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}

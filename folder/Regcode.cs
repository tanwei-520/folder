using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace folder
{
    public partial class Regcode : Form
    {
        public Regcode()
        {
            InitializeComponent();
            this.TopMost = true;//置顶
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cpublic.sno = textBox1.Text;
            Close();
            this.Dispose();
        }

        private void Regcode_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void Regcode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("注册码为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                Environment.Exit(0);
            }
        }
    }
}

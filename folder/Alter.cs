using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace folder
{
    public partial class Alter : Form
    {
        public Alter()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cpublic.tno = textBox1.Text;
            Close();
            this.Dispose();
        }

        private void Alter_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void Alter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("编号为空！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
    }
}

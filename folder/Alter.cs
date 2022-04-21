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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cpublic.tno = textBox1.Text;
            Close();
        }
    }
}

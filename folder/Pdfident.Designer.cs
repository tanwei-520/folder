namespace folder
{
    partial class Pdfident
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            Gtext = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            Mtext = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            mians = new System.Windows.Forms.Panel();
            button4 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            xnum = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ynum = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            wnum = new System.Windows.Forms.NumericUpDown();
            label7 = new System.Windows.Forms.Label();
            hnum = new System.Windows.Forms.NumericUpDown();
            button3 = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)xnum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ynum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wnum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hnum).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(876, 28);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(67, 27);
            button1.TabIndex = 14;
            button1.Text = "浏览";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Gtext
            // 
            Gtext.Location = new System.Drawing.Point(148, 30);
            Gtext.Name = "Gtext";
            Gtext.ReadOnly = true;
            Gtext.Size = new System.Drawing.Size(685, 23);
            Gtext.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(29, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 17);
            label1.TabIndex = 12;
            label1.Text = "选择PDF文件目录";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(876, 85);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(67, 27);
            button2.TabIndex = 17;
            button2.Text = "浏览";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Mtext
            // 
            Mtext.Location = new System.Drawing.Point(148, 87);
            Mtext.Name = "Mtext";
            Mtext.ReadOnly = true;
            Mtext.Size = new System.Drawing.Size(685, 23);
            Mtext.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(40, 90);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 17);
            label2.TabIndex = 15;
            label2.Text = "选择输出目录";
            // 
            // mians
            // 
            mians.AutoScroll = true;
            mians.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            mians.Location = new System.Drawing.Point(40, 208);
            mians.Name = "mians";
            mians.Size = new System.Drawing.Size(900, 356);
            mians.TabIndex = 19;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(441, 175);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(67, 27);
            button4.TabIndex = 20;
            button4.Text = "开始处理";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(40, 142);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(80, 17);
            label3.TabIndex = 22;
            label3.Text = "设置识别区域";
            // 
            // xnum
            // 
            xnum.Location = new System.Drawing.Point(181, 140);
            xnum.Maximum = new decimal(new int[] { 1920, 0, 0, 0 });
            xnum.Minimum = new decimal(new int[] { 1920, 0, 0, int.MinValue });
            xnum.Name = "xnum";
            xnum.Size = new System.Drawing.Size(70, 23);
            xnum.TabIndex = 27;
            xnum.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(156, 142);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(19, 17);
            label4.TabIndex = 28;
            label4.Text = "X:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(273, 142);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(18, 17);
            label5.TabIndex = 30;
            label5.Text = "Y:";
            // 
            // ynum
            // 
            ynum.Location = new System.Drawing.Point(298, 140);
            ynum.Maximum = new decimal(new int[] { 1080, 0, 0, 0 });
            ynum.Minimum = new decimal(new int[] { 1080, 0, 0, int.MinValue });
            ynum.Name = "ynum";
            ynum.Size = new System.Drawing.Size(70, 23);
            ynum.TabIndex = 29;
            ynum.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(400, 142);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(23, 17);
            label6.TabIndex = 32;
            label6.Text = "W:";
            // 
            // wnum
            // 
            wnum.Location = new System.Drawing.Point(425, 140);
            wnum.Maximum = new decimal(new int[] { 1920, 0, 0, 0 });
            wnum.Minimum = new decimal(new int[] { 1920, 0, 0, int.MinValue });
            wnum.Name = "wnum";
            wnum.Size = new System.Drawing.Size(70, 23);
            wnum.TabIndex = 31;
            wnum.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(531, 142);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(20, 17);
            label7.TabIndex = 34;
            label7.Text = "H:";
            // 
            // hnum
            // 
            hnum.Location = new System.Drawing.Point(556, 140);
            hnum.Maximum = new decimal(new int[] { 1920, 0, 0, 0 });
            hnum.Minimum = new decimal(new int[] { 1920, 0, 0, int.MinValue });
            hnum.Name = "hnum";
            hnum.Size = new System.Drawing.Size(70, 23);
            hnum.TabIndex = 33;
            hnum.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(876, 175);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(67, 27);
            button3.TabIndex = 35;
            button3.Text = "重置清空";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(659, 142);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(174, 17);
            label8.TabIndex = 36;
            label8.Text = "使用前请备份需处理的PDF文件";
            // 
            // Pdfident
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(971, 576);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(hnum);
            Controls.Add(label6);
            Controls.Add(wnum);
            Controls.Add(label5);
            Controls.Add(ynum);
            Controls.Add(label4);
            Controls.Add(xnum);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(mians);
            Controls.Add(button2);
            Controls.Add(Mtext);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(Gtext);
            Controls.Add(label1);
            MinimizeBox = false;
            Name = "Pdfident";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PDF识别重命名";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += Pdfident_Load;
            ((System.ComponentModel.ISupportInitialize)xnum).EndInit();
            ((System.ComponentModel.ISupportInitialize)ynum).EndInit();
            ((System.ComponentModel.ISupportInitialize)wnum).EndInit();
            ((System.ComponentModel.ISupportInitialize)hnum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Gtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Mtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel mians;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown xnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ynum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown wnum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown hnum;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
    }
}
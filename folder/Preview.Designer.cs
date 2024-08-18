namespace folder
{
    partial class Preview
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
            label7 = new System.Windows.Forms.Label();
            hnum = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            wnum = new System.Windows.Forms.NumericUpDown();
            label5 = new System.Windows.Forms.Label();
            ynum = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            xnum = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            mians = new System.Windows.Forms.Panel();
            button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)hnum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wnum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ynum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xnum).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(880, 26);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(67, 27);
            button1.TabIndex = 17;
            button1.Text = "浏览";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Gtext
            // 
            Gtext.Location = new System.Drawing.Point(152, 28);
            Gtext.Name = "Gtext";
            Gtext.ReadOnly = true;
            Gtext.Size = new System.Drawing.Size(685, 23);
            Gtext.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(33, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 17);
            label1.TabIndex = 15;
            label1.Text = "选择PDF文件";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(673, 84);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(20, 17);
            label7.TabIndex = 43;
            label7.Text = "H:";
            // 
            // hnum
            // 
            hnum.Location = new System.Drawing.Point(698, 82);
            hnum.Maximum = new decimal(new int[] { 1920, 0, 0, 0 });
            hnum.Minimum = new decimal(new int[] { 1920, 0, 0, int.MinValue });
            hnum.Name = "hnum";
            hnum.Size = new System.Drawing.Size(70, 23);
            hnum.TabIndex = 42;
            hnum.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(542, 84);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(23, 17);
            label6.TabIndex = 41;
            label6.Text = "W:";
            // 
            // wnum
            // 
            wnum.Location = new System.Drawing.Point(567, 82);
            wnum.Maximum = new decimal(new int[] { 1920, 0, 0, 0 });
            wnum.Minimum = new decimal(new int[] { 1920, 0, 0, int.MinValue });
            wnum.Name = "wnum";
            wnum.Size = new System.Drawing.Size(70, 23);
            wnum.TabIndex = 40;
            wnum.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(415, 84);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(18, 17);
            label5.TabIndex = 39;
            label5.Text = "Y:";
            // 
            // ynum
            // 
            ynum.Location = new System.Drawing.Point(440, 82);
            ynum.Maximum = new decimal(new int[] { 1080, 0, 0, 0 });
            ynum.Minimum = new decimal(new int[] { 1080, 0, 0, int.MinValue });
            ynum.Name = "ynum";
            ynum.Size = new System.Drawing.Size(70, 23);
            ynum.TabIndex = 38;
            ynum.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(298, 84);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(19, 17);
            label4.TabIndex = 37;
            label4.Text = "X:";
            // 
            // xnum
            // 
            xnum.Location = new System.Drawing.Point(323, 82);
            xnum.Maximum = new decimal(new int[] { 1920, 0, 0, 0 });
            xnum.Minimum = new decimal(new int[] { 1920, 0, 0, int.MinValue });
            xnum.Name = "xnum";
            xnum.Size = new System.Drawing.Size(70, 23);
            xnum.TabIndex = 36;
            xnum.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(182, 84);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(80, 17);
            label3.TabIndex = 35;
            label3.Text = "设置识别区域";
            // 
            // mians
            // 
            mians.AutoScroll = true;
            mians.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            mians.Location = new System.Drawing.Point(12, 169);
            mians.Name = "mians";
            mians.Size = new System.Drawing.Size(935, 395);
            mians.TabIndex = 44;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(443, 127);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(67, 27);
            button4.TabIndex = 45;
            button4.Text = "开始处理";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Preview
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(971, 576);
            Controls.Add(button4);
            Controls.Add(mians);
            Controls.Add(label7);
            Controls.Add(hnum);
            Controls.Add(label6);
            Controls.Add(wnum);
            Controls.Add(label5);
            Controls.Add(ynum);
            Controls.Add(label4);
            Controls.Add(xnum);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(Gtext);
            Controls.Add(label1);
            MinimizeBox = false;
            Name = "Preview";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PDF识别区域调试";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)hnum).EndInit();
            ((System.ComponentModel.ISupportInitialize)wnum).EndInit();
            ((System.ComponentModel.ISupportInitialize)ynum).EndInit();
            ((System.ComponentModel.ISupportInitialize)xnum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Gtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown hnum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown wnum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ynum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown xnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel mians;
        private System.Windows.Forms.Button button4;
    }
}
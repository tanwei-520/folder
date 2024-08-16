
namespace folder
{
    partial class MonitorFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorFolder));
            button3 = new System.Windows.Forms.Button();
            mians = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            button2 = new System.Windows.Forms.Button();
            Mtext = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            Gtext = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            button6 = new System.Windows.Forms.Button();
            Btext = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            num = new System.Windows.Forms.NumericUpDown();
            checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(472, 152);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(67, 27);
            button3.TabIndex = 16;
            button3.Text = "开始监听";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // mians
            // 
            mians.AutoScroll = true;
            mians.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            mians.Location = new System.Drawing.Point(33, 186);
            mians.Name = "mians";
            mians.Size = new System.Drawing.Size(900, 370);
            mians.TabIndex = 15;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(923, 185);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(19, 24);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(866, 74);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(67, 27);
            button2.TabIndex = 14;
            button2.Text = "浏览";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Mtext
            // 
            Mtext.Location = new System.Drawing.Point(143, 76);
            Mtext.Name = "Mtext";
            Mtext.ReadOnly = true;
            Mtext.Size = new System.Drawing.Size(685, 23);
            Mtext.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(69, 76);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 17);
            label2.TabIndex = 12;
            label2.Text = "选择模板";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(866, 28);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(67, 27);
            button1.TabIndex = 11;
            button1.Text = "浏览";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Gtext
            // 
            Gtext.Location = new System.Drawing.Point(143, 30);
            Gtext.Name = "Gtext";
            Gtext.ReadOnly = true;
            Gtext.Size = new System.Drawing.Size(685, 23);
            Gtext.TabIndex = 10;
            Gtext.TextChanged += Gtext_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(33, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 17);
            label1.TabIndex = 9;
            label1.Text = "选择文件根目录";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(361, 152);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(67, 27);
            button4.TabIndex = 18;
            button4.Text = "生成模板";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(580, 152);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(67, 27);
            button5.TabIndex = 19;
            button5.Text = "停止监听";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(897, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(45, 38);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(33, 163);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(188, 17);
            label3.TabIndex = 21;
            label3.Text = "不要打开或占用需要重命名的文件";
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(866, 113);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(67, 27);
            button6.TabIndex = 24;
            button6.Text = "浏览";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Btext
            // 
            Btext.Location = new System.Drawing.Point(143, 115);
            Btext.Name = "Btext";
            Btext.ReadOnly = true;
            Btext.Size = new System.Drawing.Size(685, 23);
            Btext.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(33, 118);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(92, 17);
            label4.TabIndex = 22;
            label4.Text = "引用编码对照表";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(684, 162);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(68, 17);
            label5.TabIndex = 25;
            label5.Text = "流水号位数";
            // 
            // num
            // 
            num.Location = new System.Drawing.Point(758, 157);
            num.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            num.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num.Name = "num";
            num.Size = new System.Drawing.Size(70, 23);
            num.TabIndex = 26;
            num.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(236, 161);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(99, 21);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "拼接原文件名";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // MonitorFolder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(971, 576);
            Controls.Add(pictureBox2);
            Controls.Add(checkBox1);
            Controls.Add(num);
            Controls.Add(label5);
            Controls.Add(button6);
            Controls.Add(Btext);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Mtext);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(Gtext);
            Controls.Add(label1);
            Controls.Add(mians);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(987, 615);
            Name = "MonitorFolder";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "监听文件夹";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += MonitorFolder_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)num).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel mians;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Mtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Gtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox Btext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
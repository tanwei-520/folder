
namespace folder
{
    partial class Remname
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
            button2 = new System.Windows.Forms.Button();
            Mtext = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            mians = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            only = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            Onlycurrent = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(892, 25);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(67, 27);
            button2.TabIndex = 17;
            button2.Text = "浏览";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Mtext
            // 
            Mtext.Location = new System.Drawing.Point(90, 27);
            Mtext.Name = "Mtext";
            Mtext.ReadOnly = true;
            Mtext.Size = new System.Drawing.Size(764, 23);
            Mtext.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 17);
            label2.TabIndex = 15;
            label2.Text = "选择模板";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(440, 65);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(85, 27);
            button3.TabIndex = 18;
            button3.Text = "开始重命名";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // mians
            // 
            mians.AutoScroll = true;
            mians.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            mians.Location = new System.Drawing.Point(12, 162);
            mians.Name = "mians";
            mians.Size = new System.Drawing.Size(947, 390);
            mians.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            label1.Location = new System.Drawing.Point(12, 142);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(212, 17);
            label1.TabIndex = 20;
            label1.Text = "不要打开或占用需要批量重命名的文件";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 80);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(104, 17);
            label3.TabIndex = 21;
            label3.Text = "仅修改文件后缀名";
            // 
            // only
            // 
            only.Location = new System.Drawing.Point(754, 101);
            only.Name = "only";
            only.Size = new System.Drawing.Size(100, 23);
            only.TabIndex = 22;
            only.Text = ".pdf";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(90, 101);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(627, 23);
            textBox1.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(440, 130);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(85, 27);
            button1.TabIndex = 25;
            button1.Text = "开始重命名";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(892, 99);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(67, 27);
            button4.TabIndex = 26;
            button4.Text = "浏览";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(754, 81);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(44, 17);
            label4.TabIndex = 27;
            label4.Text = "后缀名";
            // 
            // Onlycurrent
            // 
            Onlycurrent.AutoSize = true;
            Onlycurrent.Checked = true;
            Onlycurrent.CheckState = System.Windows.Forms.CheckState.Checked;
            Onlycurrent.Location = new System.Drawing.Point(756, 130);
            Onlycurrent.Name = "Onlycurrent";
            Onlycurrent.Size = new System.Drawing.Size(99, 21);
            Onlycurrent.TabIndex = 28;
            Onlycurrent.Text = "仅当前文件夹";
            Onlycurrent.UseVisualStyleBackColor = true;
            // 
            // Remname
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(971, 576);
            Controls.Add(Onlycurrent);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(only);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(mians);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Mtext);
            Controls.Add(label2);
            MinimizeBox = false;
            Name = "Remname";
            Text = "批量重命名文件";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Mtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel mians;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox only;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Onlycurrent;
    }
}
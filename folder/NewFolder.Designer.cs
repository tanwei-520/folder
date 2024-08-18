
namespace folder
{
    partial class NewFolder
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
            label1 = new System.Windows.Forms.Label();
            Gtext = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            Mtext = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            button3 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(33, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 17);
            label1.TabIndex = 0;
            label1.Text = "选择文件根目录";
            // 
            // Gtext
            // 
            Gtext.Location = new System.Drawing.Point(143, 30);
            Gtext.Name = "Gtext";
            Gtext.ReadOnly = true;
            Gtext.Size = new System.Drawing.Size(685, 23);
            Gtext.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(866, 28);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(67, 27);
            button1.TabIndex = 2;
            button1.Text = "浏览";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(69, 76);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 17);
            label2.TabIndex = 3;
            label2.Text = "选择模板";
            // 
            // Mtext
            // 
            Mtext.Location = new System.Drawing.Point(143, 76);
            Mtext.Name = "Mtext";
            Mtext.ReadOnly = true;
            Mtext.Size = new System.Drawing.Size(685, 23);
            Mtext.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(866, 74);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(67, 27);
            button2.TabIndex = 5;
            button2.Text = "浏览";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Location = new System.Drawing.Point(33, 186);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(900, 370);
            panel1.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(440, 129);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(67, 27);
            button3.TabIndex = 7;
            button3.Text = "开始新建";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(33, 164);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(18, 17);
            label3.TabIndex = 8;
            label3.Text = "--";
            // 
            // NewFolder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(971, 576);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(Mtext);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(Gtext);
            Controls.Add(label1);
            MinimizeBox = false;
            Name = "NewFolder";
            Text = "批量新建文件夹";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Gtext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Mtext;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}

namespace folder
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            批量新建文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            监听文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            批量重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            生成文件清单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pDF文件识别ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pDF识别区域调试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            显示程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            保持最前ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            退出程序ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 批量新建文件夹ToolStripMenuItem, 监听文件夹ToolStripMenuItem, 批量重命名ToolStripMenuItem, 生成文件清单ToolStripMenuItem, pDF文件识别ToolStripMenuItem, pDF识别区域调试ToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            menuStrip1.Size = new System.Drawing.Size(975, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 批量新建文件夹ToolStripMenuItem
            // 
            批量新建文件夹ToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("批量新建文件夹ToolStripMenuItem.Image");
            批量新建文件夹ToolStripMenuItem.Name = "批量新建文件夹ToolStripMenuItem";
            批量新建文件夹ToolStripMenuItem.Size = new System.Drawing.Size(120, 21);
            批量新建文件夹ToolStripMenuItem.Text = "批量新建文件夹";
            批量新建文件夹ToolStripMenuItem.Click += 批量新建文件夹ToolStripMenuItem_Click;
            // 
            // 监听文件夹ToolStripMenuItem
            // 
            监听文件夹ToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("监听文件夹ToolStripMenuItem.Image");
            监听文件夹ToolStripMenuItem.Name = "监听文件夹ToolStripMenuItem";
            监听文件夹ToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            监听文件夹ToolStripMenuItem.Text = "监听文件夹";
            监听文件夹ToolStripMenuItem.Click += 监听文件夹ToolStripMenuItem_Click;
            // 
            // 批量重命名ToolStripMenuItem
            // 
            批量重命名ToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("批量重命名ToolStripMenuItem.Image");
            批量重命名ToolStripMenuItem.Name = "批量重命名ToolStripMenuItem";
            批量重命名ToolStripMenuItem.Size = new System.Drawing.Size(120, 21);
            批量重命名ToolStripMenuItem.Text = "批量重命名文件";
            批量重命名ToolStripMenuItem.Click += 批量重命名ToolStripMenuItem_Click;
            // 
            // 生成文件清单ToolStripMenuItem
            // 
            生成文件清单ToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("生成文件清单ToolStripMenuItem.Image");
            生成文件清单ToolStripMenuItem.Name = "生成文件清单ToolStripMenuItem";
            生成文件清单ToolStripMenuItem.Size = new System.Drawing.Size(108, 21);
            生成文件清单ToolStripMenuItem.Text = "生成文件清单";
            生成文件清单ToolStripMenuItem.Click += 生成文件清单ToolStripMenuItem_Click;
            // 
            // pDF文件识别ToolStripMenuItem
            // 
            pDF文件识别ToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("pDF文件识别ToolStripMenuItem.Image");
            pDF文件识别ToolStripMenuItem.Name = "pDF文件识别ToolStripMenuItem";
            pDF文件识别ToolStripMenuItem.Size = new System.Drawing.Size(118, 21);
            pDF文件识别ToolStripMenuItem.Text = "PDF文件重命名";
            pDF文件识别ToolStripMenuItem.Click += pDF文件识别ToolStripMenuItem_Click;
            // 
            // pDF识别区域调试ToolStripMenuItem
            // 
            pDF识别区域调试ToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("pDF识别区域调试ToolStripMenuItem.Image");
            pDF识别区域调试ToolStripMenuItem.Name = "pDF识别区域调试ToolStripMenuItem";
            pDF识别区域调试ToolStripMenuItem.Size = new System.Drawing.Size(130, 21);
            pDF识别区域调试ToolStripMenuItem.Text = "PDF识别区域调试";
            pDF识别区域调试ToolStripMenuItem.Click += pDF识别区域调试ToolStripMenuItem_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Folder";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 显示程序ToolStripMenuItem, 保持最前ToolStripMenuItem, 退出程序ToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // 显示程序ToolStripMenuItem
            // 
            显示程序ToolStripMenuItem.Name = "显示程序ToolStripMenuItem";
            显示程序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            显示程序ToolStripMenuItem.Text = "显示程序";
            显示程序ToolStripMenuItem.Click += 显示程序ToolStripMenuItem_Click;
            // 
            // 保持最前ToolStripMenuItem
            // 
            保持最前ToolStripMenuItem.CheckOnClick = true;
            保持最前ToolStripMenuItem.Name = "保持最前ToolStripMenuItem";
            保持最前ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            保持最前ToolStripMenuItem.Text = "保持最前";
            保持最前ToolStripMenuItem.Click += 保持最前ToolStripMenuItem_Click;
            // 
            // 退出程序ToolStripMenuItem1
            // 
            退出程序ToolStripMenuItem1.Name = "退出程序ToolStripMenuItem1";
            退出程序ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            退出程序ToolStripMenuItem1.Text = "退出程序";
            退出程序ToolStripMenuItem1.Click += 退出程序ToolStripMenuItem1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(975, 594);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimumSize = new System.Drawing.Size(991, 633);
            Name = "Main";
            ShowInTaskbar = false;
            Text = "Folder";
            FormClosed += Main_FormClosed;
            SizeChanged += Main_MinimumSizeChanged;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 批量新建文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 监听文件夹ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保持最前ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 批量重命名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成文件清单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDF文件识别ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDF识别区域调试ToolStripMenuItem;
    }
}


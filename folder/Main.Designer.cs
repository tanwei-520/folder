
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.批量新建文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.监听文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成文件清单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保持最前ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.批量新建文件夹ToolStripMenuItem,
            this.监听文件夹ToolStripMenuItem,
            this.批量重命名ToolStripMenuItem,
            this.生成文件清单ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(975, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 批量新建文件夹ToolStripMenuItem
            // 
            this.批量新建文件夹ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("批量新建文件夹ToolStripMenuItem.Image")));
            this.批量新建文件夹ToolStripMenuItem.Name = "批量新建文件夹ToolStripMenuItem";
            this.批量新建文件夹ToolStripMenuItem.Size = new System.Drawing.Size(120, 21);
            this.批量新建文件夹ToolStripMenuItem.Text = "批量新建文件夹";
            this.批量新建文件夹ToolStripMenuItem.Click += new System.EventHandler(this.批量新建文件夹ToolStripMenuItem_Click);
            // 
            // 监听文件夹ToolStripMenuItem
            // 
            this.监听文件夹ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("监听文件夹ToolStripMenuItem.Image")));
            this.监听文件夹ToolStripMenuItem.Name = "监听文件夹ToolStripMenuItem";
            this.监听文件夹ToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            this.监听文件夹ToolStripMenuItem.Text = "监听文件夹";
            this.监听文件夹ToolStripMenuItem.Click += new System.EventHandler(this.监听文件夹ToolStripMenuItem_Click);
            // 
            // 批量重命名ToolStripMenuItem
            // 
            this.批量重命名ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("批量重命名ToolStripMenuItem.Image")));
            this.批量重命名ToolStripMenuItem.Name = "批量重命名ToolStripMenuItem";
            this.批量重命名ToolStripMenuItem.Size = new System.Drawing.Size(120, 21);
            this.批量重命名ToolStripMenuItem.Text = "批量重命名文件";
            this.批量重命名ToolStripMenuItem.Click += new System.EventHandler(this.批量重命名ToolStripMenuItem_Click);
            // 
            // 生成文件清单ToolStripMenuItem
            // 
            this.生成文件清单ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("生成文件清单ToolStripMenuItem.Image")));
            this.生成文件清单ToolStripMenuItem.Name = "生成文件清单ToolStripMenuItem";
            this.生成文件清单ToolStripMenuItem.Size = new System.Drawing.Size(108, 21);
            this.生成文件清单ToolStripMenuItem.Text = "生成文件清单";
            this.生成文件清单ToolStripMenuItem.Click += new System.EventHandler(this.生成文件清单ToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Folder";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示程序ToolStripMenuItem,
            this.保持最前ToolStripMenuItem,
            this.退出程序ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // 显示程序ToolStripMenuItem
            // 
            this.显示程序ToolStripMenuItem.Name = "显示程序ToolStripMenuItem";
            this.显示程序ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.显示程序ToolStripMenuItem.Text = "显示程序";
            this.显示程序ToolStripMenuItem.Click += new System.EventHandler(this.显示程序ToolStripMenuItem_Click);
            // 
            // 保持最前ToolStripMenuItem
            // 
            this.保持最前ToolStripMenuItem.CheckOnClick = true;
            this.保持最前ToolStripMenuItem.Name = "保持最前ToolStripMenuItem";
            this.保持最前ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保持最前ToolStripMenuItem.Text = "保持最前";
            this.保持最前ToolStripMenuItem.Click += new System.EventHandler(this.保持最前ToolStripMenuItem_Click);
            // 
            // 退出程序ToolStripMenuItem1
            // 
            this.退出程序ToolStripMenuItem1.Name = "退出程序ToolStripMenuItem1";
            this.退出程序ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.退出程序ToolStripMenuItem1.Text = "退出程序";
            this.退出程序ToolStripMenuItem1.Click += new System.EventHandler(this.退出程序ToolStripMenuItem1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 594);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(991, 633);
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.Text = "Folder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.SizeChanged += new System.EventHandler(this.Main_MinimumSizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}


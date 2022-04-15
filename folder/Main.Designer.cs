
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.批量新建文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.监听文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.批量新建文件夹ToolStripMenuItem,
            this.监听文件夹ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
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
            this.监听文件夹ToolStripMenuItem.DropDownClosed += new System.EventHandler(this.监听文件夹ToolStripMenuItem_DropDownClosed);
            this.监听文件夹ToolStripMenuItem.Click += new System.EventHandler(this.监听文件夹ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 594);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Folder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 批量新建文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 监听文件夹ToolStripMenuItem;
    }
}


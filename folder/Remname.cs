using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;

namespace folder
{
    public partial class Remname : Form
    {
        private static int y = 11;
        private string[] lie = { "原文件名", "新文件名" };
        public Remname()
        {
            InitializeComponent();
            Cpublic.log.Info("打开批量重命名菜单");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Multiselect = false,
                Title = "请选择文件", //选择器提示文字
                Filter = "Excel(*.xlsx,*.xls)|*.xlsx;*.xls" //文件类型
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileDialog.FileName))
                {
                    MessageBox.Show("文件路径不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cpublic.log.Error("文件路径不能为空！");
                    return;
                }
                Mtext.Text= fileDialog.FileName;
                Cpublic.log.Info("选择模板文件："+ fileDialog.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Mtext.Text == "")
            {
                MessageBox.Show("模板目录为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cpublic.log.Error("模板目录为空");
                return;
            }
            try
            {
                text("开始读取模板");
                Cpublic.log.Info("开始读取模板： " + Mtext.Text);
                DataTable Data = new DataTable();
                Data.Clear();
                if (!Data.Columns.Contains("old"))
                {
                    Data.Columns.Add("old");
                }
                if (!Data.Columns.Contains("new"))
                {
                    Data.Columns.Add("new");
                }
                FileStream fileStream = new FileStream(@"" + Mtext.Text + "", FileMode.Open);
                IWorkbook workbook;
                if (Mtext.Text.LastIndexOf(".xlsx") > 0)
                {
                    workbook = new XSSFWorkbook(fileStream);
                }
                else
                {
                    workbook = new HSSFWorkbook(fileStream);
                }
                ISheet sheet = workbook.GetSheetAt(0);
                IRow row;
                row = sheet.GetRow(0);
                for (int i = 0; i < lie.Length; i++)
                {
                    if (lie[i] == row.GetCell(i).ToString())
                    {
                        Cpublic.log.Info("模板列名验证正确：" + row.GetCell(i).ToString());
                    }
                    else
                    {
                        MessageBox.Show("选择的模板格式验证失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Cpublic.log.Info("模板列名验证错误：" + row.GetCell(i).ToString());
                        return;
                    }
                }
                for (int i = 1; i < sheet.LastRowNum + 1; i++)
                {
                    row = sheet.GetRow(i);
                    DataRow dr = Data.NewRow();
                    for (int t = row.FirstCellNum; t < row.LastCellNum; t++)
                    {
                        if (row.GetCell(t) != null && row.GetCell(t).ToString() != "")
                        {
                            dr[t] = row.GetCell(t).ToString();
                        }
                        else
                        {
                            dr[t] = "";
                        }
                        // Cpublic.log.Info(dr[t] = row.GetCell(t).ToString());
                    }
                    Data.Rows.Add(dr);
                }
                fileStream.Close();
                //MessageBox.Show("模板读取成功，共" + Data.Rows.Count + "行数据。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cpublic.log.Info("模板读取成功，共" + Data.Rows.Count + "行数据。");
                text("开始批量重命名");
                Cpublic.log.Info("开始批量重命名。");
                int s = 0;
                for(int i = 0; i < Data.Rows.Count; i++)
                {
                    if (File.Exists(Data.Rows[i]["old"].ToString()))
                    {
                       //text("开始重命名：" + Data.Rows[i]["old"].ToString());
                        if (!File.Exists(Data.Rows[i]["new"].ToString()))
                        {                        
                            try
                            {
                                File.Move(Data.Rows[i]["old"].ToString(), Data.Rows[i]["new"].ToString());
                                //Cpublic.log.Info("成功重命名文件：" + Data.Rows[i]["old"].ToString() + "---" + Data.Rows[i]["new"].ToString());
                                s++;
                            }
                            catch (Exception ex)
                            {
                                text("重命名失败：" + Data.Rows[i]["new"].ToString(), 0xFF0000);
                                Cpublic.log.Error("重命名失败：" + Data.Rows[i]["old"].ToString() + "---" + ex.Message);
                            }
                        }
                        else
                        {
                            text("当前文件夹下已有该名称的文件：" + Data.Rows[i]["new"].ToString(),0x4876FF);
                            Cpublic.log.Error("当前文件夹下已有该名称的文件：" + Data.Rows[i]["new"].ToString());
                        }
                    }
                    else
                    {
                        text("未找到该文件：" + Data.Rows[i]["old"].ToString(), 0xFF0000);
                        Cpublic.log.Error("未找到该文件：" + Data.Rows[i]["old"].ToString());
                    }
                }
                MessageBox.Show("重命名结束，共" + Data.Rows.Count + "个命令，成功重命名" + s.ToString() + "个文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cpublic.log.Info("重命名结束，共"+Data.Rows.Count+"个命令，成功重命名"+s.ToString()+"个文件");
            }
            catch (Exception ex)
            {
                MessageBox.Show("模板读取错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cpublic.log.Error("模板读取错误！" + ex.Message);
            }
        }
        public void text(string text)
        {
            int x = mians.VerticalScroll.Value;
            Label checkBox = new Label
            {
                Location = new Point(13, y - x),
                Name = "F" + y,
            };
            checkBox.AutoSize = true;
            checkBox.Text = text;
            //   mians.Controls.Add(checkBox);
            this.Invoke(new Action(() => { mians.Controls.Add(checkBox); }));
            y += 25;
        }
        public void text(string text, int coloer)
        {
            int x = mians.VerticalScroll.Value;
            Label checkBox = new Label
            {
                Location = new Point(13, y - x),
                Name = "F" + y,
            };
            checkBox.AutoSize = true;
            checkBox.Text = text;
            checkBox.ForeColor = Color.FromArgb(coloer);
            //mians.Controls.Add(checkBox);
            this.Invoke(new Action(() => { mians.Controls.Add(checkBox); }));
            y += 25;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                textBox1.Text = dialog.SelectedPath; //获取文件夹路径 
                Cpublic.log.Info("选择文件夹：" + dialog.SelectedPath);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == ""||only.Text=="")
            {
                MessageBox.Show("路径或后缀名为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Cpublic.log.Info("开始修改文件后缀名");
            DirectoryInfo Files = new DirectoryInfo(textBox1.Text);
            FileInfo[] files = Files.GetFiles();
            var filtered = files.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));//去除隐藏文件
            foreach (FileInfo Filename in filtered)
            {
                try
                {
                    File.Move(Filename.FullName, Filename.FullName.Replace(Filename.FullName.Substring(Filename.FullName.IndexOf(".")), only.Text));
                    Cpublic.log.Info("成功修改文件>>：" + Filename.Name);
                }
                catch (Exception ex)
                {
                    text("重命名失败：" + Filename.FullName, 0xFF0000);
                    Cpublic.log.Error("重命名失败：" + Filename.FullName+""+ex.Message);
                }
            }
            MessageBox.Show("重命名完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

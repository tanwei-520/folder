using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;

namespace folder
{
    public partial class NewFolder : Form
    {
        public NewFolder()
        {
            InitializeComponent();
            Cpublic.log.Info("启动批量新建文件夹菜单");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择根目录文件夹";
            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(dialog.SelectedPath))
                    {
                        MessageBox.Show("文件夹路径不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Cpublic.log.Error("文件夹路径不能为空！");
                        return;
                    }
                    Gtext.Text = dialog.SelectedPath;
                    Cpublic.log.Info("选择根目录 " + dialog.SelectedPath);
                }
            }
            catch (Exception ex)
            {
                Cpublic.log.Error(ex.Message);
            }
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
                Mtext.Text = fileDialog.FileName; //获取文件路径（带文件名）
                Cpublic.log.Info("选择文件 " + fileDialog.FileName);// filenameonly.Text = info.Name;  //获取文件名
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Gtext.Text == "")
            {
                MessageBox.Show("请先设置根目录！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cpublic.log.Error("未设置根目录！");
                return;
            }
            if (Mtext.Text == "")
            {
                MessageBox.Show("请先选择模板！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cpublic.log.Error("未选择模板！");
                return;
            }
            if (Mtext.Text != "" && (Mtext.Text.LastIndexOf(".xlsx") > 0 || Mtext.Text.LastIndexOf(".xls") > 0))
            {
                Cpublic.log.Info("开始新建文件夹");
                try
                {
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
                    int y = 11;
                    int i = 1;
                    int ip = 0;
                    this.panel1.Controls.Clear();
                    for (; i < sheet.LastRowNum + 1; i++)
                    {
                        row = sheet.GetRow(i);
                        string url = "";
                        for (int t = row.FirstCellNum; t < row.LastCellNum; t++)
                        {
                            if (row.GetCell(t) != null && row.GetCell(t).ToString() != "")
                            {
                                url += "\\" + row.GetCell(t).ToString();
                            }
                            else
                            {
                                break;
                            }
                        }
                        url = Gtext.Text + "" + url;
                        int x = panel1.VerticalScroll.Value;
                        Label checkBox = new Label
                        {
                            Location = new Point(13, y - x),
                            Name = "F" + i,
                        };
                        try
                        {
                            if (!Directory.Exists(@"" + url))
                            {
                                Directory.CreateDirectory(@"" + url);
                                checkBox.AutoSize = true;
                                checkBox.Text = "成功创建" + url;
                                ip++;
                                Cpublic.log.Info("新建文件夹成功：" + url);
                            }
                            else
                            {
                                checkBox.Text = "已存在该文件夹" + url;
                                checkBox.ForeColor = Color.FromArgb(252, 147, 54);
                                checkBox.AutoSize = true;
                                Cpublic.log.Info("已存在该文件夹：" + url);
                            }
                        }
                        catch (Exception ex)
                        {
                            checkBox.AutoSize = true;
                            checkBox.Text = "创建失败：" + url;
                            checkBox.ForeColor = Color.FromArgb(251, 38, 38);
                            Cpublic.log.Error(url + "创建失败 " + ex.Message);
                        }
                        panel1.Controls.Add(checkBox);
                        y += 25;
                    }
                    fileStream.Close();
                    label3.Text = "共" + (i - 1) + "条创建命令，完成" + ip + "条";
                    Cpublic.log.Info(label3.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Execl文件读取错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cpublic.log.Error(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("选择Excel文件！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cpublic.log.Error("文件错误");
            }
        }
    }
}

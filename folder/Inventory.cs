using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;

namespace folder
{
    public partial class Inventory : Form
    {
        private DataTable list = new DataTable();
        private static int y = 11;
        public Inventory()
        {
            InitializeComponent();
            Cpublic.log.Info("打开生成文件清单菜单" );
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (Gtext.Text == "")
            {
                MessageBox.Show("根目录为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Cpublic.log.Error("根目录为空!");
                return;
            }
            try
            {
                text("开始生成文件清单");
                if (!list.Columns.Contains("all"))
                {
                    list.Columns.Add("all");
                }
                if (!list.Columns.Contains("wname"))
                {
                    list.Columns.Add("wname");
                }
                if (!list.Columns.Contains("fname"))
                {
                    list.Columns.Add("fname");
                }
                list.Clear();
                DirectoryInfo Files = new DirectoryInfo(Gtext.Text);
                FileInfo[] files = Files.GetFiles();
                var filtered = files.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));//去除隐藏文件
                Cpublic.log.Info(Gtext.Text + "，开始遍历");
                text(Gtext.Text + "，开始遍历");
                foreach (FileInfo Filename in filtered)
                {
                    DataRow dr = list.NewRow();
                    dr["all"] = Gtext.Text;
                    dr["wname"] = Gtext.Text.Substring(Gtext.Text.LastIndexOf("\\") + 1);
                    dr["fname"] = Filename.Name;
                    list.Rows.Add(dr);
                }
                dibdad(Gtext.Text);
                if (list.Rows.Count > 0)
                {
                    XSSFWorkbook workbook = new XSSFWorkbook();
                    workbook.CreateSheet("sheet1");
                    XSSFSheet sheet = (XSSFSheet)workbook.GetSheet("sheet1");
                    for (int h = 0; h < list.Rows.Count + 1; h++)
                        sheet.CreateRow(h);
                    XSSFRow sheetrow = (XSSFRow)sheet.GetRow(0);
                    XSSFCell[] sheetcell = new XSSFCell[list.Columns.Count + 1];
                    for (int i = 0; i < list.Columns.Count; i++)
                    {
                        sheetcell[i] = (XSSFCell)sheetrow.CreateCell(i);
                        sheet.SetColumnWidth(i, 18 * 486);
                    }
                    sheetcell[0].SetCellValue("完整目录");
                    sheetcell[1].SetCellValue("目录名称");
                    sheetcell[2].SetCellValue("文件名称");
                    for (int i = 0; i < list.Rows.Count; i++)
                    {
                        sheetrow = (XSSFRow)sheet.GetRow(i + 1);
                        for (int t = 0; t < list.Columns.Count; t++)
                        {
                            sheetcell[t] = (XSSFCell)sheetrow.CreateCell(t);
                            if (list.Rows[i][t] != null || list.Rows[i][t].ToString() == "")
                            {
                                sheetcell[t].SetCellValue(list.Rows[i][t].ToString());
                            }
                            else
                            {
                                sheetcell[t].SetCellValue("");
                            }
                        }
                    }
                    FileStream fss = new FileStream(@"" + Gtext.Text + "\\文件清单.xlsx", FileMode.Create);
                    workbook.Write(fss);
                    fss.Close();
                    workbook.Close();
                    MessageBox.Show("生成成功，文件清单放置在根目录下！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Cpublic.log.Info("文件清单生成成功：" + Gtext.Text + "\\文件清单.xlsx");
                    text("文件清单生成成功");
                    text("共遍历"+list.Rows.Count+"个文件");
                    Cpublic.log.Info("共遍历" + list.Rows.Count + "个文件");
                    list.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("生成失败，详情请查看日志！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Cpublic.log.Error("文件清单生成失败：" +ex.Message);
            }
        }
        private void dibdad(string dirs)
        {
            if (Directory.Exists(dirs))
            {
                //文件路径
                string[] dir = Directory.GetDirectories(dirs);
                //文件名
                for (int i = 0; i < dir.Length; i++)
                {
                    if ((new FileInfo(dir[i]).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)//去除隐藏文件夹
                    {
                        continue;
                    };
                    DirectoryInfo Files = new DirectoryInfo(dir[i]);
                    FileInfo[] files = Files.GetFiles();
                    var filtered = files.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));//去除隐藏文件
                    foreach (FileInfo Filename in filtered)
                    {
                        DataRow dr = list.NewRow();
                        dr["all"] = dir[i];
                        dr["wname"] = dir[i].Replace(dirs + "\\", "");
                        dr["fname"] = Filename.Name;
                        list.Rows.Add(dr);
                    }
                    Cpublic.log.Info(dir[i] + "，开始遍历");
                    text(dir[i] + "，开始遍历");
                    dibdad(dir[i]);
                }
            }
            else
            {
                text("路径有误：" + dirs, 0xFF0000);
                Cpublic.log.Error("路径有误：" + dirs);
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
            checkBox.Dispose();
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
           // checkBox.Dispose();
        }
    }
}

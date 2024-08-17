using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Spire.Pdf;
using Spire.Pdf.Texts;
using Spire.Pdf.Graphics;
using Spire.Additions.Xps.Schema;
using System.Linq;
using System.Threading;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.Formula.Functions;


namespace folder
{
    public partial class Pdfident : Form
    {
        private DataTable list = new DataTable();
        private static int y = 11;
        public Pdfident()
        {
            InitializeComponent();
            Cpublic.log.Info("打开PDF识别重命名菜单");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                Description = "请选择识别PDF目录文件夹"
            };
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
                    Cpublic.log.Info("选择PDF文件目录 " + dialog.SelectedPath);
                }
            }
            catch (Exception ex)
            {
                Cpublic.log.Error("选择PDF文目录异常：" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                Description = "请选择输出目录文件夹"
            };
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
                    Mtext.Text = dialog.SelectedPath;
                    Cpublic.log.Info("选择PDF输出目录 " + dialog.SelectedPath);
                }
            }
            catch (Exception ex)
            {
                Cpublic.log.Error("选择PDF输出目录异常：" + ex.Message);
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
                        if (Filename.Extension.ToUpper() == ".PDF" || Filename.Extension.ToUpper() == ".pdf")
                        {
                            DataRow dr = list.NewRow();
                            dr["all"] = dir[i];
                            dr["wname"] = dir[i].Replace(dirs + "\\", "");
                            dr["allname"] = Filename;
                            dr["fname"] = Filename.Name;
                            list.Rows.Add(dr);
                        }
                    }
                    Cpublic.log.Info(dir[i] + "，开始遍历PDF");
                    dibdad(dir[i]);
                }
            }
            else
            {
                text("路径有误：" + dirs, 0xFF0000);
                Cpublic.log.Error("路径有误：" + dirs);
            }
        }
        //文本信息输出
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
            //checkBox.Dispose();
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (Gtext.Text == "" || Mtext.Text == "")
            {
                MessageBox.Show("输入或输出目录为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cpublic.log.Error("PDF输入或输出目录为空!");
                return;
            }
            if (list.Rows.Count==0)
            {
                MessageBox.Show("输入目录下无PDF文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            y = 11;
            list.Clear();
            if (!list.Columns.Contains("all"))
            {
                list.Columns.Add("all");
            }
            if (!list.Columns.Contains("wname"))
            {
                list.Columns.Add("wname");
            }
            if (!list.Columns.Contains("allname"))
            {
                list.Columns.Add("allname");
            }
            if (!list.Columns.Contains("fname"))
            {
                list.Columns.Add("fname");
            }
            list.Clear();
            DirectoryInfo Files = new DirectoryInfo(Gtext.Text);
            FileInfo[] files = Files.GetFiles();
            var filtered = files.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));//去除隐藏文件
            Cpublic.log.Info(Gtext.Text + "，开始遍历PDF");
            text(Gtext.Text + "，开始遍历PDF");
            foreach (FileInfo Filename in filtered)
            {
                if (Filename.Extension.ToUpper() == ".PDF" || Filename.Extension.ToUpper() == ".pdf")
                {
                    DataRow dr = list.NewRow();
                    dr["all"] = Gtext.Text;
                    dr["wname"] = Gtext.Text.Substring(Gtext.Text.LastIndexOf("\\") + 1);
                    dr["allname"] = Filename;
                    dr["fname"] = Filename.Name;
                    list.Rows.Add(dr);
                }
            }
            dibdad(Gtext.Text);
            if (list.Rows.Count == 0)
            {
                MessageBox.Show("输入目录下无PDF文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            try
            {
                Properties.Settings.Default.xnum = int.Parse(xnum.Value.ToString());
                Properties.Settings.Default.ynum = int.Parse(ynum.Value.ToString());
                Properties.Settings.Default.wnum = int.Parse(wnum.Value.ToString());
                Properties.Settings.Default.hnum = int.Parse(hnum.Value.ToString());
                Properties.Settings.Default.Save();
                Cpublic.log.Info("X坐标写入程序初始化：当前值" + xnum.Value.ToString());
                Cpublic.log.Info("Y坐标写入程序初始化：当前值" + ynum.Value.ToString());
                Cpublic.log.Info("W坐标写入程序初始化：当前值" + wnum.Value.ToString());
                Cpublic.log.Info("H坐标写入程序初始化：当前值" + hnum.Value.ToString());
            }
            catch (Exception ex)
            {
                Properties.Settings.Default.xnum = 0;
                Properties.Settings.Default.ynum = 0;
                Properties.Settings.Default.wnum = 0;
                Properties.Settings.Default.hnum = 0;
                Properties.Settings.Default.Save();
                Cpublic.log.Info("坐标写入程序初始化失败，将重置为0! " + ex.Message);
            }
            int s = 0;
            for (int i = 0; i < list.Rows.Count; i++)
            {
                var filepath = list.Rows[i]["allname"].ToString();
                PdfDocument doc = new PdfDocument();

                //加载PDF文件
                doc.LoadFromFile(filepath);

                //获取指定页面
                PdfPageBase page = doc.Pages[0];

                //创建一个 PdfTextExtractot 对象
                PdfTextExtractor textExtractor = new PdfTextExtractor(page);

                //创建一个 PdfTextExtractOptions 对象
                PdfTextExtractOptions extractOptions = new PdfTextExtractOptions();

                //设置矩形区域范围
                extractOptions.ExtractArea = new RectangleF(float.Parse(xnum.Value.ToString()), float.Parse(ynum.Value.ToString()), float.Parse(wnum.Value.ToString()), float.Parse(hnum.Value.ToString()));
                //OcrScanner scanner = new OcrScanner();

                //scanner.Scan("F:\\测试\\页面提取自－组合 1.jpg");
                //从指定区域中提取文本
                string text2 = textExtractor.ExtractText(extractOptions);
                text2 = text2.Replace("Evaluation Warning : The document was created with Spire.PDF for .NET.", "");
                text2 = text2.Replace(" ", "");
                text2 = text2.Replace("\n", "");
                text2 = text2.Replace("\r", "");
                text2 = text2.Replace("\\", "");
                var newname = Mtext.Text.ToString() + ("\\") + String.Concat(text2,"_",i.ToString()) + (".pdf");
                doc.Close();
                ((IDisposable)doc).Dispose();
                //string text2 = scanner.Text.ToString();
                if (File.Exists(list.Rows[i]["allname"].ToString()))
                {
                    if (!File.Exists(newname))
                    {
                        try
                        {
                            File.Move(list.Rows[i]["allname"].ToString(), newname);
                            s++;
                        }
                        catch (Exception ex)
                        {
                            text("重命名失败：" + newname, 0xFF0000);
                            Cpublic.log.Error("重命名失败：" + list.Rows[i]["allname"].ToString()+""+ex.Message);
                        }
                    }
                    else
                    {
                        text("当前文件夹下已有该名称的文件：" + newname, 0x4876FF);
                    }
                }
                else
                {
                    text("未找到该文件：" + list.Rows[i]["allname"].ToString(), 0xFF0000);
                    Cpublic.log.Error("未找到该文件：" + list.Rows[i]["allname"].ToString());
                }
            }
            MessageBox.Show("PDF处理完成，共处理文件" + s.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            text("PDF处理完成，共处理文件" + s.ToString());
        }
        //提取转换的PDF指定区域文字
        private void PDFSM(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Rows.Count; i++)
            {
                var filepath = list.Rows[i]["allname"].ToString();
                PdfDocument doc = new PdfDocument();

                //加载PDF文件
                doc.LoadFromFile(filepath);

                //获取指定页面
                PdfPageBase page = doc.Pages[0];

                //创建一个 PdfTextExtractot 对象
                PdfTextExtractor textExtractor = new PdfTextExtractor(page);

                //创建一个 PdfTextExtractOptions 对象
                PdfTextExtractOptions extractOptions = new PdfTextExtractOptions();

                //设置矩形区域范围
                extractOptions.ExtractArea = new RectangleF(0, 0, 800, 800);

                //从指定区域中提取文本
                string text2 = textExtractor.ExtractText(extractOptions);
                text(text2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clearmin();
        }

        private void Pdfident_Load(object sender, EventArgs e)//初始加载设置区域值
        {
            xnum.Value = Properties.Settings.Default.xnum;
            ynum.Value = Properties.Settings.Default.ynum;
            wnum.Value = Properties.Settings.Default.wnum;
            hnum.Value = Properties.Settings.Default.hnum;
        }
        private void Clearmin()
        {
            mians.Controls.Clear();
            y = 11;
            list.Clear();
            Gtext.Text = "";
            Mtext.Text = "";
        }
    }
}

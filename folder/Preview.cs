using Spire.Pdf.Texts;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Spire.Additions.Xps.Schema;

namespace folder
{
    public partial class Preview : Form
    {
        private static int y = 11;
        public Preview()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Multiselect = false,
                Title = "请选择文件", //选择器提示文字
                Filter = "PFF(*.PDF,*.pdf)|*.PDF;*.pdf" //文件类型
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileDialog.FileName))
                {
                    MessageBox.Show("文件路径不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cpublic.log.Error("文件路径不能为空！");
                    return;
                }
                Gtext.Text = fileDialog.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PdfDocument doc = new PdfDocument();

            //加载PDF文件
            doc.LoadFromFile(Gtext.Text);

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
            //string text2 = scanner.Text.ToString();
            mians.Controls.Clear();
            y = 11;
            text("识别内容:" + text2);
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
    }
}

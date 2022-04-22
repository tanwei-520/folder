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
using System.Threading;
namespace folder
{
    public partial class MonitorFolder : Form
    {
        public FileSystemWatcher fsw = new FileSystemWatcher();
        private static int y = 11;
        private int end = 0;//记录标记
        public static int a = 0;
        private DataTable list = new DataTable();//目录清单
        private DataTable Data = new DataTable();//模板
        private string[] lie={"完整目录","目录名称","编号"};
        private DataTable Reomname = new DataTable();
        private DataTable create = new DataTable();
        private DataTable initialize = new DataTable();//初始化各目录文件数量
        public MonitorFolder()
        {
            InitializeComponent();
            Cpublic.log.Info("启动监听文件夹菜单");
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

        private void button4_Click(object sender, EventArgs e)
        {
            /*            if (Directory.Exists(Gtext.Text))
                        {
                            //文件路径
                            string[] dir = Directory.GetDirectories(Gtext.Text);
                            //文件名
                            Cpublic.log.Info(dir);
                        }
                        else
                        {
                            Cpublic.log.Error("未找到路径");
                        }
                        director(Gtext.Text);
                        Cpublic.log.Info(list);*/
            if (Gtext.Text == "")
            {
                MessageBox.Show("根目录为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cpublic.log.Error("根目录为空");
                return;
            }
            try
            {
                Cpublic.log.Info("生成文件夹目录清单");
                list.Clear();
                if (!list.Columns.Contains("all"))
                {
                    list.Columns.Add("all");
                }
                if (!list.Columns.Contains("name"))
                {
                    list.Columns.Add("name");
                }
                DataRow dr = list.NewRow();
                dr["all"] = Gtext.Text;
                dr["name"] =Gtext.Text.Substring(Gtext.Text.LastIndexOf("\\") + 1);
                list.Rows.Add(dr);
                Cpublic.log.Info(Gtext.Text.Substring(Gtext.Text.LastIndexOf("\\") + 1));
                dibdad(Gtext.Text);
                //Cpublic.log.Info(list);
                if (Gtext.Text != "")
                {
                    Cpublic.log.Info("开始生成清单EXCEL");
                    if (list.Rows.Count > 0)
                    {
                        XSSFWorkbook workbook = new XSSFWorkbook();
                        workbook.CreateSheet("sheet1");
                        XSSFSheet sheet = (XSSFSheet)workbook.GetSheet("sheet1");
                        for (int h = 0; h < list.Rows.Count + 1; h++)
                            sheet.CreateRow(h);
                        XSSFRow sheetrow = (XSSFRow)sheet.GetRow(0);
                        XSSFCell[] sheetcell = new XSSFCell[list.Columns.Count + 1];
                        for (int i = 0; i < list.Columns.Count + 1; i++)
                        {
                            sheetcell[i] = (XSSFCell)sheetrow.CreateCell(i);
                            sheet.SetColumnWidth(i, 18 * 386);
                        }
                        sheetcell[0].SetCellValue("完整目录");
                        sheetcell[1].SetCellValue("目录名称");
                        sheetcell[2].SetCellValue("编号");
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
                        FileStream fss = new FileStream(@"" + Gtext.Text + "\\目录清单.xlsx", FileMode.Create);
                        workbook.Write(fss);
                        fss.Close();
                        workbook.Close();
                        MessageBox.Show("生成成功，目录清单放置在根目录下！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Cpublic.log.Info("清单生成成功：" + Gtext.Text + "\\目录清单.xlsx");
                    }
                }
                else
                {
                    MessageBox.Show("根目录为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cpublic.log.Error("根目录为空");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("清单生成失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cpublic.log.Error("清单生成失败！"+ex.Message);
            }
        }
        private void director(string dirs)
        {
            //绑定到指定的文件夹目录
            DirectoryInfo dir = new DirectoryInfo(dirs);
            //检索表示当前目录的文件和子目录
            //FileSystemInfo[] fsinfos = dir.GetFileSystemInfos();
            FileSystemInfo[] fsinfos = dir.GetDirectories();
            //遍历检索的文件和子目录
            foreach (FileSystemInfo fsinfo in fsinfos)
            {
                //判断是否为空文件夹　　
                if (fsinfo is DirectoryInfo)
                {
                    //递归调用
                    director(fsinfo.FullName);
                }
                else
                {
                    //将得到的文件全路径放入到集合中
                   // list.Add(fsinfo.FullName);
                }
            }
        }
        private void dibdad(string dirs)
        {
            if (Directory.Exists(dirs))
            {
                //文件路径
                string[] dir = Directory.GetDirectories(dirs);
                //文件名
                for (int i=0;i<dir.Length; i++)
                {
                    DataRow dr = list.NewRow();
                    dr["all"] = dir[i];
                    dr["name"] = dir[i].Replace(dirs + "\\", "");
                    list.Rows.Add(dr);
                    Cpublic.log.Info(dir[i].Replace(dirs + "\\", "")+"  "+i);
                    dibdad(dir[i]);
                }
            }
            else
            {
                Cpublic.log.Error("未找到路径："+ dirs);
            }
        }
        private void conuts(string dirs)//初始化数据
        {
            if (Directory.Exists(dirs))
            {
                //文件路径
                string[] dir = Directory.GetDirectories(dirs);
                //文件名
                for (int i = 0; i < dir.Length; i++)
                {
                    DataRow dr = initialize.NewRow();
                    dr["path"] = dir[i];
                    dr["count"] =int.Parse(Directory.GetFiles(dir[i]).Length.ToString());
                    initialize.Rows.Add(dr);
                    Cpublic.log.Info(dir[i]+"--" + (int.Parse(Directory.GetFiles(dir[i]).Length.ToString())));
                    conuts(dir[i]);
                }
            }
            else
            {
                Cpublic.log.Error("未找到路径：" + dirs);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Gtext.Text == "")
            {
                MessageBox.Show("根目录为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cpublic.log.Error("监听根目录为空!");
                return;
            }
            if (a!=0)
            {
                if (fsw.EnableRaisingEvents == true)
                {
                    MessageBox.Show("监听正在运行中！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cpublic.log.Info("监听正在运行中!同时运行多个监听，会导致记录重复！");
                    return;
                }
            }
            if (Mtext.Text=="")
            {
                if (MessageBox.Show("当前模板为空，继续仍可监听，但不会进行自动重命名（是/否）", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    run(a);
                    a++;
                    end = 1;
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (end==0) 
                {

                    Reomname.Columns.Add("path");
                    Reomname.Columns.Add("old");
                    Reomname.Columns.Add("new");
                    create.Columns.Add("path");
                    create.Columns.Add("name");
                    initialize.Columns.Add("path");
                    initialize.Columns.Add("count");
                    text("开始初始化程序...");
                    Cpublic.log.Info("开始初始化程序...");
                    DataRow dr = initialize.NewRow();
                    dr["path"] = Gtext.Text;
                    dr["count"] = int.Parse(Directory.GetFiles(Gtext.Text).Length.ToString());
                    initialize.Rows.Add(dr);
                    conuts(Gtext.Text);
                    if (initialize.Rows.Count<1)
                    {
                        Cpublic.log.Error("程序初始化失败！Count="+initialize.Rows.Count);
                        text("程序初始化失败！", 0xFF0000);
                        return;
                    }
                    else
                    {
                        Cpublic.log.Info("程序初始化成功！Count=" + initialize.Rows.Count);
                        text("程序初始化成功！");
                    }
                }
                end = 2;
                run(a);
                a++;
            }
        }
        public void run(int a)//开始监听
        {
            try
            {
                if (a == 0)
                {
                    fsw.Path = @"" + Gtext.Text;
                    fsw.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.CreationTime | NotifyFilters.FileName;
                    fsw.Filter = "*.*";
                    fsw.IncludeSubdirectories = true;
                    fsw.InternalBufferSize = 64 * 1024;
                    fsw.Created += new FileSystemEventHandler(Fsw_Created);
                    // fsw.Changed += new FileSystemEventHandler(Fsw_Changed);
                    fsw.Deleted += new FileSystemEventHandler(Fsw_Deleted);
                    fsw.Renamed += new RenamedEventHandler(Fsw_Renamed);
                    fsw.EnableRaisingEvents = true;
                    text("开始监听");
                    Cpublic.log.Info("启动监听");
                }
                else
                {
                    fsw.EnableRaisingEvents = true;
                    text("开始监听");
                    Cpublic.log.Info("启动监听");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("未能成功启动监听程序！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cpublic.log.Error("未能成功启动监听程序："+ex.Message);
            }
        }

        private  void Fsw_Renamed(object sender, RenamedEventArgs e)
        {
            text("文件重命名："+e.OldName, 0x00CD00);
            text("重命名结果："+e.Name, 0x00CD00);
            Cpublic.log.Info("文件重命名：" + e.OldName);
            Cpublic.log.Info("重命名结果：" + e.Name);
                DataRow dr = Reomname.NewRow();
                dr["path"] = e.FullPath.Substring(0,e.FullPath.LastIndexOf("\\")); 
                dr["old"] = e.OldName.Substring(e.OldName.LastIndexOf("\\")+1);
                dr["new"] = e.Name.Substring(e.Name.LastIndexOf("\\")+1);
                Reomname.Rows.Add(dr);
            //WriteLine($"原名：{e.OldName}   新名称：{e.Name}");
        }
        private  void Fsw_Deleted(object sender, FileSystemEventArgs e)
        {
            text("删除文件：" + e.Name, 0xFF0000);
            Cpublic.log.Info("删除文件：" + e.Name);
            //  WriteLine($"{e.Name}  我被删除了");
        }
/*        private  void Fsw_Changed(object sender, FileSystemEventArgs e)
        {
            text("文件复制或修改（"+e.ChangeType+"）：" + e.Name, 0x10B2AA);
            // WriteLine($"{e.Name}  我被修改了");
        }*/
        private  void Fsw_Created(object sender, FileSystemEventArgs e)
        {
            text("创建文件：" + e.Name,0x4876FF);
            Cpublic.log.Info("创建文件：" + e.Name);
            try
            {
                if (end == 2)
                {
                    DataRow d = create.NewRow();
                    d["path"] = e.FullPath.Substring(0, e.FullPath.LastIndexOf("\\"));
                    d["name"] = e.Name;
                    create.Rows.Add(d);
                    bool done = false;
                    DataRow[] fc;
                    fc = create.Select("path = '" + e.FullPath.Substring(0, e.FullPath.LastIndexOf("\\")) + "'");
                    DataRow[] fd;
                    fd = initialize.Select("path = '" + e.FullPath.Substring(0, e.FullPath.LastIndexOf("\\")) + "'");
                    if (fd.Length < 1)
                    {
                        Cpublic.log.Error("该路径数据未能初始化成功：" + e.FullPath.Substring(0, e.FullPath.LastIndexOf("\\")));
                        DataRow ac = initialize.NewRow();
                        ac["path"] = e.FullPath.Substring(0, e.FullPath.LastIndexOf("\\"));
                        ac["count"] = 1;
                        fd[0] = ac;
                    }
                    string s = (int.Parse(fd[0]["count"].ToString()) + int.Parse(fc.Length.ToString())).ToString();
                    s = s.PadLeft((5), '0');
                    Cpublic.log.Info("S:" + s);
                    do
                    {
                        try
                        {
                            using (File.Open(e.FullPath, FileMode.Open)) { done = true; }
                        }
                        catch { done = false; Cpublic.log.Error("文件被占用"); }
                        Thread.Sleep(800);
                    } while (!done);
                    string name = "";
                    string name2 = "";
                    string[] sname = e.FullPath.Replace(Gtext.Text, "").Split("\\", StringSplitOptions.None);
                    for (int i = 0; i < sname.Length - 1;)
                    {
                        DataRow[] dr;
                        string sql = "";
                        if (sname[i] == "")
                        {
                            name2 += sname[i];
                            sql = "" + Gtext.Text + "" + name2 + "";
                        }
                        else
                        {
                            name2 = name2 + "\\" + sname[i];
                            sql = "" + Gtext.Text + "" + name2 + "";
                        }
                        dr = Data.Select("all='" + sql + "'");
                        if (dr.Length > 0)
                        {
                            // Cpublic.log.Info("ssss:" + dr[0]["tno"].ToString());
                            if (dr[0]["tno"].ToString() != "")
                            {
                                if (dr[0]["tno"].ToString() == "custom")
                                {
                                    if (ActiveMdiChild != null)
                                    {
                                        ActiveMdiChild.Close();
                                    }
                                    Alter f = new Alter();
                                    f.Activate();
                                    f.TopMost = true;
                                    f.ShowDialog();
                                    //  this.Invoke(new Action(() => { f.ShowDialog();}));
                                    //  
                                    if (Cpublic.tno != "" && Cpublic.tno != null)
                                    {
                                        name += Cpublic.tno + "-";
                                    }
                                }
                                else
                                {
                                    name += dr[0]["tno"].ToString() + "-";
                                }
                            }
                        }
                        // Cpublic.log.Info(i + ":" + sql + ":" + dr.Length);
                        i++;
                    }
                    if (name != "")
                    {
                        try
                        {
                            name += s;
                            name += e.FullPath.Substring(e.FullPath.LastIndexOf("."));
                            //ThreadPool.QueueUserWorkItem(Worker, fsArgs);
                            File.Move(e.FullPath, e.FullPath.Substring(0, e.FullPath.LastIndexOf("\\")) + "\\" + name);
                        }
                        catch (Exception ex)
                        {
                            text("重命名失败,文件可能被占用", 0xFF34B3);
                            Cpublic.log.Error("重命名失败：" + ex.Message);
                        }
                    }
                    else
                    {
                        Cpublic.log.Info("当前路径下，重命名结果为空，若有异常请检查编码模板！ " + e.FullPath);
                    }
                }
            }
            catch (Exception ex)
            {
                Cpublic.log.Error("重命名失败！"+ex.Message);
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
        public  void text(string text, int coloer)
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

        private void MonitorFolder_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                fsw.EnableRaisingEvents = false;
                text("停止监听");
                Cpublic.log.Info("停止监听");
            }
            catch(Exception ex)
            {
                MessageBox.Show("未能成功停止监听程序！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cpublic.log.Error("未能成功停止监听程序："+ex.Message);
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
                try
                {
                    Mtext.Text = fileDialog.FileName; //获取文件路径（带文件名）
                    Cpublic.log.Info("选择模板 " + fileDialog.FileName);// filenameonly.Text = info.Name;  //获取文件名
                    Cpublic.log.Info("开始读取模板 " + Mtext.Text);
                    Data.Clear();
                    if (!Data.Columns.Contains("all"))
                    {
                        Data.Columns.Add("all");
                    }
                    if (!Data.Columns.Contains("name"))
                    {
                        Data.Columns.Add("name");
                    }
                    if (!Data.Columns.Contains("tno"))
                    {
                        Data.Columns.Add("tno");
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
                    for (int i = 0; i < 3; i++)
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
                    DataRow[] dc;
                    dc = Data.Select(" tno <> ''");
                    MessageBox.Show("模板读取成功，共" + Data.Rows.Count + "行数据。含编号" + dc.Length + "个", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    end = 0;
                    Cpublic.log.Info("模板读取成功，共" + Data.Rows.Count + "行数据。含编号" + dc.Length + "个");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("模板读取错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cpublic.log.Error("模板读取错误！"+ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Gtext.Text == "")
            {
                MessageBox.Show("根目录为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cpublic.log.Error("根目录为空");
                return;
            }
            try
            {
                Cpublic.log.Info("导出重命名记录");
                //Cpublic.log.Info(list);
                if (Gtext.Text != "")
                {
                    Cpublic.log.Info("开始导出重命名记录EXCEL");
                    if (Reomname.Rows.Count > 0)
                    {
                        XSSFWorkbook workbook = new XSSFWorkbook();
                        workbook.CreateSheet("sheet1");
                        XSSFSheet sheet = (XSSFSheet)workbook.GetSheet("sheet1");
                        for (int h = 0; h < Reomname.Rows.Count + 1; h++)
                            sheet.CreateRow(h);
                        XSSFRow sheetrow = (XSSFRow)sheet.GetRow(0);
                        XSSFCell[] sheetcell = new XSSFCell[Reomname.Columns.Count + 1];
                        for (int i = 0; i < Reomname.Columns.Count + 1; i++)
                        {
                            sheetcell[i] = (XSSFCell)sheetrow.CreateCell(i);
                            sheet.SetColumnWidth(i, 18 * 386);
                        }
                        sheetcell[0].SetCellValue("文件目录");
                        sheetcell[1].SetCellValue("修改前文件名");
                        sheetcell[2].SetCellValue("修改后文件名");
                        for (int i = 0; i < Reomname.Rows.Count; i++)
                        {
                            sheetrow = (XSSFRow)sheet.GetRow(i + 1);
                            for (int t = 0; t < Reomname.Columns.Count; t++)
                            {
                                sheetcell[t] = (XSSFCell)sheetrow.CreateCell(t);
                                if (Reomname.Rows[i][t] != null || Reomname.Rows[i][t].ToString() == "")
                                {
                                    sheetcell[t].SetCellValue(Reomname.Rows[i][t].ToString());
                                }
                                else
                                {
                                    sheetcell[t].SetCellValue("");
                                }
                            }
                        }
                        FileStream fss = new FileStream(@"" + Gtext.Text + "\\重命名记录"+ DateTime.Now.Day.ToString()+ DateTime.Now.ToLongTimeString().ToString().Replace(":","")+".xlsx", FileMode.Create);
                        workbook.Write(fss);
                        fss.Close();
                        workbook.Close();
                        MessageBox.Show("生成成功，重命名记录放置在根目录下！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Cpublic.log.Info("重命名记录生成成功：" + Gtext.Text + "\\重命名记录" + DateTime.Now.Day.ToString() + DateTime.Now.ToLongTimeString().ToString().Replace(":", "") + ".xlsx");
                    }
                    else
                    {
                        MessageBox.Show("当前记录为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Cpublic.log.Info("当前记录为空,不能导出重命名记录！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("重命名记录生成失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cpublic.log.Error("重命名记录生成失败！" + ex.Message);
            }
        }
    }
}

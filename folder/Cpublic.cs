using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using log4net;
using log4net.Config;

[assembly: XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]

namespace folder
{
    class Cpublic
    {
        public static string AppPath;
/*        public static void Log(string logs)
        {
            if (!File.Exists(AppPath + "log.txt"))
                File.Create(AppPath + "log.txt").Close();
            StreamWriter dout = new StreamWriter(AppPath + "log.txt", true);
            dout.Write(System.DateTime.Now.ToString("yyy-MM-dd HH:mm:ss") + " : "+logs);
            dout.Write(System.Environment.NewLine); //换行
            dout.Close();
        }*/ //自写日志
        public static readonly ILog log = LogManager.GetLogger(typeof(Program));//log4net日志
    }
}

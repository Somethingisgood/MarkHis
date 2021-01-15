using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebService
{
    public static class Common
    {
        internal static void WriteLog(string vsString, string vsFileGourp = "服务日志")
        {
            try
            {
                if (vsString.ToUpper().Contains("ORA-00060"))
                {
                    vsFileGourp = "死锁监测日志";
                }
                string text = AppDomain.CurrentDomain.BaseDirectory + vsFileGourp;
                if (!Directory.Exists(text))
                {
                    Directory.CreateDirectory(text);
                }
                string str = text;
                DateTime now = DateTime.Now;
                string path = str + "\\" + now.ToString("yyyy-MM-dd") + ".log";
                using (StreamWriter streamWriter = new StreamWriter(path, true))
                {
                    StreamWriter streamWriter2 = streamWriter;
                    now = DateTime.Now;
                    streamWriter2.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss:fff"));
                    streamWriter.WriteLine(vsString + "\r\n");
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
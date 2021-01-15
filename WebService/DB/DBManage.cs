using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebService
{
    public static class DBManage
    {
        public static int ExecSql( string sql, string vsKey, TSQLPara tPara = null)
        {
            int num = 0;
            try
            {


            }
            catch
            {

            }
            return num;
        }


        /// <summary>
        /// 日志保存
        /// </summary>
        /// <param name="opt"></param>
        /// <param name="vsKey"></param>
        /// <param name="vsText"></param>
        /// <param name="vsType"></param>
        /// <param name="vbSave"></param>
        public static void SaveOptLog(string vsKey, string vsText, string vsType = "1", bool vbSave = true)
        {
            try
            {
                DateTime now = DateTime.Now;

                object[] obj = new object[11]
                        {
                        AppDomain.CurrentDomain.BaseDirectory,
                        "\\系统操作日志\\",
                       "备注下",// opt.fsRemark1, 第二阶段
                        "\\",
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null
                        };
                now = DateTime.Now;
                obj[4] = now.Year;
                obj[5] = "\\";
                now = DateTime.Now;
                obj[6] = now.Month;
                obj[7] = "\\";
                now = DateTime.Now;
                obj[8] = now.Day;
                obj[9] = "\\";
                obj[10] = "目前单用户"; //obj[10] = opt.fsUserID; 第二阶段
                string text = string.Concat(obj) ?? "";
                if (!Directory.Exists(text))
                {
                    Directory.CreateDirectory(text);
                }
                string[] obj2 = new string[6]
                {
                        text,
                        "\\",
                        null,
                        null,
                        null,
                        null
                };
                now = DateTime.Now;
                obj2[2] = now.ToString("yyyy-MM-dd");
                obj2[3] = "_";
                obj2[4] = vsType;
                obj2[5] = ".log";
                string path = string.Concat(obj2);
                using (StreamWriter streamWriter = new StreamWriter(path, true))
                {
                    //streamWriter.WriteLine(aLogInfo.SerializeObject() + "*\r\n"); 数据json化，第二阶段
                    streamWriter.WriteLine("日志的具体信息--第二阶段" + "*\r\n");
                    streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                Common.WriteLog(ex.Message + "->" + vsText, "服务日志");
            }
        }




    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebService
{
    /// <summary>
    /// 返回结果类
    /// </summary>
    [Serializable]
    public class ResultClass
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        public bool vbResult = false;
        /// <summary>
        /// 提示信息
        /// </summary>
        public string vsMessage = "";
        /// <summary>
        /// 返回表
        /// </summary>
        public DataTable vdTable = null;
        /// <summary>
        /// 受影响行数
        /// </summary>
        public int viCount = 0;
        //public TSQLPara tPara = null;
        //public TSQLPara[] tPara_Proc = null;


    }
}
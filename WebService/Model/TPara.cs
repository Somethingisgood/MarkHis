using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class TPara
    {
        /// <summary>
        /// 参数名称
        /// </summary>
        public string sName = "@";
        /// <summary>
        /// 参数值
        /// </summary>
        public string sValue = "";
        /// <summary>
        /// 参数类型
        /// </summary>
        public string sType = "S";
        /// <summary>
        /// 输入-是否
        /// </summary>
        public bool bOut = false;
        /// <summary>
        /// 输入输出-是否
        /// </summary>
        public bool bIntOut = false;
    }
}
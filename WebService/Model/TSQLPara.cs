using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class TSQLPara
    {

        /// <summary>
        /// 参数
        /// </summary>
        public TPara[] paraList = new TPara[128];
        /// <summary>
        /// 参数个数
        /// </summary>
        public int iCount = 0;

        //TODO 这个输出参数有什么用？第二阶段
        //private int[] iOutIdx = new int[128];

        //private int icc = 0;

        /// <summary>
        /// 添加参数--方法一
        /// </summary>
        /// <param name="vsName"></param>
        /// <param name="vsValue"></param>
        public void AddInPara(string vsName, object vsValue)
        {
            paraList[iCount] = new TPara();
            paraList[iCount].sName = vsName;
            paraList[iCount].sValue = vsValue.ToString();
            paraList[iCount].bOut = false;
            iCount++;
        }

        /// <summary>
        /// 添加参数--方法二
        /// </summary>
        /// <param name="vsName"></param>
        /// <param name="vsValue"></param>
        /// <param name="type"></param>
        public void AddInPara(string vsName, object vsValue, string type)
        {
            paraList[iCount] = new TPara();
            paraList[iCount].sName = vsName;
            paraList[iCount].sValue = vsValue.ToString();
            paraList[iCount].bOut = false;
            paraList[iCount].sType = type;
            iCount++;
        }

        /// <summary>
        /// 修改参数值
        /// </summary>
        /// <param name="vsName"></param>
        /// <param name="vsValue"></param>
        public void SetInPara(string vsName, object vsValue)
        {
            int num = 0;
            while (true)
            {
                if (num < iCount)
                {
                    if(!(paraList[num].sName==vsName))
                    {
                        num++;
                        continue;
                    }
                    break;
                }
                return;
            }
            paraList[num].sValue = vsValue.ToString();
        }

        public string GetValue(string vsName)
        {
            for(int i=0;i<iCount;i++)
            {
                if(paraList[i].sName.ToUpper() == vsName.ToUpper())
                {
                    return paraList[i].sValue;
                }
            }

            throw new Exception("参数名称[" + vsName + "]不存在.");
        }

        #region 暂时注释-搞清楚输出参数用法
        ///// <summary>
        ///// 添加输出参数-方法一
        ///// </summary>
        ///// <param name="vsName"></param>
        ///// <param name="viBufLen"></param>
        //public void AddOutPara(string vsName, int viBufLen)
        //{
        //    paraList[iCount] = new TPara();
        //    paraList[iCount].sName = vsName;
        //    paraList[iCount].sValue = viBufLen.ToString();
        //    paraList[iCount].bOut = true;
        //    iOutIdx[icc] = iCount;
        //    icc++;
        //    iCount++;
        //}

        ///// <summary>
        ///// 添加输出参数-方法二
        ///// </summary>
        ///// <param name="vsName"></param>
        ///// <param name="viBufLen"></param>
        //public void AddOutPara(string vsName, int viBufLen)
        //{
        //    paraList[iCount] = new TPara();
        //    paraList[iCount].sName = vsName;
        //    paraList[iCount].sValue = viBufLen.ToString();
        //    paraList[iCount].bOut = true;
        //    iOutIdx[icc] = iCount;
        //    icc++;
        //    iCount++;
        //}

        //public void Format(string vsOutList)
        //{
        //    string[] array = vsOutList.Split('\t');
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        paraList[iOutIdx[i]].sValue = array[i];
        //    }
        //}
        #endregion

    }
}
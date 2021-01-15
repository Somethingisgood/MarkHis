using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// WebService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

    
        /// <summary>
        /// 执行 insert update delete
        /// </summary>
        /// <param name="vsSql">sql</param>
        /// <param name="tPara">参数</param>
        /// <returns></returns>

        public ResultClass ExecSql(string vsSql, TSQLPara tPara)
        {
            //TODO ///授权验证后续完成优化 第二阶段
            //Authorization.Validate(licensees, licenseKey);
            //OptExecTime optExecTime = new OptExecTime(vsSql, optClass);

            ///服务器升级验证
            //if (Common.IsUpgrading && Common.fsUpgradingKEY != vsKey)
            //{
            //    resultClass.vbResult = false;
            //    resultClass.vsMessage = "当前服务器正在升级,请等待升级完成后重试!";
            //    return resultClass;
            //}

            ResultClass resultClass = new ResultClass();
            try
            {
                int viCount = DBManage.ExecSql( vsSql, tPara);
                resultClass.vbResult = true;
                resultClass.viCount = viCount;
            }
            catch (Exception ex)
            {
                resultClass.vbResult = false;
                resultClass.vsMessage = ex.Message;
            }

        }
    }
}

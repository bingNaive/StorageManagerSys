using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Storage.UI.Portal
{
    /// <summary>
    /// Route 的摘要说明
    /// </summary>
    public class Route : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var path = context.Request.Path;
            //拆分路径获取类名和方法名.do
            string[] data = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

            //                        获取当前项目的程序集
            Assembly ass = this.GetType().Assembly;
            //                                                        通过路径中的类名创建对象
            var controller = ass.CreateInstance("Storage.UI.Portal.Controllers." + data[1] + "Controller");
            //获取创建对象的类型
            Type conType = controller.GetType();
            //                              获取对应的方法     调用执行该方法
            conType.GetMethod(data[2]).Invoke(controller, new object[] { context });
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
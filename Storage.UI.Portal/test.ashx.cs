using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Storage.BLL;

namespace Storage.UI.Portal
{
    /// <summary>
    /// test 的摘要说明
    /// </summary>
    public class test : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            UserService us = new UserService();
            var list = us.GetSignleEntities().ToList();
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
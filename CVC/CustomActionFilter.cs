
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI;

namespace CVC
{      //Updated on 20 Nov 2017 4.45PM

  
    public class CustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {


            LogError(filterContext);
            // base.OnException(filterContext);

            filterContext.Result = new RedirectResult("~/ErrorPage/Index");
            filterContext.ExceptionHandled = true;
            //HttpContext.Current.Response.Write("<script>alert('Hello');</script>");
        }
        public void MsgBox()
        {
         //   this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You clicked YES!')", true);
        }

        //public override void OnException(ExceptionContext filterContext)
        //{
        //    LogError(filterContext);
        //    base.OnException(filterContext);
        //}

        public void LogError(ExceptionContext filterContext)
        {
            // You could use any logging approach here
            //try
            //{
            StringBuilder builder = new StringBuilder();
            builder
                .AppendLine("----------")
                .AppendLine(DateTime.Now.ToString())
                .AppendFormat("Source:\t{0}", filterContext.Exception.Source)
                .AppendLine()
                .AppendFormat("Target:\t{0}", filterContext.Exception.TargetSite)
                .AppendLine()
                .AppendFormat("Type:\t{0}", filterContext.Exception.GetType().Name)
                .AppendLine()
                .AppendFormat("Message:\t{0}", filterContext.Exception.Message)
                .AppendLine()
                .AppendFormat("Stack:\t{0}", filterContext.Exception.StackTrace)
                .AppendLine();

            //if (!Directory.Exists(filterContext.HttpContext.Server.MapPath("~/ErrorLog/Error.log")))
            //{
            //    Directory.CreateDirectory((filterContext.HttpContext.Server.MapPath("~/ErrorLog/Error.log")));
            //}
            //string filePath = filterContext.HttpContext.Server.MapPath("~/ErrorLog/Error.log");

            string path = AppDomain.CurrentDomain.BaseDirectory + "\\ErrorLog";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\ErrorLog\\ErrorLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
            if (!File.Exists(filepath))
            {
                // Create a file to write to.   
                using (StreamWriter writer = File.CreateText(filepath))
                {
                    writer.Write(builder.ToString());
                    writer.Flush();
                    // sw.WriteLine(" At " + DateTime.Now.ToString() + " Section: " + Section + " Error: " + Message + " Value: " + Value);
                }
            }

            using (StreamWriter writer = File.AppendText(filepath))
            {
                writer.Write(builder.ToString());
                writer.Flush();
            }
            //}
            //catch(Exception ex)
            //{
            //    throw ex;
            //}
        }
    }
}
using CVC.BusinessServices.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace CVC.License.Algorithms
{
    public class ErrorManagement
    {
        readonly CommonServices commonServices = new CommonServices();
        public void ErrorMessage(string ErrorMessage)
        {
            Console.WriteLine(ErrorMessage);
        }
        public void ErrorMessage(string ErrorMessage, Exception ex)
        {
            Console.WriteLine(ErrorMessage);
        }
        //public void ErrorMessage(String FunctionName, string ErrorMessage, Exception ex)
        //{
        //    Console.WriteLine(ErrorMessage);
        //    if (ex != null)
        //        commonServices.AddToAuditLog(ex.Message);
        //}
        public void LogMessage(String FunctionName, string Message)
        {
            try
            {
                String LogDate = DateTime.Now.ToString();
                Console.WriteLine(Message);
                string controllerName = null;
                string actionName = null;
                string Url = null;
                HttpContextBase context = new HttpContextWrapper(HttpContext.Current);
                if (context != null)
                {
                    RouteData routeData = RouteTable.Routes.GetRouteData(context);
                    if (routeData.Values.ContainsKey("MS_DirectRouteMatches"))
                    {
                        routeData = ((IEnumerable<RouteData>)routeData.Values["MS_DirectRouteMatches"]).First();
                    }
                    if (routeData != null)
                    {
                        controllerName = (routeData.Values["controller"] as string != null) ? routeData.Values["controller"] as string : null;
                        actionName = (routeData.Values["action"] as string != null) ? routeData.Values["action"] as string : null;
                        Url = $"{controllerName}/{actionName}";
                    }
                }
                commonServices.AddToAuditLog(Action: Message, Module: controllerName, Page: Url);
            }
            catch (Exception ex)
            {
            }

        }
        public void ErrorMessage(String FunctionName, string Message, Exception ex = null)
        {
            Console.WriteLine(Message);
            string controllerName = null;
            string actionName = null;
            string Url = null;
            HttpContextBase context = new HttpContextWrapper(HttpContext.Current);
            if (context != null)
            {
                RouteData routeData = RouteTable.Routes.GetRouteData(context);
                if (routeData.Values.ContainsKey("MS_DirectRouteMatches"))
                {
                    routeData = ((IEnumerable<RouteData>)routeData.Values["MS_DirectRouteMatches"]).First();
                }
                if (routeData != null)
                {
                    controllerName = (routeData.Values["controller"] as string != null) ? routeData.Values["controller"] as string : null;
                    actionName = (routeData.Values["action"] as string != null) ? routeData.Values["action"] as string : null;
                    Url = $"{controllerName}/{actionName}";
                }
            }
            if (ex != null)
            {
                commonServices.AddExceptionLog(type: ex.GetType().ToString(), isProtected: false, url: Url, message: ex.Message);
            }
            else
            {
                commonServices.AddToAuditLog(Action: Message, Module: controllerName, Page: Url);
            }
        }
    }
}
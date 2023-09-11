// Decompiled with JetBrains decompiler
// Type: CVC.Global
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Data.EDMX;
using CVC.License.Algorithms;
using CVC.License.Algorithms.Notification;
using CVC.License.Algorithms.Process;
using CVC.Machine.Pages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using bs = CVC.BusinessServices.Common;

namespace CVC
{
    public class Global : HttpApplication
    {
        System.Timers.Timer aTimer = new System.Timers.Timer();
        List<string> lstIPCAddress = new List<string>();
        int sendHeartBeatDefaultvalue = -1;
        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(new Action<HttpConfiguration>(WebApiConfig.Register));
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ValueProviderFactories.Factories.Remove((ValueProviderFactory)ValueProviderFactories.Factories.OfType<JsonValueProviderFactory>().First<JsonValueProviderFactory>());
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add((IViewEngine)new RazorViewEngine());
            SiteInitialization.ApplicationStart();
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            Application["IsSendHeartHeat"] = false;

            CallSendHeartBeatService();
            CallBackupService();
        }


        public void CallSendHeartBeatService()
        {
            try
            {

                System.Timers.Timer aTimer = new System.Timers.Timer();
                aTimer.Elapsed += ATimer_Elapsed;
                aTimer.Interval = 1000;
                aTimer.Enabled = true;
            }
            catch (System.Exception)
            {

            }
        }

        public void CallBackupService()
        {
            try
            {

                System.Timers.Timer aTimer = new System.Timers.Timer();
                aTimer.Elapsed += ATimer_Elapsed1;
                aTimer.Interval = 3000000;
                // aTimer.Interval = 60000;
                aTimer.Enabled = true;
            }
            catch (System.Exception)
            {

            }
        }

        private void ATimer_Elapsed1(object sender, System.Timers.ElapsedEventArgs e)
        {

            new CVC.Modules.Common.Dashboard.DashboardCommon().CheckBackup();

        }

        private void ATimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (Convert.ToBoolean(Application["IsSendHeartHeat"]) == true)
            {
                sendHeartBeatDefaultvalue = new CVC.Modules.Common.Dashboard.DashboardCommon().SendHeartBeat(sendHeartBeatDefaultvalue);
            }
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Application["IsSendHeartHeat"] = false;
            SiteInitialization.ApplicationEnd();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            ////bs.CommonServices commonServices = new bs.CommonServices();




            //HttpContextBase context = new HttpContextWrapper(HttpContext.Current);
            //if (context != null)
            //{
            //    RouteData routeData = RouteTable.Routes.GetRouteData(context);
            //    if (routeData != null)
            //    {
            //        if (routeData.Values.ContainsKey("MS_DirectRouteMatches"))
            //        {
            //            routeData = ((IEnumerable<RouteData>)routeData.Values["MS_DirectRouteMatches"]).First();
            //        }
            //        string controllerName = routeData.Values["controller"] as string ?? null;
            //        string actionName = routeData.Values["action"] as string ?? null;

            //        if (!string.IsNullOrWhiteSpace(controllerName) || !string.IsNullOrWhiteSpace(actionName))
            //        {

            //            var isAjax = Request.Headers["X-Requested-With"] == "XMLHttpRequest";
            //            if (!Logic.LogicImplementation())
            //            {
            //                if (!Logic.isActivationValid || !Logic.isLicenseFileValid || !Logic.IsLicenseControllerValid || Logic.LType == false)
            //                {
            //                    Response.RedirectToRoute(new RouteValueDictionary { { "Controller", "LicenseUpload" }, { "Action", "Index" } });
            //                }
            //                else if ((isAjax && !Logic.IsLicenseActionValid && Logic.isLicenseFileValid))
            //                {
            //                    Response.RedirectToRoute(new RouteValueDictionary { { "Controller", "Common" }, { "Action", "GetMessageDetailsById" }, { "messageTypeId", "29" } });
            //                }
            //            }
            //        }
            //    }
            //}

            HttpCookie cookie = this.Request.Cookies["LanguagePreference"];
            if (cookie == null)
                return;
            if (string.IsNullOrEmpty(cookie.Value))
                return;
            try
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(cookie.Value);
            }
            catch (CultureNotFoundException ex)
            {
            }


        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
        }

        protected void Application_Error(object sender, EventArgs e)
        {
        }
        void Application_EndRequest(object sender, EventArgs e)
        {
            HttpContextBase context = new HttpContextWrapper(HttpContext.Current);
            if (context != null)
            {
                RouteData routeData = RouteTable.Routes.GetRouteData(context);
                if (routeData != null)
                {
                    if (routeData.Values.ContainsKey("MS_DirectRouteMatches"))
                    {
                        routeData = ((IEnumerable<RouteData>)routeData.Values["MS_DirectRouteMatches"]).First();
                    }
                    string controllerName = routeData.Values["controller"] as string ?? null;
                    string actionName = routeData.Values["action"] as string ?? null;

                    var responseStatusCode = Response.StatusCode;
                    List<int> ResponseCodeList = new List<int>();
                    ResponseCodeList.Add(201);
                    ResponseCodeList.Add(202);
                    ResponseCodeList.Add(400);
                    ResponseCodeList.Add(401);
                    ResponseCodeList.Add(403);
                    ResponseCodeList.Add(404);
                    ResponseCodeList.Add(405);
                    ResponseCodeList.Add(408);
                    ResponseCodeList.Add(429);
                    ResponseCodeList.Add(500);
                    ResponseCodeList.Add(501);
                    ResponseCodeList.Add(502);
                    ResponseCodeList.Add(503);
                    ResponseCodeList.Add(504);
                    ResponseCodeList.Add(505);

                    if (ResponseCodeList.Contains(responseStatusCode))
                    {
                        Logic.PostLicenseAction(controllerName, actionName, CVC.License.Algorithms.Forms.Enums.CommonEnums.LicenseAction.Failure);
                    }

                }
            }

        }
    }
}

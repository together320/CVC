// Decompiled with JetBrains decompiler
// Type: CVC.Machine.Pages.SettingsController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.BusinessServices.Common;
using CVC.Data;
using CVC.Data.EDMX;
using CVC.Modules.Common.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CVC.License.Algorithms.Process;

namespace CVC.Machine.Pages
{
    [RoutePrefix("SettingsMachine")]
    [Route("{action=index}")]
    // [CustomExceptionFilter]
    public class SettingsController : Controller
    {
        [DllImport("psapi.dll")]
        public static extern bool EmptyWorkingSet(IntPtr hProcess);

        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {
            // CommonServices objCommonServices = new CommonServices();
            var aa = (Request.QueryString["module"]);
            var module = new CVC.Modules.Common.Dashboard.DashboardCommon().GetModule(Request.QueryString["module"]);
            var model = new SettingsPageModel();
            model.ModuleId = module.CurrentModule;      //labeling machine mdouel id : 5
            model.Views = new DashboardCommon().GetViewsByModule(model.ModuleId);
            var MachineId = 0;
            //changes added By Vinayak On 07.08.2018
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                MachineId = cvcEntities.Modules?.FirstOrDefault(a => a.ModuleId == model.ModuleId)?.MachineId.Value ?? 0;   //labeling machine id : 8

            }
            model.Alarms = new DashboardCommon().GetAlarmByModule(model.ModuleId);
            model.AlarmsExist = new DashboardCommon().GetAlarmExist(model.ModuleId, MachineId); // changes added by Vinayak On 02.08.2018
            using (CommonServices objCommonServices = new CommonServices())
            {
                ViewBag.pick = objCommonServices.GetPickListValues();
            }

            //ended By Vinayak On 07.08.2018
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var GetLabelRollDetails = cvcEntities.Views?.FirstOrDefault(a => a.ModuleId == model.ModuleId && a.IslabelRoll == true) ?? null;
                if (GetLabelRollDetails != null)
                {

                    model.LabelRollViewId = GetLabelRollDetails.ViewsId;
                    var GetUserId = Serenity.Authorization.UserId;
                    int UserId = Convert.ToInt32(GetUserId);
                    var RoleId = cvcEntities.Users.Where(u => u.UserId == UserId).FirstOrDefault().RoleId;
                    model.IsModifyLabelRoll = cvcEntities.ViewsAccesses.FirstOrDefault(va => va.ViewsId == GetLabelRollDetails.ViewsId && va.RoleId == RoleId && va.ModuleId == model.ModuleId)?.IsModify ?? false;

                }

                var ProtocolName = cvcEntities.MachineCommunications?.FirstOrDefault(mc => mc.MachineId == MachineId)?.Protocol?.ProtocolName ?? null;

                if (ProtocolName != null)   //127.0.0.1, 502 port, 500 poll rate, protocol type : 1 -> Modbus TCP/IP
                {
                    //if (ProtocolName.ToUpper() == "MDB")
                    //{
                    //    HttpContext.Cache["ActiveMachineType"] = Enum.GetName(typeof(CVC.BusinessServices.Common.ClsConstants.MachineType), 2);
                    //}
                    //else
                    //{
                    //    HttpContext.Cache["ActiveMachineType"] = Enum.GetName(typeof(CVC.BusinessServices.Common.ClsConstants.MachineType), 1);
                    //}
                    HttpContext.Cache["ActiveMachineId"] = MachineId;
                    if (HttpContext.Cache["MachineSettings"] != null)
                        HttpContext.Cache.Remove("MachineSettings");

                }

            }
            HttpContext.Cache["ActiveMachineId"] = MachineId;
            // Adding Notifications

            _ = new LicenseStatus().GenerateNotification(ClsConstants.MessageType.LicenseExpired, Session["CVCUserId"].ToString());
            _ = new LicenseStatus().GenerateNotification(ClsConstants.MessageType.LicenseExpiredSoon, Session["CVCUserId"].ToString());
            return (ActionResult)this.View("~/Modules/Machine/SettingsIndex.cshtml", (object)model);
        }

        public ActionResult ShowAlarmPopUp(int ModuleId)
        {
            var model = new SettingsPageModel();
            if (Session["AlarmData"] != null)
            {
                model.AlarmsExist = (List<Tuple<string, string, bool, int, bool?>>)Session["AlarmData"];
                model.Alarms = new DashboardCommon().GetAlarmByModuleNew();

            }

            return Json(model.Alarms, JsonRequestBehavior.AllowGet);

            // return PartialView("~/Modules/Machine/AlarmPartial.cshtml", (object)model);
        }

        public ActionResult CleanMemory()
        {
            string selectedProcess = "openkiosk";

            var SelectedProcesses = Process.GetProcessesByName(selectedProcess);

            foreach (Process process in SelectedProcesses)
            {
                try
                {
                    long mem = process.PrivateMemorySize64;
                    int memsize = (Convert.ToInt32(mem) / (int)(1024)) / (int)1024;
                    if (memsize > 100)
                    {
                        bool Result = EmptyWorkingSet(process.Handle);
                        System.Threading.Thread.Sleep(100);
                    }
                }
                catch
                {

                }
            }
            return Json("OK", JsonRequestBehavior.AllowGet);
        }

        //public ActionResult ShowAlarmPopUp(int ModuleId)
        //{
        //    var model = new SettingsPageModel();
        //    model.Alarms = new DashboardCommon().GetAlarmByModule(ModuleId);
        //    return Json(model.Alarms, JsonRequestBehavior.AllowGet);

        //    // return PartialView("~/Modules/Machine/AlarmPartial.cshtml", (object)model);
        //}
    }
}

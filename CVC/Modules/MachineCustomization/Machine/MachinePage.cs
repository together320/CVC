// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Pages.MachineController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.BusinessServices.Common;
using CVC.MachineCustomization.Entities;
using Serenity.Web;
using System;
using System.Linq;
using System.Web.Mvc;

namespace CVC.MachineCustomization.Pages
{
  [RoutePrefix("MachineCustomization/Machine")]
  [Route("{action=index}")]
  [PageAuthorize(typeof (MachineRow))]
  public class MachineController : Controller
  {
        CommonServices objCommonServices = new CommonServices();

        public ActionResult Index()
        {
            var roleId = Session["CVCRoleId"] != null ? Convert.ToInt32(Session["CVCRoleId"]) : 0;
            ViewBag.IsModifyPermission = objCommonServices.GetRolePermission(roleId, objCommonServices.GetRolePermissionKey("machine"));
            return (ActionResult) this.View("~/Modules/MachineCustomization/Machine/MachineIndex.cshtml");
       }

        public ActionResult GetMachineDetails(int machineId)
        {
            var getMachineDetails = objCommonServices.GetMachineDetails(machineId);
            ViewBag.StatusList = objCommonServices.GetAllStatus();
            var roleId = Session["CVCRoleId"] != null ? Convert.ToInt32(Session["CVCRoleId"]) : 0;

            var rolePermissions = objCommonServices.GetRolePermission(roleId);

            if (rolePermissions.Count > 0)
            {
                if( rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "ExternalApplicationInterface:MachineCommunication:Import:Modify") !=null)
                {
                    getMachineDetails.IsImportAccessForMachineCommunication = true;
                }

                if (rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "MachineCustomization:Alarm:Import:Modify") != null)
                {
                    getMachineDetails.IsImportAccessForAlarm = true;

                }

                if (rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "MachineCustomization:MachineParameter:Import:Modify") != null)
                {
                    getMachineDetails.IsImportAccessForMachineParameter = true;

                }

                if (rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "ExternalApplicationInterface:IpcParameter:Import:Modify") != null)
                {
                    getMachineDetails.IsImportAccessForIpcParameter = true;

                }

                if (rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "EAI:MachineCommunication:Modify") != null)
                {
                    getMachineDetails.IsMenuAccessForMachineCommunication = true;
                }

                if (rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "MachineCustomization:Alarm:Modify") != null)
                {
                    getMachineDetails.IsMenuAccessForAlarm = true;
                }

                if (rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "MachineCustomization:MachineParameter:Modify") != null)
                {
                    getMachineDetails.IsMenuAccessForMachineParameter = true;

                }

                if (rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "EAI:IPCParameter:Modify") != null)
                {
                    getMachineDetails.IsMenuAccessForIpcParameter = true;

                }


                // var checkPermission = rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "Batch:Authentication");
            }
            //  ViewBag.ImportModifyPermissionForMachineParameter = objCommonServices.GetRolePermission(roleId, objCommonServices.GetRolePermissionKey("machineParameter"));
            // return Json(getMachineDetails, JsonRequestBehavior.AllowGet);
            return View("~/Modules/MachineCustomization/Machine/MachineDetailsTab.cshtml",getMachineDetails);
        }

    }
}

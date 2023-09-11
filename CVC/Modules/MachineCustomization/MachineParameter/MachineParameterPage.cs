// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Pages.MachineParameterController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.BusinessServices.Common;
using CVC.MachineCustomization.Entities;
using Serenity.Web;
using System;
using System.Web.Mvc;

namespace CVC.MachineCustomization.Pages
{
  [RoutePrefix("MachineCustomization/MachineParameter")]
  [Route("{action=index}")]
  [PageAuthorize(typeof (MachineParameterRow))]
  public class MachineParameterController : Controller
  {
        CommonServices objCommonServices = new CommonServices();

        public ActionResult Index()
        {
            var roleId = Session["CVCRoleId"] != null ? Convert.ToInt32(Session["CVCRoleId"]) : 0;
            ViewBag.IsModifyPermission = objCommonServices.GetRolePermission(roleId, objCommonServices.GetRolePermissionKey("machineParameter"));
            return (ActionResult) this.View("~/Modules/MachineCustomization/MachineParameter/MachineParameterIndex.cshtml");
       }
  }
}

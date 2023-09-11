// Decompiled with JetBrains decompiler
// Type: CVC.ExternalApplicationInterface.Pages.MachineCommunicationController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.BusinessServices.Common;
using CVC.ExternalApplicationInterface.Entities;
using Serenity.Web;
using System;
using System.Web.Mvc;

namespace CVC.ExternalApplicationInterface.Pages
{
  [RoutePrefix("ExternalApplicationInterface/MachineCommunication")]
  [Route("{action=index}")]
  [PageAuthorize(typeof (MachineCommunicationRow))]
  public class MachineCommunicationController : Controller
  {
        CommonServices objCommonServices = new CommonServices();

        public ActionResult Index()
        {
            var roleId = Session["CVCRoleId"] != null ? Convert.ToInt32(Session["CVCRoleId"]) : 0;
            ViewBag.IsModifyPermission = objCommonServices.GetRolePermission(roleId, objCommonServices.GetRolePermissionKey("machineCommunication"));
            return (ActionResult) this.View("~/Modules/ExternalApplicationInterface/MachineCommunication/MachineCommunicationIndex.cshtml");
        }
  }
}

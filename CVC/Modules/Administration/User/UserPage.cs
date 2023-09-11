// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Pages.UserController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.BusinessServices.Common;
using Serenity.Web;
using System;
using System.Web.Mvc;

namespace CVC.Administration.Pages
{
  [RoutePrefix("Administration/User")]
  [Route("{action=index}")]
  [PageAuthorize(typeof (UserRow))]
  public class UserController : Controller
  {
   CommonServices objCommonServices = new CommonServices();

    public ActionResult Index()
     {
        var roleId = Session["CVCRoleId"] != null ? Convert.ToInt32(Session["CVCRoleId"]) : 0;
        ViewBag.IsModifyPermission = objCommonServices.GetRolePermission(roleId, objCommonServices.GetRolePermissionKey("userManagement"));

        return (ActionResult) this.View("~/Modules/Administration/User/UserIndex.cshtml");
    }
  }
}

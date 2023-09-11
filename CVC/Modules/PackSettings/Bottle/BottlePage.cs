﻿// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Pages.BottleController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.BusinessServices.Common;
using CVC.PackSettings.Entities;
using Serenity.Web;
using System;
using System.Web.Mvc;

namespace CVC.PackSettings.Pages
{
  [RoutePrefix("PackSettings/Bottle")]
  [Route("{action=index}")]
  [PageAuthorize(typeof (BottleRow))]
  public class BottleController : Controller
    {
      CommonServices objCommonServices = new CommonServices();

     public ActionResult Index()
    {
       var roleId = Session["CVCRoleId"] != null ? Convert.ToInt32(Session["CVCRoleId"]) : 0;
       ViewBag.IsModifyPermission = objCommonServices.GetRolePermission(roleId, objCommonServices.GetRolePermissionKey("bottle"));

       return (ActionResult) this.View("~/Modules/PackSettings/Bottle/BottleIndex.cshtml");
    }
  }
}

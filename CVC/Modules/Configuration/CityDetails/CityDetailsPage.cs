// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Pages.CityDetailsController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.BusinessServices.Common;
using CVC.Configuration.Entities;
using Serenity.Web;
using System;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace CVC.Configuration.Pages
{
  [RoutePrefix("Configuration/CityDetails")]
  [Route("{action=index}")]
  [PageAuthorize(typeof (CityDetailsRow))]
  public class CityDetailsController : Controller
    {
        CommonServices objCommonServices = new CommonServices();

        public ActionResult Index()
        {
            var roleId = Session["CVCRoleId"] != null ? Convert.ToInt32(Session["CVCRoleId"]) : 0;
            ViewBag.IsModifyPermission = objCommonServices.GetRolePermission(roleId, objCommonServices.GetRolePermissionKey("cityDetails"));
            return (ActionResult) this.View("~/Modules/Configuration/CityDetails/CityDetailsIndex.cshtml");
        }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.AdminDashboard.Pages.AdminDashboardController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using MvcBreadCrumbs;
using System.Web.Mvc;

namespace CVC.AdminDashboard.Pages
{
  [RoutePrefix("AdminDashboard")]
  [Route("{action=index}")]
  [BreadCrumb]
  public class AdminDashboardController : Controller
  {
    [Authorize]
    [HttpGet]
    [Route("~/AdminDashboard")]
    public ActionResult Index()
    {
      return (ActionResult) this.View("~/Modules/AdminDashboard/AdminDashboardIndex.cshtml", (object) new AdminDashboardPageModel());
    }
  }
}

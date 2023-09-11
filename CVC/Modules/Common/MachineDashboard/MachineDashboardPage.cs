// Decompiled with JetBrains decompiler
// Type: CVC.Common.Pages.MachineDashboardController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using System.Web.Mvc;

namespace CVC.Common.Pages
{
  [RoutePrefix("Common/MachineDashboard")]
  [Route("{action=index}")]
  public class MachineDashboardController : Controller
  {
    [Authorize]
    [HttpGet]
    public ActionResult Index()
    {
      return (ActionResult) this.View("~/Modules/Common/MachineDashboard/MachineDashboardIndex.cshtml", (object) new MachineDashboardPageModel());
    }
  }
}

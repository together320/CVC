// Decompiled with JetBrains decompiler
// Type: CVC.Machine.Pages.ReconcilationController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using System.Web.Mvc;

namespace CVC.Machine.Pages
{
  [RoutePrefix("Reconciliation")]
  [Route("{action=index}")]
  public class ReconcilationController : Controller
  {
    [Authorize]
    [HttpGet]
    public ActionResult Index()
    {
      return (ActionResult) this.View("~/Modules/Machine/ReconcilationIndex.cshtml", (object) new ReconcilationPageModel());
    }
  }
}

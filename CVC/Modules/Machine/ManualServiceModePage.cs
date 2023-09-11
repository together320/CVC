// Decompiled with JetBrains decompiler
// Type: CVC.Machine.Pages.ManualServiceModeController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Data;
using CVC.Data.EDMX;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CVC.Machine.Pages
{
  [RoutePrefix("ManualServiceModeMachine")]
  [Route("{action=index}")]
  public class ManualServiceModeController : Controller
  {
    [Authorize]
    [HttpGet]
    public ActionResult Index()
    {
      IList<ViewField> viewFieldList1 = (IList<ViewField>) new List<ViewField>();
      IList<ViewField> viewFieldList2 = CVCDaoFactory.GetViewFieldList(4);
      return (ActionResult) this.View("~/Modules/Machine/ManualServiceModeIndex.cshtml", (object) new ManualServiceModePageModel()
      {
        ViewFieldList = viewFieldList2
      });
    }
  }
}

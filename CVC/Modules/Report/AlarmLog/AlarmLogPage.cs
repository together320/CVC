// Decompiled with JetBrains decompiler
// Type: CVC.Report.Pages.AlarmLogController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Report.Entities;
using Serenity.Web;
using System.Web.Mvc;

namespace CVC.Report.Pages
{
  [RoutePrefix("Report/AlarmLog")]
  [Route("{action=index}")]
  [PageAuthorize(typeof (AlarmLogRow))]
  public class AlarmLogController : Controller
  {
    public ActionResult Index()
    {
      return (ActionResult) this.View("~/Modules/Report/AlarmLog/AlarmLogIndex.cshtml");
    }
  }
}

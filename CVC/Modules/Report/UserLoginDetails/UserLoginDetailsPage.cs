// Decompiled with JetBrains decompiler
// Type: CVC.Report.Pages.UserLoginDetailsController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Report.Entities;
using Serenity.Web;
using System.Web.Mvc;

namespace CVC.Report.Pages
{
  [RoutePrefix("Report/UserLoginDetails")]
  [Route("{action=index}")]
  [PageAuthorize(typeof (UserLoginDetailsRow))]
  public class UserLoginDetailsController : Controller
  {
    public ActionResult Index()
    {
      return (ActionResult) this.View("~/Modules/Report/UserLoginDetails/UserLoginDetailsIndex.cshtml");
    }
  }
}

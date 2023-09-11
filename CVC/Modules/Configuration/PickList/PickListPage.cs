// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Pages.PickListController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.Web;
using System.Web.Mvc;

namespace CVC.Configuration.Pages
{
  [RoutePrefix("Configuration/PickList")]
  [Route("{action=index}")]
  [PageAuthorize(typeof (PickListRow))]
  public class PickListController : Controller
  {
    public ActionResult Index()
    {
      return (ActionResult) this.View("~/Modules/Configuration/PickList/PickListIndex.cshtml");
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Pages.AdminFormController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using Serenity.Web;
using System.Web.Mvc;

namespace CVC.Administration.Pages
{
  [RoutePrefix("Administration/AdminForm")]
  [Route("{action=index}")]
  [PageAuthorize(typeof (AdminFormRow))]
  public class AdminFormController : Controller
  {
    public ActionResult Index()
    {
      return (ActionResult) this.View("~/Modules/Administration/AdminForm/AdminFormIndex.cshtml");
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Pages.ModuleAccessController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using Serenity.Web;
using System.Web.Mvc;

namespace CVC.Administration.Pages
{
  [RoutePrefix("Administration/ModuleAccess")]
  [Route("{action=index}")]
  [PageAuthorize(typeof (ModuleAccessRow))]
  public class ModuleAccessController : Controller
  {
    public ActionResult Index()
    {
      return (ActionResult) this.View("~/Modules/Administration/ModuleAccess/ModuleAccessIndex.cshtml");
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.ModuleManagement.Pages.ModuleController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.ModuleManagement.Entities;
using Serenity.Web;
using System.Web.Mvc;

namespace CVC.ModuleManagement.Pages
{
  [RoutePrefix("ModuleManagement/Module")]
  [Route("{action=index}")]
  [PageAuthorize(typeof (ModuleRow))]
  public class ModuleController : Controller
  {
    public ActionResult Index()
    {
      return (ActionResult) this.View("~/Modules/ModuleManagement/Module/ModuleIndex.cshtml");
    }
  }
}

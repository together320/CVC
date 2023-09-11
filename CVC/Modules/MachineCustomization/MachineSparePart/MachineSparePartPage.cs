// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Pages.MachineSparePartController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.Web;
using System.Web.Mvc;

namespace CVC.MachineCustomization.Pages
{
  [RoutePrefix("MachineCustomization/MachineSparePart")]
  [Route("{action=index}")]
  [PageAuthorize(typeof (MachineSparePartRow))]
  public class MachineSparePartController : Controller
  {
    public ActionResult Index()
    {
      return (ActionResult) this.View("~/Modules/MachineCustomization/MachineSparePart/MachineSparePartIndex.cshtml");
    }
  }
}

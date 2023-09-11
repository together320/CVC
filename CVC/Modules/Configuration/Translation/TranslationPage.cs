// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Pages.TranslationController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.Web;
using System.Web.Mvc;

namespace CVC.Configuration.Pages
{
  [RoutePrefix("Configuration/Translation")]
  [Route("{action=index}")]
  [PageAuthorize("Administration:Translation")]
  public class TranslationController : Controller
  {
    public ActionResult Index()
    {
      return (ActionResult) this.View("~/Modules/Configuration/Translation/TranslationIndex.cshtml");
    }
  }
}

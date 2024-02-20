
namespace CVC.MachineCustomization.Pages
{
  using Serenity;
  using Serenity.Web;
  using System.Web.Mvc;
  using System.Collections.Generic;
  using System.Linq;
  using System.Web;
  using CVC.ViewModels;
  using CVC.MachineCustomization;
  using CVC.Data.EDMX;
  using CVC.MDB;
  using CVC.Modules.Common.CommonServices;
  using System.Data.Entity;

  [RoutePrefix("MachineCustomization/DisplayObject"), Route("{action=index}")]
  [PageAuthorize(typeof(Entities.DisplayObjectRow))]
  public class DisplayObjectController : Controller
  {
    public ActionResult Index()
    {
      return View("~/Modules/MachineCustomization/DisplayObject/DisplayObjectIndex.cshtml");
    }
  }
}
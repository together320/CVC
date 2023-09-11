
namespace CVC.MachineCustomization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

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

namespace CVC.MachineCustomization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MachineCustomization/DisplayObjectColor"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.DisplayObjectColorRow))]
    public class DisplayObjectColorController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MachineCustomization/DisplayObjectColor/DisplayObjectColorIndex.cshtml");
        }
    }
}
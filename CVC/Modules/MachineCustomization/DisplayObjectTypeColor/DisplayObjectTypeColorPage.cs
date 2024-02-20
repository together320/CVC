
namespace CVC.MachineCustomization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MachineCustomization/DisplayObjectTypeColor"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.DisplayObjectTypeColorRow))]
    public class DisplayObjectTypeColorController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MachineCustomization/DisplayObjectTypeColor/DisplayObjectTypeColorIndex.cshtml");
        }
    }
}

namespace CVC.MachineCustomization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MachineCustomization/ButtonDisplay"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ButtonDisplayRow))]
    public class ButtonDisplayController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MachineCustomization/ButtonDisplay/ButtonDisplayIndex.cshtml");
        }
    }
}
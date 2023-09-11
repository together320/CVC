
namespace CVC.MachineCustomization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MachineCustomization/ScreenViews"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ScreenViewsRow))]
    public class ScreenViewsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MachineCustomization/ScreenViews/ScreenViewsIndex.cshtml");
        }
    }
}
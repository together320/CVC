
namespace CVC.MachineCustomization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MachineCustomization/ListDisplay"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ListDisplayRow))]
    public class ListDisplayController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MachineCustomization/ListDisplay/ListDisplayIndex.cshtml");
        }
    }
}
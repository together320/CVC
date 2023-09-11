
namespace CVC.MachineCustomization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MachineCustomization/TreeDisplay"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.TreeDisplayRow))]
    public class TreeDisplayController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MachineCustomization/TreeDisplay/TreeDisplayIndex.cshtml");
        }
    }
}
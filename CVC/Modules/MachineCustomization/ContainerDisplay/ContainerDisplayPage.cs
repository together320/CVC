
namespace CVC.MachineCustomization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MachineCustomization/ContainerDisplay"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ContainerDisplayRow))]
    public class ContainerDisplayController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MachineCustomization/ContainerDisplay/ContainerDisplayIndex.cshtml");
        }
    }
}
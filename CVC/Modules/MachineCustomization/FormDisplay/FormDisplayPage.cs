
namespace CVC.MachineCustomization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MachineCustomization/FormDisplay"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.FormDisplayRow))]
    public class FormDisplayController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MachineCustomization/FormDisplay/FormDisplayIndex.cshtml");
        }
    }
}
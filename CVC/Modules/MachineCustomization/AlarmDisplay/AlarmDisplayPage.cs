
namespace CVC.MachineCustomization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MachineCustomization/AlarmDisplay"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.AlarmDisplayRow))]
    public class AlarmDisplayController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MachineCustomization/AlarmDisplay/AlarmDisplayIndex.cshtml");
        }
    }
}
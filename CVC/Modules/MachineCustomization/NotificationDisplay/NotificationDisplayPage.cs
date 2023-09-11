
namespace CVC.MachineCustomization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MachineCustomization/NotificationDisplay"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.NotificationDisplayRow))]
    public class NotificationDisplayController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MachineCustomization/NotificationDisplay/NotificationDisplayIndex.cshtml");
        }
    }
}

namespace CVC.MachineCustomization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MachineCustomization/RealtimeParameterDisplay"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.RealtimeParameterDisplayRow))]
    public class RealtimeParameterDisplayController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MachineCustomization/RealtimeParameterDisplay/RealtimeParameterDisplayIndex.cshtml");
        }
    }
}
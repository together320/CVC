
namespace CVC.MachineCustomization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MachineCustomization/PieChartDisplay"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PieChartDisplayRow))]
    public class PieChartDisplayController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MachineCustomization/PieChartDisplay/PieChartDisplayIndex.cshtml");
        }
    }
}
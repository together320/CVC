
namespace CVC.MachineCustomization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MachineCustomization/LineChartDisplay"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.LineChartDisplayRow))]
    public class LineChartDisplayController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MachineCustomization/LineChartDisplay/LineChartDisplayIndex.cshtml");
        }
    }
}

namespace CVC.MachineCustomization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MachineCustomization/PrimaryRelationship"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PrimaryRelationshipRow))]
    public class PrimaryRelationshipController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MachineCustomization/PrimaryRelationship/PrimaryRelationshipIndex.cshtml");
        }
    }
}
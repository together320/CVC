
namespace CVC.MachineCustomization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MachineCustomization/SecondaryRelationship"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.SecondaryRelationshipRow))]
    public class SecondaryRelationshipController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MachineCustomization/SecondaryRelationship/SecondaryRelationshipIndex.cshtml");
        }
    }
}
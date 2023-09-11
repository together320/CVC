
namespace CVC.MachineCustomization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MachineCustomization/AttachmentDisplay"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.AttachmentDisplayRow))]
    public class AttachmentDisplayController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MachineCustomization/AttachmentDisplay/AttachmentDisplayIndex.cshtml");
        }
    }
}
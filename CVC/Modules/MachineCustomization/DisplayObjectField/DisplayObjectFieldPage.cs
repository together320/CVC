
namespace CVC.MachineCustomization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MachineCustomization/DisplayObjectField"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.DisplayObjectFieldRow))]
    public class DisplayObjectFieldController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MachineCustomization/DisplayObjectField/DisplayObjectFieldIndex.cshtml");
        }
    }
}
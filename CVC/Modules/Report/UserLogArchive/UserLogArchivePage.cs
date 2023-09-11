using CVC.Report.Entities;
using Serenity.Web;
using System.Web.Mvc;

namespace CVC.Batch.Pages
{
    [RoutePrefix("Report/UserLogArchive")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(UserLogArchiveRow))]
    public class UserLogArchiveController : Controller
    {
        public ActionResult Index()
        {
            return (ActionResult)this.View("~/Modules/Report/UserLogArchive/UserLogArchiveIndex.cshtml");
        }
    }
}
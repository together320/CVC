
using CVC.Report.Entities;
using Serenity.Web;
using System.Web.Mvc;

namespace CVC.Report.Pages
{
    [RoutePrefix("Report/BatchLogArchive")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(BatchLogArchiveRow))]
    public class BatchLogArchiveController : Controller
    {
        public ActionResult Index()
        {
            return (ActionResult)this.View("~/Modules/Report/BatchLogArchive/BatchLogArchiveIndex.cshtml");
        }
    }
}

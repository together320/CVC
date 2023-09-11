
using CVC.Report.Entities;
using Serenity.Web;
using System.Web.Mvc;

namespace CVC.Report.Pages
{
    [RoutePrefix("Report/AlarmLogArchive")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(AlarmLogArchiveRow))]
    public class AlarmLogArchiveController : Controller
    {
        public ActionResult Index()
        {
            return (ActionResult)this.View("~/Modules/Report/AlarmLogArchive/AlarmLogArchiveIndex.cshtml");
        }
    }
}

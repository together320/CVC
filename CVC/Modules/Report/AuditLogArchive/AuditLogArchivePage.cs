
using CVC.Report.Entities;
using Serenity.Web;
using System.Web.Mvc;

namespace CVC.Report.Pages
{
    [RoutePrefix("Report/AuditLogArchive")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(AuditLogArchiveRow))]
    public class AuditLogArchiveController : Controller
    {
        public ActionResult Index()
        {
            return (ActionResult)this.View("~/Modules/Report/AuditLogArchive/AuditLogArchiveIndex.cshtml");
        }
    }
}

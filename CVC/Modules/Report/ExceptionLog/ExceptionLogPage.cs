
using CVC.Report.Entities;
using Serenity.Web;
using System.Web.Mvc;

namespace CVC.Report.Pages
{
    [RoutePrefix("Report/ExceptionLog")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(ExceptionLogRow))]
    public class ExceptionLogController : Controller
    {
        public ActionResult Index()
        {
            return (ActionResult)this.View("~/Modules/Report/ExceptionLog/ExceptionLogIndex.cshtml");
        }
    }
}
using CVC.Report.Entities;
using Serenity.Web;
using System.Web.Mvc;

namespace CVC.Report.Pages
{
    [RoutePrefix("Report/UserLog")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(UserLogRow))]
    public class UserLogController : Controller
    {
        public ActionResult Index()
        {
            return (ActionResult)this.View("~/Modules/Report/UserLog/UserLogIndex.cshtml");
        }
    }
}
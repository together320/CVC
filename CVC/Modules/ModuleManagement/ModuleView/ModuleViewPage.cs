
using CVC.ModuleManagement.Entities;
using Serenity.Web;
using System.Web.Mvc;

namespace CVC.ModuleManagement.Pages
{
    [RoutePrefix("ModuleManagement/ModuleView")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(ModuleViewRow))]
    public class ModuleViewController : Controller
    {

    }
}

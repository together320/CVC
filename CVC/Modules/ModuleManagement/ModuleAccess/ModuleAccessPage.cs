
using CVC.ModuleManagement.Entities;
using Serenity.Web;
using System.Web.Mvc;

namespace CVC.ModuleManagement.Pages
{
    [RoutePrefix("ModuleManagement/ModuleAccess")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(ModuleAccessRow))]
    public class ModuleAccessController : Controller
    {

    }
}

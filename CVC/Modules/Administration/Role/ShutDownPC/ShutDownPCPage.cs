using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CVC.Modules.Administration.Role.ShutDownPC
{
    [RoutePrefix("Administration/Role/ShutDownPC")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(ShutDownPCRow))]
    public class ShutDownPCPage
    {
    }
}
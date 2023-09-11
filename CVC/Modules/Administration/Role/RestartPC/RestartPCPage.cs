using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CVC.Modules.Administration.Role.RestartPC
{
    [RoutePrefix("Administration/Role/RestartPC")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(RestartPCRow))]
    public class RestartPCPage
    {
    }
}
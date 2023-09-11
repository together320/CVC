using CVC.Configuration.Entities;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
namespace CVC.Modules.Licensing.License
{
    [RoutePrefix("Licensing/License")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(LicenseRow))]
    public class LicensePage
    {
    }
}
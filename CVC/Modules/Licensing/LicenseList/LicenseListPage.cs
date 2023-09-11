using CVC.Configuration.Entities;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
namespace CVC.Modules.Licensing.LicenseList
{
    [RoutePrefix("Licensing/LicenseList")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(LicenseListRow))]
    public class LicenseListPage
    {
    }
}
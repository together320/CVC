using CVC.Configuration.Entities;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
namespace CVC.Modules.Licensing.LicenseUpload
{
    [RoutePrefix("Licensing/LicenseUpload")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(LicenseUploadRow))]
    public class LicenseUploadPage
    {
    }
}
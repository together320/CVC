using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CVC.Modules.Configuration.Shift.Import
{
    [RoutePrefix("Configuration/Shift/Import")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(ImportRow))]
    public class ImportPage
    {
    }
}
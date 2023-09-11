using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CVC.Modules.PackSettings.Outsert.Import
{
    [RoutePrefix("PackSettings/Outsert/Import")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(ImportRow))]
    public class ImportPage
    {
    }
}
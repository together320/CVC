using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CVC.Modules.ExternalApplicationInterface.Protocol.Import
{
    [RoutePrefix("ExternalApplicationInterface/Protocol/Import")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(ImportRow))]
    public class ImportPage
    {
    }
}
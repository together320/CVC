using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CVC.Modules.MachineCustomization.TerminalType
{
    [RoutePrefix("MachineCustomization/TerminalType")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(TerminalTypeRow))]
    public class TerminalTypePage
    {
    }
}



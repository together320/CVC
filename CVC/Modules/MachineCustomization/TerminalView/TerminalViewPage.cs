using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CVC.Modules.MachineCustomization.TerminalView
{
    [RoutePrefix("MachineCustomization/TerminalView")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(TerminalViewRow))]
    public class TerminalViewPage
    {
    }
}



﻿using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CVC.Modules.MachineCustomization.TerminalMaster
{
    [RoutePrefix("MachineCustomization/TerminalMaster")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(TerminalMasterRow))]
    public class TerminalMasterPage
    {
    }
}



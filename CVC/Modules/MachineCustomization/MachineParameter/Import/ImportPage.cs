﻿using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CVC.Modules.MachineCustomization.MachineParameter.Import
{
    [RoutePrefix("MachineCustomization/MachineParameter/Import")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(ImportRow))]
    public class ImportPage
    {
    }
}
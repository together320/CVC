using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CVC.Modules.MachineCustomization.MachineDetails
{
    [RoutePrefix("MachineCustomization/MachineDetails")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(MachineDetailsRow))]
    public class MachineDetailsPage
    {
    }
}



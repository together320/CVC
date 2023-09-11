using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CVC.Modules.MachineCustomization.Message
{
    [RoutePrefix("MachineCustomization/Message")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(MessageRow))]
    public class MessagePage
    {
    }
}



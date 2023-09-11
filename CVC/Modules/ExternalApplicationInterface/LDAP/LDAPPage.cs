using CVC.ExternalApplicationInterface.Entities;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CVC.Modules.ExternalApplicationInterface.LDAP

{
    [RoutePrefix("ExternalApplicationInterface/LDAP")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(LDAPRow))]
    public class LDAPPage
    {
    }
}
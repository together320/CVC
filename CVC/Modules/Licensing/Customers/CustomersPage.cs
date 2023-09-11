using CVC.Configuration.Entities;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
namespace CVC.Modules.Licensing.Customers
{
    [RoutePrefix("Licensing/Customers")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(CustomersRow))]
    public class CustomersPage
    {
    }
}
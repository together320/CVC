using CVC.Configuration.Entities;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CVC.Modules.Configuration.DataBaseArchival
{
    [RoutePrefix("Configuration/DataBaseArchival")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(DataBaseArchivalRow))]
    public class DataBaseArchivalPage
    {
    }
}
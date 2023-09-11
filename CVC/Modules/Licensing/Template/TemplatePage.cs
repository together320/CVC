using CVC.Configuration.Entities;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
namespace CVC.Modules.Licensing.Template
{
    [RoutePrefix("Licensing/Template")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(TemplateRow))]
    public class TemplatePage
    {
    }
}
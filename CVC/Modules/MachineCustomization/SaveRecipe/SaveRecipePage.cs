using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CVC.Modules.MachineCustomization.SaveRecipe
{
    [RoutePrefix("MachineCustomization/SaveRecipe")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(SaveRecipeRow))]
    public class SaveRecipePage
    {
    }
}



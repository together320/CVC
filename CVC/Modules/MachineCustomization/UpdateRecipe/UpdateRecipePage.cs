using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CVC.Modules.MachineCustomization.UpdateRecipe
{
    [RoutePrefix("MachineCustomization/UpdateRecipe")]
    [Route("{action=index}")]
    [PageAuthorize(typeof(UpdateRecipeRow))]
    public class UpdateRecipePage
    {
    }
}



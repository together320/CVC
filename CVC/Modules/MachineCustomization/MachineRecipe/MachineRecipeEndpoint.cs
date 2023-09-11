// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Endpoints.MachineRecipeController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Data.EDMX;
using CVC.MachineCustomization.Entities;
using CVC.MachineCustomization.Repositories;
using CVC.Modules.Common.Dashboard;
using Serenity.Data;
using Serenity.Services;
using System.Data; 
using System.Linq;
using System.Web.Mvc;

namespace CVC.MachineCustomization.Endpoints
{
    [RoutePrefix("Services/MachineCustomization/MachineRecipe")]
    [Route("{action}")]
    [ConnectionKey(typeof(MachineRecipeRow))]
    [ServiceAuthorize(typeof(MachineRecipeRow))]
    public class MachineRecipeController : ServiceEndpoint
    {
        [HttpPost]
        [AuthorizeCreate(typeof(MachineRecipeRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineRecipeRow> request)
        {
            return new MachineRecipeRepository().Create(uow, request);
        }

        [HttpPost]
        [AuthorizeUpdate(typeof(MachineRecipeRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineRecipeRow> request)
        {
            return new MachineRecipeRepository().Update(uow, request);
        }

        [HttpPost]
        [AuthorizeDelete(typeof(MachineRecipeRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MachineRecipeRepository().Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MachineRecipeRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MachineRecipeRepository().Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<MachineRecipeRow> List(IDbConnection connection, ListRequest request)
        {
            return new MachineRecipeRepository().List(connection, request);
        }
    }


    [RoutePrefix("MachineRecipeReport")]
    [Route("{action=index}")]
    public class MachineRecipeReportController : Controller
    {
        [Authorize]
        [HttpGet]
        [ActionName("MachineRecipeReport")]
        public ActionResult MachineRecipeReport(int id)
        {
            var Model = new DashboardCommon().GetMachineRecipeReport(id);
            return (ActionResult)this.View("~/Modules/MachineCustomization/MachineRecipe/MachineRecipeReport.cshtml", (object)Model);
        }
    }
}

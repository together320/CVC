// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Endpoints.BatchController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using CVC.Batch.Repositories;
using CVC.Modules.Common.Dashboard;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Batch.Endpoints
{
    [RoutePrefix("Services/Batch/Batch")]
    [Route("{action}")]
    [ConnectionKey(typeof(BatchRow1))]
   [ServiceAuthorize(typeof(BatchRow1))]
    public class BatchController : ServiceEndpoint
    {
        [HttpPost]
       [AuthorizeCreate(typeof(BatchRow1))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<BatchRow1> request)
        {
            var ret = new BatchRepository().Create(uow, request);
           // new DashboardCommon().ResetOnBatchCreate();
            return ret;
        }

        [HttpPost]
        [AuthorizeUpdate(typeof(BatchRow1))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<BatchRow1> request)
        {
            return new BatchRepository().Update(uow, request);
        }

        [HttpPost]
        [AuthorizeDelete(typeof(BatchRow1))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new BatchRepository().Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<BatchRow1> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new BatchRepository().Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<BatchRow1> List(IDbConnection connection, ListRequest request)
        {
            return new BatchRepository().List(connection, request);
        }

      
    }

    [RoutePrefix("BatchReport")]
    [Route("{action=index}")]
    public class BatchReportController : Controller
    {
        [Authorize]
        [HttpGet]
        [ActionName("BatchReport")]
        public ActionResult BatchReport(int id)
        {
            var Model = new DashboardCommon().GetBatchReport(id);
            return (ActionResult)this.View("~/Modules/Batch/Batch/BatchReport.cshtml", (object)Model);
        }
    }
}

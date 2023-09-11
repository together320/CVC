// Decompiled with JetBrains decompiler
// Type: CVC.Report.Endpoints.BatchLogController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Report.Entities;
using CVC.Report.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Report.Endpoints
{
  [RoutePrefix("Services/Report/BatchLog")]
  [Route("{action}")]
  [ConnectionKey(typeof (BatchLogRow))]
  [ServiceAuthorize(typeof (BatchLogRow))]
  public class BatchLogController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (BatchLogRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<BatchLogRow> request)
    {
      return new BatchLogRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (BatchLogRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<BatchLogRow> request)
    {
      return new BatchLogRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (BatchLogRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new BatchLogRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<BatchLogRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new BatchLogRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<BatchLogRow> List(IDbConnection connection, ListRequest request)
    {
      return new BatchLogRepository().List(connection, request);
    }
  }
}

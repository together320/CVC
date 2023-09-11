// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Endpoints.BatchRunDataController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using CVC.Batch.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Batch.Endpoints
{
  [RoutePrefix("Services/Batch/BatchRunData")]
  [Route("{action}")]
  [ConnectionKey(typeof (BatchRunDataRow))]
  [ServiceAuthorize(typeof (BatchRunDataRow))]
  public class BatchRunDataController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (BatchRunDataRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<BatchRunDataRow> request)
    {
      return new BatchRunDataRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (BatchRunDataRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<BatchRunDataRow> request)
    {
      return new BatchRunDataRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (BatchRunDataRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new BatchRunDataRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<BatchRunDataRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new BatchRunDataRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<BatchRunDataRow> List(IDbConnection connection, ListRequest request)
    {
      return new BatchRunDataRepository().List(connection, request);
    }
  }
}

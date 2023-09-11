// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Endpoints.BatchMachineWiseController
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
  [RoutePrefix("Services/Batch/BatchMachineWise")]
  [Route("{action}")]
  [ConnectionKey(typeof (BatchMachineWiseRow))]
  [ServiceAuthorize(typeof (BatchMachineWiseRow))]
  public class BatchMachineWiseController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (BatchMachineWiseRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<BatchMachineWiseRow> request)
    {
      return new BatchMachineWiseRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (BatchMachineWiseRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<BatchMachineWiseRow> request)
    {
      return new BatchMachineWiseRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (BatchMachineWiseRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new BatchMachineWiseRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<BatchMachineWiseRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new BatchMachineWiseRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<BatchMachineWiseRow> List(IDbConnection connection, ListRequest request)
    {
      return new BatchMachineWiseRepository().List(connection, request);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Endpoints.BatchRecipeModifyController
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
  [RoutePrefix("Services/Batch/BatchRecipeModify")]
  [Route("{action}")]
  [ConnectionKey(typeof (BatchRecipeModifyRow))]
  [ServiceAuthorize(typeof (BatchRecipeModifyRow))]
  public class BatchRecipeModifyController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (BatchRecipeModifyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<BatchRecipeModifyRow> request)
    {
      return new BatchRecipeModifyRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (BatchRecipeModifyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<BatchRecipeModifyRow> request)
    {
      return new BatchRecipeModifyRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (BatchRecipeModifyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new BatchRecipeModifyRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<BatchRecipeModifyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new BatchRecipeModifyRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<BatchRecipeModifyRow> List(IDbConnection connection, ListRequest request)
    {
      return new BatchRecipeModifyRepository().List(connection, request);
    }
  }
}

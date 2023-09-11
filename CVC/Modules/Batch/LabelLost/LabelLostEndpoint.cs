// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Endpoints.LabelLostController
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
  [RoutePrefix("Services/Batch/LabelLost")]
  [Route("{action}")]
  [ConnectionKey(typeof (LabelLostRow))]
  [ServiceAuthorize(typeof (LabelLostRow))]
  public class LabelLostController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (LabelLostRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<LabelLostRow> request)
    {
      return new LabelLostRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (LabelLostRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<LabelLostRow> request)
    {
      return new LabelLostRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (LabelLostRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new LabelLostRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<LabelLostRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new LabelLostRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<LabelLostRow> List(IDbConnection connection, ListRequest request)
    {
      return new LabelLostRepository().List(connection, request);
    }
  }
}

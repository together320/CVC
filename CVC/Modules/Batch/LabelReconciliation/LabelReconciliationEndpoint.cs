// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Endpoints.LabelReconciliationController
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
  [RoutePrefix("Services/Batch/LabelReconciliation")]
  [Route("{action}")]
  [ConnectionKey(typeof (LabelReconciliationRow))]
  [ServiceAuthorize(typeof (LabelReconciliationRow))]
  public class LabelReconciliationController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (LabelReconciliationRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<LabelReconciliationRow> request)
    {
      return new LabelReconciliationRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (LabelReconciliationRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<LabelReconciliationRow> request)
    {
      return new LabelReconciliationRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (LabelReconciliationRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new LabelReconciliationRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<LabelReconciliationRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new LabelReconciliationRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<LabelReconciliationRow> List(IDbConnection connection, ListRequest request)
    {
      return new LabelReconciliationRepository().List(connection, request);
    }
  }
}

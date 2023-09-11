// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Endpoints.PickListValueController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.Configuration.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Configuration.Endpoints
{
  [RoutePrefix("Services/Configuration/PickListValue")]
  [Route("{action}")]
  [ConnectionKey(typeof (PickListValueRow))]
  [ServiceAuthorize(typeof (PickListValueRow))]
  public class PickListValueController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (PickListValueRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<PickListValueRow> request)
    {
      return new PickListValueRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (PickListValueRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<PickListValueRow> request)
    {
      return new PickListValueRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (PickListValueRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new PickListValueRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<PickListValueRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new PickListValueRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<PickListValueRow> List(IDbConnection connection, ListRequest request)
    {
      return new PickListValueRepository().List(connection, request);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Endpoints.PickListController
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
  [RoutePrefix("Services/Configuration/PickList")]
  [Route("{action}")]
  [ConnectionKey(typeof (PickListRow))]
  [ServiceAuthorize(typeof (PickListRow))]
  public class PickListController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (PickListRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<PickListRow> request)
    {
      return new PickListRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (PickListRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<PickListRow> request)
    {
      return new PickListRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (PickListRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new PickListRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<PickListRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new PickListRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<PickListRow> List(IDbConnection connection, ListRequest request)
    {
      return new PickListRepository().List(connection, request);
    }
  }
}

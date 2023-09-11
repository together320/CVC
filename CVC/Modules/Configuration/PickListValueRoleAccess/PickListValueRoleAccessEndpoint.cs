// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Endpoints.PickListValueRoleAccessController
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
  [RoutePrefix("Services/Configuration/PickListValueRoleAccess")]
  [Route("{action}")]
  [ConnectionKey(typeof (PickListValueRoleAccessRow))]
  [ServiceAuthorize(typeof (PickListValueRoleAccessRow))]
  public class PickListValueRoleAccessController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (PickListValueRoleAccessRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<PickListValueRoleAccessRow> request)
    {
      return new PickListValueRoleAccessRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (PickListValueRoleAccessRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<PickListValueRoleAccessRow> request)
    {
      return new PickListValueRoleAccessRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (PickListValueRoleAccessRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new PickListValueRoleAccessRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<PickListValueRoleAccessRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new PickListValueRoleAccessRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<PickListValueRoleAccessRow> List(IDbConnection connection, ListRequest request)
    {
      return new PickListValueRoleAccessRepository().List(connection, request);
    }
  }
}

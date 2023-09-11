// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Endpoints.RoleController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Administration.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Administration.Endpoints
{
  [RoutePrefix("Services/Administration/Role")]
  [Route("{action}")]
  [ConnectionKey(typeof (RoleRow))]
  [ServiceAuthorize(typeof (RoleRow))]
  public class RoleController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (RoleRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<RoleRow> request)
    {
      return new RoleRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (RoleRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<RoleRow> request)
    {
      return new RoleRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (RoleRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new RoleRepository().Delete(uow, request);
    }

    public RetrieveResponse<RoleRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new RoleRepository().Retrieve(connection, request);
    }

    public ListResponse<RoleRow> List(IDbConnection connection, ListRequest request)
    {
      return new RoleRepository().List(connection, request);
    }
  }
}

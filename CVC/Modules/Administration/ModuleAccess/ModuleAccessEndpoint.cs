// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Endpoints.ModuleAccessController
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
  [RoutePrefix("Services/Administration/ModuleAccess")]
  [Route("{action}")]
  [ConnectionKey(typeof (ModuleAccessRow))]
  [ServiceAuthorize(typeof (ModuleAccessRow))]
  public class ModuleAccessController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (ModuleAccessRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<ModuleAccessRow> request)
    {
      return new ModuleAccessRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (ModuleAccessRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<ModuleAccessRow> request)
    {
      return new ModuleAccessRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (ModuleAccessRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new ModuleAccessRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<ModuleAccessRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new ModuleAccessRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<ModuleAccessRow> List(IDbConnection connection, ListRequest request)
    {
      return new ModuleAccessRepository().List(connection, request);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.ModuleManagement.Endpoints.ModuleController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.ModuleManagement.Entities;
using CVC.ModuleManagement.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.ModuleManagement.Endpoints
{
  [RoutePrefix("Services/ModuleManagement/Module")]
  [Route("{action}")]
  [ConnectionKey(typeof (ModuleRow))]
  [ServiceAuthorize(typeof (ModuleRow))]
  public class ModuleController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (ModuleRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<ModuleRow> request)
    {
      return new ModuleRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (ModuleRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<ModuleRow> request)
    {
      return new ModuleRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (ModuleRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new ModuleRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<ModuleRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new ModuleRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<ModuleRow> List(IDbConnection connection, ListRequest request)
    {
      return new ModuleRepository().List(connection, request);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Endpoints.MachineUserController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using CVC.MachineCustomization.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.MachineCustomization.Endpoints
{
  [RoutePrefix("Services/MachineCustomization/MachineUser")]
  [Route("{action}")]
  [ConnectionKey(typeof (MachineUserRow))]
  [ServiceAuthorize(typeof (MachineUserRow))]
  public class MachineUserController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (MachineUserRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineUserRow> request)
    {
      return new MachineUserRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (MachineUserRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineUserRow> request)
    {
      return new MachineUserRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (MachineUserRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineUserRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MachineUserRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineUserRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<MachineUserRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineUserRepository().List(connection, request);
    }
  }
}

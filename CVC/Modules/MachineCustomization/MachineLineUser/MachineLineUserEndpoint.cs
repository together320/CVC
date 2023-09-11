// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Endpoints.MachineLineUserController
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
  [RoutePrefix("Services/MachineCustomization/MachineLineUser")]
  [Route("{action}")]
  [ConnectionKey(typeof (MachineLineUserRow))]
  [ServiceAuthorize(typeof (MachineLineUserRow))]
  public class MachineLineUserController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (MachineLineUserRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineLineUserRow> request)
    {
      return new MachineLineUserRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (MachineLineUserRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineLineUserRow> request)
    {
      return new MachineLineUserRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (MachineLineUserRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineLineUserRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MachineLineUserRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineLineUserRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<MachineLineUserRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineLineUserRepository().List(connection, request);
    }
  }
}

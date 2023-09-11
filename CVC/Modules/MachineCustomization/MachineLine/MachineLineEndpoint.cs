// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Endpoints.MachineLineController
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
  [RoutePrefix("Services/MachineCustomization/MachineLine")]
  [Route("{action}")]
  [ConnectionKey(typeof (MachineLineRow))]
  [ServiceAuthorize(typeof (MachineLineRow))]
  public class MachineLineController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (MachineLineRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineLineRow> request)
    {
      return new MachineLineRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (MachineLineRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineLineRow> request)
    {
      return new MachineLineRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (MachineLineRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineLineRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MachineLineRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineLineRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<MachineLineRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineLineRepository().List(connection, request);
    }
  }
}

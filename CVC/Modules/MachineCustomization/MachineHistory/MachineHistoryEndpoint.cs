// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Endpoints.MachineHistoryController
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
  [RoutePrefix("Services/MachineCustomization/MachineHistory")]
  [Route("{action}")]
  [ConnectionKey(typeof (MachineHistoryRow))]
  [ServiceAuthorize(typeof (MachineHistoryRow))]
  public class MachineHistoryController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (MachineHistoryRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineHistoryRow> request)
    {
      return new MachineHistoryRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (MachineHistoryRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineHistoryRow> request)
    {
      return new MachineHistoryRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (MachineHistoryRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineHistoryRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MachineHistoryRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineHistoryRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<MachineHistoryRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineHistoryRepository().List(connection, request);
    }
  }
}

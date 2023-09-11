// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Endpoints.MachineMaintenanceScheduleController
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
  [RoutePrefix("Services/MachineCustomization/MachineMaintenanceSchedule")]
  [Route("{action}")]
  [ConnectionKey(typeof (MachineMaintenanceScheduleRow))]
  [ServiceAuthorize(typeof (MachineMaintenanceScheduleRow))]
  public class MachineMaintenanceScheduleController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (MachineMaintenanceScheduleRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineMaintenanceScheduleRow> request)
    {
      return new MachineMaintenanceScheduleRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (MachineMaintenanceScheduleRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineMaintenanceScheduleRow> request)
    {
      return new MachineMaintenanceScheduleRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (MachineMaintenanceScheduleRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineMaintenanceScheduleRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MachineMaintenanceScheduleRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineMaintenanceScheduleRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<MachineMaintenanceScheduleRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineMaintenanceScheduleRepository().List(connection, request);
    }
  }
}

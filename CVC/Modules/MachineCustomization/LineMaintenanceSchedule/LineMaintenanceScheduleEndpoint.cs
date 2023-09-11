// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Endpoints.LineMaintenanceScheduleController
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
  [RoutePrefix("Services/MachineCustomization/LineMaintenanceSchedule")]
  [Route("{action}")]
  [ConnectionKey(typeof (LineMaintenanceScheduleRow))]
  [ServiceAuthorize(typeof (LineMaintenanceScheduleRow))]
  public class LineMaintenanceScheduleController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (LineMaintenanceScheduleRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<LineMaintenanceScheduleRow> request)
    {
      return new LineMaintenanceScheduleRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (LineMaintenanceScheduleRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<LineMaintenanceScheduleRow> request)
    {
      return new LineMaintenanceScheduleRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (LineMaintenanceScheduleRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new LineMaintenanceScheduleRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<LineMaintenanceScheduleRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new LineMaintenanceScheduleRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<LineMaintenanceScheduleRow> List(IDbConnection connection, ListRequest request)
    {
      return new LineMaintenanceScheduleRepository().List(connection, request);
    }
  }
}

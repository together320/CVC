// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Repositories.LineMaintenanceScheduleRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.MachineCustomization.Repositories
{
  public class LineMaintenanceScheduleRepository
  {
    private static LineMaintenanceScheduleRow.RowFields fld
    {
      get
      {
        return LineMaintenanceScheduleRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<LineMaintenanceScheduleRow> request)
    {
      return new LineMaintenanceScheduleRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<LineMaintenanceScheduleRow> request)
    {
      return new LineMaintenanceScheduleRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new LineMaintenanceScheduleRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<LineMaintenanceScheduleRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new LineMaintenanceScheduleRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<LineMaintenanceScheduleRow> List(IDbConnection connection, ListRequest request)
    {
      return new LineMaintenanceScheduleRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<LineMaintenanceScheduleRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<LineMaintenanceScheduleRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<LineMaintenanceScheduleRow>
    {
    }

    private class MyListHandler : ListRequestHandler<LineMaintenanceScheduleRow>
    {
    }
  }
}

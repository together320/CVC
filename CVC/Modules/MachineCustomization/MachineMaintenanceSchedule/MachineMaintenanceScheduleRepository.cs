// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Repositories.MachineMaintenanceScheduleRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.MachineCustomization.Repositories
{
  public class MachineMaintenanceScheduleRepository
  {
    private static MachineMaintenanceScheduleRow.RowFields fld
    {
      get
      {
        return MachineMaintenanceScheduleRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineMaintenanceScheduleRow> request)
    {
      return new MachineMaintenanceScheduleRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineMaintenanceScheduleRow> request)
    {
      return new MachineMaintenanceScheduleRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineMaintenanceScheduleRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<MachineMaintenanceScheduleRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineMaintenanceScheduleRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<MachineMaintenanceScheduleRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineMaintenanceScheduleRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<MachineMaintenanceScheduleRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<MachineMaintenanceScheduleRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<MachineMaintenanceScheduleRow>
    {
    }

    private class MyListHandler : ListRequestHandler<MachineMaintenanceScheduleRow>
    {
    }
  }
}

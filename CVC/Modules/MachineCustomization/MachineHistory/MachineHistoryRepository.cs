// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Repositories.MachineHistoryRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.MachineCustomization.Repositories
{
  public class MachineHistoryRepository
  {
    private static MachineHistoryRow.RowFields fld
    {
      get
      {
        return MachineHistoryRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineHistoryRow> request)
    {
      return new MachineHistoryRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineHistoryRow> request)
    {
      return new MachineHistoryRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineHistoryRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<MachineHistoryRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineHistoryRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<MachineHistoryRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineHistoryRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<MachineHistoryRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<MachineHistoryRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<MachineHistoryRow>
    {
    }

    private class MyListHandler : ListRequestHandler<MachineHistoryRow>
    {
    }
  }
}

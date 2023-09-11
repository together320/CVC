// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Repositories.MachineLineRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.MachineCustomization.Repositories
{
  public class MachineLineRepository
  {
    private static MachineLineRow.RowFields fld
    {
      get
      {
        return MachineLineRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineLineRow> request)
    {
      return new MachineLineRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineLineRow> request)
    {
      return new MachineLineRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineLineRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<MachineLineRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineLineRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<MachineLineRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineLineRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<MachineLineRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<MachineLineRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<MachineLineRow>
    {
    }

    private class MyListHandler : ListRequestHandler<MachineLineRow>
    {
    }
  }
}

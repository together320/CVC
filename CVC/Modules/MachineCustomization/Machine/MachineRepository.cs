// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Repositories.MachineRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.MachineCustomization.Repositories
{
  public class MachineRepository
  {
    private static MachineRow.RowFields fld
    {
      get
      {
        return MachineRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineRow> request)
    {
      return new MachineRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineRow> request)
    {
      return new MachineRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<MachineRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<MachineRow> List(IDbConnection connection, ListRequest request)
    {

            return new MachineRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<MachineRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<MachineRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<MachineRow>
    {
    }

    private class MyListHandler : ListRequestHandler<MachineRow>
    {
    }
  }
}

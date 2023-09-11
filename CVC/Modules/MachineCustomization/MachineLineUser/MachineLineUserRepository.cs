// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Repositories.MachineLineUserRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.MachineCustomization.Repositories
{
  public class MachineLineUserRepository
  {
    private static MachineLineUserRow.RowFields fld
    {
      get
      {
        return MachineLineUserRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineLineUserRow> request)
    {
      return new MachineLineUserRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineLineUserRow> request)
    {
      return new MachineLineUserRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineLineUserRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<MachineLineUserRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineLineUserRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<MachineLineUserRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineLineUserRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<MachineLineUserRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<MachineLineUserRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<MachineLineUserRow>
    {
    }

    private class MyListHandler : ListRequestHandler<MachineLineUserRow>
    {
    }
  }
}

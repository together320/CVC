// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Repositories.MachineUserRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.MachineCustomization.Repositories
{
  public class MachineUserRepository
  {
    private static MachineUserRow.RowFields fld
    {
      get
      {
        return MachineUserRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineUserRow> request)
    {
      return new MachineUserRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineUserRow> request)
    {
      return new MachineUserRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineUserRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<MachineUserRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineUserRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<MachineUserRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineUserRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<MachineUserRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<MachineUserRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<MachineUserRow>
    {
    }

    private class MyListHandler : ListRequestHandler<MachineUserRow>
    {
    }
  }
}

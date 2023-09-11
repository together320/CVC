// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Repositories.MachineVideoRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.MachineCustomization.Repositories
{
  public class MachineVideoRepository
  {
    private static MachineVideoRow.RowFields fld
    {
      get
      {
        return MachineVideoRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineVideoRow> request)
    {
      return new MachineVideoRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineVideoRow> request)
    {
      return new MachineVideoRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineVideoRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<MachineVideoRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineVideoRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<MachineVideoRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineVideoRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<MachineVideoRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<MachineVideoRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<MachineVideoRow>
    {
    }

    private class MyListHandler : ListRequestHandler<MachineVideoRow>
    {
    }
  }
}

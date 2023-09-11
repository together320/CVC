// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Repositories.MachineSpecificationRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.MachineCustomization.Repositories
{
  public class MachineSpecificationRepository
  {
    private static MachineSpecificationRow.RowFields fld
    {
      get
      {
        return MachineSpecificationRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineSpecificationRow> request)
    {
      return new MachineSpecificationRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineSpecificationRow> request)
    {
      return new MachineSpecificationRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineSpecificationRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<MachineSpecificationRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineSpecificationRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<MachineSpecificationRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineSpecificationRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<MachineSpecificationRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<MachineSpecificationRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<MachineSpecificationRow>
    {
    }

    private class MyListHandler : ListRequestHandler<MachineSpecificationRow>
    {
    }
  }
}

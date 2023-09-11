// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Repositories.MachineSparePartRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.MachineCustomization.Repositories
{
  public class MachineSparePartRepository
  {
    private static MachineSparePartRow.RowFields fld
    {
      get
      {
        return MachineSparePartRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineSparePartRow> request)
    {
      return new MachineSparePartRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineSparePartRow> request)
    {
      return new MachineSparePartRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineSparePartRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<MachineSparePartRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineSparePartRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<MachineSparePartRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineSparePartRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<MachineSparePartRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<MachineSparePartRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<MachineSparePartRow>
    {
    }

    private class MyListHandler : ListRequestHandler<MachineSparePartRow>
    {
    }
  }
}

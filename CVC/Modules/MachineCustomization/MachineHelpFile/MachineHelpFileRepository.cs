// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Repositories.MachineHelpFileRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.MachineCustomization.Repositories
{
  public class MachineHelpFileRepository
  {
    private static MachineHelpFileRow.RowFields fld
    {
      get
      {
        return MachineHelpFileRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineHelpFileRow> request)
    {
      return new MachineHelpFileRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineHelpFileRow> request)
    {
      return new MachineHelpFileRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineHelpFileRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<MachineHelpFileRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineHelpFileRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<MachineHelpFileRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineHelpFileRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<MachineHelpFileRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<MachineHelpFileRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<MachineHelpFileRow>
    {
    }

    private class MyListHandler : ListRequestHandler<MachineHelpFileRow>
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Repositories.PickListRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Configuration.Repositories
{
  public class PickListRepository
  {
    private static PickListRow.RowFields fld
    {
      get
      {
        return PickListRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<PickListRow> request)
    {
      return new PickListRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<PickListRow> request)
    {
      return new PickListRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new PickListRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<PickListRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new PickListRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<PickListRow> List(IDbConnection connection, ListRequest request)
    {
      return new PickListRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<PickListRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<PickListRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<PickListRow>
    {
    }

    private class MyListHandler : ListRequestHandler<PickListRow>
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Repositories.ViewFieldAccessRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Administration.Repositories
{
  public class ViewFieldAccessRepository
  {
    private static ViewFieldAccessRow.RowFields fld
    {
      get
      {
        return ViewFieldAccessRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<ViewFieldAccessRow> request)
    {
      return new ViewFieldAccessRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<ViewFieldAccessRow> request)
    {
      return new ViewFieldAccessRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new ViewFieldAccessRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<ViewFieldAccessRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new ViewFieldAccessRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<ViewFieldAccessRow> List(IDbConnection connection, ListRequest request)
    {
      return new ViewFieldAccessRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<ViewFieldAccessRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<ViewFieldAccessRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<ViewFieldAccessRow>
    {
    }

    private class MyListHandler : ListRequestHandler<ViewFieldAccessRow>
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Repositories.ViewsAccessRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Administration.Repositories
{
  public class ViewsAccessRepository
  {
    private static ViewsAccessRow.RowFields fld
    {
      get
      {
        return ViewsAccessRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<ViewsAccessRow> request)
    {
      return new ViewsAccessRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<ViewsAccessRow> request)
    {
      return new ViewsAccessRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new ViewsAccessRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<ViewsAccessRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new ViewsAccessRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<ViewsAccessRow> List(IDbConnection connection, ListRequest request)
    {
      return new ViewsAccessRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<ViewsAccessRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<ViewsAccessRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<ViewsAccessRow>
    {
    }

    private class MyListHandler : ListRequestHandler<ViewsAccessRow>
    {
    }
  }
}

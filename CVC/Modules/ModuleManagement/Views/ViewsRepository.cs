// Decompiled with JetBrains decompiler
// Type: CVC.ModuleManagement.Repositories.ViewsRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.ModuleManagement.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.ModuleManagement.Repositories
{
  public class ViewsRepository
  {
    private static ViewsRow.RowFields fld
    {
      get
      {
        return ViewsRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<ViewsRow> request)
    {
      return new ViewsRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<ViewsRow> request)
    {
      return new ViewsRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new ViewsRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<ViewsRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new ViewsRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<ViewsRow> List(IDbConnection connection, ListRequest request)
    {
      return new ViewsRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<ViewsRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<ViewsRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<ViewsRow>
    {
    }

    private class MyListHandler : ListRequestHandler<ViewsRow>
    {
    }
  }
}

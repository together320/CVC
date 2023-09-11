// Decompiled with JetBrains decompiler
// Type: CVC.ModuleManagement.Repositories.ViewFieldRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.ModuleManagement.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.ModuleManagement.Repositories
{
  public class ViewFieldRepository
  {
    private static ViewFieldRow.RowFields fld
    {
      get
      {
        return ViewFieldRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<ViewFieldRow> request)
    {
      return new ViewFieldRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<ViewFieldRow> request)
    {
      return new ViewFieldRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new ViewFieldRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<ViewFieldRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new ViewFieldRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<ViewFieldRow> List(IDbConnection connection, ListRequest request)
    {
      return new ViewFieldRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<ViewFieldRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<ViewFieldRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<ViewFieldRow>
    {
    }

    private class MyListHandler : ListRequestHandler<ViewFieldRow>
    {
    }
  }
}

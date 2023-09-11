// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Repositories.AdminFormRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Administration.Repositories
{
  public class AdminFormRepository
  {
    private static AdminFormRow.RowFields fld
    {
      get
      {
        return AdminFormRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<AdminFormRow> request)
    {
      return new AdminFormRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<AdminFormRow> request)
    {
      return new AdminFormRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new AdminFormRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<AdminFormRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new AdminFormRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<AdminFormRow> List(IDbConnection connection, ListRequest request)
    {
      return new AdminFormRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<AdminFormRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<AdminFormRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<AdminFormRow>
    {
    }

    private class MyListHandler : ListRequestHandler<AdminFormRow>
    {
    }
  }
}

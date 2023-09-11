// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Repositories.CurrencyRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Configuration.Repositories
{
  public class CurrencyRepository
  {
    private static CurrencyRow.RowFields fld
    {
      get
      {
        return CurrencyRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<CurrencyRow> request)
    {
      return new CurrencyRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<CurrencyRow> request)
    {
      return new CurrencyRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new CurrencyRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<CurrencyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new CurrencyRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<CurrencyRow> List(IDbConnection connection, ListRequest request)
    {
      return new CurrencyRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<CurrencyRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<CurrencyRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<CurrencyRow>
    {
    }

    private class MyListHandler : ListRequestHandler<CurrencyRow>
    {
    }
  }
}

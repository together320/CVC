// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Endpoints.CurrencyController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.Configuration.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Configuration.Endpoints
{
  [RoutePrefix("Services/Configuration/Currency")]
  [Route("{action}")]
  [ConnectionKey(typeof (CurrencyRow))]
  [ServiceAuthorize(typeof (CurrencyRow))]
  public class CurrencyController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (CurrencyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<CurrencyRow> request)
    {
      return new CurrencyRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (CurrencyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<CurrencyRow> request)
    {
      return new CurrencyRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (CurrencyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new CurrencyRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<CurrencyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new CurrencyRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<CurrencyRow> List(IDbConnection connection, ListRequest request)
    {
      return new CurrencyRepository().List(connection, request);
    }
  }
}

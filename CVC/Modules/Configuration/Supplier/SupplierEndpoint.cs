// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Endpoints.SupplierController
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
  [RoutePrefix("Services/Configuration/Supplier")]
  [Route("{action}")]
  [ConnectionKey(typeof (SupplierRow))]
  [ServiceAuthorize(typeof (SupplierRow))]
  public class SupplierController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (SupplierRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<SupplierRow> request)
    {
      return new SupplierRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (SupplierRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<SupplierRow> request)
    {
      return new SupplierRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (SupplierRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new SupplierRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<SupplierRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new SupplierRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<SupplierRow> List(IDbConnection connection, ListRequest request)
    {
      return new SupplierRepository().List(connection, request);
    }
  }
}

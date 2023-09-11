// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Endpoints.ShiftController
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
  [RoutePrefix("Services/Configuration/Shift")]
  [Route("{action}")]
  [ConnectionKey(typeof (ShiftRow))]
  [ServiceAuthorize(typeof (ShiftRow))]
  public class ShiftController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (ShiftRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<ShiftRow> request)
    {
      return new ShiftRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (ShiftRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<ShiftRow> request)
    {
      return new ShiftRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (ShiftRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new ShiftRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<ShiftRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new ShiftRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<ShiftRow> List(IDbConnection connection, ListRequest request)
    {
      return new ShiftRepository().List(connection, request);
    }
  }
}

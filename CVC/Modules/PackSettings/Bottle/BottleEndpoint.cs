// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Endpoints.BottleController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.PackSettings.Entities;
using CVC.PackSettings.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.PackSettings.Endpoints
{
  [RoutePrefix("Services/PackSettings/Bottle")]
  [Route("{action}")]
  [ConnectionKey(typeof (BottleRow))]
  [ServiceAuthorize(typeof (BottleRow))]
  public class BottleController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (BottleRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<BottleRow> request)
    {
      return new BottleRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (BottleRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<BottleRow> request)
    {
      return new BottleRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (BottleRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new BottleRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<BottleRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new BottleRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<BottleRow> List(IDbConnection connection, ListRequest request)
    {
      return new BottleRepository().List(connection, request);
    }
  }
}

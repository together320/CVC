// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Endpoints.CottonController
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
  [RoutePrefix("Services/PackSettings/Cotton")]
  [Route("{action}")]
  [ConnectionKey(typeof (CottonRow))]
  [ServiceAuthorize(typeof (CottonRow))]
  public class CottonController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (CottonRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<CottonRow> request)
    {
      return new CottonRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (CottonRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<CottonRow> request)
    {
      return new CottonRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (CottonRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new CottonRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<CottonRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new CottonRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<CottonRow> List(IDbConnection connection, ListRequest request)
    {
      return new CottonRepository().List(connection, request);
    }
  }
}

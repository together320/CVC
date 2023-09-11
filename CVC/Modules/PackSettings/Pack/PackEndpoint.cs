// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Endpoints.PackController
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
  [RoutePrefix("Services/PackSettings/Pack")]
  [Route("{action}")]
  [ConnectionKey(typeof (PackRow))]
  [ServiceAuthorize(typeof (PackRow))]
  public class PackController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (PackRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<PackRow> request)
    {
      return new PackRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (PackRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<PackRow> request)
    {
      return new PackRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (PackRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new PackRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<PackRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new PackRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<PackRow> List(IDbConnection connection, ListRequest request)
    {
      return new PackRepository().List(connection, request);
    }
  }
}

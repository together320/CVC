// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Endpoints.StatusController
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
  [RoutePrefix("Services/Configuration/Status")]
  [Route("{action}")]
  [ConnectionKey(typeof (StatusRow))]
  [ServiceAuthorize(typeof (StatusRow))]
  public class StatusController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (StatusRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<StatusRow> request)
    {
      return new StatusRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (StatusRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<StatusRow> request)
    {
      return new StatusRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (StatusRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new StatusRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<StatusRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new StatusRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<StatusRow> List(IDbConnection connection, ListRequest request)
    {
      return new StatusRepository().List(connection, request);
    }
  }
}

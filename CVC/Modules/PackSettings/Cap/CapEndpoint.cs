// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Endpoints.CapController
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
  [RoutePrefix("Services/PackSettings/Cap")]
  [Route("{action}")]
  [ConnectionKey(typeof (CapRow))]
  [ServiceAuthorize(typeof (CapRow))]
  public class CapController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (CapRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<CapRow> request)
    {
      return new CapRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (CapRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<CapRow> request)
    {
      return new CapRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (CapRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new CapRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<CapRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new CapRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<CapRow> List(IDbConnection connection, ListRequest request)
    {
      return new CapRepository().List(connection, request);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Endpoints.ViewFieldAccessController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Administration.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Administration.Endpoints
{
  [RoutePrefix("Services/Administration/ViewFieldAccess")]
  [Route("{action}")]
  [ConnectionKey(typeof (ViewFieldAccessRow))]
  [ServiceAuthorize(typeof (ViewFieldAccessRow))]
  public class ViewFieldAccessController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (ViewFieldAccessRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<ViewFieldAccessRow> request)
    {
      return new ViewFieldAccessRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (ViewFieldAccessRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<ViewFieldAccessRow> request)
    {
      return new ViewFieldAccessRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (ViewFieldAccessRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new ViewFieldAccessRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<ViewFieldAccessRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new ViewFieldAccessRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<ViewFieldAccessRow> List(IDbConnection connection, ListRequest request)
    {
      return new ViewFieldAccessRepository().List(connection, request);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Endpoints.ViewsAccessController
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
  [RoutePrefix("Services/Administration/ViewsAccess")]
  [Route("{action}")]
  [ConnectionKey(typeof (ViewsAccessRow))]
  [ServiceAuthorize(typeof (ViewsAccessRow))]
  public class ViewsAccessController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (ViewsAccessRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<ViewsAccessRow> request)
    {
      return new ViewsAccessRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (ViewsAccessRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<ViewsAccessRow> request)
    {
      return new ViewsAccessRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (ViewsAccessRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new ViewsAccessRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<ViewsAccessRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new ViewsAccessRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<ViewsAccessRow> List(IDbConnection connection, ListRequest request)
    {
      return new ViewsAccessRepository().List(connection, request);
    }
  }
}

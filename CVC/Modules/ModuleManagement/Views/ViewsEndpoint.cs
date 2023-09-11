// Decompiled with JetBrains decompiler
// Type: CVC.ModuleManagement.Endpoints.ViewsController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.ModuleManagement.Entities;
using CVC.ModuleManagement.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.ModuleManagement.Endpoints
{
  [RoutePrefix("Services/ModuleManagement/Views")]
  [Route("{action}")]
  [ConnectionKey(typeof (ViewsRow))]
  [ServiceAuthorize(typeof (ViewsRow))]
  public class ViewsController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (ViewsRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<ViewsRow> request)
    {
      return new ViewsRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (ViewsRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<ViewsRow> request)
    {
      return new ViewsRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (ViewsRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new ViewsRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<ViewsRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new ViewsRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<ViewsRow> List(IDbConnection connection, ListRequest request)
    {
      return new ViewsRepository().List(connection, request);
    }
  }
}

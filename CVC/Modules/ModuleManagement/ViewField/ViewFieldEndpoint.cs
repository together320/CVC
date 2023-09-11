// Decompiled with JetBrains decompiler
// Type: CVC.ModuleManagement.Endpoints.ViewFieldController
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
  [RoutePrefix("Services/ModuleManagement/ViewField")]
  [Route("{action}")]
  [ConnectionKey(typeof (ViewFieldRow))]
  [ServiceAuthorize(typeof (ViewFieldRow))]
  public class ViewFieldController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (ViewFieldRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<ViewFieldRow> request)
    {
      return new ViewFieldRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (ViewFieldRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<ViewFieldRow> request)
    {
      return new ViewFieldRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (ViewFieldRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new ViewFieldRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<ViewFieldRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new ViewFieldRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<ViewFieldRow> List(IDbConnection connection, ListRequest request)
    {
      return new ViewFieldRepository().List(connection, request);
    }
  }
}

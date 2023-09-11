// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Endpoints.AdminFormController
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
  [RoutePrefix("Services/Administration/AdminForm")]
  [Route("{action}")]
  [ConnectionKey(typeof (AdminFormRow))]
  [ServiceAuthorize(typeof (AdminFormRow))]
  public class AdminFormController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (AdminFormRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<AdminFormRow> request)
    {
      return new AdminFormRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (AdminFormRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<AdminFormRow> request)
    {
      return new AdminFormRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (AdminFormRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new AdminFormRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<AdminFormRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new AdminFormRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<AdminFormRow> List(IDbConnection connection, ListRequest request)
    {
      return new AdminFormRepository().List(connection, request);
    }
  }
}

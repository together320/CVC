// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Endpoints.DepartmentController
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
  [RoutePrefix("Services/Configuration/Department")]
  [Route("{action}")]
  [ConnectionKey(typeof (DepartmentRow))]
  [ServiceAuthorize(typeof (DepartmentRow))]
  public class DepartmentController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (DepartmentRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<DepartmentRow> request)
    {
      return new DepartmentRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (DepartmentRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<DepartmentRow> request)
    {
      return new DepartmentRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (DepartmentRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new DepartmentRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<DepartmentRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new DepartmentRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<DepartmentRow> List(IDbConnection connection, ListRequest request)
    {
      return new DepartmentRepository().List(connection, request);
    }
  }
}

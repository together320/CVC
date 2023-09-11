// Decompiled with JetBrains decompiler
// Type: CVC.ExternalApplicationInterface.Endpoints.IpcParameterController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.ExternalApplicationInterface.Entities;
using CVC.ExternalApplicationInterface.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.ExternalApplicationInterface.Endpoints
{
  [RoutePrefix("Services/ExternalApplicationInterface/IpcParameter")]
  [Route("{action}")]
  [ConnectionKey(typeof (IpcParameterRow))]
  [ServiceAuthorize(typeof (IpcParameterRow))]
  public class IpcParameterController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (IpcParameterRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<IpcParameterRow> request)
    {
      return new IpcParameterRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (IpcParameterRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<IpcParameterRow> request)
    {
      return new IpcParameterRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (IpcParameterRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new IpcParameterRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<IpcParameterRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new IpcParameterRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<IpcParameterRow> List(IDbConnection connection, ListRequest request)
    {
      return new IpcParameterRepository().List(connection, request);
    }
  }
}

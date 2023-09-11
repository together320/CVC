// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Endpoints.EnvironmentVariablesController
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
  [RoutePrefix("Services/Configuration/EnvironmentVariables")]
  [Route("{action}")]
  [ConnectionKey(typeof (EnvironmentVariablesRow))]
  [ServiceAuthorize(typeof (EnvironmentVariablesRow))]
  public class EnvironmentVariablesController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (EnvironmentVariablesRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<EnvironmentVariablesRow> request)
    {
      return new EnvironmentVariablesRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (EnvironmentVariablesRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<EnvironmentVariablesRow> request)
    {
      return new EnvironmentVariablesRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (EnvironmentVariablesRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new EnvironmentVariablesRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<EnvironmentVariablesRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new EnvironmentVariablesRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<EnvironmentVariablesRow> List(IDbConnection connection, ListRequest request)
    {
      return new EnvironmentVariablesRepository().List(connection, request);
    }
  }
}

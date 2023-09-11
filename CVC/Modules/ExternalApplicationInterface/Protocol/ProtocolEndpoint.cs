// Decompiled with JetBrains decompiler
// Type: CVC.ExternalApplicationInterface.Endpoints.ProtocolController
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
  [RoutePrefix("Services/ExternalApplicationInterface/Protocol")]
  [Route("{action}")]
  [ConnectionKey(typeof (ProtocolRow))]
  [ServiceAuthorize(typeof (ProtocolRow))]
  public class ProtocolController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (ProtocolRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<ProtocolRow> request)
    {
      return new ProtocolRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (ProtocolRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<ProtocolRow> request)
    {
      return new ProtocolRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (ProtocolRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new ProtocolRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<ProtocolRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new ProtocolRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<ProtocolRow> List(IDbConnection connection, ListRequest request)
    {
      return new ProtocolRepository().List(connection, request);
    }
  }
}

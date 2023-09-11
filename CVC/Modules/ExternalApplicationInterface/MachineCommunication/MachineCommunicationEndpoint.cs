// Decompiled with JetBrains decompiler
// Type: CVC.ExternalApplicationInterface.Endpoints.MachineCommunicationController
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
  [RoutePrefix("Services/ExternalApplicationInterface/MachineCommunication")]
  [Route("{action}")]
  [ConnectionKey(typeof (MachineCommunicationRow))]
  [ServiceAuthorize(typeof (MachineCommunicationRow))]
  public class MachineCommunicationController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (MachineCommunicationRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineCommunicationRow> request)
    {
      return new MachineCommunicationRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (MachineCommunicationRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineCommunicationRow> request)
    {
      return new MachineCommunicationRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (MachineCommunicationRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineCommunicationRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MachineCommunicationRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineCommunicationRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<MachineCommunicationRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineCommunicationRepository().List(connection, request);
    }
  }
}

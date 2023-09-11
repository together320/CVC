// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Endpoints.MachineVideoController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using CVC.MachineCustomization.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.MachineCustomization.Endpoints
{
  [RoutePrefix("Services/MachineCustomization/MachineVideo")]
  [Route("{action}")]
  [ConnectionKey(typeof (MachineVideoRow))]
  [ServiceAuthorize(typeof (MachineVideoRow))]
  public class MachineVideoController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (MachineVideoRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineVideoRow> request)
    {
      return new MachineVideoRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (MachineVideoRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineVideoRow> request)
    {
      return new MachineVideoRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (MachineVideoRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineVideoRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MachineVideoRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineVideoRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<MachineVideoRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineVideoRepository().List(connection, request);
    }
  }
}

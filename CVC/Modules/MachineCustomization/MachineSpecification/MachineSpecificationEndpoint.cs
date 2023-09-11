// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Endpoints.MachineSpecificationController
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
  [RoutePrefix("Services/MachineCustomization/MachineSpecification")]
  [Route("{action}")]
  [ConnectionKey(typeof (MachineSpecificationRow))]
  [ServiceAuthorize(typeof (MachineSpecificationRow))]
  public class MachineSpecificationController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (MachineSpecificationRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineSpecificationRow> request)
    {
      return new MachineSpecificationRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (MachineSpecificationRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineSpecificationRow> request)
    {
      return new MachineSpecificationRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (MachineSpecificationRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineSpecificationRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MachineSpecificationRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineSpecificationRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<MachineSpecificationRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineSpecificationRepository().List(connection, request);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Endpoints.MachineSparePartController
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
  [RoutePrefix("Services/MachineCustomization/MachineSparePart")]
  [Route("{action}")]
  [ConnectionKey(typeof (MachineSparePartRow))]
  [ServiceAuthorize(typeof (MachineSparePartRow))]
  public class MachineSparePartController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (MachineSparePartRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineSparePartRow> request)
    {
      return new MachineSparePartRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (MachineSparePartRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineSparePartRow> request)
    {
      return new MachineSparePartRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (MachineSparePartRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineSparePartRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MachineSparePartRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineSparePartRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<MachineSparePartRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineSparePartRepository().List(connection, request);
    }
  }
}

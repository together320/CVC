// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Endpoints.MachineHelpFileController
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
  [RoutePrefix("Services/MachineCustomization/MachineHelpFile")]
  [Route("{action}")]
  [ConnectionKey(typeof (MachineHelpFileRow))]
  [ServiceAuthorize(typeof (MachineHelpFileRow))]
  public class MachineHelpFileController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (MachineHelpFileRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineHelpFileRow> request)
    {
      return new MachineHelpFileRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (MachineHelpFileRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineHelpFileRow> request)
    {
      return new MachineHelpFileRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (MachineHelpFileRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineHelpFileRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MachineHelpFileRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineHelpFileRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<MachineHelpFileRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineHelpFileRepository().List(connection, request);
    }
  }
}

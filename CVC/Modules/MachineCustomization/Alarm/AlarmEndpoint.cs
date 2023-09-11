// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Endpoints.AlarmController
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
  [RoutePrefix("Services/MachineCustomization/Alarm")]
  [Route("{action}")]
  [ConnectionKey(typeof (AlarmRow))]
  [ServiceAuthorize(typeof (AlarmRow))]
  public class AlarmController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (AlarmRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<AlarmRow> request)
    {
      return new AlarmRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (AlarmRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<AlarmRow> request)
    {
      return new AlarmRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (AlarmRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new AlarmRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<AlarmRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new AlarmRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<AlarmRow> List(IDbConnection connection, ListRequest request)
    {
      return new AlarmRepository().List(connection, request);
    }
  }
}

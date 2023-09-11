// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Endpoints.AlarmResetIdController
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
  [RoutePrefix("Services/MachineCustomization/AlarmResetId")]
  [Route("{action}")]
  [ConnectionKey(typeof (AlarmResetIdRow))]
  [ServiceAuthorize(typeof (AlarmResetIdRow))]
  public class AlarmResetIdController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (AlarmResetIdRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<AlarmResetIdRow> request)
    {
      return new AlarmResetIdRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (AlarmResetIdRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<AlarmResetIdRow> request)
    {
      return new AlarmResetIdRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (AlarmResetIdRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new AlarmResetIdRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<AlarmResetIdRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new AlarmResetIdRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<AlarmResetIdRow> List(IDbConnection connection, ListRequest request)
    {
      return new AlarmResetIdRepository().List(connection, request);
    }
  }
}

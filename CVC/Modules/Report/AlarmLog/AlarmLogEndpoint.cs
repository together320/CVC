// Decompiled with JetBrains decompiler
// Type: CVC.Report.Endpoints.AlarmLogController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Report.Entities;
using CVC.Report.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Report.Endpoints
{
  [RoutePrefix("Services/Report/AlarmLog")]
  [Route("{action}")]
  [ConnectionKey(typeof (AlarmLogRow))]
  [ServiceAuthorize(typeof (AlarmLogRow))]
  public class AlarmLogController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (AlarmLogRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<AlarmLogRow> request)
    {
      return new AlarmLogRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (AlarmLogRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<AlarmLogRow> request)
    {
      return new AlarmLogRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (AlarmLogRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new AlarmLogRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<AlarmLogRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new AlarmLogRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<AlarmLogRow> List(IDbConnection connection, ListRequest request)
    {
      return new AlarmLogRepository().List(connection, request);
    }
  }
}

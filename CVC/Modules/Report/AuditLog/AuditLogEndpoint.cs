// Decompiled with JetBrains decompiler
// Type: CVC.Report.Endpoints.AuditLogController
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
  [RoutePrefix("Services/Report/AuditLog")]
  [Route("{action}")]
  [ConnectionKey(typeof (AuditLogRow))]
  [ServiceAuthorize(typeof (AuditLogRow))]
  public class AuditLogController : ServiceEndpoint
  {
    //[HttpPost]
    //[AuthorizeCreate(typeof (AuditLogRow))]
    //public SaveResponse Create(IUnitOfWork uow, SaveRequest<AuditLogRow> request)
    //{
    //  return new AuditLogRepository().Create(uow, request);
    //}

    //[HttpPost]
    //[AuthorizeUpdate(typeof (AuditLogRow))]
    //public SaveResponse Update(IUnitOfWork uow, SaveRequest<AuditLogRow> request)
    //{
    //  return new AuditLogRepository().Update(uow, request);
    //}

    //[HttpPost]
    //[AuthorizeDelete(typeof (AuditLogRow))]
    //public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    //{
    //  return new AuditLogRepository().Delete(uow, request);
    //}

    [HttpPost]
    public RetrieveResponse<AuditLogRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new AuditLogRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<AuditLogRow> List(IDbConnection connection, ListRequest request)
    {
           // var criteria = request.Criteria;
           
           // if (criteria.IsEmpty)
            {
                ListResponse<AuditLogRow> lst = new ListResponse<AuditLogRow>();

                lst = new AuditLogRepository().List(connection, request);

                return new AuditLogRepository().List(connection, request);
            }
          //  return null;
    }
  }
}

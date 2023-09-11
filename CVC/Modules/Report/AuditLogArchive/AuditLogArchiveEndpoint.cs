
using CVC.Report.Entities;
using CVC.Report.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Report.Endpoints
{
    [RoutePrefix("Services/Report/AuditLogArchive")]
    [Route("{action}")]
    [ConnectionKey(typeof(AuditLogArchiveRow))]
    [ServiceAuthorize(typeof(AuditLogArchiveRow))]
    public class AuditLogArchiveController : ServiceEndpoint
    {


        [HttpPost]
        public RetrieveResponse<AuditLogArchiveRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new AuditLogArchiveRepository().Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<AuditLogArchiveRow> List(IDbConnection connection, ListRequest request)
        {
            ListResponse<AuditLogArchiveRow> lst = new ListResponse<AuditLogArchiveRow>();

            lst = new AuditLogArchiveRepository().List(connection, request);

            return new AuditLogArchiveRepository().List(connection, request);
        }
    }
}



using CVC.Report.Entities;
using CVC.Report.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Report.Endpoints
{
    [RoutePrefix("Services/Report/AlarmLogArchive")]
    [Route("{action}")]
    [ConnectionKey(typeof(AlarmLogArchiveRow))]
    [ServiceAuthorize(typeof(AlarmLogArchiveRow))]
    public class AlarmLogArchiveController : ServiceEndpoint
    {
        [HttpPost]
        [AuthorizeCreate(typeof(AlarmLogArchiveRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<AlarmLogArchiveRow> request)
        {
            return new AlarmLogArchiveRepository().Create(uow, request);
        }

        [HttpPost]
        [AuthorizeUpdate(typeof(AlarmLogArchiveRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<AlarmLogArchiveRow> request)
        {
            return new AlarmLogArchiveRepository().Update(uow, request);
        }

        [HttpPost]
        [AuthorizeDelete(typeof(AlarmLogArchiveRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new AlarmLogArchiveRepository().Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<AlarmLogArchiveRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new AlarmLogArchiveRepository().Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<AlarmLogArchiveRow> List(IDbConnection connection, ListRequest request)
        {
            return new AlarmLogArchiveRepository().List(connection, request);
        }
    }
}

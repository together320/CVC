
using CVC.Report.Entities;
using CVC.Report.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Report.Endpoints
{

    [RoutePrefix("Services/Report/ExceptionLog")]
    [Route("{action}")]
    [ConnectionKey(typeof(ExceptionLogRow))]
    [ServiceAuthorize(typeof(ExceptionLogRow))]
    public class ExceptionLogController : ServiceEndpoint
    {

        [HttpPost]
        [AuthorizeCreate(typeof(ExceptionLogRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<ExceptionLogRow> request)
        {
            return new ExceptionLogRepository().Create(uow, request);
        }

        [HttpPost]
        [AuthorizeUpdate(typeof(ExceptionLogRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<ExceptionLogRow> request)
        {
            return new ExceptionLogRepository().Update(uow, request);
        }

        [HttpPost]
        [AuthorizeDelete(typeof(ExceptionLogRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new ExceptionLogRepository().Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<ExceptionLogRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new ExceptionLogRepository().Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<ExceptionLogRow> List(IDbConnection connection, ListRequest request)
        {
            return new ExceptionLogRepository().List(connection, request);
        }
    }
}
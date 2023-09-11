
using CVC.Report.Entities;
using CVC.Report.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Report.Endpoints
{

    [RoutePrefix("Services/Report/UserLog")]
    [Route("{action}")]
    [ConnectionKey(typeof(UserLogRow))]
    [ServiceAuthorize(typeof(UserLogRow))]
    public class UserLogController : ServiceEndpoint
    {

        [HttpPost]
        [AuthorizeCreate(typeof(UserLogRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<UserLogRow> request)
        {
            return new UserLogRepository().Create(uow, request);
        }

        [HttpPost]
        [AuthorizeUpdate(typeof(UserLogRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<UserLogRow> request)
        {
            return new UserLogRepository().Update(uow, request);
        }

        [HttpPost]
        [AuthorizeDelete(typeof(UserLogRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new UserLogRepository().Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<UserLogRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new UserLogRepository().Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<UserLogRow> List(IDbConnection connection, ListRequest request)
        {
            return new UserLogRepository().List(connection, request);
        }
    }
}
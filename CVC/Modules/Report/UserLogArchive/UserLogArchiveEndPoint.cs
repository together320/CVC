
using CVC.Report.Entities;
using CVC.Report.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Report.Endpoints
{

    [RoutePrefix("Services/Report/UserLogArchive")]
    [Route("{action}")]
    [ConnectionKey(typeof(UserLogArchiveRow))]
    [ServiceAuthorize(typeof(UserLogArchiveRow))]
    public class UserLogArchiveController : ServiceEndpoint
    {

        [HttpPost]
        [AuthorizeCreate(typeof(UserLogArchiveRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<UserLogArchiveRow> request)
        {
            return new UserLogArchiveRepository().Create(uow, request);
        }

        [HttpPost]
        [AuthorizeUpdate(typeof(UserLogArchiveRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<UserLogArchiveRow> request)
        {
            return new UserLogArchiveRepository().Update(uow, request);
        }

        [HttpPost]
        [AuthorizeDelete(typeof(UserLogArchiveRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new UserLogArchiveRepository().Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<UserLogArchiveRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new UserLogArchiveRepository().Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<UserLogArchiveRow> List(IDbConnection connection, ListRequest request)
        {
            return new UserLogArchiveRepository().List(connection, request);
        }
    }
}

using CVC.Report.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Report.Repositories
{
    public class UserLogArchiveRepository
    {
        private static UserLogArchiveRow.RowFields fld
        {
            get
            {
                return UserLogArchiveRow.Fields;
            }
        }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<UserLogArchiveRow> request)
        {
            return new UserLogArchiveRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<UserLogArchiveRow> request)
        {
            return new UserLogArchiveRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new UserLogArchiveRepository.MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<UserLogArchiveRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new UserLogArchiveRepository.MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<UserLogArchiveRow> List(IDbConnection connection, ListRequest request)
        {
            return new UserLogArchiveRepository.MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<UserLogArchiveRow>
        {
        }

        private class MyDeleteHandler : DeleteRequestHandler<UserLogArchiveRow>
        {
        }

        private class MyRetrieveHandler : RetrieveRequestHandler<UserLogArchiveRow>
        {
        }

        private class MyListHandler : ListRequestHandler<UserLogArchiveRow>
        {
        }
    }
}

using CVC.Report.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Report.Repositories
{
    public class UserLogRepository
    {
        private static UserLogRow.RowFields fld
        {
            get
            {
                return UserLogRow.Fields;
            }
        }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<UserLogRow> request)
        {
            return new UserLogRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<UserLogRow> request)
        {
            return new UserLogRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new UserLogRepository.MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<UserLogRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new UserLogRepository.MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<UserLogRow> List(IDbConnection connection, ListRequest request)
        {
            return new UserLogRepository.MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<UserLogRow>
        {
        }

        private class MyDeleteHandler : DeleteRequestHandler<UserLogRow>
        {
        }

        private class MyRetrieveHandler : RetrieveRequestHandler<UserLogRow>
        {
        }

        private class MyListHandler : ListRequestHandler<UserLogRow>
        {
        }
    }
}
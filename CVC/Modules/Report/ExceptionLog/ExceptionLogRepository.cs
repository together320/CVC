using CVC.Report.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Report.Repositories
{
    public class ExceptionLogRepository
    {
        private static ExceptionLogRow.RowFields fld
        {
            get
            {
                return ExceptionLogRow.Fields;
            }
        }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<ExceptionLogRow> request)
        {
            return new ExceptionLogRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<ExceptionLogRow> request)
        {
            return new ExceptionLogRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new ExceptionLogRepository.MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<ExceptionLogRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new ExceptionLogRepository.MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<ExceptionLogRow> List(IDbConnection connection, ListRequest request)
        {
            return new ExceptionLogRepository.MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<ExceptionLogRow>
        {
        }

        private class MyDeleteHandler : DeleteRequestHandler<ExceptionLogRow>
        {
        }

        private class MyRetrieveHandler : RetrieveRequestHandler<ExceptionLogRow>
        {
        }

        private class MyListHandler : ListRequestHandler<ExceptionLogRow>
        {
        }
    }
}
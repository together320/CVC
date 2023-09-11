
using CVC.Report.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Report.Repositories
{
    public class AuditLogArchiveRepository
    {
        private static AuditLogArchiveRow.RowFields fld
        {
            get
            {
                return AuditLogArchiveRow.Fields;
            }
        }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<AuditLogArchiveRow> request)
        {
            return new AuditLogArchiveRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<AuditLogArchiveRow> request)
        {
            return new AuditLogArchiveRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new AuditLogArchiveRepository.MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<AuditLogArchiveRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new AuditLogArchiveRepository.MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<AuditLogArchiveRow> List(IDbConnection connection, ListRequest request)
        {
            return new AuditLogArchiveRepository.MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<AuditLogArchiveRow>
        {
        }

        private class MyDeleteHandler : DeleteRequestHandler<AuditLogArchiveRow>
        {
        }

        private class MyRetrieveHandler : RetrieveRequestHandler<AuditLogArchiveRow>
        {
        }

        private class MyListHandler : ListRequestHandler<AuditLogArchiveRow>
        {
        }
    }
}

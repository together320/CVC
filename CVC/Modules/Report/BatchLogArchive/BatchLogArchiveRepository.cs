// Decompiled with JetBrains decompiler
// Type: CVC.Report.Repositories.BatchLogRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Report.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Report.Repositories
{
    public class BatchLogArchiveRepository
    {
        private static BatchLogArchiveRow.RowFields fld
        {
            get
            {
                return BatchLogArchiveRow.Fields;
            }
        }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<BatchLogArchiveRow> request)
        {
            return new BatchLogArchiveRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<BatchLogArchiveRow> request)
        {
            return new BatchLogArchiveRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new BatchLogArchiveRepository.MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<BatchLogArchiveRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new BatchLogArchiveRepository.MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<BatchLogArchiveRow> List(IDbConnection connection, ListRequest request)
        {
            return new BatchLogArchiveRepository.MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<BatchLogArchiveRow>
        {
        }

        private class MyDeleteHandler : DeleteRequestHandler<BatchLogArchiveRow>
        {
        }

        private class MyRetrieveHandler : RetrieveRequestHandler<BatchLogArchiveRow>
        {
        }

        private class MyListHandler : ListRequestHandler<BatchLogArchiveRow>
        {
        }
    }
}

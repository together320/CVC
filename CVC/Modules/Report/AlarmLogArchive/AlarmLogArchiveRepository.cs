// Decompiled with JetBrains decompiler
// Type: CVC.Report.Repositories.AlarmLogRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Report.Entities;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using System.Globalization;

namespace CVC.Report.Repositories
{
    public class AlarmLogArchiveRepository
    {
        private static AlarmLogArchiveRow.RowFields fld
        {
            get
            {
                return AlarmLogArchiveRow.Fields;
            }
        }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<AlarmLogArchiveRow> request)
        {
            return new AlarmLogArchiveRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<AlarmLogArchiveRow> request)
        {
            return new AlarmLogArchiveRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new AlarmLogArchiveRepository.MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<AlarmLogArchiveRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new AlarmLogArchiveRepository.MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<AlarmLogArchiveRow> List(IDbConnection connection, ListRequest request)
        {
            var response = new AlarmLogArchiveRepository.MyListHandler().Process(connection, request);

            return response;
        }

        private class MySaveHandler : SaveRequestHandler<AlarmLogArchiveRow>
        {
        }

        private class MyDeleteHandler : DeleteRequestHandler<AlarmLogArchiveRow>
        {
        }

        private class MyRetrieveHandler : RetrieveRequestHandler<AlarmLogArchiveRow>
        {
        }

        private class MyListHandler : ListRequestHandler<AlarmLogArchiveRow>
        {
        }
    }
}

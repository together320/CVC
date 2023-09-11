// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Repositories.LabelRollRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using CVC.Modules.Common.Dashboard;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web;

namespace CVC.Batch.Repositories
{
    public class LabelRollRepository
    {
        private static LabelRollRow.RowFields fld
        {
            get
            {
                return LabelRollRow.Fields;
            }
        }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<LabelRollRow> request)
        {
            string moduleId = null;
            int? machineId = 0;
            if (HttpContext.Current.Session["ModuleId"] != null)
            {
                moduleId = HttpContext.Current.Session["ModuleId"].ToString();
                machineId = new DashboardCommon().GetMachineId(moduleId);
                request.Entity.MachineId = machineId.Value;

            }
            var batchId = new DashboardCommon().GetBatchForLebelRoll();
            if (batchId != null)
                request.Entity.BatchId = batchId.Value;
            request.Entity.LabelRemaining = request.Entity.NumberOfLabels;
            return new LabelRollRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<LabelRollRow> request)
        {
            return new LabelRollRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new LabelRollRepository.MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<LabelRollRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new LabelRollRepository.MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<LabelRollRow> List(IDbConnection connection, ListRequest request)
        {
            return new LabelRollRepository.MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<LabelRollRow>
        {
        }

        private class MyDeleteHandler : DeleteRequestHandler<LabelRollRow>
        {
        }

        private class MyRetrieveHandler : RetrieveRequestHandler<LabelRollRow>
        {
        }

        private class MyListHandler : ListRequestHandler<LabelRollRow>
        {

            protected override void ApplyFilters(SqlQuery query)
            {
                base.ApplyFilters(query);
                var batchId = new DashboardCommon().GetBatchForLebelRoll();
                if (batchId == null)
                    batchId = -1;
                query.Where(fld.BatchId == batchId.Value);
            }
        }
    }
}

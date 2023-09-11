// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Repositories.BatchRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using CVC.BusinessServices.Common;
using CVC.Data.EDMX;
using CVC.Modules.Common.Dashboard;
using CVC.Modules.Common.MachineDashboard;
using CVC.OpcUaClient;
using CVC.ViewModels;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using static CVC.BusinessServices.Common.ClsConstants;
using modules=CVC.Modules.Common.CommonServices;

namespace CVC.Batch.Repositories
{
    public class BatchRepository
    {
        private static BatchRow1.RowFields fld
        {
            get
            {
                return BatchRow1.Fields;
            }
        }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<BatchRow1> request)
        {
            var isReloadBatch = false;
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var requestEntity = request.Entity;
                  if (request.Entity.BatchVersion == "New Batch")
                {
                    var batch = cvcEntities.Batches.FirstOrDefault(b => b.BatchName == requestEntity.BatchName && b.BatchVersion == "v0");
                    if (batch != null)
                        throw new Serenity.Services.ValidationError("Alert", "Batch Name already exist.");

                     request.Entity.BatchVersion = "v0";
                     request.Entity.RepackStatus = "Not Repacked";
                     request.Entity.BatchLatestVersion= "v0";
                }

                #region  Sr.No:168 Reload Batch
                else if (request.Entity.BatchVersion == "Reload Batch")
                {
                    isReloadBatch = true;
                    checkBatchNameExist(requestEntity.BatchName);
                    var batchVersion = cvcEntities.Batches.Where(b => b.BatchName == requestEntity.BatchName).OrderByDescending(b => b.BatchId).FirstOrDefault()?.BatchVersion;

                    string[] numbers = Regex.Split(batchVersion, @"\D+");
                    int versionNumber = Convert.ToInt32(numbers[1]) + 1;
                     request.Entity.BatchVersion = "v" + versionNumber;

                }
                #endregion


                //var packName = request.Entity.BatchStatus;

                //#region Check Pack Code exist
                //var packId = cvcEntities.Packs.FirstOrDefault(p => p.PackName == packName)?.PackId;
                //if (packId == null)
                //{
                //    throw new Serenity.Services.ValidationError("Alert", "Pack Code does not exist.");
                //}
                //#endregion

                var packId = checkPackCodeExist(request.Entity.BatchStatus);

                request.Entity.PackId = packId;
                request.Entity.BatchStatus = "Batch Created";
                // request.Entity.BatchVersion
                var MachineId = 0;
                if (HttpContext.Current.Session["ModuleId"] != null)
                {
                    var ModuleId = HttpContext.Current.Session["ModuleId"].ToString();
                    MachineId = (int)new DashboardCommon().GetMachineId(ModuleId);
                }
                // var protocolType = System.Web.HttpContext.Current.Cache["ProtocolType"];

                modules.CommonServices commonServices = new modules.CommonServices();
                commonServices.WriteValuesToAllMachinesAsync("IsWriteToPLC", "1");
                commonServices.WriteValuesToAllMachinesAsync("IsBatchSize", request.Entity.BatchSize.ToString());
                commonServices.WriteValuesToAllMachinesAsync("IsCounterReset","1");


                HttpContext.Current.Cache["LabelRollNumber"] = "";

                #region  Sr.No:168 Reload Batch
                if (isReloadBatch)
                {
                     var parentBatch = cvcEntities.Batches.FirstOrDefault(b => b.BatchName == requestEntity.BatchName && b.BatchVersion == "v0");
                     request.Entity.ParentId = parentBatch.BatchId;
                     parentBatch.BatchLatestVersion = request.Entity.BatchVersion;
                     parentBatch.RepackStatus = "Repack Started";

                    cvcEntities.SaveChanges();
                }
                #endregion
                //var GetMachineParameterIdForLabelRollIPC = cvcEntities.IPCParameters?.FirstOrDefault(i => i.MachineId == MachineId && i.IsLabelRollIPC == true)?.MachineParameterId??null;
                //if (GetMachineParameterIdForLabelRollIPC != null)
                //{
                //  new ConnectMachine().Write((int)GetMachineParameterIdForLabelRollIPC, "");

                //}

            }
            return new BatchRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<BatchRow1> request)
        {
            #region  Sr.No.:170 Update Batch
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var packId = checkPackCodeExist(request.Entity.BatchStatus);

                request.Entity.PackId = packId;
                request.Entity.BatchStatus = "Batch Edited";

                var batchDetails = cvcEntities.Batches.FirstOrDefault(b => b.BatchId == request.Entity.BatchId);
                request.Entity.BatchStartDateTime = batchDetails.BatchStartDateTime;
                request.Entity.BatchEndDateTime = batchDetails.BatchEndDateTime;
                request.Entity.MachineLineId = batchDetails.MachineLineId;
                request.Entity.NumberOfBottles = batchDetails.NumberOfBottles;
                request.Entity.TotalGoodBottles = batchDetails.TotalGoodBottles;
                request.Entity.TotalRejectedBottles = batchDetails.TotalRejectedBottles;
                request.Entity.ProductionSpeed = batchDetails.ProductionSpeed;
                request.Entity.StatusId = batchDetails.StatusId;
                request.Entity.CreatedBy = batchDetails.CreatedBy;
                request.Entity.CreatedDate = batchDetails.CreatedDate;
                request.Entity.BatchLatestVersion = batchDetails.BatchLatestVersion;
                request.Entity.ParentId = batchDetails.ParentId;
                request.Entity.Comments = batchDetails.Comments;
                request.Entity.RepackStatus = batchDetails.RepackStatus;
                request.Entity.BatchVersion = batchDetails.BatchVersion;

                var MachineId = 0;
                if (HttpContext.Current.Session["ModuleId"] != null)
                {
                    var ModuleId = HttpContext.Current.Session["ModuleId"].ToString();
                    MachineId = (int)new DashboardCommon().GetMachineId(ModuleId);
                }

                // var MachineParameterId = cvcEntities.IPCParameters?.FirstOrDefault(i => i.MachineId == MachineId && i.IsBatchSize == true)?.MachineParameterId ?? null;

                modules.CommonServices commonServices = new modules.CommonServices();
                commonServices.WriteValuesToAllMachinesAsync("IsWriteToPLC", "1");
                commonServices.WriteValuesToAllMachinesAsync("IsBatchSize", request.Entity.BatchSize.ToString());

            }
            return new BatchRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
            #endregion
            
        }

        private int? checkPackCodeExist(string packName)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                #region Check Pack Code exist
                var packId = cvcEntities.Packs.FirstOrDefault(p => p.PackName == packName)?.PackId;
                if (packId == null)
                {
                    throw new Serenity.Services.ValidationError("Alert", "Pack Code does not exist.");
                }
                return packId;
                #endregion
            }
        }

        private void checkBatchNameExist(string batchName)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                #region Check Batch Name exist
                var batch = cvcEntities.Batches.FirstOrDefault(p => p.BatchName == batchName);
                if (batch == null)
                {
                    throw new Serenity.Services.ValidationError("Alert", "Batch Name does not exist.");
                }
                #endregion
            }        
        }


        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new BatchRepository.MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<BatchRow1> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new BatchRepository.MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<BatchRow1> List(IDbConnection connection, ListRequest request)
        {
            return new BatchRepository.MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<BatchRow1>
        {
        }

        private class MyDeleteHandler : DeleteRequestHandler<BatchRow1>
        {
        }

        private class MyRetrieveHandler : RetrieveRequestHandler<BatchRow1>
        {
        }

        private class MyListHandler : ListRequestHandler<BatchRow1>
        {
        }
    }
}

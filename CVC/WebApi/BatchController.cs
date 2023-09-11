// Decompiled with JetBrains decompiler
// Type: CVC.WebApi.BatchController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Data;
using CVC.Data.DTO;
using CVC.Data.EDMX;
using CVC.Modules.Common.Dashboard;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace CVC.WebApi
{
   

    public class BatchController : ApiController
    {
        [HttpPost]
        [ActionName("ProductList")]
        public HttpResponseMessage GetProductList(Parameter parameter)
        {
            if (!this.ModelState.IsValid)
                return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
            IList<Product> productList = (IList<Product>)new List<Product>();
            return this.Request.CreateResponse<IList<Product>>(HttpStatusCode.OK, CVCDaoFactory.GetProductList());
        }

        [HttpPost]
        [ActionName("PackList")]
        public HttpResponseMessage GetPackList(Parameter parameter)
        {
            if (!this.ModelState.IsValid)
                return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
            IList<Pack> packList = (IList<Pack>)new List<Pack>();
            return this.Request.CreateResponse<IList<Pack>>(HttpStatusCode.OK, CVCDaoFactory.GetPackList());
        }

        [HttpPost]
        [ActionName("SaveBatch")]
        public HttpResponseMessage SaveBatchDetails(CVC.Data.EDMX.Batch aBatch)
        {
            if (!this.ModelState.IsValid)
                return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
            return this.Request.CreateResponse<string>(HttpStatusCode.OK, CVCDaoFactory.SaveBatchDetails(aBatch));
        }

        [HttpPost]
        [ActionName("BatchDetails")]
        public HttpResponseMessage GetBatchDetails(Parameter parameter)
        {
            if (!this.ModelState.IsValid)
                return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
            BatchDTO batchDto = new BatchDTO();
            return this.Request.CreateResponse<BatchDTO>(HttpStatusCode.OK, CVCDaoFactory.GetBatchDetails());
        }

        [HttpPost]
        [ActionName("GetBatchDetailsByBatchId")]
        public HttpResponseMessage GetBatchDetailsByBatchId(Parameter parameter)
        {
            if (!this.ModelState.IsValid)
                return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
            BatchDTO batchDto = new BatchDTO();
            DashboardCommon dashboardCommon = new DashboardCommon();
            return this.Request.CreateResponse<CVC.Modules.Batch.Batch.BatchReport>(HttpStatusCode.OK,dashboardCommon.GetBatchReport(parameter.BatchId));
        }

        [HttpPost]
        [ActionName("PackageLineDetails")]
        public HttpResponseMessage GetPackageLineDetails()
        {
            if (!this.ModelState.IsValid)
                return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
            MachineLine machineLine = new MachineLine();
            return this.Request.CreateResponse<MachineLine>(HttpStatusCode.OK, CVCDaoFactory.GetMachineLine());
        }

        [HttpPost]
        [ActionName("MachineDetails")]
        public HttpResponseMessage GetMachineDetails()
        {
            if (!this.ModelState.IsValid)
                return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
            CVC.Data.EDMX.Machine machine = new CVC.Data.EDMX.Machine();
            return this.Request.CreateResponse<CVC.Data.EDMX.Machine>(HttpStatusCode.OK, CVCDaoFactory.GetLabelingMachine());
        }

        [HttpPost]
        [ActionName("MachineRecipeParameter")]
        public HttpResponseMessage GetMachineRecipeParameterList(Parameter parameter)
        {
            if (!this.ModelState.IsValid)
                return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
            IList<MachineRecipeParameter> machineRecipeParameterList = (IList<MachineRecipeParameter>)new List<MachineRecipeParameter>();
            return this.Request.CreateResponse<IList<MachineRecipeParameter>>(HttpStatusCode.OK, CVCDaoFactory.GetMachineRecipeParameterList(parameter.MacineRecipeId));
        }

        [HttpPost]
        [ActionName("RecipeParameter")]
        public HttpResponseMessage GetRecipeParameterList(Parameter parameter)
        {
            if (!this.ModelState.IsValid)
                return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
            IList<RecipeSettingsParameter> settingsParameterList = (IList<RecipeSettingsParameter>)new List<RecipeSettingsParameter>();
            return this.Request.CreateResponse<IList<RecipeSettingsParameter>>(HttpStatusCode.OK, CVCDaoFactory.GetRecipeSettingsParameterList(parameter.MacineRecipeId));
        }

        [HttpPost]
        [ActionName("SaveMachineRecipeParameter")]
        public HttpResponseMessage SaveMachineRecipeParameter(IList<MachineRecipeParameter> parameter)
        {
            if (!this.ModelState.IsValid)
                return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
            return this.Request.CreateResponse<string>(HttpStatusCode.OK, CVCDaoFactory.SaveMachineRecipeParameter(parameter));
        }

        [HttpPost]
        [ActionName("StartStopBatch")]
        public HttpResponseMessage StartStopBatch(Parameter parameter)
        {
           
                if (!this.ModelState.IsValid)
                return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);          
            return this.Request.CreateResponse<string>(HttpStatusCode.OK, DashboardCommon.StartStopBatch(parameter.BatchId, parameter.StartStop, parameter.ModuleId)); ;
        }

        [HttpPost]
        [ActionName("EndBatch")]
        public HttpResponseMessage EndBatch(Parameter parameter)
        {
            if (!this.ModelState.IsValid)
                return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
            return this.Request.CreateResponse<string>(HttpStatusCode.OK, DashboardCommon.EndBatch(parameter.BatchId,parameter.Recipe, parameter.ModuleId));
        }

        [HttpPost]
        [ActionName("ApplyRemoveRoll")]
        public HttpResponseMessage ApplyRemoveRoll(Parameter parameter)
        {
            return this.Request.CreateResponse<bool>(HttpStatusCode.OK, new DashboardCommon().ApplyRemoveRoll(parameter.rollId, parameter.IsApplied,parameter.MachineId));           
        }



        [HttpPost]
        [ActionName("ApplyRecipe")]
        public HttpResponseMessage ApplyRecipe(Parameter parameter)
        {
            if(parameter.RecipeAction=="DefaultRecipe")
            {
                return this.Request.CreateResponse<bool>(HttpStatusCode.OK, new DashboardCommon().SetDefaultRecipe(parameter.MacineRecipeId));

            }
            return this.Request.CreateResponse<bool>(HttpStatusCode.OK, new DashboardCommon().ApplyRecipe(parameter.MacineRecipeId));
        }


        [HttpPost]
        [ActionName("GetReportDetails")]
        public HttpResponseMessage GetReportDetails()
        {
           
            BatchDTO batchDto = new BatchDTO();
            return this.Request.CreateResponse<ReportDetails>(HttpStatusCode.OK, DashboardCommon.GetReportDetails());
        }

        [HttpPost]
        [ActionName("BatchStatus")]
        public HttpResponseMessage BatchStatus(Parameter parameter)
        {
            #region Sr.No:84 Date:17/02/2020
            // if (!this.ModelState.IsValid)
            //    return this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
            return this.Request.CreateResponse<string>(HttpStatusCode.OK, DashboardCommon.GetBatchStatus(parameter.BatchId));
            #endregion
        }

        #region Sr.No.:169 Repack Batch
        [HttpPost]
        [ActionName("UpdateRepackStatus")]
        public HttpResponseMessage UpdateRepackStatus(Parameter parameter)
        {
           // var aa =HttpContent.Application["IsSendHeartHeat"];
            if (DashboardCommon.CheckValidUser(parameter.UserName, parameter.Password) == true)
            {
                using (CVCEntities cVCEntities = new CVCEntities())
                {
                    var repacksBatch = cVCEntities.Batches.FirstOrDefault(b => b.BatchId == parameter.BatchId);
                    repacksBatch.RepackStatus = parameter.RepackStatus;
                    // repacksBatch.Comments = parameter.Comments;
                    var latestBatch = cVCEntities.Batches.Where(b => b.BatchName == repacksBatch.BatchName).OrderByDescending(b => b.BatchId).FirstOrDefault();
                    latestBatch.Comments = parameter.Comments;
                    cVCEntities.SaveChanges();
                    var dashObj = new DashboardCommon();
                    bool tr = dashObj.AddAuditLogforBatch(repacksBatch.RepackStatus, "Batch", "Batch Report", "", "", "",(parameter.BatchId), null, null, null, "Batch");
                    return this.Request.CreateResponse<string>(HttpStatusCode.OK, "");

                }
            }
            else
            {
                return this.Request.CreateResponse<string>(HttpStatusCode.OK, "Invalid User");

            }
        }
        #endregion
    }
}   

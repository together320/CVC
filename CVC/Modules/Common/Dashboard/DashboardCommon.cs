using CVC.Data.DTO;
using CVC.Data.EDMX;
using CVC.Machine;
using CVC.MachineCustomization.Entities;
using CVC.MDB;
using CVC.Modules.Batch.Batch;
using CVC.Modules.Common.MachineDashboard;
using CVC.Modules.MachineCustomization.MachineRecipe;
using Serenity;
using Serenity.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using CVC.Modules.Common.CommonServices;
using CVC.Data;
using CVC.BusinessServices.Common;
using System.Web.UI;
using AdvancedHMIDrivers;
using CVC.ViewModels;
using System.Threading.Tasks;
using CVC.BusinessServices.DAL;
using static CVC.BusinessServices.Common.ClsConstants;
using CVC.OpcUaClient;
using modules = CVC.Modules.Common.CommonServices;
using bs = CVC.BusinessServices.Common;
using System.Text;
using CVC.SiemensS7Net;
using System.Runtime.Caching;

namespace CVC.Modules.Common.Dashboard
{

    public class ModuleData
    {
        public List<KeyValuePair<int, string>> Modules { get; set; }

        public int? MachineSettings { get; set; }

        public int? MachineSummary { get; set; }

        public int? labelRoll { get; set; }

        public int? CommandPanel { get; set; }

        public int CurrentModule { get; set; }

    }

    public class DashboardCommon
    {
        // static CVCEntities cvcEntities = new CVCEntities();

        //Stopwatch stopwatch = new Stopwatch();



        public ModuleData GetModule(string strModule = null)
        {

            int? moduleId = null;
            if (!string.IsNullOrEmpty(strModule))
                moduleId = int.Parse(strModule);
            // CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                ModuleData obj = new ModuleData();
                var GetUserId = Serenity.Authorization.UserId;
                int UserId = Convert.ToInt32(GetUserId);
                var RoleId = cvcEntities.Users.Where(u => u.UserId == UserId).FirstOrDefault().RoleId;
                /* changed on 4 march 2019 12.46 pm*/ //var module = cvcEntities.Modules.Where(a => a.StatusId == 1).OrderBy(a => a.Sequence).ToList();

                var module = new List<CVC.Data.EDMX.ModuleAccess>();

                #region Terminal-User-Machine Mapping
                TerminalMasterDAL terminalMasterDAL = new TerminalMasterDAL();
                MachineDAL machineDAL = new MachineDAL();

                var terminalId = Convert.ToInt32(HttpContext.Current.Session["TerminalId"]);
                MachineTerminalMapping machineTerminalMapping = new MachineTerminalMapping
                {
                    TerminalId = terminalId
                };
                var userId = Convert.ToInt32(HttpContext.Current.Session["CVCUserId"]);

                MachineUserMapping machineUserMapping = new MachineUserMapping
                {
                    UserId = UserId
                };
                var machineDataByTerminalId = terminalMasterDAL.GetMachinesByTerminalId(machineTerminalMapping);
                var machineArrayByTerminalId = machineDataByTerminalId.Select(m => m.ModuleId).ToArray();

                var machineDataByUserId = machineDAL.GetMachinesByUserId(machineUserMapping);
                var machineArrayByUserId = machineDataByUserId.Select(m => m.ModuleId).ToArray();

                int[] intersect = machineArrayByTerminalId.Intersect(machineArrayByUserId).ToArray();

                #endregion
                if (RoleId == 1)
                {

                    module = cvcEntities.ModuleAccesses.Where(a => a.RoleId == RoleId && a.StatusId == 1).OrderBy(a => a.Module.Sequence).ToList();

                }
                else
                {
                    module = cvcEntities.ModuleAccesses.Where(a => a.RoleId == RoleId && a.StatusId == 1).OrderBy(a => a.Module.Sequence).ToList();
                }

                module = module.Where(m => intersect.Contains((int)m.ModuleId)).ToList();
                /* changed on 4 march 2019 12.46 pm*/  //obj.Modules = module.Select(a => new KeyValuePair<int, string>(a.ModuleId, a.ModuleName)).ToList();
                obj.Modules = module.Select(a => new KeyValuePair<int, string>(a.Module.ModuleId, a.Module.ModuleName)).ToList();
                if (module.Any())
                {
                    var first = module.FirstOrDefault(a => a.ModuleId == moduleId || moduleId == null);
                    var MachineSettings = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == first.ModuleId && a.IsMachineSettings == true);
                    var MachineSummary = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == first.ModuleId && a.IsMachineSummary == true);
                    var labelRoll = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == first.ModuleId && a.IslabelRoll == true);
                    var CommandPanel = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == first.ModuleId && a.IsCommandPanel == true);
                    if (MachineSettings != null)
                        obj.MachineSettings = MachineSettings.ViewsId;
                    if (MachineSummary != null)
                        obj.MachineSummary = MachineSummary.ViewsId;
                    if (labelRoll != null)
                        obj.labelRoll = labelRoll.ViewsId;
                    if (CommandPanel != null)
                        obj.CommandPanel = CommandPanel.ViewsId;

                    /* //changed on 4 march 2019 12.46 pm*/ //obj.CurrentModule = first.ModuleId;
                    obj.CurrentModule = first.Module.ModuleId;
                }
                return obj;
            }
        }

        public static string GetCompanyLogo()
        {
            string logo = "~/Content/site/images/cvcTransLogoin_mini.png";
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var company = cvcEntities.Companies.FirstOrDefault();
                if (company != null)
                {
                    if (!string.IsNullOrEmpty(company.CompanyLogo))
                        logo = "/upload/" + company.CompanyLogo;
                }
                return logo;
            }


        }


        public void CheckBackup()
        {
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var EnvironmentVaiable = cvcEntities.EnvironmentVariables.FirstOrDefault();
                    if (EnvironmentVaiable != null)
                    {
                        DateTime LastBackupDate = EnvironmentVaiable.LastBackupDate != null ? new DateTime(EnvironmentVaiable.LastBackupDate.Value.Year, EnvironmentVaiable.LastBackupDate.Value.Month, EnvironmentVaiable.LastBackupDate.Value.Day) : DateTime.Now.AddDays(-1);
                        DateTime CurrentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

                        if (LastBackupDate != CurrentDate)
                        {
                            if (!Directory.Exists(EnvironmentVaiable.BackupFolder))
                            {
                                Directory.CreateDirectory(EnvironmentVaiable.BackupFolder);
                            }

                            if ((bool)EnvironmentVaiable.IsOverWriteBackup)
                            {
                                //string[] filePaths = Directory.GetFiles(@"D:\CVCPublish\");
                                string[] FilePaths = Directory.GetFiles(EnvironmentVaiable.BackupFolder);
                                foreach (string file in FilePaths)
                                {
                                    System.IO.File.Delete(file);
                                }
                            }
                            // cvcEntities.BackupData();
                            cvcEntities.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, "EXEC BackupData");
                            //  CommonServices.CommonServices.AddAuditLog("DataBase Backup Successfull", "", "", "", "", "", null, null, null);
                        }


                    }

                }
            }
            catch (System.Exception ex)
            {
                CommonServices.CommonServices.AddAuditLog("DataBase Backup Failed", "", "", "", "", "", null, null, null);
            }
        }

        //public void AlarmSet(AlarmRow row)
        //{
        //    CVCEntities cvcEntities = new CVCEntities();
        //    // In Case Of MDB Call MDB                      
        //    if (cvcEntities.MachineCommunications.Any(a => a.ProtocolTypeId == 4 && a.StatusId == 1 && a.MachineId == row.MachineId))
        //    {
        //        var ipcPara = cvcEntities.IPCParameters.FirstOrDefault(a => a.IPCParameterId == row.MachineParameterId);
        //        if (ipcPara != null)
        //        {
        //            if (ipcPara.MachineParameterId != null)
        //            {
        //                Operations mdb = new Operations();
        //                mdb.Write(ipcPara.MachineParameterId.Value, row.IsMachineRequiredToStop == true ? "1" : "0");
        //            }
        //        }
        //    }
        //}

        #region Apply Recipe 
        public bool ApplyRecipe(int MacineRecipeId)
        {
            try
            {
                //CVCEntities cvcEntities = new CVCEntities();
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var getMachineId = cvcEntities.MachineRecipeParameters.Where(a => a.MachineRecipeId == MacineRecipeId)?.FirstOrDefault()?.MachineRecipe?.MachineId ?? null;
                    //string MachineType = CommonServices.CommonServices.GetMachineType(GetMachineId);
                    var protocolType = System.Web.HttpContext.Current.Cache["ProtocolType"];
                    List<OPCUaClientWriteValues> lstOPCUaClientWriteValues = new List<OPCUaClientWriteValues>();

                    var isFirstValue = true;
                    var isWriteToPLCData = new List<IPCParameter>();
                    foreach (var item in cvcEntities.MachineRecipeParameters.Where(a => a.MachineRecipeId == MacineRecipeId))
                    {
                        if (isFirstValue)
                        {
                            isFirstValue = false;
                            isWriteToPLCData = cvcEntities.IPCParameters.Where(i => i.MachineId == getMachineId && i.IsWriteToPLC == true)?.ToList();

                        }

                        // var aa=item.MachineParameter.IPCParameters.fi
                        if (item.MachineParameterId == null)
                            continue;
                        if (string.IsNullOrEmpty(item.MachineParameterValue))
                            continue;
                        if (protocolType.ToString() == ProtocolType.MDB.ToUpper())
                        {
                            new Operations().Write(item.MachineParameterId.Value, item.MachineParameterValue);

                        }
                        else if (protocolType.ToString().Contains(ProtocolType.Modbus.ToUpper()))
                        {
                            if (isWriteToPLCData != null)
                            {
                                foreach (var items in isWriteToPLCData)
                                {
                                    new CVC.PLC.Operations().Write(items.MachineParameterId.Value, "1");
                                }
                            }

                            new CVC.PLC.Operations().Write(item.MachineParameterId.Value, item.MachineParameterValue);

                        }
                        else if (protocolType.ToString() == ProtocolType.OPCUaClient.ToUpper())
                        {
                            //var isWriteToPLC = item?.MachineParameter?.IPCParameters?.FirstOrDefault(i => i.IsWriteToPLC == true);
                            //if (isWriteToPLC != null)
                            //{
                            //   new ClsOpcUaClient.Write(item.MachineParameterId.Value, 1);
                            //}


                            var ipcParameter = item.MachineParameter.IPCParameters.FirstOrDefault();
                            if (ipcParameter != null)
                            {
                                OPCUaClientWriteValues machineRecipeWriteValues = new OPCUaClientWriteValues
                                {
                                    NodeId = ipcParameter.NodeId,
                                    AttributeId = Convert.ToUInt32(ipcParameter.AttributeId),
                                    Value = item.MachineParameterValue
                                };
                                lstOPCUaClientWriteValues.Add(machineRecipeWriteValues);
                            }

                        }

                        else if (protocolType.ToString().Contains(ProtocolType.SiemensS7Net.ToUpper()))
                        {
                            ClsSiemensS7Net clsSiemensS7Net = new ClsSiemensS7Net();
                            DashBoardField dashBoardField = new DashBoardField();
                            List<DashBoardField> lstDashBoardFields = new List<DashBoardField>();
                            DashBoardViewModel objDashBoardViewModel;
                            if (isWriteToPLCData != null)
                            {
                                foreach (var items in isWriteToPLCData)
                                {

                                    dashBoardField = new DashBoardField
                                    {
                                        IPCAddress = items.IPCAddress,
                                        Value = "1",
                                        DataTypeName = item?.MachineParameter?.DataType?.DataTypeName

                                    };

                                    lstDashBoardFields.Add(dashBoardField);
                                    objDashBoardViewModel = new bs.CommonServices().GetDashBoardViewModel(items?.Machine.MachineCommunications.FirstOrDefault());
                                    objDashBoardViewModel.ViewFieldList = lstDashBoardFields;
                                    clsSiemensS7Net.Write(objDashBoardViewModel);
                                }
                            }

                            dashBoardField = new DashBoardField
                            {
                                IPCAddress = item.MachineParameter?.Machine?.IPCParameters?.FirstOrDefault().IPCAddress,
                                Value = item.MachineParameterValue,
                                DataTypeName = item?.MachineParameter?.DataType?.DataTypeName
                            };

                            lstDashBoardFields.Add(dashBoardField);
                            var machineCommunication = item.MachineParameter?.Machine?.MachineCommunications?.FirstOrDefault();
                            objDashBoardViewModel = new bs.CommonServices().GetDashBoardViewModel(machineCommunication);
                            objDashBoardViewModel.ViewFieldList = lstDashBoardFields;
                            clsSiemensS7Net.Write(objDashBoardViewModel);

                        }



                        // System.Threading.Thread.Sleep(500);
                    }

                    if (lstOPCUaClientWriteValues.Count() > 0)
                    {
                        ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
                        var opcUaClientViewModel = new OPCUaClientViewModel();
                        opcUaClientViewModel.lstWriteValues = lstOPCUaClientWriteValues;

                        clsOpcUaClient.WriteValueCollection(opcUaClientViewModel);
                        //bs.CommonServices commonServices = new bs.CommonServices();
                        //commonServices.WriteValueCollectionForOPCUaClient(lstOPCUaClientWriteValues);
                    }

                    var recepe = cvcEntities.MachineRecipes.FirstOrDefault(a => a.MachineRecipeId == MacineRecipeId);
                    recepe.IsApply = true;
                    cvcEntities.Entry<MachineRecipe>(recepe).State = System.Data.Entity.EntityState.Modified;
                    var list = cvcEntities.MachineRecipes.Where(a => a.MachineId == recepe.MachineId && a.MachineRecipeId != MacineRecipeId).ToList();
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i].IsApply = false;
                        cvcEntities.Entry<MachineRecipe>(list[i]).State = System.Data.Entity.EntityState.Modified;
                    }
                    cvcEntities.SaveChanges();
                }
                return true;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region Set Default Recipe 
        public bool SetDefaultRecipe(int MacineRecipeId)
        {
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var MachineId = cvcEntities.MachineRecipes.FirstOrDefault(a => a.MachineRecipeId == MacineRecipeId)?.MachineId ?? null;
                    var PackId = Convert.ToInt32(HttpContext.Current.Cache["PackId"]);

                    foreach (var item in cvcEntities.MachineRecipes.Where(a => a.PackId == PackId && a.MachineId == MachineId && a.IsDefaultRecipe == true))
                    {
                        item.IsDefaultRecipe = false;
                        cvcEntities.Entry<MachineRecipe>(item).State = System.Data.Entity.EntityState.Modified;
                        cvcEntities.SaveChanges();
                    }

                    var DefaultRecipe = cvcEntities.MachineRecipes.FirstOrDefault(mr => mr.MachineRecipeId == MacineRecipeId);
                    DefaultRecipe.IsDefaultRecipe = true;
                    cvcEntities.SaveChanges();

                }



                return true;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        #endregion

        public bool ApplyRemoveRoll(int rollId, bool IsApplied, int MachineId)
        {
            // CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var MaChineSummary = new MachineSummaryPageModel();
                MaChineSummary = (MachineSummaryPageModel)HttpContext.Current.Cache["MachineSummary"];
                var GetLabelRemaining = MaChineSummary.ViewFieldList.Where(v => v.IsLabelRollIPC == true)?.FirstOrDefault()?.Value ?? "";
                long LabelRemaining = 0;
                if (!string.IsNullOrEmpty(GetLabelRemaining))
                    LabelRemaining = Convert.ToInt32(GetLabelRemaining);

                if (IsApplied == true && HttpContext.Current.Cache["LabelRollId"] != null && HttpContext.Current.Cache["LabelRollId"].ToString() != "")
                {
                    var LabelRollId = Convert.ToInt32(HttpContext.Current.Cache["LabelRollId"]);
                    var NumberOfLabels = Convert.ToInt32(HttpContext.Current.Cache["NumberOfLabels"]);

                    var UpdateLabelRollForApplied = cvcEntities.LabelRolls.FirstOrDefault(a => a.LabelRollId == LabelRollId);
                    UpdateLabelRollForApplied.NumberOfLabelsUsed = NumberOfLabels - LabelRemaining;
                    UpdateLabelRollForApplied.LabelRemaining = LabelRemaining;
                    cvcEntities.Entry<LabelRoll>(UpdateLabelRollForApplied).State = System.Data.Entity.EntityState.Modified;
                    cvcEntities.SaveChanges();
                }
                else if (IsApplied == false)
                {
                    var UpdateLabelRollForRemoved = cvcEntities.LabelRolls.FirstOrDefault(a => a.LabelRollId == rollId);
                    UpdateLabelRollForRemoved.NumberOfLabelsUsed = UpdateLabelRollForRemoved.NumberOfLabels - LabelRemaining;
                    UpdateLabelRollForRemoved.LabelRemaining = LabelRemaining;
                    cvcEntities.Entry<LabelRoll>(UpdateLabelRollForRemoved).State = System.Data.Entity.EntityState.Modified;
                    cvcEntities.SaveChanges();
                }

                var roll = cvcEntities.LabelRolls.FirstOrDefault(a => a.LabelRollId == rollId);

                // Update LabelRemaining
                //if(MachineId == 1)
                //{
                //    if (IsApplied)
                //    {
                //        var para = cvcEntities.MachineParameters.FirstOrDefault(a => a.IsLabelRoll == true && a.StatusId == 1);
                //        if (para != null)
                //            new Operations().Write(para.MachineParameterId, roll.NumberOfLabels.ToString());
                //    }
                //}
                //else
                //{
                //    if (IsApplied)
                //    {
                //        var para = cvcEntities.IPCParameters.FirstOrDefault(a => a.IsLabelRollIPC == true && a.StatusId == 1);
                //        if (para != null)
                //             new CVC.PLC.Operations().Write(Convert.ToInt32(para.MachineParameterId), roll.NumberOfLabels.ToString());
                //    }
                //}

                if (IsApplied)
                {
                    HttpContext.Current.Cache["LabelRollNumber"] = roll.LabelRollNumber;
                    HttpContext.Current.Cache["NumberOfLabels"] = roll.NumberOfLabels;
                    HttpContext.Current.Cache["LabelRollId"] = roll.LabelRollId;

                    modules.CommonServices commonServices = new modules.CommonServices();
                    commonServices.WriteValuesToAllMachinesAsync("IsWriteToPLC", "1");
                    commonServices.WriteValuesToAllMachinesAsync("IsLabelRollIPC", roll.LabelRemaining.ToString());


                    //var para = cvcEntities.MachineParameters.FirstOrDefault(a => a.IsLabelRoll == true && a.StatusId == 1);
                    //if (para != null)
                    //    new CVC.PLC.Operations().Write(para.MachineParameterId, roll.LabelRemaining.ToString());

                }
                else
                {
                    HttpContext.Current.Cache["LabelRollNumber"] = "";
                    HttpContext.Current.Cache["NumberOfLabels"] = "";
                    HttpContext.Current.Cache["LabelRollId"] = "";
                }




                //if (IsApplied)
                //{
                //    var para = cvcEntities.MachineParameters.FirstOrDefault(a => a.IsLabelRoll == true && a.StatusId == 1);
                //    if (para != null)
                //        return new CVC.PLC.Operations().Write(para.MachineParameterId, roll.NumberOfLabels.ToString());
                //}

                roll.IsApplied = IsApplied;
                // roll.MachineId = MachineId;
                cvcEntities.Entry<LabelRoll>(roll).State = System.Data.Entity.EntityState.Modified;
                if (IsApplied) // Remove other Is Applieds
                {
                    var list = cvcEntities.LabelRolls.Where(a => a.BatchId == roll.BatchId && a.LabelRollId != roll.LabelRollId).ToList();
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i].IsApplied = false;
                        cvcEntities.Entry<LabelRoll>(list[i]).State = System.Data.Entity.EntityState.Modified;
                    }
                }
                cvcEntities.SaveChanges();
            }
            return true;
        }

        public bool CheckViewPermission(int viewId)
        {
            if (Authorization.Username == "admin")
                return true;

            // CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                UserDefinition userDefinition = (UserDefinition)Authorization.UserDefinition;
                var userDetails = cvcEntities.Users.FirstOrDefault(a => a.UserId == userDefinition.UserId);
                if (cvcEntities.ViewsAccesses.Any(a => a.ViewsId == viewId && a.IsView == true && a.StatusId == 1 && a.RoleId == userDetails.RoleId))
                    return true;
            }

            return false;
        }

        public string GetViewName(int ViewId)
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var view = cvcEntities.Views.FirstOrDefault(a => a.ViewsId == ViewId && a.StatusId == 1);
                if (view != null)
                    return view.ViewName;
            }

            return "";
        }

        public List<RecipeReport> GetMachineRecipeReport(int id)
        {
            List<RecipeReport> obj = new List<RecipeReport>();
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var recipe = cvcEntities.MachineRecipes.FirstOrDefault(a => a.MachineRecipeId == id);
                foreach (var item in recipe.MachineRecipeParameters)
                {
                    if (item.MachineParameter != null)
                        obj.Add(new RecipeReport() { RecipeName = recipe.RecipeName, Paramter = item.MachineParameter.ParameterName, Value = item.MachineParameterValue });
                }
            }
            return obj;
        }

        public BatchReport GetBatchReport(int id)
        {
            BatchReport obj = new BatchReport();
            try
            {

                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var DateTimeFormat = ConfigurationManager.AppSettings["DateFormat"];
                    var batch = cvcEntities.Batches.FirstOrDefault(a => a.BatchId == id);
                    obj.PackName = batch.Pack.PackName;
                    obj.ProductName = batch.Pack.TabletDetail.TabletName;
                    if (batch.BatchStartDateTime != null)
                        obj.BatchStart = batch.BatchStartDateTime.Value.ToString(DateTimeFormat);
                    // obj.BatchStart = batch.BatchStartDateTime.Value.ToString("dd-MMM-yyyy hh:mm:ss tt");

                    if (batch.BatchEndDateTime != null)
                        obj.BatchEnd = batch.BatchEndDateTime.Value.ToString(DateTimeFormat);
                    obj.BatchName = batch.BatchName;
                    obj.CreateBy = batch.User.Username;
                    obj.RecipeName = batch.RecipeName;
                    obj.Size = Convert.ToString(batch.BatchSize);

                    var TotalGoodBottles = batch.TotalGoodBottles ?? 0;
                    var TotalBottles = TotalGoodBottles + (batch.TotalRejectedBottles ?? 0);

                    obj.Total = Convert.ToString(TotalBottles);
                    obj.Reject = Convert.ToString(batch.TotalRejectedBottles ?? 0);
                    obj.Good = Convert.ToString(batch.TotalGoodBottles ?? 0);

                    var GoodPercentage = Math.Round(((TotalGoodBottles / (TotalBottles + 0.00)) * 100.00), 2);
                    obj.GoodPercentage = double.IsNaN(GoodPercentage) ? "0" : GoodPercentage.ToString();


                    obj.RejectionPer = (100 - decimal.Parse(obj.GoodPercentage)).ToString();

                    if (batch.RunTime != null)
                    {
                        if (batch.RunTime != 0)
                        {
                            var RunTime = batch?.RunTime ?? 0;
                            obj.AverageSpeed = Math.Round(TotalBottles / (RunTime + 0.0), 2).ToString();
                        }

                    }

                    obj.RunTime = Convert.ToString(batch?.RunTime ?? 0);
                    obj.Rejcam1 = batch.RejectedByCam1;
                    obj.Rejcam2 = batch.RejectedByCam2;
                    obj.Rejmissi = batch.RejByMissingLabelSensor;
                    var PickListId = cvcEntities.PickLists?.FirstOrDefault(pl => pl.PickListName.ToUpper() == "BOTTLE")?.PickListId ?? null;
                    if (PickListId != null)
                    {
                        obj.BottleName = cvcEntities.PickListValues?.FirstOrDefault(pl => pl.PickListId == PickListId)?.PickListValueName ?? "Bottles";
                    }

                    PickListId = cvcEntities.PickLists?.FirstOrDefault(pl => pl.PickListName.ToUpper() == "PACK")?.PickListId ?? null;
                    if (PickListId != null)
                    {
                        obj.Pack = cvcEntities.PickListValues?.FirstOrDefault(pl => pl.PickListId == PickListId)?.PickListValueName ?? "Pack ID";
                    }
                    var batchLatestVersion = cvcEntities.Batches.Where(b => b.BatchName == batch.BatchName).OrderByDescending(b => b.BatchId).FirstOrDefault()?.BatchVersion;

                    obj.BatchVersion = batch.BatchVersion;
                    obj.BatchLatestVersion = batchLatestVersion;
                    obj.Comments = batch.Comments;
                }
            }
            catch (System.Exception ex)
            {
                string exce = ex.Message;
                string bb = exce;
            }
            return obj;
        }

        public static ReportDetails GetReportDetails()
        {
            ReportDetails obj = new ReportDetails();
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var machine = cvcEntities.Modules.FirstOrDefault().Machine;
                var company = cvcEntities.Companies.FirstOrDefault();

                var equipmentDetails = cvcEntities.PickLists?.Where(pl => pl.PickListName.ToLower() == "equipment name" || pl.PickListName == "equipment id").ToList().OrderByDescending(pl => pl.PickListName == "Equipment Name");

                if (equipmentDetails != null)
                {
                    var isFirst = true;
                    foreach (var item in equipmentDetails)
                    {
                        if (isFirst)
                        {
                            obj.MachineName = item.PickListValues.FirstOrDefault().PickListValueName;
                            isFirst = false;
                        }
                        else
                        {
                            obj.Serial = item.PickListValues.FirstOrDefault().PickListValueName;
                        }
                    }
                }


                // obj.MachineName = machine.MachineName;
                //obj.Serial = machine.SerialNumber;
                obj.Model = machine.ModelNumber;
                obj.comname = company.CompanyName;
                // obj.EquipmentId = machine.EquipmentID == null ? "" : machine.EquipmentID;
                obj.EquipmentId = machine.EquipmentID ?? "";

                obj.address = company.Address;
                obj.generatedby = ((UserDefinition)Authorization.UserDefinition).Username;

                if (!string.IsNullOrEmpty(company.CompanyLogo))
                {
                    string path = HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data/upload/" + company.CompanyLogo);
                    byte[] imageArray = System.IO.File.ReadAllBytes(path);
                    obj.logo = Convert.ToBase64String(imageArray);
                    obj.logotype = company.CompanyLogo.Split('.')[1];
                }
                var folderName = BusinessServices.Common.ClsConstants.GraphFolderPath.GraphPath;

                string[] FilePaths = Directory.GetFiles(HttpContext.Current.ApplicationInstance.Server.MapPath(folderName));
                foreach (string file in FilePaths)
                {
                    byte[] imageArray = System.IO.File.ReadAllBytes(file);
                    obj.BatchGraph = Convert.ToBase64String(imageArray);
                }
            }
            return obj;
        }

        public Tuple<string, string> GetRecepe(int moduleId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var machine = cvcEntities.Modules.FirstOrDefault(a => a.ModuleId == moduleId).MachineId.Value;
                var recepe = cvcEntities.MachineRecipes.FirstOrDefault(a => a.MachineId == machine && a.IsApply == true);
                if (recepe != null)
                    return new Tuple<string, string>(recepe.MachineRecipeId.ToString(), recepe.RecipeName);
                return new Tuple<string, string>("", "");
            }
        }

        public string GetPackNameByPackId(int RecipeId)
        {
            using (CVCEntities cVCEntities = new CVCEntities())
            {
                var PackId = cVCEntities?.MachineRecipes?.FirstOrDefault(r => r.MachineRecipeId == RecipeId)?.PackId ?? 0;
                return cVCEntities?.Packs?.FirstOrDefault(p => p.PackId == PackId)?.
                    PackName ?? "NA";
            }
        }

        public List<KeyValuePair<int, string>> GetViewsByModule(int ModuleId)
        {
            //CVCEntities cvcEntities = new CVCEntities();
            List<KeyValuePair<int, string>> ret = new List<KeyValuePair<int, string>>();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                UserDefinition userDefinition = (UserDefinition)Authorization.UserDefinition;
                var userDetails = cvcEntities.Users.FirstOrDefault(a => a.UserId == userDefinition.UserId);

                //changed on 16 apr 2019 3.29 pm foreach (var item in cvcEntities.Views.Where(a => a.ModuleId == ModuleId && a.StatusId == 1 && a.ViewsId != 6 && a.ViewsId != 7 && a.ViewsId!=22 && a.IsCommandPanel != true))
                foreach (var item in cvcEntities.Views.Where(a => a.ModuleId == ModuleId && a.StatusId == 1 && a.IsMachineSummary != true && a.IsCommandPanel != true))
                {
                    // /* changed on 4 march 2019 12.46 pm*/ if (Authorization.Username == "admin" || item.ViewsAccesses.Any(a => a.StatusId == 1 && a.IsView == true && a.RoleId == userDetails.RoleId))


                    if (userDetails.RoleId == 1)
                    {
                        //if (item.ViewsAccesses.Any(a => a.StatusId == 1 && a.IsView == true && a.ModuleId == ModuleId))
                        {
                            ret.Add(new KeyValuePair<int, string>(item.ViewsId, item.ViewName));
                        }
                    }
                    else
                    {
                        if (item.ViewsAccesses.Any(a => a.StatusId == 1 && a.IsView == true && a.RoleId == userDetails.RoleId && a.ModuleId == ModuleId))
                        {
                            ret.Add(new KeyValuePair<int, string>(item.ViewsId, item.ViewName));
                        }

                    }


                }
            }
            return ret;

        }

        public string ReverseString(string val)
        {
            return new string(val.ToCharArray().Reverse().ToArray());
        }

        public void WriteToFile(string Section = "", string Message = "", string Value = "")
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
            if (!File.Exists(filepath))
            {
                // Create a file to write to.   
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(" At " + DateTime.Now.ToString() + " Section: " + Section + " Error: " + Message + " Value: " + Value);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(" At " + DateTime.Now.ToString() + " Section: " + Section + " Error: " + Message + " Value: " + Value);

                }
            }
        }

        public void CheckAlarmNew()
        {
            WriteToFile("CheckAlarmNew started at " + DateTime.Now);
            try
            {
                //CVCEntities cvcEntities = new CVCEntities();
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    //   WriteToFile("cvcEntities started at " + DateTime.Now);
                    var data = (from i in cvcEntities.IPCParameters
                                join a in cvcEntities.Alarms on i.MachineParameterId equals a.MachineParameterId
                                where i.IsBitWise == true && i.IsAlarm == true

                                select new { IPCAddress = i.IPCAddress }).ToList();
                    IEnumerable<string> IPCAddressList = data.Select(x => x.IPCAddress).Distinct().ToList();
                    //  WriteToFile("data count " + data.Count());
                    foreach (var IPCAddress in IPCAddressList)
                    {

                        WriteToFile("ipc address " + IPCAddress);

                        var MachineParameterId = cvcEntities.IPCParameters.Where(i => i.IPCAddress == IPCAddress).FirstOrDefault()?.MachineParameterId ?? 0;
                        // stopwatch.Start();
                        // WriteToFile("plc read start " + stopwatch.Elapsed);

                        string GetAlarmBits = new CVC.PLC.Operations().ReadAlarm(IPCAddress, MachineParameterId);
                        GetAlarmBits = ReverseString(GetAlarmBits);
                        // stopwatch.Stop();
                        // WriteToFile("plc read stop " + stopwatch.Elapsed);

                        if (GetAlarmBits.Contains("1"))
                        {
                            for (int i = 0; i < GetAlarmBits.Length - 1; i++)
                            {
                                if (GetAlarmBits[i].ToString() == "1")
                                {
                                    //  stopwatch.Start();

                                    //  WriteToFile("db update1 start " + stopwatch.Elapsed);

                                    var GetMachineParameterId = cvcEntities.IPCParameters.Where(x => x.IPCAddress == IPCAddress && x.BitWiseIndex == i).FirstOrDefault()?.MachineParameterId ?? 0;
                                    var updateAlarm = cvcEntities.Alarms.FirstOrDefault(a => a.MachineParameterId == GetMachineParameterId);
                                    if (updateAlarm != null)
                                    {
                                        updateAlarm.lastvalue = true;
                                        cvcEntities.Entry<Alarm>(updateAlarm).State = System.Data.Entity.EntityState.Modified;
                                        cvcEntities.SaveChanges();
                                    }
                                    // WriteToFile("db update1 end " + stopwatch.Elapsed);
                                    // stopwatch.Stop();

                                }
                                else
                                {
                                    //  stopwatch.Start();

                                    //  WriteToFile("db update2 start " + stopwatch.Elapsed);
                                    var GetMachineParameterId = cvcEntities.IPCParameters.Where(x => x.IPCAddress == IPCAddress && x.BitWiseIndex == i).FirstOrDefault()?.MachineParameterId ?? 0;
                                    var updateAlarm = cvcEntities.Alarms.FirstOrDefault(a => a.MachineParameterId == GetMachineParameterId);
                                    if (updateAlarm != null)
                                    {
                                        updateAlarm.lastvalue = false;
                                        cvcEntities.Entry<Alarm>(updateAlarm).State = System.Data.Entity.EntityState.Modified;
                                        cvcEntities.SaveChanges();
                                    }
                                    // WriteToFile("db update2 end " + stopwatch.Elapsed);
                                    // stopwatch.Stop();
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < GetAlarmBits.Length - 1; i++)
                            {
                                // stopwatch.Start();

                                // WriteToFile("db update3 start " + stopwatch.Elapsed);

                                var GetMachineParameterId = cvcEntities.IPCParameters.Where(x => x.IPCAddress == IPCAddress && x.BitWiseIndex == i).FirstOrDefault()?.MachineParameterId ?? 0;
                                var updateAlarm = cvcEntities.Alarms.FirstOrDefault(a => a.MachineParameterId == GetMachineParameterId);
                                if (updateAlarm != null)
                                {
                                    updateAlarm.lastvalue = false;
                                    cvcEntities.Entry<Alarm>(updateAlarm).State = System.Data.Entity.EntityState.Modified;
                                    cvcEntities.SaveChanges();
                                }

                                // WriteToFile("db update3 end " + stopwatch.Elapsed);
                                //stopwatch.Stop();
                            }
                        }
                        WriteToFile("ipc address end" + IPCAddress);

                    }


                }

            }
            catch (System.Exception ex)
            {
                WriteToFile("exception" + ex.Message);
            }
        }

        public void CheckAlarm()
        {
            try
            {
                //CVCEntities cvcEntities = new CVCEntities();
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    // Check For MDB Only As of Now
                    foreach (var item in cvcEntities.Alarms.Where(a => a.Machine.MachineCommunications.Any(c => (c.ProtocolTypeId == 4 || c.ProtocolTypeId == 1) && c.StatusId == 1)).ToList())
                    {
                        if (item.MachineParameterId != null)
                        {
                            ConnectMachine mdb = new ConnectMachine();
                            string value = mdb.Read(item.MachineParameterId.Value);
                            bool mdbValue = false;
                            if (!string.IsNullOrEmpty(value))
                            {
                                if (value == "1")
                                    mdbValue = true;
                                // In Case Of Alarm Is Raised and Not Changed Since Last Time insert In Log
                                if (mdbValue && (item.lastvalue == null || (item.lastvalue != null && item.lastvalue != mdbValue)))
                                {
                                    AlarmLog log = new AlarmLog();
                                    log.MachineId = item.MachineId;
                                    log.AlarmId = item.AlarmId;
                                    log.LoggedUserId = null;
                                    log.AlarmDateTime = DateTime.Now;
                                    log.BatchId = GetCurrentRunningBatch();
                                    cvcEntities.AlarmLogs.Add(log);
                                    cvcEntities.SaveChanges();
                                }


                                // Update Alarm
                                if (item.lastvalue != mdbValue)
                                {
                                    var updateAlarm = cvcEntities.Alarms.FirstOrDefault(a => a.AlarmId == item.AlarmId);
                                    updateAlarm.lastvalue = mdbValue;
                                    cvcEntities.Entry<Alarm>(updateAlarm).State = System.Data.Entity.EntityState.Modified;
                                    cvcEntities.SaveChanges();
                                }
                            }

                        }
                    }
                }
                // Check For PLC Connection/ ModBus

            }
            catch (System.Exception ex)
            {

            }
        }

        public static string EndBatch(int BatchId, string RecipeName, int ModuleId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                string str;
                try
                {
                    #region Batch End Write To PLC
                    var MachineId = 0;

                    MachineId = (int)new DashboardCommon().GetMachineId(ModuleId.ToString());

                    modules.CommonServices commonServices = new modules.CommonServices();
                    commonServices.WriteValuesToAllMachinesAsync("IsWriteToPLC", "1");
                    commonServices.WriteValuesToAllMachinesAsync("IsBatchStartRequiredIPC", "0");

                    #endregion

                    str = "1";
                    var entity = cvcEntities.Batches.FirstOrDefault(b => b.BatchId == BatchId);
                    entity.BatchStatus = "Batch Ended";
                    entity.BatchEndDateTime = new DateTime?(DateTime.Now);

                    //if (entity.LastBatchStartDateTime != null)
                    //{
                    //    int runtime = (DateTime.Now - entity.LastBatchStartDateTime.Value).Minutes;
                    //    if (entity.RunTime != null)
                    //        runtime = runtime + entity.RunTime.Value;
                    //    entity.RunTime = runtime;
                    //}

                    if (entity.BatchStartDateTime.Value != null)
                    {
                        TimeSpan var = DateTime.Now - entity.BatchStartDateTime.Value;
                        int runtime = Convert.ToInt32(var.TotalMinutes);
                        entity.RunTime = runtime;
                    }


                    //var recipeName = cvcEntities.MachineRecipes.Where(a => a.IsApply == true).ToList();
                    var RecipeDetails = cvcEntities?.MachineRecipes?.Where(a => a.RecipeName == RecipeName)?.FirstOrDefault() ?? null;

                    if (RecipeDetails != null)
                    {
                        entity.RecipeName = RecipeDetails.RecipeName;
                        entity.RecipeId = RecipeDetails.MachineRecipeId;
                        // entity.RecipeId = recipeName.FirstOrDefault().MachineRecipeId;
                    }

                    var batchSettings = cvcEntities.BatchSettings.FirstOrDefault();
                    if (batchSettings != null)
                    {
                        ConnectMachine mdb = new ConnectMachine();
                        ClsSiemensS7Net clsSiemensS7Net = new ClsSiemensS7Net();
                        var machineComunicaation = batchSettings?.MachineParameter?.Machine?.MachineCommunications?.FirstOrDefault();
                        DashBoardViewModel dashBoardViewModel = new bs.CommonServices().GetDashBoardViewModel(machineComunicaation);
                        DashBoardField dashBoardField = new DashBoardField();
                        List<DashBoardField> lstDashBoardFields = new List<DashBoardField>();


                        if (batchSettings.BottleCounterParaId != null)
                        {
                            dashBoardField = new DashBoardField
                            {
                                IPCAddress = batchSettings?.MachineParameter?.IPCParameters?.FirstOrDefault().IPCAddress,
                                DataTypeName = batchSettings?.MachineParameter?.DataType?.DataTypeName

                            };
                            lstDashBoardFields.Add(dashBoardField);
                            dashBoardViewModel.ViewFieldList = lstDashBoardFields;
                            var value = mdb.Read(batchSettings.BottleCounterParaId.Value, dashBoardViewModel);
                            //int i;
                            if (int.TryParse(value.Replace(".00", ""), out int i))
                                entity.BottleCounter = i;
                        }
                        if (batchSettings.RejectCounterParaId != null)
                        {

                            dashBoardField = new DashBoardField
                            {
                                IPCAddress = batchSettings?.MachineParameter1?.IPCParameters?.FirstOrDefault().IPCAddress,
                                DataTypeName = batchSettings?.MachineParameter1?.DataType?.DataTypeName

                            };
                            lstDashBoardFields.Add(dashBoardField);
                            dashBoardViewModel.ViewFieldList = lstDashBoardFields;
                            var value = mdb.Read(batchSettings.RejectCounterParaId.Value, dashBoardViewModel);
                            //int i;
                            if (int.TryParse(value.Replace(".00", ""), out int i))
                                entity.TotalRejectedBottles = i;
                        }
                        if (batchSettings.GoodCounterParaId != null)
                        {

                            dashBoardField = new DashBoardField
                            {
                                IPCAddress = batchSettings?.MachineParameter5?.IPCParameters?.FirstOrDefault().IPCAddress,
                                DataTypeName = batchSettings?.MachineParameter5?.DataType?.DataTypeName

                            };
                            lstDashBoardFields.Add(dashBoardField);
                            dashBoardViewModel.ViewFieldList = lstDashBoardFields;
                            var value = mdb.Read(batchSettings.GoodCounterParaId.Value, dashBoardViewModel);
                            //int i;
                            if (int.TryParse(value.Replace(".00", ""), out int i))
                                entity.TotalGoodBottles = i;
                        }
                        if (batchSettings.RejCam1ParaId != null)
                        {
                            dashBoardField = new DashBoardField
                            {
                                IPCAddress = batchSettings?.MachineParameter2?.IPCParameters?.FirstOrDefault().IPCAddress,
                                DataTypeName = batchSettings?.MachineParameter2?.DataType?.DataTypeName

                            };
                            lstDashBoardFields.Add(dashBoardField);
                            dashBoardViewModel.ViewFieldList = lstDashBoardFields;
                            entity.RejectedByCam1 = mdb.Read(batchSettings.RejCam1ParaId.Value, dashBoardViewModel);
                        }
                        if (batchSettings.RejCam2ParaId != null)
                        {
                            dashBoardField = new DashBoardField
                            {
                                IPCAddress = batchSettings?.MachineParameter3?.IPCParameters?.FirstOrDefault().IPCAddress,
                                DataTypeName = batchSettings?.MachineParameter3?.DataType?.DataTypeName

                            };
                            lstDashBoardFields.Add(dashBoardField);
                            dashBoardViewModel.ViewFieldList = lstDashBoardFields;
                            entity.RejectedByCam2 = mdb.Read(batchSettings.RejCam2ParaId.Value, dashBoardViewModel);
                        }
                        if (batchSettings.MissingLabelRejeParaId != null)
                        {
                            dashBoardField = new DashBoardField
                            {
                                IPCAddress = batchSettings?.MachineParameter4?.IPCParameters?.FirstOrDefault().IPCAddress,
                                DataTypeName = batchSettings?.MachineParameter4?.DataType?.DataTypeName

                            };
                            lstDashBoardFields.Add(dashBoardField);
                            dashBoardViewModel.ViewFieldList = lstDashBoardFields;
                            entity.RejByMissingLabelSensor = mdb.Read(batchSettings.MissingLabelRejeParaId.Value, dashBoardViewModel);
                        }
                    }

                    var parentBatch = cvcEntities.Batches.FirstOrDefault(b => b.BatchName == entity.BatchName && b.BatchVersion == "v0");
                    parentBatch.RepackStatus = "Repack Done";

                    cvcEntities.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    cvcEntities.SaveChanges();

                    var dashObj = new DashboardCommon();
                    bool tr = dashObj.AddAuditLogforBatch(entity.BatchStatus, "Batch", "/SettingsMachine", "", "", "", Convert.ToInt32(BatchId), null, null, BatchId.ToString(), "Batch");
                    AddBatchSectionData(BatchId, RecipeDetails?.MachineRecipeId ?? null);
                    AddLogOfBatchRunData(BatchId);
                }
                catch (System.Exception ex)
                {
                    str = ex.Message;
                }
                return str;
            }
        }

        private static void AddBatchSectionData(int batchId, int? recipeId)
        {
            using (CVCEntities context = new CVCEntities())
            {
                // using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        bs.CommonServices commonServices = new bs.CommonServices();

                        var loggedUserIdCache = commonServices.GetCacheData(ClsCacheConfig.CacheKeys.LoggedUserId);

                        int userId = loggedUserIdCache;
                        //  var userId = HttpContext.Current.Cache["LoggedUserIdCache"] != null ? Convert.ToInt32(HttpContext.Current.Cache["LoggedUserIdCache"].ToString()) : (int?)null;
                        var userDetails = context.Users.FirstOrDefault(a => a.UserId == userId);

                        var getModule = context.ModuleAccesses.Where(a => a.RoleId == userDetails.RoleId && a.StatusId == 1).OrderBy(a => a.Module.Sequence).ToList();

                        foreach (var module in getModule)
                        {
                            var machineId = module.Module.MachineId;
                            var machineRecipeId = context.MachineRecipes?.FirstOrDefault(mr => mr.MachineId == machineId && mr.IsApply == true)?.MachineRecipeId ?? null;
                            BatchMachineWise batchMachineWise = new BatchMachineWise
                            {
                                MachineId = machineId,
                                BatchId = batchId,
                                RecipeId = machineRecipeId,
                                StatusId = (int)bs.ClsConstants.StatusType.Active,
                                CreatedBy = userId,
                                CreatedDate = DateTime.Now
                            };
                            context.BatchMachineWises.Add(batchMachineWise);
                            context.SaveChanges();

                            var viewId = context.Views?.FirstOrDefault(a => a.ModuleId == module.ModuleId && a.IsMachineSummary == true)?.ViewsId ?? 0;

                            var viewFields = new List<CVC.Data.EDMX.ViewField>();
                            if (userDetails.RoleId == 1)
                            {
                                viewFields = (List<CVC.Data.EDMX.ViewField>)context.ViewFields.Where(a => a.ViewsId == viewId && a.StatusId == 1 && ((a.ViewFieldAccesses.Any(f => f.IsView == true && f.StatusId == 1)))).OrderBy(a => a.MachineParameter.IPCParameters.FirstOrDefault().IsTotalBottles).ToList();
                            }
                            else
                            {
                                viewFields = (List<CVC.Data.EDMX.ViewField>)context.ViewFields.Where(a => a.ViewsId == viewId && a.StatusId == 1 && ((a.ViewFieldAccesses.Any(f => f.IsView == true && f.StatusId == 1 && f.RoleId == userDetails.RoleId)))).OrderBy(a => a.MachineParameter.IPCParameters.FirstOrDefault().IsTotalBottles).ToList();
                            }
                            ConnectMachine connect = new ConnectMachine(machineId);

                            if (viewFields != null)
                            {
                                string goodBottles = string.Empty, rejectedBottles = string.Empty;

                                foreach (var item in viewFields)
                                {
                                    var value = string.Empty;


                                    if (item.MachineParameter.IPCParameters.FirstOrDefault().IsTotalBottles == true && item.MachineParameter.IPCParameters.FirstOrDefault().IsCalculated == true)
                                    {
                                        var totalBottles = ExtensionMethods.ParseInt64(goodBottles) + CVC.BusinessServices.Common.ExtensionMethods.ParseInt64(rejectedBottles);
                                        value = Convert.ToString(totalBottles);
                                    }
                                    else
                                    {
                                        value = connect.Read((int)item.MachineParameterId);
                                    }
                                    if (item.MachineParameter.IPCParameters.FirstOrDefault().IsGoodBottles == true)
                                    {
                                        goodBottles = value;
                                    }
                                    if (item.MachineParameter.IPCParameters.FirstOrDefault().IsRejectBottles == true)
                                    {
                                        rejectedBottles = value;
                                    }


                                    BatchRunData batchRunData = new BatchRunData
                                    {
                                        BatchMachineWiseId = batchMachineWise.BatchMachineId,
                                        IPCParameterId = item.MachineParameter.IPCParameters.FirstOrDefault().IPCParameterId,
                                        IPCParameterValue = value,
                                        ViewFieldId = item.ViewField1,
                                        UpdatedDateTime = DateTime.Now,
                                        LoggedInUser = userId

                                    };

                                    context.BatchRunDatas.Add(batchRunData);
                                    context.SaveChanges();
                                }
                            }
                            // transaction.Commit();
                        }
                    }
                    catch (System.Exception ex)
                    {
                        //transaction.Rollback();
                    }
                }
            }

        }

        private static void AddLogOfBatchRunData(int batchId)
        {
            using (CVCEntities cVCEntities = new CVCEntities())
            {
                var batchMachineWise = cVCEntities.BatchMachineWises.Where(bmw => bmw.BatchId == batchId).ToList();

                if (batchMachineWise != null)
                {
                    StringBuilder builder = new StringBuilder();

                    var batchName = string.Empty;
                    var isFirst = true;
                    foreach (var item in batchMachineWise)
                    {
                        if (isFirst)
                        {
                            batchName = item.Batch.BatchName;
                            isFirst = false;
                        }
                        builder.Append($"Batch Name :{item.Batch.BatchName}")
                                .AppendLine()
                                .Append($"Machine Name :{item.Machine.MachineName}")
                                .AppendLine();

                        var batchRunData = cVCEntities.BatchRunDatas.Where(brd => brd.BatchMachineWiseId == item.BatchMachineId).ToList();

                        if (batchRunData != null)
                        {
                            List<BatchRunDataViewModel> batchRunDatas = new List<BatchRunDataViewModel>();
                            foreach (var runData in batchRunData)
                            {
                                builder.Append($"{runData.ViewField.ViewFieldName} : {runData.IPCParameterValue}").AppendLine();
                            }
                            builder.AppendLine("-------------------------------------------------------------------------");

                        }
                        else
                        {
                            builder.Append("No Data");
                            builder.AppendLine("-------------------------------------------------------------------------");

                        }

                    }

                    string path = AppDomain.CurrentDomain.BaseDirectory + "\\BatchRunData";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    string filepath = $"{AppDomain.CurrentDomain.BaseDirectory}\\BatchRunData\\{batchName}.txt";

                    // string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\BatchRunData\\BatchRunData_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
                    if (!File.Exists(filepath))
                    {
                        // Create a file to write to.   
                        using (StreamWriter writer = File.CreateText(filepath))
                        {
                            writer.Write(builder.ToString());
                            writer.Flush();
                            // sw.WriteLine(" At " + DateTime.Now.ToString() + " Section: " + Section + " Error: " + Message + " Value: " + Value);
                        }
                    }

                }

            }
        }


        public int? GetCurrentRunningBatch()
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                if (cvcEntities.Batches.Any(a => a.BatchStatus == "Batch Started"))
                {
                    return cvcEntities.Batches.Where(a => a.BatchStatus == "Batch Started").OrderByDescending(a => a.BatchId).FirstOrDefault().BatchId;
                }
                return null;
            }
        }

        public int? GetBatchForLebelRoll()
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                if (cvcEntities.Batches.Any())
                {
                    var lastbatch = cvcEntities.Batches.OrderByDescending(a => a.BatchId).FirstOrDefault();
                    if (lastbatch.BatchStatus == "Batch Ended")
                        return null;
                    else
                        return lastbatch.BatchId;
                }
                return null;
            }
        }

        public int? GetBatchForLebelRollCurrent()
        {
            // CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                if (cvcEntities.Batches.Any())
                {
                    var lastbatch = cvcEntities.Batches.OrderByDescending(a => a.BatchId).FirstOrDefault();
                    return lastbatch.BatchId;
                }
                return null;
            }
        }

        //changes added by Vinayak 18.07.2018
        public List<MachineParameter> GetMachineParameterLabelRoll(int moduleId)
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var machineid = cvcEntities.Modules.Where(a => a.ModuleId == moduleId).FirstOrDefault().MachineId;

                var details = cvcEntities.MachineParameters.Where(a => a.MachineId == machineid && a.IsLabelRoll == true).ToList();

                return details;
            }
        }

        public List<IPCParameter> GetIPCParameterLabelRoll(int moduleId)
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var machineid = cvcEntities.Modules.Where(a => a.ModuleId == moduleId).FirstOrDefault().MachineId;

                var details = cvcEntities.IPCParameters.Where(a => a.MachineId == machineid && a.IsLabelRollIPC == true).ToList();

                return details;
            }
        }

        public string GetReading(int? paraId)
        {
            ConnectMachine connect = new ConnectMachine();
            string value = connect.Read(Convert.ToInt32(paraId));
            return value;
        }

        public string GetPLCReading(int? paraId)
        {
            ConnectMachine connect = new ConnectMachine();
            string value = new CVC.PLC.Operations().Read(Convert.ToInt32(paraId));
            return value;
        }



        //ended By Vinayak

        public bool AddAuditLog(string Action, string Module, string Page, string FieldName = "", string OldValue = "", string NewValue = "", int? BatchId = null, int? MachineId = null, User user = null, int? PickListValueId = null, string Comments = null, int? AuthenticationId = null)
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                AuditLog log = new AuditLog();
                UserDefinition userDefinition = (UserDefinition)Authorization.UserDefinition;
                if (userDefinition != null)
                {
                    log.UserId = userDefinition.UserId;
                    log.UserName = userDefinition.Username;
                }
                if (user != null)
                {
                    log.UserId = user.UserId;
                    log.UserName = user.Username;
                }
                log.Action = Action;

                log.ChangedOn = DateTime.Now;
                log.Module = Module;
                log.Page = Page;
                log.FieldName = FieldName;
                log.OldValue = OldValue;
                log.NewValue = NewValue;
                log.BatchId = BatchId;
                log.MachineId = MachineId;
                log.Comments = Comments;
                log.PickListValueId = PickListValueId;
                log.AuthenticationId = AuthenticationId;
                cvcEntities.AuditLogs.Add(log);
                cvcEntities.SaveChanges();
            }
            return true;
        }

        public bool AddAuditLog(List<AuditLog> lstAuditLog)
        {

            using (CVCEntities cvcEntities = new CVCEntities())
            {
                foreach (var item in lstAuditLog)
                {
                    AuditLog log = new AuditLog();
                    UserDefinition userDefinition = (UserDefinition)Authorization.UserDefinition;
                    if (userDefinition != null)
                    {
                        log.UserId = userDefinition.UserId;
                        log.UserName = userDefinition.Username;
                    }
                    if (item.User != null)
                    {
                        log.UserId = item.User.UserId;
                        log.UserName = item.User.Username;
                    }
                    log.Action = item.Action;

                    log.ChangedOn = DateTime.Now;
                    log.Module = item.Module;
                    log.Page = item.Page;
                    log.FieldName = item.FieldName;
                    log.OldValue = item.OldValue;
                    log.NewValue = item.NewValue;
                    log.BatchId = item.BatchId;
                    log.MachineId = item.MachineId;
                    log.Comments = item.Comments;
                    log.PickListValueId = item.PickListValueId;
                    log.AuthenticationId = item.AuthenticationId;
                    cvcEntities.AuditLogs.Add(log);
                    cvcEntities.SaveChanges();
                }

            }
            return true;
        }


        public bool AddUserLog(string Action, string Module, string Page, string FieldName = "", string OldValue = "", string NewValue = "", int? BatchId = null, int? MachineId = null, User user = null)
        {
            // CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                UserLog log = new UserLog();
                UserDefinition userDefinition = (UserDefinition)Authorization.UserDefinition;
                if (userDefinition != null)
                {
                    log.UserId = userDefinition.UserId;
                    log.UserName = userDefinition.Username;
                }
                if (user != null)
                {
                    log.UserId = user.UserId;
                    log.UserName = user.Username;
                }
                log.Action = Action;

                log.ChangedOn = DateTime.Now;
                cvcEntities.UserLogs.Add(log);
                cvcEntities.SaveChanges();
            }
            return true;
        }

        public string GetLebelRollByBatch(int batch)
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var roll = cvcEntities.LabelRolls.FirstOrDefault(a => a.BatchId == batch && a.IsApplied == true);
                if (roll != null)
                    return roll.LabelRollNumber.ToString();
            }
            return "";
        }

        //commented By Vinayak On 19.07.2018 because new function has been writeen down
        //public List<Tuple<string, string>> GetAlarmByModule(int ModuleId)
        //{
        //    List<Tuple<string, string>> data = new List<Tuple<string, string>>();
        //    CVCEntities cvcEntities = new CVCEntities();
        //    var machineId = cvcEntities.Modules.FirstOrDefault(a => a.ModuleId == ModuleId).MachineId.Value;
        //    foreach (var item in cvcEntities.Alarms.Where(a => a.lastvalue == true && a.StatusId == 1 && a.MachineId == machineId).ToList())
        //    {
        //        data.Add(new Tuple<string, string>(item.AlarmName, item.Message));
        //    }
        //    return data;
        //}

        //public List<Tuple<string, string,bool,int>> GetAlarmByModule(int ModuleId)
        //{
        //    List<Tuple<string, string,bool,int>> data = new List<Tuple<string, string,bool,int>>();
        //    CVCEntities cvcEntities = new CVCEntities();
        //    var machineId = cvcEntities.Modules.FirstOrDefault(a => a.ModuleId == ModuleId).MachineId.Value;
        //    foreach (var item in cvcEntities.Alarms.Where(a => a.lastvalue == true && a.StatusId == 1 && a.MachineId == machineId && a.IsResetRequired == false).ToList())
        //    {
        //        data.Add(new Tuple<string, string,bool,int>(item.AlarmName, item.Message,Convert.ToBoolean(item.IsCommentRequired),item.AlarmId));
        //    }
        //    //changes added By Vinayak On 26.07.2018

        //    //foreach(var id in data.ToList())
        //    //{
        //    //    var test = cvcEntities.AlarmLogs.Where(a => a.AlarmId == id.Item4).ToList();

        //    //    if(test.Count() != 0)
        //    //    {
        //    //        data.Remove(id);
        //    //    }
        //    //}
        //    //changes ended By Vinayak on 26.07.2018

        //    return data;
        //}



        public List<Tuple<string, string, bool, int>> GetAlarmByModule(int ModuleId)
        {

            List<Tuple<string, string, bool, int>> data = new List<Tuple<string, string, bool, int>>();
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var machineId = cvcEntities.Modules?.FirstOrDefault(a => a.ModuleId == ModuleId)?.MachineId.Value;
                foreach (var item in cvcEntities.Alarms.Where(a => a.lastvalue == true && a.StatusId == 1 && a.MachineId == machineId).ToList())
                {
                    if (item.IsCommentRequired == true)
                    {
                        data.Add(new Tuple<string, string, bool, int>(item.AlarmName, item.Message, Convert.ToBoolean(item.IsCommentRequired), item.AlarmId));
                    }
                }

                foreach (var id in data.ToList())
                {
                    bool test = cvcEntities.AlarmLogs.Any(a => a.AlarmId == id.Item4 && a.Comment == null);

                    if (!test)
                    {
                        //if (test.Comment == null)
                        //{
                        //    //if (test.FirstOrDefault().Comment == null)
                        //{
                        data.Remove(id);
                        // }
                        //  }
                    }
                }
            }
            //changes ended By Vinayak on 26.07.2018

            return data;
        }

        public List<Tuple<string, string, bool, int>> GetAlarmByModuleNew()
        {
            List<Tuple<string, string, bool, int>> data = (List<Tuple<string, string, bool, int>>)HttpContext.Current.Session["AlarmData"];
            var IsCommedRequiredData = data.Where(x => x.Item3 == true).ToList();

            foreach (var id in IsCommedRequiredData.ToList())
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    bool AlarmLogs = cvcEntities.AlarmLogs.Any(a => a.AlarmId == id.Item4 && a.Comment == null);

                    if (!AlarmLogs)
                    {
                        IsCommedRequiredData.Remove(id);
                    }

                }
            }

            return IsCommedRequiredData;
        }


        //changes added By Vinayak On 02.08.2018

        public List<Tuple<string, string, bool, int, bool?>> GetAlarmExist(int ModuleId, int MachineId)
        {
            List<Tuple<string, string, bool, int, bool?>> data = new List<Tuple<string, string, bool, int, bool?>>();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                foreach (var item in cvcEntities.Alarms.Where(a => a.lastvalue == true && a.StatusId == 1 && a.MachineId == MachineId).ToList())
                {
                    // var IsRefreshMachineSettings = cvcEntities.IPCParameters.FirstOrDefault(a => a.MachineParameterId == item.MachineParameterId)?.IsRefreshMachineSettings ?? null;
                    data.Add(new Tuple<string, string, bool, int, bool?>(item.AlarmName, item.Message, Convert.ToBoolean(item.IsCommentRequired), item.AlarmId, item.IsRefreshMachineSettings));
                }

            }

            return data;
        }

        //ended By Vinayak On 02.08.2018

        public void ResetOnBatchCreate()
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                Operations mdb = new Operations();
                foreach (var item in cvcEntities.MachineParameters.Where(a => a.StatusId == 1 && a.IsResetOnBatchCreate == true).ToList())
                {
                    mdb.Write(item.MachineParameterId, "0");
                    System.Threading.Thread.Sleep(500);
                }

                //changes added by Vinayak On 17.07.2018
                foreach (var ipcitem in cvcEntities.IPCParameters.Where(a => a.StatusId == 1 && a.IsResetOnBatchCreateIPC == true).ToList())
                {
                    new CVC.PLC.Operations().Write(Convert.ToInt32(ipcitem.MachineParameterId), "0");
                    System.Threading.Thread.Sleep(500);
                }
            }

            //ended by Vinayak On 17.07.2018
        }

        public string SaveMachineRecipe(IUnitOfWork uow, int recipeid, int machineViewId, int? machId)
        {

            //CVCEntities cvcEntities = new CVCEntities();
            string str = "";
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                cvcEntities.Configuration.ProxyCreationEnabled = false;
                ConnectMachine connect = new ConnectMachine();

                try
                {
                    var list = cvcEntities.ViewFields.Where(a => a.ViewsId == machineViewId && a.MachineParameterId != null && a.StatusId == 1).ToList();

                    var moduleId = cvcEntities.Views.FirstOrDefault(a => a.ViewsId == machineViewId).ModuleId;
                    var machineId = cvcEntities.Modules.FirstOrDefault(a => a.ModuleId == moduleId).MachineId;
                    foreach (var item in list)
                    {
                        var Para = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == item.MachineParameterId);
                        if (Para == null)
                            continue;
                        if (Para.MachineId != machId)
                            continue;

                        //var delete =  uow.Connection.Query  cvcEntities.MachineRecipeParameters.FirstOrDefault(a => a.MachineRecipeId == recipeid && a.IPCParameterId == item.IPCParameterId);
                        //if (delete != null)
                        //    uow.Connection.DeleteById<MachineRecipeParameterRow>(delete.MachineRecipeParameterId);

                        var machineRecipeParameter = new MachineRecipeParameterRow() { MachineRecipeId = recipeid };
                        machineRecipeParameter.CreatedDate = new DateTime?(DateTime.Now);
                        machineRecipeParameter.UpdatedDate = new DateTime?(DateTime.Now);
                        machineRecipeParameter.StatusId = new int?(1);
                        machineRecipeParameter.MachineRecipeId = recipeid;
                        machineRecipeParameter.MachineParameterId = item.MachineParameterId;
                        machineRecipeParameter.MachineParameterValue = connect.Read(item.MachineParameterId.Value);

                        MachineRecipeParameterRow.RowFields fields = MachineRecipeParameterRow.Fields;
                        if (uow.Connection.Exists<MachineRecipeParameterRow>((ICriteria)((BaseCriteria)new Criteria((IField)fields.MachineRecipeId) == recipeid & new Criteria((IField)fields.MachineParameterId) == item.MachineParameterId.Value)))
                        {
                            var updateItem = uow.Connection.First<MachineRecipeParameterRow>((ICriteria)((BaseCriteria)new Criteria((IField)fields.MachineRecipeId) == recipeid & new Criteria((IField)fields.MachineParameterId) == item.MachineParameterId.Value));
                            machineRecipeParameter.MachineRecipeParameterId = updateItem.MachineRecipeParameterId;
                            uow.Connection.UpdateById<MachineRecipeParameterRow>(machineRecipeParameter);
                        }
                        else
                            uow.Connection.Insert<MachineRecipeParameterRow>(machineRecipeParameter);
                    }

                }
                catch (SystemException ex)
                {
                    str = ex.Message;
                }
            }
            return str;
        }

        public List<string> GetMessagesByModule(int ModuleId)
        {
            ConnectMachine connect = new ConnectMachine();
            List<string> data = new List<string>();
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var machineId = cvcEntities.Modules.FirstOrDefault(a => a.ModuleId == ModuleId).MachineId.Value;
                foreach (var item in cvcEntities.MachineParameters.Where(a => a.StatusId == 1 && a.MachineId == machineId && a.IsShowAsMessage == true).ToList())
                {
                    if (connect.Read(item.MachineParameterId) == "1")
                    {
                        data.Add(item.ParameterName);
                    }
                }
            }
            return data;
        }


        //public static string StartStopBatch(int BatchId, int StartStop,int ModuleId)
        //{
        //    using (CVCEntities cvcEntities = new CVCEntities())
        //    {
        //        string str;
        //        try
        //        {
        //            var entity = cvcEntities.Batches.FirstOrDefault(b => b.BatchId == BatchId);
        //            str = "1";
        //            var MachineId = 0;


        //                MachineId = (int)new DashboardCommon().GetMachineId(ModuleId.ToString());


        //            if (StartStop == 1)
        //            {
        //                #region Batch Start Write To PLC

        //                var GetMachineParameterId = cvcEntities.IPCParameters?.FirstOrDefault(i => i.MachineId == MachineId && i.IsBatchStartRequiredIPC == true)?.MachineParameterId ?? null;
        //                if (GetMachineParameterId != null)
        //                {
        //                    var result = new ConnectMachine().Write((int)GetMachineParameterId, "1");
        //                }
        //                #endregion

        //                entity.BatchStatus = "Batch Started";
        //                if (entity.BatchStartDateTime != null)
        //                {
        //                    entity.BatchStartDateTime = new DateTime?(DateTime.Now);
        //                }
        //                entity.LastBatchStartDateTime = DateTime.Now;
        //            }
        //            else
        //            {

        //                #region Batch Stop Write To PLC

        //                var GetMachineParameterId = cvcEntities.IPCParameters?.FirstOrDefault(i => i.MachineId == MachineId && i.IsBatchStartRequiredIPC == true)?.MachineParameterId ?? null;
        //                if (GetMachineParameterId != null)
        //                {
        //                    var result = new ConnectMachine().Write((int)GetMachineParameterId, "0");
        //                }
        //                #endregion

        //                //#region Batch Stop Write To PLC

        //                //var result = new ConnectMachine().Write(1710, "0");
        //                //#endregion

        //                entity.BatchStatus = "Batch Stopped";
        //                // On Batch Stop Stop Conveyer
        //                ConnectMachine connect = new ConnectMachine();
        //                foreach (var item in cvcEntities.MachineParameters.Where(a => a.StatusId == 1 && a.IsStopOnBatchStop == true).ToList())
        //                {
        //                    var machineparaid = item.MachineParameterId;
        //                    if (item.ReadMachineParameterId != null)
        //                        machineparaid = item.ReadMachineParameterId.Value;
        //                    if (connect.Read(machineparaid) == "1") // Check if Conveyor Running
        //                    {
        //                        connect.Write(item.MachineParameterId, "1");
        //                        System.Threading.Thread.Sleep(500);
        //                    }
        //                }
        //                if (entity.LastBatchStartDateTime != null)
        //                {
        //                    int runtime = (DateTime.Now - entity.LastBatchStartDateTime.Value).Minutes;
        //                    if (entity.RunTime != null)
        //                        runtime = runtime + entity.RunTime.Value;
        //                    entity.RunTime = runtime;
        //                }

        //            }
        //            cvcEntities.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        //            cvcEntities.SaveChanges();

        //            //changes added By Vinayak to add in audit log On 31.07.2018

        //            var dashObj = new DashboardCommon();
        //            bool tr = dashObj.AddAuditLogforBatch(entity.BatchStatus, "Batch", "/SettingsMachine", "", "", "", Convert.ToInt32(BatchId), null, null, BatchId.ToString(), "Batch");


        //            //ended By Vinayak On 31.07.2018
        //        }
        //        catch (System.Exception ex)
        //        {
        //            str = ex.Message+"----------"+ex.StackTrace;
        //        }
        //        return str;
        //    }
        //}
        #region Batch Start/Stop code
        public static string StartStopBatch(int BatchId, int StartStop, int ModuleId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                string str;
                try
                {
                    var entity = cvcEntities.Batches.FirstOrDefault(b => b.BatchId == BatchId);
                    str = "1";
                    var MachineId = 0;


                    MachineId = (int)new DashboardCommon().GetMachineId(ModuleId.ToString());

                    var protocolType = System.Web.HttpContext.Current.Cache["ProtocolType"];

                    modules.CommonServices moduleCommonServices = new modules.CommonServices();
                    moduleCommonServices.WriteValuesToAllMachinesAsync("IsWriteToPLC", "1");

                    if (StartStop == 1)
                    {
                        #region Batch Start Write To PLC
                        modules.CommonServices commonServices = new modules.CommonServices();
                        commonServices.WriteValuesToAllMachinesAsync("IsBatchStartRequiredIPC", "1");
                        #endregion

                        entity.BatchStatus = "Batch Started";

                        #region Sr.No.101 Date:29/01/2020 Add BatchStartDateTime while start batch 
                        if (entity.BatchStartDateTime == null)
                        {
                            entity.BatchStartDateTime = new DateTime?(DateTime.Now);
                        }
                        #endregion

                        //    entity.LastBatchStartDateTime = DateTime.Now;
                    }
                    else
                    {

                        #region Batch Stop Write To PLC
                        // var ipcParameter = cvcEntities.IPCParameters?.FirstOrDefault(i => i.MachineId == MachineId && i.IsBatchStartRequiredIPC == true);
                        modules.CommonServices commonServices = new modules.CommonServices();
                        commonServices.WriteValuesToAllMachinesAsync("IsBatchStartRequiredIPC", "0");
                        #endregion

                        //#region Batch Stop Write To PLC

                        //var result = new ConnectMachine().Write(1710, "0");
                        //#endregion

                        entity.BatchStatus = "Batch Stopped";
                        // On Batch Stop Stop Conveyer
                        ConnectMachine connect = new ConnectMachine();
                        foreach (var item in cvcEntities.MachineParameters.Where(a => a.StatusId == 1 && a.IsStopOnBatchStop == true).ToList())
                        {
                            ClsSiemensS7Net clsSiemensS7Net = new ClsSiemensS7Net();
                            DashBoardViewModel dashBoardViewModel = new bs.CommonServices().GetDashBoardViewModel(item?.Machine?.MachineCommunications?.FirstOrDefault());

                            List<DashBoardField> lstDashBoardFields = new List<DashBoardField>();
                            DashBoardField dashBoardField = new DashBoardField
                            {
                                IPCAddress = item?.IPCParameters?.FirstOrDefault()?.IPCAddress,
                                DataTypeName = item?.DataType?.DataTypeName,
                                Value = "1"
                            };
                            lstDashBoardFields.Add(dashBoardField);
                            dashBoardViewModel.ViewFieldList = lstDashBoardFields;
                            var machineparaid = item.MachineParameterId;
                            if (item.ReadMachineParameterId != null)
                                machineparaid = item.ReadMachineParameterId.Value;
                            if (connect.Read(machineparaid, dashBoardViewModel) == "1") // Check if Conveyor Running
                            {
                                connect.Write(item.MachineParameterId, "1", dashBoardViewModel);
                                System.Threading.Thread.Sleep(500);
                            }
                        }
                        /*  if (entity.LastBatchStartDateTime != null)
                          {
                              int runtime = (DateTime.Now - entity.LastBatchStartDateTime.Value).Minutes;
                              if (entity.RunTime != null)
                                  runtime = runtime + entity.RunTime.Value;
                              entity.RunTime = runtime;
                          }*/

                    }

                    cvcEntities.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    cvcEntities.SaveChanges();

                    //changes added By Vinayak to add in audit log On 31.07.2018

                    var dashObj = new DashboardCommon();
                    bool tr = dashObj.AddAuditLogforBatch(entity.BatchStatus, "Batch", "/SettingsMachine", "", "", "", Convert.ToInt32(BatchId), null, null, BatchId.ToString(), "Batch");


                    //ended By Vinayak On 31.07.2018
                }
                catch (System.Exception ex)
                {
                    str = ex.Message;
                }
                return str;
            }
        }
        #endregion

        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }

        //changes added By Vinayak On 31.07.2018
        public bool AddAuditLogforBatch(string Action, string Module, string Page, string FieldName = "", string OldValue = "", string NewValue = "", int? BatchId = null, int? MachineId = null, User user = null, string RowId = "", string TableName = "")
        {
            //CVCEntities cvcEntities = new CVCEntities();
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                AuditLog log = new AuditLog();
                UserDefinition userDefinition = (UserDefinition)Authorization.UserDefinition;
                if (userDefinition != null)
                {
                    log.UserId = userDefinition.UserId;
                    log.UserName = userDefinition.Username;
                }
                if (user != null)
                {
                    log.UserId = user.UserId;
                    log.UserName = user.Username;
                }
                log.Action = Action;

                log.ChangedOn = DateTime.Now;
                log.Module = Module;
                log.Page = Page;
                log.FieldName = FieldName;
                log.OldValue = OldValue;
                log.NewValue = NewValue;
                log.BatchId = BatchId;
                log.MachineId = MachineId;
                cvcEntities.AuditLogs.Add(log);
                cvcEntities.SaveChanges();
            }
            return true;
        }

        //changes added By Vinayak On 31.07.2018

        public async Task<List<DashBoardField>> GetDashBoardFieldAsync(int ModuleId, int ViewId)
        {
            List<DashBoardField> fields = new List<DashBoardField>();

            int alarmCounterSequence = 1, readValueSequence = 0;

            using (CVCEntities cvcEntities = new CVCEntities())
            {

                UserDefinition userDefinition = (UserDefinition)Authorization.UserDefinition;
                var runningbatch = GetCurrentRunningBatch();
                var module = cvcEntities.Modules.FirstOrDefault(a => a.ModuleId == ModuleId);
                var userDetails = cvcEntities.Users.FirstOrDefault(a => a.UserId == userDefinition.UserId);
                var ViewsAccess = cvcEntities.ViewsAccesses.FirstOrDefault(a => a.ViewsId == ViewId && a.StatusId == 1 && a.RoleId == userDetails.RoleId);
                ConnectMachine connect = new ConnectMachine(module.MachineId.Value);
                //changed on 4 march 2019 12.46 pm foreach (var item in cvcEntities.ViewFields.Where(a => a.ViewsId == ViewId && a.StatusId == 1 && (Authorization.Username == "admin" || (a.ViewFieldAccesses.Any(f => f.IsView == true && f.StatusId == 1)))).OrderBy(a => a.Sequence))
                ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
                OPCUaClientViewModel oPCUaClientViewModel = new OPCUaClientViewModel();
                ClsSiemensS7Net clsSiemensS7Net = new ClsSiemensS7Net();
                DashBoardViewModel dashBoardViewModel = new DashBoardViewModel();
                DashBoardField dashBoardField = new DashBoardField();
                List<DashBoardField> lstDashBoardField = new List<DashBoardField>();


                var IsViewAccess = true;

                if (ViewsAccess != null && userDetails.RoleId != 1)
                {
                    IsViewAccess = ViewsAccess?.IsView ?? false;
                }


                var ViewFields = new List<CVC.Data.EDMX.ViewField>();
                if (userDetails.RoleId == 1)
                {
                    ViewFields = (List<CVC.Data.EDMX.ViewField>)cvcEntities.ViewFields.Where(a => a.ViewsId == ViewId && a.StatusId == 1 && ((a.ViewFieldAccesses.Any(f => f.IsView == true && f.StatusId == 1)))).OrderBy(a => a.Sequence).ToList();
                }
                else
                {
                    ViewFields = (List<CVC.Data.EDMX.ViewField>)cvcEntities.ViewFields.Where(a => a.ViewsId == ViewId && a.StatusId == 1 && ((a.ViewFieldAccesses.Any(f => f.IsView == true && f.StatusId == 1 && f.RoleId == userDetails.RoleId)))).OrderBy(a => a.Sequence).ToList();

                }
                var protocolName = string.Empty;
                //foreach (var item in cvcEntities.ViewFields.Where(a => a.ViewsId == ViewId && a.StatusId == 1 && ( (a.ViewFieldAccesses.Any(f => f.IsView == true && f.StatusId == 1 && f.RoleId== userDetails.RoleId)))).OrderBy(a => a.Sequence))
                if (IsViewAccess)
                {
                    foreach (var item in ViewFields)
                    {
                        if (item.MachineParameter != null)
                        {
                            if (readValueSequence == 0)
                            {
                                protocolName = item?.MachineParameter?.Machine?.MachineCommunications?.FirstOrDefault()?.Protocol?.ProtocolName;
                                System.Web.HttpContext.Current.Cache.Remove("ProtocolType");
                                System.Web.HttpContext.Current.Cache["ProtocolType"] = protocolName.ToUpper();

                                if (protocolName.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                                {
                                    oPCUaClientViewModel.ServerAddress = item.MachineParameter.Machine.MachineCommunications.FirstOrDefault().IPAddress;
                                    oPCUaClientViewModel.ServerPortNumber = Convert.ToString(item.MachineParameter.Machine.MachineCommunications.FirstOrDefault().TCPIPPort);
                                    oPCUaClientViewModel.UserName = item.MachineParameter.Machine.MachineCommunications.FirstOrDefault().UserName;
                                    oPCUaClientViewModel.Password = item.MachineParameter.Machine.MachineCommunications.FirstOrDefault().Password;

                                }

                                if (protocolName.ToUpper() == ProtocolType.SiemensS7Net.ToUpper())
                                {
                                    dashBoardViewModel = new bs.CommonServices().GetDashBoardViewModel(item?.MachineParameter?.Machine?.MachineCommunications?.FirstOrDefault());

                                }

                            }

                            // If This Fields Does not belongs to This Machine the countinue
                            if (item.MachineParameter.MachineId != module.MachineId)
                                continue;

                            if (userDetails.RoleId != 1)
                            {
                                if (item.ViewFieldAccesses?.FirstOrDefault(vfa => vfa.RoleId == userDetails.RoleId && vfa.ViewFieldId == item.ViewField1 && vfa.ViewsId == ViewId)?.IsView == false)
                                {
                                    continue;
                                }

                            }

                            DashBoardField addItem = new DashBoardField();
                            addItem.MachineParameterId = item.MachineParameterId.Value;
                            if (item.MachineParameter.Type != null)
                                addItem.Type = item.MachineParameter.Type.Value;
                            addItem.ParameterName = item.ViewFieldName;
                            addItem.DateTypeId = item.MachineParameter.DataTypeId.Value;


                            if (item.MachineParameter.PickListValue != null)
                                addItem.UnitName = item.MachineParameter.PickListValue.PickListValueName;
                            addItem.IsRangeUnlimited = item.MachineParameter.IsRangeUnlimited.Value;
                            if (item.MachineParameter.Min != null)
                                addItem.Min = item.MachineParameter.Min.Value;
                            if (item.MachineParameter.Max != null)
                                addItem.Max = item.MachineParameter.Max.Value;


                            // If User Dont Have View Modify Access For Role Then 
                            if (ViewsAccess != null)
                                if (ViewsAccess.IsModify == false)
                                    addItem.IsModify = false;
                                else
                                {
                                    addItem.IsModify = item.ViewFieldAccesses?.FirstOrDefault(vfa => vfa.RoleId == userDetails.RoleId && vfa.ViewFieldId == item.ViewField1 && vfa.ViewsId == item.ViewsId)?.IsModify ?? false;

                                    // Check View Field Have Modify Acecess 
                                    //if (item.ViewFieldAccesses.Any(a => a.IsModify == false && a.StatusId == 1))
                                    //    addItem.IsModify = false;
                                    //else
                                    //    addItem.IsModify = true;
                                }
                            // If Is Read is Checked Then Only Read Value
                            if (item.MachineParameter.IsRead == true)
                            {
                                // In Case Of MDB Call MDB   
                                int? machineparaId = addItem.MachineParameterId;
                                //if (item.MachineParameter.Machine.MachineCommunications.Any(a => a.ProtocolTypeId == 4 && a.StatusId == 1))
                                if (protocolName.ToUpper() == ProtocolType.MDB.ToUpper())
                                {
                                    // In Case of Button and Read Is Set from Another Field
                                    if (item.MachineParameter.Type == 49 && item.MachineParameter.ReadMachineParameterId != null)
                                        machineparaId = item.MachineParameter.ReadMachineParameterId.Value;
                                    else if (item.MachineParameter.Type == 49 && item.MachineParameter.ReadMachineParameterId == null)
                                        machineparaId = null; // In Case of Button and No Read send Value as Blank
                                    if (machineparaId != null)
                                        addItem.Value = connect.Read(machineparaId.Value);

                                    //addItem.IsConnected = connect.CheckModBusConnection(machineparaId.Value) == true ? true : false;
                                }

                                // else if (item.MachineParameter.Machine.MachineCommunications.Any(a => a.ProtocolTypeId == 1 && a.StatusId == 1))
                                else if (protocolName.ToUpper().Contains(ProtocolType.Modbus.ToUpper()))

                                {
                                    addItem.Value = connect.Read(machineparaId.Value);
                                    //addItem.IsConnected = connect.CheckModBusConnection(machineparaId.Value) == true ? true : false;
                                }
                                else if (protocolName.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                                {
                                    addItem.NodeId = item.MachineParameter.IPCParameters.FirstOrDefault().NodeId;
                                    addItem.AttributeId = item.MachineParameter.IPCParameters.FirstOrDefault().AttributeId;
                                    addItem.IPCAddress = ProtocolType.OPCUaClient.ToUpper();
                                    oPCUaClientViewModel.NodeId = addItem.NodeId;
                                    oPCUaClientViewModel.AttributeId = Convert.ToUInt32(addItem.AttributeId);
                                    oPCUaClientViewModel.MachineId = module.MachineId.Value;
                                    addItem.Value = clsOpcUaClient.Read(oPCUaClientViewModel);
                                }
                                else if (protocolName.ToUpper() == ProtocolType.SiemensS7Net.ToUpper())
                                {
                                    addItem.IPCAddress = item?.MachineParameter?.IPCParameters?.FirstOrDefault()?.IPCAddress;

                                    dashBoardField.IPCAddress = item?.MachineParameter?.IPCParameters?.FirstOrDefault()?.IPCAddress;
                                    dashBoardField.DataTypeName = item?.MachineParameter?.DataType?.DataTypeName;
                                    lstDashBoardField.Add(dashBoardField);
                                    dashBoardViewModel.ViewFieldList = lstDashBoardField;
                                    addItem.Value = await clsSiemensS7Net.Read(dashBoardViewModel);
                                }
                            }



                            // If IsWrite Is false Then Dont allow Field to be modify
                            if (item.MachineParameter.IsWrite == false)
                                addItem.IsModify = false;
                            else if (Authorization.Username.ToLower() == "admin")
                                addItem.IsModify = true;

                            // If batch not Running then disable control
                            if (item.MachineParameter.IsBatchStartRequired == true && runningbatch == null)
                                addItem.IsDisabled = true;

                            //changes added by Vinayak

                            if (item.MachineParameter.IPCParameters.FirstOrDefault().IsBatchStartRequiredIPC == true)
                            {
                                addItem.IsDisabled = true;
                            }

                            //ended by Vinayak

                            // If disabled is set disable field
                            if (item.MachineParameter.DisableParameterId != null)
                            {
                                if (connect.Read(item.MachineParameter.DisableParameterId.Value) == item.MachineParameter.DisableParameterValue)
                                    addItem.IsDisabled = true;
                            }
                            if (item.MachineParameter.AllowDecimalPoint != null)
                                addItem.AllowDecimalPoint = item.MachineParameter.AllowDecimalPoint.Value;

                            if (protocolName.ToUpper().Contains(ProtocolType.Modbus.ToUpper()))
                            {
                                if (item.MachineParameter.IPCParameters.FirstOrDefault().IPCAddress != null)
                                {
                                    addItem.IPCAddress = item.MachineParameter.IPCParameters.FirstOrDefault().IPCAddress;
                                }
                            }

                            if (item.MachineParameter.IPCParameters.FirstOrDefault().OperationTypeIPC != null)
                            {
                                addItem.OperationTypeIPC = item.MachineParameter.IPCParameters.FirstOrDefault()?.OperationTypeIPC ?? 0;
                                addItem.OperationTypeName = cvcEntities.PickListValues?.FirstOrDefault(pl => pl.PickListValueId == addItem.OperationTypeIPC)?.PickListValueName;

                            }
                            if (item.MachineParameter.IPCParameters.FirstOrDefault().OperationValueIPC != null)
                            {
                                addItem.OperationValueIPC = item.MachineParameter.IPCParameters.FirstOrDefault().OperationValueIPC;
                                if (addItem.OperationValueIPC != null)
                                {

                                    addItem.OperationValueIPC = IntegerExtension(addItem.OperationValueIPC);
                                }
                            }

                            addItem.DataTypeId = item.MachineParameter.DataTypeId;
                            addItem.DataTypeName = item?.MachineParameter?.DataType?.DataTypeName?.ToLower();
                            addItem.IsByteSwap = item.MachineParameter.IPCParameters.FirstOrDefault().IsByteSwap;
                            addItem.IsWordSwap = item.MachineParameter.IPCParameters.FirstOrDefault().IsWordSwap;
                            addItem.Is32Bit = item.MachineParameter.IPCParameters.FirstOrDefault().Is32Bit;
                            addItem.IsBitWise = item.MachineParameter.IPCParameters.FirstOrDefault().IsBitWise;
                            addItem.Bit32Address = item.MachineParameter.IPCParameters.FirstOrDefault().Bit32Address;
                            addItem.BitWiseIndex = item.MachineParameter.IPCParameters.FirstOrDefault().BitWiseIndex;
                            addItem.IsMachineSpeed = item.MachineParameter.IPCParameters.FirstOrDefault().IsMachineSpeed;
                            addItem.IsLabelRollIPC = item.MachineParameter.IPCParameters.FirstOrDefault().IsLabelRollIPC;
                            addItem.IsRefreshMachineSettings = item.MachineParameter.IPCParameters.FirstOrDefault().IsRefreshMachineSettings;

                            addItem.IsPopUpRequired = cvcEntities.ViewFields.FirstOrDefault(vf => vf.MachineParameterId == item.MachineParameterId.Value)?.IsPopUpRequired ?? false;
                            addItem.IsCommentRequired = cvcEntities.ViewFields.FirstOrDefault(vf => vf.MachineParameterId == item.MachineParameterId.Value)?.IsCommentRequired ?? false;
                            addItem.IsAuthenticationRequired = cvcEntities.ViewFields.FirstOrDefault(vf => vf.MachineParameterId == item.MachineParameterId.Value)?.IsAuthenticationRequired ?? false;
                            addItem.IsAuthorisedRole = cvcEntities.ViewFieldAuthentications.FirstOrDefault(vfa => vfa.RoleId == userDetails.RoleId && vfa.ViewFieldId == item.ViewField1) == null ? false : true;
                            addItem.ViewFieldId = item.ViewField1;
                            var Roles = cvcEntities.ViewFieldAuthentications.Where(vf => vf.ViewFieldId == item.ViewField1).Select(vf => vf.Role.RoleName).ToArray();
                            addItem.RoleNames = Roles != null ? string.Join(",", Roles.Select(x => x.ToString()).ToArray()) : "NA";

                            var IPCParameters = cvcEntities.IPCParameters?.FirstOrDefault(i => i.MachineId == module.MachineId && i.IsWriteToPLC == true);
                            if (IPCParameters != null)
                            {
                                addItem.WriteToPLCIPCMachineParameterId = IPCParameters.MachineParameterId;
                            }

                            addItem.IsIndicatorParameter = cvcEntities.IPCParameters.FirstOrDefault(vf => vf.MachineParameterId == item.MachineParameterId.Value)?.IsIndicatorParameter ?? false;
                            if (addItem.IsIndicatorParameter == true)
                            {
                                var IndicatorParameterId = cvcEntities.IPCParameters.FirstOrDefault(vf => vf.MachineParameterId == item.MachineParameterId.Value)?.IndicatorParameterId ?? null;
                                var GetIPCParameters = cvcEntities.IPCParameters.FirstOrDefault(vf => vf.MachineParameterId == IndicatorParameterId);
                                if (GetIPCParameters != null)
                                {
                                    if (protocolName.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                                    {
                                        addItem.NodeId = GetIPCParameters.NodeId;
                                        addItem.AttributeId = GetIPCParameters.AttributeId;
                                        addItem.IPCAddress = ProtocolType.OPCUaClient.ToUpper();
                                        addItem.DataTypeId = GetIPCParameters.MachineParameter.DataTypeId;
                                        addItem.Bit32Address = GetIPCParameters.Bit32Address;
                                        addItem.BitWiseIndex = GetIPCParameters.BitWiseIndex;
                                        addItem.IsBitWise = GetIPCParameters.IsBitWise;

                                    }
                                    else
                                    {

                                        addItem.IPCAddress = GetIPCParameters.IPCAddress;
                                        addItem.DataTypeId = GetIPCParameters.MachineParameter.DataTypeId;
                                        addItem.Bit32Address = GetIPCParameters.Bit32Address;
                                        addItem.BitWiseIndex = GetIPCParameters.BitWiseIndex;
                                        addItem.IsBitWise = GetIPCParameters.IsBitWise;
                                    }
                                }
                            }
                            addItem.IsGoodBottles = item.MachineParameter.IPCParameters.FirstOrDefault().IsGoodBottles;
                            addItem.IsRejectBottles = item.MachineParameter.IPCParameters.FirstOrDefault().IsRejectBottles;
                            addItem.IsBatchSize = item.MachineParameter.IPCParameters.FirstOrDefault().IsBatchSize;
                            if (addItem.IsGoodBottles == true)
                            {
                                addItem.BatchSizeIPCAddress = cvcEntities.IPCParameters?.FirstOrDefault(i => i.IsBatchSize == true && i.MachineId == module.MachineId)?.IPCAddress ?? null;
                            }
                            addItem.RowId = item.MachineParameter.RowId;
                            addItem.Bit32RowId = item.MachineParameter.Bit32RowId;

                            if (userDetails.RoleId != 1)
                            {
                                if (ViewsAccess != null)
                                {
                                    if (ViewsAccess.IsModify == false || ViewsAccess.IsModify == null)
                                    {
                                        addItem.IsDisabled = false;
                                    }
                                    else
                                    {
                                        addItem.IsDisabled = item.ViewFieldAccesses?.FirstOrDefault(vfa => vfa.RoleId == userDetails.RoleId && vfa.ViewFieldId == item.ViewField1 && vfa.ViewsId == ViewId)?.IsModify == false ? true : false;
                                    }

                                }
                            }

                            if (item.MachineParameter.IPCParameters.FirstOrDefault().IsConveyer == true)
                            {
                                addItem.IsConveyerClass = "IsConveyerClass";
                            }

                            var machineId = module.Machine.MachineId;
                            var isWrite = cvcEntities.TerminalMachineMappings.FirstOrDefault(mtm => mtm.MachineId == machineId)?.MasterTerminal.TerminalType.IsWrite ?? false;
                            addItem.IsWriteTerminalType = isWrite;

                            addItem.IsMissingLabelCounter = item.MachineParameter.IPCParameters.FirstOrDefault().IsMissingLabelCounter;
                            if (addItem.IsMissingLabelCounter == true)
                            {
                                addItem.AlarmId = cvcEntities.Alarms.Where(a => a.MachineParameterId == item.MachineParameterId && a.MachineId == item.MachineParameter.MachineId).FirstOrDefault()?.AlarmId ?? null;
                                addItem.AlarmCounterSequence = alarmCounterSequence;
                                alarmCounterSequence++;
                            }

                            addItem.ReadValueSequence = readValueSequence;
                            readValueSequence++;
                            fields.Add(addItem);
                        }
                    }
                }
            }
            return fields;
        }

        public async Task<List<DashBoardField>> GetDashBoardFieldAsyncForDisplayPreview(int MachineId, int ViewId)
        {
            List<DashBoardField> fields = new List<DashBoardField>();

            int alarmCounterSequence = 1, readValueSequence = 0;

            using (CVCEntities cvcEntities = new CVCEntities())
            {

                UserDefinition userDefinition = (UserDefinition)Authorization.UserDefinition;
                var runningbatch = GetCurrentRunningBatch();
                var userDetails = cvcEntities.Users.FirstOrDefault(a => a.UserId == userDefinition.UserId);
                var ViewsAccess = cvcEntities.ViewsAccesses.FirstOrDefault(a => a.ViewsId == ViewId && a.StatusId == 1 && a.RoleId == userDetails.RoleId);
                ConnectMachine connect = new ConnectMachine(MachineId);
                //changed on 4 march 2019 12.46 pm foreach (var item in cvcEntities.ViewFields.Where(a => a.ViewsId == ViewId && a.StatusId == 1 && (Authorization.Username == "admin" || (a.ViewFieldAccesses.Any(f => f.IsView == true && f.StatusId == 1)))).OrderBy(a => a.Sequence))
                ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
                OPCUaClientViewModel oPCUaClientViewModel = new OPCUaClientViewModel();
                ClsSiemensS7Net clsSiemensS7Net = new ClsSiemensS7Net();
                DashBoardViewModel dashBoardViewModel = new DashBoardViewModel();
                DashBoardField dashBoardField = new DashBoardField();
                List<DashBoardField> lstDashBoardField = new List<DashBoardField>();


                var IsViewAccess = true;


                var ViewFields = new List<CVC.Data.EDMX.ViewField>();
                if (userDetails.RoleId == 1)
                {
                    ViewFields = (List<CVC.Data.EDMX.ViewField>)cvcEntities.ViewFields.Where(a => a.ViewsId == ViewId && a.StatusId == 1).ToList();
                }
                else
                {
                    ViewFields = (List<CVC.Data.EDMX.ViewField>)cvcEntities.ViewFields.Where(a => a.ViewsId == ViewId && a.StatusId == 1).ToList();

                }
                var protocolName = string.Empty;
                //foreach (var item in cvcEntities.ViewFields.Where(a => a.ViewsId == ViewId && a.StatusId == 1 && ( (a.ViewFieldAccesses.Any(f => f.IsView == true && f.StatusId == 1 && f.RoleId== userDetails.RoleId)))).OrderBy(a => a.Sequence))
                if (IsViewAccess)
                {
                    foreach (var item in ViewFields)
                    {
                        if (item.MachineParameter != null)
                        {
                            if (readValueSequence == 0)
                            {
                                protocolName = item?.MachineParameter?.Machine?.MachineCommunications?.FirstOrDefault()?.Protocol?.ProtocolName;
                                System.Web.HttpContext.Current.Cache.Remove("ProtocolType");
                                System.Web.HttpContext.Current.Cache["ProtocolType"] = protocolName.ToUpper();

                                if (protocolName.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                                {
                                    oPCUaClientViewModel.ServerAddress = item.MachineParameter.Machine.MachineCommunications.FirstOrDefault().IPAddress;
                                    oPCUaClientViewModel.ServerPortNumber = Convert.ToString(item.MachineParameter.Machine.MachineCommunications.FirstOrDefault().TCPIPPort);
                                    oPCUaClientViewModel.UserName = item.MachineParameter.Machine.MachineCommunications.FirstOrDefault().UserName;
                                    oPCUaClientViewModel.Password = item.MachineParameter.Machine.MachineCommunications.FirstOrDefault().Password;

                                }

                                if (protocolName.ToUpper() == ProtocolType.SiemensS7Net.ToUpper())
                                {
                                    dashBoardViewModel = new bs.CommonServices().GetDashBoardViewModel(item?.MachineParameter?.Machine?.MachineCommunications?.FirstOrDefault());

                                }

                            }

                            // If This Fields Does not belongs to This Machine the countinue
                            if (item.MachineParameter.MachineId != MachineId)
                                continue;

                            if (userDetails.RoleId != 1)
                            {
                                if (item.ViewFieldAccesses?.FirstOrDefault(vfa => vfa.RoleId == userDetails.RoleId && vfa.ViewFieldId == item.ViewField1 && vfa.ViewsId == ViewId)?.IsView == false)
                                {
                                    continue;
                                }

                            }

                            DashBoardField addItem = new DashBoardField();
                            addItem.MachineParameterId = item.MachineParameterId.Value;
                            if (item.MachineParameter.Type != null)
                                addItem.Type = item.MachineParameter.Type.Value;
                            addItem.ParameterName = item.ViewFieldName;
                            addItem.DateTypeId = item.MachineParameter.DataTypeId.Value;


                            if (item.MachineParameter.PickListValue != null)
                                addItem.UnitName = item.MachineParameter.PickListValue.PickListValueName;
                            addItem.IsRangeUnlimited = item.MachineParameter.IsRangeUnlimited.Value;
                            if (item.MachineParameter.Min != null)
                                addItem.Min = item.MachineParameter.Min.Value;
                            if (item.MachineParameter.Max != null)
                                addItem.Max = item.MachineParameter.Max.Value;


                            // If User Dont Have View Modify Access For Role Then 
                            if (ViewsAccess != null)
                                if (ViewsAccess.IsModify == false)
                                    addItem.IsModify = false;
                                else
                                {
                                    addItem.IsModify = item.ViewFieldAccesses?.FirstOrDefault(vfa => vfa.RoleId == userDetails.RoleId && vfa.ViewFieldId == item.ViewField1 && vfa.ViewsId == item.ViewsId)?.IsModify ?? false;

                                    // Check View Field Have Modify Acecess 
                                    //if (item.ViewFieldAccesses.Any(a => a.IsModify == false && a.StatusId == 1))
                                    //    addItem.IsModify = false;
                                    //else
                                    //    addItem.IsModify = true;
                                }
                            // If Is Read is Checked Then Only Read Value
                            if (item.MachineParameter.IsRead == true)
                            {
                                // In Case Of MDB Call MDB   
                                int? machineparaId = addItem.MachineParameterId;
                                //if (item.MachineParameter.Machine.MachineCommunications.Any(a => a.ProtocolTypeId == 4 && a.StatusId == 1))
                                if (protocolName.ToUpper() == ProtocolType.MDB.ToUpper())
                                {
                                    // In Case of Button and Read Is Set from Another Field
                                    if (item.MachineParameter.Type == 49 && item.MachineParameter.ReadMachineParameterId != null)
                                        machineparaId = item.MachineParameter.ReadMachineParameterId.Value;
                                    else if (item.MachineParameter.Type == 49 && item.MachineParameter.ReadMachineParameterId == null)
                                        machineparaId = null; // In Case of Button and No Read send Value as Blank
                                    if (machineparaId != null)
                                        addItem.Value = connect.Read(machineparaId.Value);

                                    //addItem.IsConnected = connect.CheckModBusConnection(machineparaId.Value) == true ? true : false;
                                }

                                // else if (item.MachineParameter.Machine.MachineCommunications.Any(a => a.ProtocolTypeId == 1 && a.StatusId == 1))
                                else if (protocolName.ToUpper().Contains(ProtocolType.Modbus.ToUpper()))

                                {
                                    addItem.Value = connect.Read(machineparaId.Value);
                                    //addItem.IsConnected = connect.CheckModBusConnection(machineparaId.Value) == true ? true : false;
                                }
                                else if (protocolName.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                                {
                                    addItem.NodeId = item.MachineParameter.IPCParameters.FirstOrDefault().NodeId;
                                    addItem.AttributeId = item.MachineParameter.IPCParameters.FirstOrDefault().AttributeId;
                                    addItem.IPCAddress = ProtocolType.OPCUaClient.ToUpper();
                                    oPCUaClientViewModel.NodeId = addItem.NodeId;
                                    oPCUaClientViewModel.AttributeId = Convert.ToUInt32(addItem.AttributeId);
                                    oPCUaClientViewModel.MachineId = MachineId;
                                    addItem.Value = clsOpcUaClient.Read(oPCUaClientViewModel);
                                }
                                else if (protocolName.ToUpper() == ProtocolType.SiemensS7Net.ToUpper())
                                {
                                    addItem.IPCAddress = item?.MachineParameter?.IPCParameters?.FirstOrDefault()?.IPCAddress;

                                    dashBoardField.IPCAddress = item?.MachineParameter?.IPCParameters?.FirstOrDefault()?.IPCAddress;
                                    dashBoardField.DataTypeName = item?.MachineParameter?.DataType?.DataTypeName;
                                    lstDashBoardField.Add(dashBoardField);
                                    dashBoardViewModel.ViewFieldList = lstDashBoardField;
                                    addItem.Value = await clsSiemensS7Net.Read(dashBoardViewModel);
                                }
                            }



                            // If IsWrite Is false Then Dont allow Field to be modify
                            if (item.MachineParameter.IsWrite == false)
                                addItem.IsModify = false;
                            else if (Authorization.Username.ToLower() == "admin")
                                addItem.IsModify = true;

                            // If batch not Running then disable control
                            if (item.MachineParameter.IsBatchStartRequired == true && runningbatch == null)
                                addItem.IsDisabled = true;

                            //changes added by Vinayak

                            if (item.MachineParameter.IPCParameters.FirstOrDefault().IsBatchStartRequiredIPC == true)
                            {
                                addItem.IsDisabled = true;
                            }

                            //ended by Vinayak

                            // If disabled is set disable field
                            if (item.MachineParameter.DisableParameterId != null)
                            {
                                if (connect.Read(item.MachineParameter.DisableParameterId.Value) == item.MachineParameter.DisableParameterValue)
                                    addItem.IsDisabled = true;
                            }
                            if (item.MachineParameter.AllowDecimalPoint != null)
                                addItem.AllowDecimalPoint = item.MachineParameter.AllowDecimalPoint.Value;

                            if (protocolName.ToUpper().Contains(ProtocolType.Modbus.ToUpper()))
                            {
                                if (item.MachineParameter.IPCParameters.FirstOrDefault().IPCAddress != null)
                                {
                                    addItem.IPCAddress = item.MachineParameter.IPCParameters.FirstOrDefault().IPCAddress;
                                }
                            }

                            if (item.MachineParameter.IPCParameters.FirstOrDefault().OperationTypeIPC != null)
                            {
                                addItem.OperationTypeIPC = item.MachineParameter.IPCParameters.FirstOrDefault()?.OperationTypeIPC ?? 0;
                                addItem.OperationTypeName = cvcEntities.PickListValues?.FirstOrDefault(pl => pl.PickListValueId == addItem.OperationTypeIPC)?.PickListValueName;

                            }
                            if (item.MachineParameter.IPCParameters.FirstOrDefault().OperationValueIPC != null)
                            {
                                addItem.OperationValueIPC = item.MachineParameter.IPCParameters.FirstOrDefault().OperationValueIPC;
                                if (addItem.OperationValueIPC != null)
                                {

                                    addItem.OperationValueIPC = IntegerExtension(addItem.OperationValueIPC);
                                }
                            }

                            addItem.DataTypeId = item.MachineParameter.DataTypeId;
                            addItem.DataTypeName = item?.MachineParameter?.DataType?.DataTypeName?.ToLower();
                            addItem.IsByteSwap = item.MachineParameter.IPCParameters.FirstOrDefault().IsByteSwap;
                            addItem.IsWordSwap = item.MachineParameter.IPCParameters.FirstOrDefault().IsWordSwap;
                            addItem.Is32Bit = item.MachineParameter.IPCParameters.FirstOrDefault().Is32Bit;
                            addItem.IsBitWise = item.MachineParameter.IPCParameters.FirstOrDefault().IsBitWise;
                            addItem.Bit32Address = item.MachineParameter.IPCParameters.FirstOrDefault().Bit32Address;
                            addItem.BitWiseIndex = item.MachineParameter.IPCParameters.FirstOrDefault().BitWiseIndex;
                            addItem.IsMachineSpeed = item.MachineParameter.IPCParameters.FirstOrDefault().IsMachineSpeed;
                            addItem.IsLabelRollIPC = item.MachineParameter.IPCParameters.FirstOrDefault().IsLabelRollIPC;
                            addItem.IsRefreshMachineSettings = item.MachineParameter.IPCParameters.FirstOrDefault().IsRefreshMachineSettings;

                            addItem.IsPopUpRequired = cvcEntities.ViewFields.FirstOrDefault(vf => vf.MachineParameterId == item.MachineParameterId.Value)?.IsPopUpRequired ?? false;
                            addItem.IsCommentRequired = cvcEntities.ViewFields.FirstOrDefault(vf => vf.MachineParameterId == item.MachineParameterId.Value)?.IsCommentRequired ?? false;
                            addItem.IsAuthenticationRequired = cvcEntities.ViewFields.FirstOrDefault(vf => vf.MachineParameterId == item.MachineParameterId.Value)?.IsAuthenticationRequired ?? false;
                            addItem.IsAuthorisedRole = cvcEntities.ViewFieldAuthentications.FirstOrDefault(vfa => vfa.RoleId == userDetails.RoleId && vfa.ViewFieldId == item.ViewField1) == null ? false : true;
                            addItem.ViewFieldId = item.ViewField1;
                            var Roles = cvcEntities.ViewFieldAuthentications.Where(vf => vf.ViewFieldId == item.ViewField1).Select(vf => vf.Role.RoleName).ToArray();
                            addItem.RoleNames = Roles != null ? string.Join(",", Roles.Select(x => x.ToString()).ToArray()) : "NA";

                            addItem.MachineParameterName = cvcEntities.MachineParameters.FirstOrDefault(vf => vf.MachineParameterId == item.MachineParameterId.Value).ParameterName;

                            var IPCParameters = cvcEntities.IPCParameters?.FirstOrDefault(i => i.MachineId == MachineId && i.IsWriteToPLC == true);
                            if (IPCParameters != null)
                            {
                                addItem.WriteToPLCIPCMachineParameterId = IPCParameters.MachineParameterId;
                            }

                            addItem.IsIndicatorParameter = cvcEntities.IPCParameters.FirstOrDefault(vf => vf.MachineParameterId == item.MachineParameterId.Value)?.IsIndicatorParameter ?? false;
                            if (addItem.IsIndicatorParameter == true)
                            {
                                var IndicatorParameterId = cvcEntities.IPCParameters.FirstOrDefault(vf => vf.MachineParameterId == item.MachineParameterId.Value)?.IndicatorParameterId ?? null;
                                var GetIPCParameters = cvcEntities.IPCParameters.FirstOrDefault(vf => vf.MachineParameterId == IndicatorParameterId);
                                if (GetIPCParameters != null)
                                {
                                    if (protocolName.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                                    {
                                        addItem.NodeId = GetIPCParameters.NodeId;
                                        addItem.AttributeId = GetIPCParameters.AttributeId;
                                        addItem.IPCAddress = ProtocolType.OPCUaClient.ToUpper();
                                        addItem.DataTypeId = GetIPCParameters.MachineParameter.DataTypeId;
                                        addItem.Bit32Address = GetIPCParameters.Bit32Address;
                                        addItem.BitWiseIndex = GetIPCParameters.BitWiseIndex;
                                        addItem.IsBitWise = GetIPCParameters.IsBitWise;

                                    }
                                    else
                                    {

                                        addItem.IPCAddress = GetIPCParameters.IPCAddress;
                                        addItem.DataTypeId = GetIPCParameters.MachineParameter.DataTypeId;
                                        addItem.Bit32Address = GetIPCParameters.Bit32Address;
                                        addItem.BitWiseIndex = GetIPCParameters.BitWiseIndex;
                                        addItem.IsBitWise = GetIPCParameters.IsBitWise;
                                    }
                                }
                            }
                            addItem.IsGoodBottles = item.MachineParameter.IPCParameters.FirstOrDefault().IsGoodBottles;
                            addItem.IsRejectBottles = item.MachineParameter.IPCParameters.FirstOrDefault().IsRejectBottles;
                            addItem.IsBatchSize = item.MachineParameter.IPCParameters.FirstOrDefault().IsBatchSize;
                            if (addItem.IsGoodBottles == true)
                            {
                                addItem.BatchSizeIPCAddress = cvcEntities.IPCParameters?.FirstOrDefault(i => i.IsBatchSize == true && i.MachineId == MachineId)?.IPCAddress ?? null;
                            }
                            addItem.RowId = item.MachineParameter.RowId;
                            addItem.Bit32RowId = item.MachineParameter.Bit32RowId;

                            if (userDetails.RoleId != 1)
                            {
                                if (ViewsAccess != null)
                                {
                                    if (ViewsAccess.IsModify == false || ViewsAccess.IsModify == null)
                                    {
                                        addItem.IsDisabled = false;
                                    }
                                    else
                                    {
                                        addItem.IsDisabled = item.ViewFieldAccesses?.FirstOrDefault(vfa => vfa.RoleId == userDetails.RoleId && vfa.ViewFieldId == item.ViewField1 && vfa.ViewsId == ViewId)?.IsModify == false ? true : false;
                                    }

                                }
                            }

                            if (item.MachineParameter.IPCParameters.FirstOrDefault().IsConveyer == true)
                            {
                                addItem.IsConveyerClass = "IsConveyerClass";
                            }

                            var machineId = MachineId;
                            var isWrite = cvcEntities.TerminalMachineMappings.FirstOrDefault(mtm => mtm.MachineId == machineId)?.MasterTerminal.TerminalType.IsWrite ?? false;
                            addItem.IsWriteTerminalType = isWrite;

                            addItem.IsMissingLabelCounter = item.MachineParameter.IPCParameters.FirstOrDefault().IsMissingLabelCounter;
                            if (addItem.IsMissingLabelCounter == true)
                            {
                                addItem.AlarmId = cvcEntities.Alarms.Where(a => a.MachineParameterId == item.MachineParameterId && a.MachineId == item.MachineParameter.MachineId).FirstOrDefault()?.AlarmId ?? null;
                                addItem.AlarmCounterSequence = alarmCounterSequence;
                                alarmCounterSequence++;
                            }

                            addItem.ReadValueSequence = readValueSequence;
                            readValueSequence++;
                            fields.Add(addItem);
                        }
                    }
                }
            }
            return fields;
        }

        public string CheckCommuniation()
        {
            ConnectMachine connect = new ConnectMachine();
            string ReadCommunication = connect.ReadComunication();
            return ReadCommunication;
        }

        public bool SaveAlarmComments(string alarmId, string Comments, string ModuleId)
        {
            try
            {
                Int32 GetModuleID = Convert.ToInt32(ModuleId);
                //CVCEntities cvcEntities = new CVCEntities();
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var MachineId = cvcEntities.Modules.FirstOrDefault(a => a.ModuleId == GetModuleID).MachineId;
                    int AlarmId = Convert.ToInt32(alarmId);
                    var GetCommentNullAlarmLog = cvcEntities.AlarmLogs.Where(x => x.AlarmId == AlarmId && x.Comment == null).ToList();


                    //AlarmLog log = new AlarmLog();
                    //log.MachineId = Convert.ToInt32(MachineId);
                    //log.AlarmId = Convert.ToInt32(alarmId);
                    //log.Comment = Comments;
                    //log.LoggedUserId = null;
                    //log.AlarmDateTime = DateTime.Now;
                    //log.BatchId = GetCurrentRunningBatch();
                    //cvcEntities.AlarmLogs.Add(log);
                    //cvcEntities.SaveChanges();

                    foreach (var item in GetCommentNullAlarmLog)
                    {


                        item.MachineId = Convert.ToInt32(MachineId);
                        item.AlarmId = Convert.ToInt32(alarmId);
                        item.Comment = Comments;
                        item.LoggedUserId = null;
                        item.AlarmDateTime = DateTime.Now;
                        item.BatchId = GetCurrentRunningBatch();
                        // cvcEntities.AlarmLogs.(item);
                        // cvcEntities.SaveChanges();
                        cvcEntities.Entry<AlarmLog>(item).State = System.Data.Entity.EntityState.Modified;

                        cvcEntities.SaveChanges();
                    }



                    AuditLog auditlog = new AuditLog();
                    UserDefinition userDefinition = (UserDefinition)Authorization.UserDefinition;
                    if (userDefinition != null)
                    {
                        auditlog.UserId = userDefinition.UserId;
                        auditlog.UserName = userDefinition.Username;
                    }

                    auditlog.Action = "Alarm Comments Inserted";

                    auditlog.ChangedOn = DateTime.Now;
                    auditlog.Module = "Alarm";
                    auditlog.Page = "Alarm Comments";
                    auditlog.FieldName = "IsCommentRequired";
                    auditlog.OldValue = "";
                    auditlog.NewValue = Comments;
                    auditlog.BatchId = null;
                    auditlog.MachineId = Convert.ToInt32(MachineId);
                    cvcEntities.AuditLogs.Add(auditlog);
                    cvcEntities.SaveChanges();

                    int alarid = Convert.ToInt32(alarmId);

                    var alarmlogs = cvcEntities.AlarmLogs.FirstOrDefault(a => a.AlarmId == alarid && a.Comment == null);

                    alarmlogs.Comment = Comments;

                    cvcEntities.Entry<AlarmLog>(alarmlogs).State = System.Data.Entity.EntityState.Modified;

                    cvcEntities.SaveChanges();
                }
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        //public bool SaveAlarmComments(string alarmId, string Comments,string ModuleId)
        //{
        //    try
        //    {
        //        CVCEntities cvcEntities = new CVCEntities();

        //        AlarmLog log = new AlarmLog();
        //        log.MachineId = Convert.ToInt32(ModuleId);
        //        log.AlarmId = Convert.ToInt32(alarmId);
        //        log.Comment = Comments;
        //        log.LoggedUserId = null;
        //        log.AlarmDateTime = DateTime.Now;
        //        log.BatchId = GetCurrentRunningBatch();
        //        cvcEntities.AlarmLogs.Add(log);
        //        cvcEntities.SaveChanges();

        //        AuditLog auditlog = new AuditLog();
        //        UserDefinition userDefinition = (UserDefinition)Authorization.UserDefinition;
        //        if (userDefinition != null)
        //        {
        //            auditlog.UserId = userDefinition.UserId;
        //            auditlog.UserName = userDefinition.Username;
        //        }

        //        auditlog.Action = "Alarm Comments Inserted";

        //        auditlog.ChangedOn = DateTime.Now;
        //        auditlog.Module = "Alarm";
        //        auditlog.Page = "Alarm Comments";
        //        auditlog.FieldName = "IsCommentRequired";
        //        auditlog.OldValue = "";
        //        auditlog.NewValue = Comments;
        //        log.BatchId = null;
        //        log.MachineId = Convert.ToInt32(ModuleId);
        //        cvcEntities.AuditLogs.Add(auditlog);
        //        cvcEntities.SaveChanges();

        //        int alarid = Convert.ToInt32(alarmId);

        //        var alarmlogs = cvcEntities.AlarmLogs.FirstOrDefault(a => a.AlarmId == alarid && a.Comment == null);

        //        alarmlogs.Comment = Comments;

        //        cvcEntities.Entry<AlarmLog>(alarmlogs).State = System.Data.Entity.EntityState.Modified;

        //        cvcEntities.SaveChanges();

        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        public int? GetMachineIdFromViewId(int viewId)
        {
            var machineId = 0;
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                machineId = cvcEntities?.Views?.FirstOrDefault(a => a.ViewsId == viewId)?.MachineId ?? 0;
            }
            if (machineId == 0 || machineId == null)
            {
                int? moduleId = 0;
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    moduleId = cvcEntities?.Views?.FirstOrDefault(a => a.ViewsId == viewId)?.ModuleId;
                }
                return GetMachineId(moduleId);
            }
            return machineId;
        }

        public bool? GetMachineRealTimeFromMachineId(int machineId)
        {
            bool? isRealTime;
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                isRealTime = cvcEntities?.Machines?.FirstOrDefault(a => a.MachineId == machineId)?.IsRealTime;
            }

            return isRealTime;
        }

        public int? GetModuleIdFromMachineId(int machineId)
        {
            int? moduleId = null;
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var module = cvcEntities.Modules.FirstOrDefault(a => a.MachineId == machineId);
                if (module != null)
                    moduleId = module.ModuleId;
            }
            return moduleId;
        }


        public int? GetMachineId(int? ModuleId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                return cvcEntities?.Modules?.FirstOrDefault(a => a.ModuleId == ModuleId)?.MachineId ?? 0;
            }
        }

        public int? GetMachineId(string ModuleId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                int modid = Convert.ToInt32(ModuleId);
                return cvcEntities?.Modules?.FirstOrDefault(a => a.ModuleId == modid)?.MachineId ?? 0;
            }
        }

        public string GetSerialNumber(int? machineId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {

                var machine = cvcEntities?.Machines?.FirstOrDefault(a => a.MachineId == machineId)?.SerialNumber;
                return machine == null ? "" : machine.ToString();
            }
        }


        public string GetEquipmentId(int? machineId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {

                var machine = cvcEntities.Machines.FirstOrDefault(a => a.MachineId == machineId).EquipmentID;

                return machine == null ? "" : machine.ToString();
            }
        }

        public async Task<List<DashBoardField>> GetMachineSettingsFieldAsync(int ModuleId)
        {

            var model = new SettingsPageModel();
            model.ModuleId = ModuleId;
            model.Views = new DashboardCommon().GetViewsByModule(model.ModuleId);
            int[] Viewsarray = model.Views.Select(a => a.Key).ToArray();


            List<DashBoardField> fields = new List<DashBoardField>();
            int readValueSequence = 0;
            var protocolName = string.Empty;

            ClsSiemensS7Net clsSiemensS7Net = new ClsSiemensS7Net();
            DashBoardViewModel dashBoardViewModel = new DashBoardViewModel();
            DashBoardField dashBoardField = new DashBoardField();
            List<DashBoardField> lstDashBoardField = new List<DashBoardField>();


            using (CVCEntities cvcEntities = new CVCEntities())
            {
                UserDefinition userDefinition = (UserDefinition)Authorization.UserDefinition;
                var runningbatch = GetCurrentRunningBatch();
                var module = cvcEntities.Modules.FirstOrDefault(a => a.ModuleId == ModuleId);
                var userDetails = cvcEntities.Users.FirstOrDefault(a => a.UserId == userDefinition.UserId);
                //  var ViewsAccess = cvcEntities.ViewsAccesses.FirstOrDefault(a => a.ViewsId == ViewId && a.StatusId == 1 && a.RoleId == userDetails.RoleId);
                ConnectMachine connect = new ConnectMachine(module.MachineId.Value);

                ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
                OPCUaClientViewModel oPCUaClientViewModel = new OPCUaClientViewModel();

                var ViewFields = new List<CVC.Data.EDMX.ViewField>();
                if (userDetails.RoleId == 1)
                {
                    ViewFields = (List<CVC.Data.EDMX.ViewField>)cvcEntities.ViewFields.Where(a => Viewsarray.Contains((int)a.ViewsId) && a.StatusId == 1).OrderBy(a => a.Sequence).ToList();

                    //  ViewFields = (List<CVC.Data.EDMX.ViewField>)cvcEntities.ViewFields.Where(a => Viewsarray.Contains((int)a.ViewsId) && a.StatusId == 1 && ((a.ViewFieldAccesses.Any(f => f.IsView == true && f.StatusId == 1)))).OrderBy(a => a.Sequence).ToList();
                }
                else
                {
                    ViewFields = (List<CVC.Data.EDMX.ViewField>)cvcEntities.ViewFields.Where(a => Viewsarray.Contains((int)a.ViewsId) && a.StatusId == 1 && ((a.ViewFieldAccesses.Any(f => f.IsView == true && f.StatusId == 1 && f.RoleId == userDetails.RoleId)))).OrderBy(a => a.Sequence).ToList();

                }

                //changed on 4 march 2019 12.46 pm  foreach (var item in cvcEntities.ViewFields.Where(a => Viewsarray.Contains((int)a.ViewsId) && a.StatusId == 1 && (Authorization.Username == "admin" || (a.ViewFieldAccesses.Any(f => f.IsView == true && f.StatusId == 1)))).OrderBy(a => a.Sequence))
                // foreach (var item in cvcEntities.ViewFields.Where(a => Viewsarray.Contains((int)a.ViewsId) && a.StatusId == 1 && ((a.ViewFieldAccesses.Any(f => f.IsView == true && f.StatusId == 1 && f.RoleId== userDetails.RoleId)))).OrderBy(a => a.Sequence))
                foreach (var item in ViewFields)
                {

                    var GetViewsAccess = cvcEntities.ViewsAccesses.FirstOrDefault(a => a.ViewsId == item.ViewsId && a.StatusId == 1 && a.RoleId == userDetails.RoleId);

                    var IsViewAccess = true;

                    if (GetViewsAccess != null && userDetails.RoleId != 1)
                    {
                        IsViewAccess = GetViewsAccess?.IsView ?? false;
                    }

                    if (IsViewAccess)
                        if (item.MachineParameter != null)
                        {
                            if (readValueSequence == 0)
                            {
                                protocolName = item?.MachineParameter?.Machine?.MachineCommunications?.FirstOrDefault()?.Protocol?.ProtocolName;
                                System.Web.HttpContext.Current.Cache.Remove("ProtocolType");
                                System.Web.HttpContext.Current.Cache["ProtocolType"] = protocolName.ToUpper();
                                if (protocolName.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                                {
                                    oPCUaClientViewModel.ServerAddress = item.MachineParameter.Machine.MachineCommunications.FirstOrDefault().IPAddress;
                                    oPCUaClientViewModel.ServerPortNumber = Convert.ToString(item.MachineParameter.Machine.MachineCommunications.FirstOrDefault().TCPIPPort);
                                    oPCUaClientViewModel.UserName = item.MachineParameter.Machine.MachineCommunications.FirstOrDefault().UserName;
                                    oPCUaClientViewModel.Password = item.MachineParameter.Machine.MachineCommunications.FirstOrDefault().Password;

                                }
                                else if (protocolName.ToUpper() == ProtocolType.SiemensS7Net.ToUpper())
                                {
                                    dashBoardViewModel = new bs.CommonServices().GetDashBoardViewModel(item.MachineParameter.Machine.MachineCommunications.FirstOrDefault());
                                }

                                var machineCommunication = item.MachineParameter.Machine.MachineCommunications.FirstOrDefault();
                                MachineCommunicationViewModel machineCommunicationViewModel = new MachineCommunicationViewModel
                                {
                                    ProtocolTypeName = machineCommunication?.Protocol?.ProtocolName,
                                    IPAddress = machineCommunication.IPAddress,
                                    TCPIPPort = machineCommunication.TCPIPPort,
                                    MDBPath = machineCommunication.MDBPath,
                                    UserName = machineCommunication.UserName,
                                    Password = machineCommunication.Password,
                                    Rack = machineCommunication.Rack,
                                    Slot = machineCommunication.Slot,
                                    CpuType = machineCommunication?.PickListValue6?.PickList?.PickListName

                                };

                                ObjectCache cache = MemoryCache.Default;
                                cache.Remove(ClsCacheConfig.CacheKeys.MachineCommunication);
                                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                                cacheItemPolicy.AbsoluteExpiration = ClsCacheConfig.CacheExpiry.CacheExpiryTime;
                                cache.Add(ClsCacheConfig.CacheKeys.MachineCommunication, machineCommunicationViewModel, cacheItemPolicy);
                            }


                            // If This Fields Does not belongs to This Machine the countinue
                            if (item.MachineParameter.MachineId != module.MachineId)
                                continue;


                            if (userDetails.RoleId != 1)
                            {
                                if (item.ViewFieldAccesses?.FirstOrDefault(vfa => vfa.RoleId == userDetails.RoleId && vfa.ViewFieldId == item.ViewField1 && vfa.ViewsId == item.ViewsId)?.IsView == false)
                                {
                                    continue;
                                }

                            }


                            DashBoardField addItem = new DashBoardField();
                            addItem.ViewsId = (int)item.ViewsId;
                            addItem.ViewName = cvcEntities.Views.FirstOrDefault(a => a.ViewsId == item.ViewsId && a.StatusId == 1).ViewName;
                            addItem.MachineParameterId = item.MachineParameterId.Value;
                            if (item.MachineParameter.Type != null)
                                addItem.Type = item.MachineParameter.Type.Value;
                            addItem.ParameterName = item.ViewFieldName;
                            addItem.DateTypeId = item.MachineParameter.DataTypeId.Value;


                            if (item.MachineParameter.PickListValue != null)
                                addItem.UnitName = item.MachineParameter.PickListValue.PickListValueName;
                            addItem.IsRangeUnlimited = item.MachineParameter.IsRangeUnlimited.Value;
                            if (item.MachineParameter.Min != null)
                                addItem.Min = item.MachineParameter.Min.Value;
                            if (item.MachineParameter.Max != null)
                                addItem.Max = item.MachineParameter.Max.Value;

                            var ViewsAccess = cvcEntities.ViewsAccesses.FirstOrDefault(a => a.ViewsId == item.ViewsId && a.StatusId == 1 && a.RoleId == userDetails.RoleId);
                            // If User Dont Have View Modify Access For Role Then 
                            if (ViewsAccess != null)
                                if (ViewsAccess.IsModify == false)
                                    addItem.IsModify = false;
                                else
                                {

                                    addItem.IsModify = item.ViewFieldAccesses?.FirstOrDefault(vfa => vfa.RoleId == userDetails.RoleId && vfa.ViewFieldId == item.ViewField1 && vfa.ViewsId == item.ViewsId)?.IsModify ?? false;


                                    //if (item.ViewFieldAccesses.Any(a => a.IsModify == false && a.StatusId == 1))
                                    //    addItem.IsModify = false;
                                    //else
                                    //    addItem.IsModify = true;
                                }
                            // If Is Read is Checked Then Only Read Value
                            if (item.MachineParameter.IsRead == true)
                            {
                                // In Case Of MDB Call MDB   
                                int? machineparaId = addItem.MachineParameterId;
                                // if (item.MachineParameter.Machine.MachineCommunications.Any(a => a.ProtocolTypeId == 4 && a.StatusId == 1))

                                if (protocolName.ToUpper() == ProtocolType.MDB.ToUpper())
                                {
                                    // In Case of Button and Read Is Set from Another Field
                                    if (item.MachineParameter.Type == 49 && item.MachineParameter.ReadMachineParameterId != null)
                                        machineparaId = item.MachineParameter.ReadMachineParameterId.Value;
                                    else if (item.MachineParameter.Type == 49 && item.MachineParameter.ReadMachineParameterId == null)
                                        machineparaId = null; // In Case of Button and No Read send Value as Blank
                                    if (machineparaId != null)
                                        addItem.Value = connect.Read(machineparaId.Value);

                                    //addItem.IsConnected = connect.CheckModBusConnection(machineparaId.Value) == true ? true : false;
                                }
                                //  else if (item.MachineParameter.Machine.MachineCommunications.Any(a => a.ProtocolTypeId == 1 && a.StatusId == 1))
                                else if (protocolName.ToString().Contains(ProtocolType.Modbus.ToUpper()))
                                {
                                    addItem.Value = connect.Read(machineparaId.Value);
                                    //addItem.IsConnected = connect.CheckModBusConnection(machineparaId.Value) == true ? true : false;
                                }
                                else if (protocolName.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                                {
                                    addItem.NodeId = item.MachineParameter.IPCParameters.FirstOrDefault().NodeId;
                                    addItem.AttributeId = item.MachineParameter.IPCParameters.FirstOrDefault().AttributeId;
                                    addItem.IPCAddress = ProtocolType.OPCUaClient.ToUpper();
                                    oPCUaClientViewModel.NodeId = addItem.NodeId;
                                    oPCUaClientViewModel.AttributeId = Convert.ToUInt32(addItem.AttributeId);
                                    oPCUaClientViewModel.MachineId = module.MachineId.Value;
                                    addItem.Value = clsOpcUaClient.Read(oPCUaClientViewModel);
                                }
                                else if (protocolName.ToUpper() == ProtocolType.SiemensS7Net.ToUpper())
                                {
                                    addItem.IPCAddress = item?.MachineParameter?.IPCParameters?.FirstOrDefault()?.IPCAddress;

                                    dashBoardField.IPCAddress = item?.MachineParameter?.IPCParameters?.FirstOrDefault()?.IPCAddress;
                                    dashBoardField.DataTypeName = item?.MachineParameter?.DataType?.DataTypeName;
                                    lstDashBoardField.Add(dashBoardField);
                                    dashBoardViewModel.ViewFieldList = lstDashBoardField;
                                    addItem.Value = await clsSiemensS7Net.Read(dashBoardViewModel);
                                }

                            }



                            // If IsWrite Is false Then Dont allow Field to be modify
                            if (item.MachineParameter.IsWrite == false)
                                addItem.IsModify = false;
                            else if (Authorization.Username == "admin")
                                addItem.IsModify = true;

                            // If batch not Running then disable control
                            if (item.MachineParameter.IsBatchStartRequired == true && runningbatch == null)
                                addItem.IsDisabled = true;

                            //changes added by Vinayak

                            if (item?.MachineParameter?.IPCParameters?.FirstOrDefault()?.IsBatchStartRequiredIPC == true)
                            {
                                addItem.IsDisabled = true;
                            }

                            //ended by Vinayak

                            // If disabled is set disable field
                            if (item.MachineParameter.DisableParameterId != null)
                            {
                                if (connect.Read(item.MachineParameter.DisableParameterId.Value, dashBoardViewModel) == item.MachineParameter.DisableParameterValue)
                                    addItem.IsDisabled = true;
                            }
                            if (item.MachineParameter.AllowDecimalPoint != null)
                                addItem.AllowDecimalPoint = item.MachineParameter.AllowDecimalPoint.Value;

                            if (item.MachineParameter.IPCParameters.FirstOrDefault().IPCAddress != null)
                            {
                                addItem.IPCAddress = item.MachineParameter.IPCParameters.FirstOrDefault().IPCAddress;
                            }
                            if (item.MachineParameter.IPCParameters.FirstOrDefault().OperationTypeIPC != null)
                            {
                                addItem.OperationTypeIPC = item.MachineParameter.IPCParameters.FirstOrDefault()?.OperationTypeIPC ?? 0;
                                addItem.OperationTypeName = cvcEntities.PickListValues?.FirstOrDefault(pl => pl.PickListValueId == addItem.OperationTypeIPC)?.PickListValueName;
                            }
                            if (item.MachineParameter.IPCParameters.FirstOrDefault().OperationValueIPC != null)
                            {
                                addItem.OperationValueIPC = item.MachineParameter.IPCParameters.FirstOrDefault().OperationValueIPC;
                                if (addItem.OperationValueIPC != null)
                                    addItem.OperationValueIPC = IntegerExtension(addItem.OperationValueIPC);

                            }

                            addItem.DataTypeId = item.MachineParameter.DataTypeId;
                            addItem.DataTypeName = item?.MachineParameter?.DataType?.DataTypeName?.ToLower();

                            addItem.IsByteSwap = item.MachineParameter.IPCParameters.FirstOrDefault().IsByteSwap;
                            addItem.IsWordSwap = item.MachineParameter.IPCParameters.FirstOrDefault().IsWordSwap;
                            addItem.Is32Bit = item.MachineParameter.IPCParameters.FirstOrDefault().Is32Bit;
                            addItem.IsBitWise = item.MachineParameter.IPCParameters.FirstOrDefault().IsBitWise;
                            addItem.Bit32Address = item.MachineParameter.IPCParameters.FirstOrDefault().Bit32Address;
                            addItem.BitWiseIndex = item.MachineParameter.IPCParameters.FirstOrDefault().BitWiseIndex;
                            addItem.IsMachineSpeed = item.MachineParameter.IPCParameters.FirstOrDefault().IsMachineSpeed;
                            addItem.IsLabelRollIPC = item.MachineParameter.IPCParameters.FirstOrDefault().IsLabelRollIPC;
                            addItem.IsRefreshMachineSettings = item.MachineParameter.IPCParameters.FirstOrDefault().IsRefreshMachineSettings;

                            addItem.IsPopUpRequired = cvcEntities.ViewFields.FirstOrDefault(vf => vf.MachineParameterId == item.MachineParameterId.Value)?.IsPopUpRequired ?? false;
                            addItem.IsCommentRequired = cvcEntities.ViewFields.FirstOrDefault(vf => vf.MachineParameterId == item.MachineParameterId.Value)?.IsCommentRequired ?? false;
                            addItem.IsAuthenticationRequired = cvcEntities.ViewFields.FirstOrDefault(vf => vf.MachineParameterId == item.MachineParameterId.Value)?.IsAuthenticationRequired ?? false;
                            addItem.IsAuthorisedRole = cvcEntities.ViewFieldAuthentications.FirstOrDefault(vfa => vfa.RoleId == userDetails.RoleId && vfa.ViewFieldId == item.ViewField1) == null ? false : true;
                            addItem.ViewFieldId = item.ViewField1;
                            var Roles = cvcEntities.ViewFieldAuthentications.Where(vf => vf.ViewFieldId == item.ViewField1).Select(vf => vf.Role.RoleName).ToArray();
                            addItem.RoleNames = Roles != null ? string.Join(",", Roles.Select(x => x.ToString()).ToArray()) : "NA";
                            var IPCParameters = cvcEntities.IPCParameters?.FirstOrDefault(i => i.MachineId == module.MachineId && i.IsWriteToPLC == true);
                            if (IPCParameters != null)
                            {
                                addItem.WriteToPLCIPCMachineParameterId = IPCParameters.MachineParameterId;
                            }

                            addItem.IsIndicatorParameter = cvcEntities.IPCParameters.FirstOrDefault(vf => vf.MachineParameterId == item.MachineParameterId.Value)?.IsIndicatorParameter ?? false;
                            if (addItem.IsIndicatorParameter == true)
                            {
                                var IndicatorParameterId = cvcEntities.IPCParameters.FirstOrDefault(vf => vf.MachineParameterId == item.MachineParameterId.Value)?.IndicatorParameterId ?? null;
                                var GetIPCParameters = cvcEntities.IPCParameters.FirstOrDefault(vf => vf.MachineParameterId == IndicatorParameterId);
                                if (GetIPCParameters != null)
                                {
                                    if (protocolName.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                                    {
                                        addItem.NodeId = GetIPCParameters.NodeId;
                                        addItem.AttributeId = GetIPCParameters.AttributeId;
                                        addItem.IPCAddress = ProtocolType.OPCUaClient.ToUpper();
                                        addItem.DataTypeId = GetIPCParameters.MachineParameter.DataTypeId;
                                        addItem.Bit32Address = GetIPCParameters.Bit32Address;
                                        addItem.BitWiseIndex = GetIPCParameters.BitWiseIndex;
                                        addItem.IsBitWise = GetIPCParameters.IsBitWise;

                                    }
                                    else
                                    {

                                        addItem.IPCAddress = GetIPCParameters.IPCAddress;
                                        addItem.DataTypeId = GetIPCParameters.MachineParameter.DataTypeId;
                                        addItem.Bit32Address = GetIPCParameters.Bit32Address;
                                        addItem.BitWiseIndex = GetIPCParameters.BitWiseIndex;
                                        addItem.IsBitWise = GetIPCParameters.IsBitWise;
                                    }
                                }
                            }


                            if (userDetails.RoleId != 1)
                            {
                                if (ViewsAccess != null)
                                {
                                    if (ViewsAccess.IsModify == false || ViewsAccess.IsModify == null)
                                    {
                                        addItem.IsDisabled = false;
                                    }
                                    else
                                    {
                                        addItem.IsDisabled = item.ViewFieldAccesses?.FirstOrDefault(vfa => vfa.RoleId == userDetails.RoleId && vfa.ViewFieldId == item.ViewField1 && vfa.ViewsId == item.ViewsId)?.IsModify == false ? true : false;
                                    }

                                }

                            }
                            addItem.ReadValueSequence = readValueSequence;
                            readValueSequence++;
                            fields.Add(addItem);
                        }
                }
            }
            return fields;
        }

        public decimal? IntegerExtension(decimal? Number)
        {
            var Value = string.Format("{0:0.00}", Number);

            if (Value.EndsWith("00"))
            {
                return ((int)Number);
            }
            else
            {
                return Number;
            }
        }

        public static string GetBatchStatus(int BatchId)
        {
            if (BatchId > 0)
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    return cvcEntities.Batches.Where(a => a.BatchId == BatchId).Select(a => a.BatchStatus).FirstOrDefault();
                }
            }
            return "Create New Batch";

        }

        //public string ReadPLC(int machineParaId)
        //{
        //    string str = "";
        //    using (CVCEntities cvcEntities = new CVCEntities())
        //    {
        //        using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
        //        {



        //            if (machineCommunication != null)
        //            {
        //                var ipcpara = machinePara.IPCParameters;
        //                if (ipcpara.Any())
        //                {
        //                    string address = ipcpara.FirstOrDefault().IPCAddress;

        //                    modbusTCP.IPAddress = machineCommunication.IPAddress;
        //                    modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
        //                    modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;

        //                    if (machinePara.DataTypeId == 9) // Siemens Float or SWAP FLOAT
        //                    {
        //                        // this.modbusTCP.SwapWords = true;
        //                        address = "F" + address;
        //                    }

        //                    if (machinePara.DataTypeId == 10) //D-WORD
        //                    {
        //                        // this.modbusTCP.SwapWords = false;
        //                        address = "U" + address;
        //                    }

        //                    if (machinePara.DataTypeId == 8) //WORD
        //                    {
        //                        // this.modbusTCP.SwapWords = false;
        //                        address = "L" + address;
        //                    }

        //                    if (ipcpara.FirstOrDefault().IsByteSwap == true)
        //                    {
        //                        modbusTCP.SwapBytes = true;
        //                    }

        //                    if (ipcpara.FirstOrDefault().IsWordSwap == true)
        //                    {
        //                        modbusTCP.SwapWords = true;
        //                    }

        //                    str = modbusTCP.Read(address);

        //                    //System.Threading.Thread.Sleep(50);

        //                    //if (string.IsNullOrEmpty(str))
        //                    //{
        //                    //    goto LblModBusRead;
        //                    //}

        //                    if (ipcpara.FirstOrDefault().Is32Bit == true)
        //                    {
        //                        string lowerbit = DecimalToBinary(int.Parse(str));
        //                        string higherbit = DecimalToBinary(int.Parse(modbusTCP.Read(ipcpara.FirstOrDefault().Bit32Address)));
        //                        str = Convert.ToInt32(higherbit + lowerbit, 2).ToString();
        //                    }

        //                    if (ipcpara.FirstOrDefault().IsBitWise == true)
        //                    {
        //                        string binaryValue = DecimalToBinary(int.Parse(str));
        //                        str = ReverseString(binaryValue).ToString().Substring(ipcpara.FirstOrDefault().BitWiseIndex.Value, 1);
        //                    }

        //                    var OperationValueIPC = Convert.ToDecimal(0.0);
        //                    if (machinePara.IPCParameters.FirstOrDefault().OperationValueIPC != null)
        //                    {

        //                        OperationValueIPC = (decimal)IntegerExtension(machinePara.IPCParameters.FirstOrDefault().OperationValueIPC.Value);

        //                    }

        //                    if (machinePara.IPCParameters.FirstOrDefault().OperationTypeIPC == 50)
        //                    {
        //                        str = (Decimal.Parse(str) - OperationValueIPC).ToString();
        //                    }
        //                    if (machinePara.IPCParameters.FirstOrDefault().OperationTypeIPC == 51)
        //                    {
        //                        str = (Decimal.Parse(str) + OperationValueIPC).ToString();
        //                    }
        //                    if (machinePara.IPCParameters.FirstOrDefault().OperationTypeIPC == 52)
        //                    {
        //                        str = (Math.Round(Decimal.Parse(str) / OperationValueIPC, 2)).ToString();
        //                    }
        //                    if (machinePara.IPCParameters.FirstOrDefault().OperationTypeIPC == 53)
        //                    {
        //                        str = (Decimal.Parse(str) * OperationValueIPC).ToString();
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return str;
        //}

        #region Sr.No.79 SendHeartBeat 

        public int SendHeartBeat(int Value)
        {
            try
            {

                return WriteHeartBeat(Value.ToString());

            }
            catch
            {



            }
            finally
            {
                // MachineParameterId = 0;
                // Value = 0;
                // IncrementalNumber = 0;
                //EndNumber = 0;


            }
            return Value;

        }

        public int WriteHeartBeat(string Value)
        {
            string address = string.Empty;
            // var CommandPanel = new CommandPanelPageModel();
            var machineCommunication = new MachineCommunicationViewModel();
            string value32bit = string.Empty;
            var binary32bit = string.Empty;
            string binaryValue = string.Empty;
            var sendHeartBeatViewModel = new SendHeartBeatViewModel();
            using (CVCEntities cvcEntities = new CVCEntities())

            {
                try
                {
                    // var protocolType = (string)System.Web.HttpContext.Current.Cache["ProtocolType"];2017

                    var protocolType = (string)System.Web.HttpRuntime.Cache["ProtocolType"];
                    if (protocolType.Contains(ProtocolType.Modbus.ToUpper()))
                    {
                        using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
                        {

                            sendHeartBeatViewModel = (SendHeartBeatViewModel)HttpRuntime.Cache["SendHeartBeatModelCache"];

                            address = sendHeartBeatViewModel.IPCAddress;

                            if (sendHeartBeatViewModel.DataTypeId == 2) // Bit Momentary
                            {
                                Value = "1";
                            }
                            else if (sendHeartBeatViewModel.DataTypeId == 3) // Bit Reset
                            {
                                Value = "0";
                            }
                            else if (sendHeartBeatViewModel.DataTypeId == 4) // Bit Set
                            {
                                Value = "1";
                            }
                            else
                            {
                                address = GetFormatedIPCAddress(address, sendHeartBeatViewModel?.DataTypeId ?? 0);
                            }


                            if (sendHeartBeatViewModel.IsByteSwap == true)
                            {
                                modbusTCP.SwapBytes = true;
                            }


                            if (sendHeartBeatViewModel.IsWordSwap == true)
                            {
                                modbusTCP.SwapWords = true;
                            }

                            //   CommandPanel = (CommandPanelPageModel)HttpContext.Current.Cache["CommandPanel"];
                            // CommandPanel = (CommandPanelPageModel)HttpRuntime.Cache["CommandPanel"];
                            bs.CommonServices commonServices = new bs.CommonServices();
                            machineCommunication = commonServices.GetCacheData(ClsCacheConfig.CacheKeys.MachineCommunication);

                            modbusTCP.IPAddress = machineCommunication.IPAddress;
                            modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
                            modbusTCP.PollRateOverride = machineCommunication?.PollRate ?? 0;
                            Value = Value == "-1" ? Convert.ToString(sendHeartBeatViewModel.StartNumber) : Value;
                            modbusTCP.Write(address, Value);
                        }
                    }
                    else if (protocolType == ProtocolType.OPCUaClient.ToUpper())
                    {
                        ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
                        clsOpcUaClient.Write(sendHeartBeatViewModel.NodeId, sendHeartBeatViewModel.AttributeId, Value);
                    }

                    else if (protocolType == ProtocolType.SiemensS7Net.ToUpper())
                    {
                        var getMachineCommunication = new bs.CommonServices().GetCacheData(ClsCacheConfig.CacheKeys.MachineCommunication);

                        DashBoardField dashBoardField = new DashBoardField
                        {
                            IPCAddress = sendHeartBeatViewModel.IPCAddress,
                            DataTypeName = sendHeartBeatViewModel.DataTypeName,
                            Value = sendHeartBeatViewModel?.Value?.ToString()
                        };
                        List<DashBoardField> lstDashBoardFields = new List<DashBoardField>();
                        lstDashBoardFields.Add(dashBoardField);
                        DashBoardViewModel dashBoardViewModel = new DashBoardViewModel
                        {
                            IPAddress = machineCommunication.IPAddress,
                            TCPIPPort = machineCommunication.TCPIPPort,
                            CpuType = machineCommunication.CpuType,
                            Rack = machineCommunication.Rack,
                            Slot = machineCommunication.Slot,
                            ViewFieldList = lstDashBoardFields

                        };
                        ClsSiemensS7Net clsSiemensS7Net = new ClsSiemensS7Net();
                        clsSiemensS7Net.Write(dashBoardViewModel);
                    }


                    Value = Convert.ToInt32(Value) == sendHeartBeatViewModel.EndNumber ? "0" : Value;
                    return (sendHeartBeatViewModel.EndNumber == 1 ? (Convert.ToInt32(Value) == 0 ? 1 : 0) : (Convert.ToInt32(Value) + 1));
                    //Value = (sendHeartBeatViewModel.EndNumber == 1 ? (Convert.ToInt32( Value) == 0 ? 1 : 0) : (Value + sendHeartBeatViewModel.IncrementalNumber));

                }
                catch (System.Exception ex)
                {
                    ex = null;

                }
                finally
                {

                    Value = string.Empty;
                    address = string.Empty;
                    machineCommunication = null;
                    //CommandPanel = null;
                    value32bit = string.Empty;
                    binary32bit = string.Empty;
                    binaryValue = string.Empty;
                    sendHeartBeatViewModel = null;

                }
                return (sendHeartBeatViewModel.EndNumber == 1 ? (Convert.ToInt32(Value) == 0 ? 1 : 0) : (Convert.ToInt32(Value) + 1));
            }

        }
        #endregion

        public string DecimalToBinary32(long num)
        {
            long quot;
            string rem = string.Empty;
            while (num >= 1)
            {
                quot = num / 2;
                rem += (num % 2).ToString();
                num = quot;
            }
            string bin = "";
            for (int i = rem.Length - 1; i >= 0; i--)
            {
                bin = bin + rem[i];
            }
            int len = (32 - bin.Length);
            for (int i = 0; i < len; i++)
                bin = "0" + bin;
            return bin;
        }

        public string DecimalToBinary(int num)
        {
            string rem = "";
            string bin = "";
            try
            {
                int quot;

                while (num >= 1)
                {
                    quot = num / 2;
                    rem += (num % 2).ToString();
                    num = quot;
                }

                for (int i = rem.Length - 1; i >= 0; i--)
                {
                    bin = bin + rem[i];
                }
                int len = (16 - bin.Length);
                for (int i = 0; i < len; i++)
                    bin = "0" + bin;

                rem = null;
                return bin;
            }
            catch (System.Exception ex)
            {
                ex = null;
            }
            finally
            {
                rem = null;
                bin = null;
            }
            return bin;
        }

        public string GetFormatedIPCAddress(string IPCAddress, int DataTypeId)
        {
            try
            {
                switch (DataTypeId)
                {
                    case 1:
                    case 10:
                        IPCAddress = "U" + IPCAddress;
                        break;
                    case 5:
                    case 8:
                        IPCAddress = "L" + IPCAddress;
                        break;
                    case 9:
                        IPCAddress = "F" + IPCAddress;
                        break;
                    default:
                        break;
                }
                return IPCAddress;
            }
            catch (System.Exception ex)
            {
                ex = null;
            }
            finally
            {
                IPCAddress = null;
            }
            return IPCAddress;


        }

        public static bool CheckValidUser(string UserName, string Password)
        {
            using (CVC.BusinessServices.Common.CommonServices objCommonServices = new CVC.BusinessServices.Common.CommonServices())
            {

                Tuple<bool, int?> AuthenticateData = objCommonServices.AuthenticateUserByLogin(UserName, Password);

                if (AuthenticateData.Item1 == false)
                {
                    return false;

                }

            }
            return true;

        }

        public static User GetUserDetailsByUserName(string UserName)
        {
            using (CVCEntities cVCEntities = new CVCEntities())
            {

                return cVCEntities.Users.FirstOrDefault(u => u.Username == UserName);


            }

        }

    }
}
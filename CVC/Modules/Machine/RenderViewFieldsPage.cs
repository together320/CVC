// Decompiled with JetBrains decompiler
// Type: CVC.Machine.Pages.RenderViewFieldsController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using AdvancedHMIDrivers;
using CVC.BusinessServices.Common;
using CVC.Data;
using CVC.Data.EDMX;
using CVC.MDB;
using CVC.Modules.Common.Dashboard;
using CVC.Modules.Common.MachineDashboard;
using CVC.Modules;
using CVC.OpcUaClient;
using CVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Web.Mvc;
using System.Web.SessionState;
using static CVC.BusinessServices.Common.ClsConstants;
using ms = CVC.Modules.Common.CommonServices;
using System.Threading.Tasks;
using CVC.SiemensS7Net;

namespace CVC.Machine.Pages
{
    [RoutePrefix("RenderViewFieldsMachine")]
    [Route("{action=index}")]
    [SessionState(SessionStateBehavior.Disabled)]

    public class RenderViewFieldsController : Controller
    {
        CommonServices objCommonServices;

       public RenderViewFieldsController()
        {
            objCommonServices = new CommonServices();

        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult> Index(int ModuleId, int ViewId,bool ForLabelRollView)
        {
            if(ForLabelRollView == true)
            {
                RenderViewFieldsPageModel Model = new RenderViewFieldsPageModel();
                return (ActionResult)this.View("~/Modules/Machine/RenderViewFields.cshtml", (object)Model);

            }

            if (HttpContext.Cache["MachineSettings"] != null)
            {
                int CacheModuleId = (int)HttpContext.Cache["ActiveModuleId"];
                if (CacheModuleId != ModuleId)
                {
                    return await GetSettingsPanelDataAsync(ModuleId,ViewId);
                }


                RenderViewFieldsPageModel Model = ReadSettingsPanel(ModuleId, ViewId, false);
               // RenderViewFieldsPageModel Model = new RenderViewFieldsPageModel();
                Model = (RenderViewFieldsPageModel)HttpContext.Cache["MachineSettings"];
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    var recipe = new DashboardCommon().GetRecepe(ModuleId);
                    Model.RecipeId = recipe.Item1;
                    Model.RecipeName = recipe.Item2;
                    Model.IsMachineSettings = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == ModuleId && a.ViewsId == ViewId)?.IsMachineSettings ?? false;
                    Model.MachineSettingsViewId = ViewId;
                    Model.LstViewId = cvcEntities.Views.Where(vs => vs.ModuleId == ModuleId && vs.StatusId == (int)ClsConstants.StatusType.Active).OrderByDescending(vs => vs.IsMachineSettings).Select(vs => vs.ViewsId).Distinct().ToList();
                    var GetLabelRollDetails = cvcEntities.Views?.FirstOrDefault(a => a.ModuleId == ModuleId && a.IslabelRoll == true) ?? null;
                    if (GetLabelRollDetails != null)
                    {
                        Model.IsLabelRoll = GetLabelRollDetails?.IslabelRoll ?? false;
                        Model.LabelRollViewId = GetLabelRollDetails.ViewsId;

                    }

                }

                return (ActionResult)this.View("~/Modules/Machine/RenderViewFields.cshtml", (object)Model);
            }
            else
            {
                return await GetSettingsPanelDataAsync (ModuleId, ViewId);
            }
            //else
            //{
            //    var Model = new RenderViewFieldsPageModel() { ModuleId = ModuleId, ViewId = ViewId };
            //    Model.ViewFieldList = new DashboardCommon().GetMachineSettingsField(ModuleId);
            //    if (ViewId < 0)
            //        Model.ViewName = "Machine Dashboard";
            //    else
            //        Model.ViewName = new DashboardCommon().GetViewName(ViewId);
            //    if (/*ViewId == 1*/ ViewId > 0)
            //    {
            //        var rec = new DashboardCommon().GetRecepe(ModuleId);
            //        Model.RecipeId = rec.Item1;
            //        Model.RecipeName = rec.Item2;
            //    }
            //    if (Model.ViewFieldList.Count > 0)
            //    {
            //        Model.MachineParameterId = Model.ViewFieldList.Where(a => a.MachineParameterId > 0).FirstOrDefault().MachineParameterId;

            //        var machineCommunication = new CVC.BusinessServices.Common.CommonServices().GetMachineCommunicationDetails(Model.MachineParameterId);
            //        if (machineCommunication != null)
            //        {
            //            Model.MachineType = machineCommunication.Protocol.ProtocolName;
            //            if (Model.MachineType.ToUpper() == "MDB")
            //            {
            //                Model.MDBPath = machineCommunication.MDBPath;
            //            }
            //            else
            //            {
            //                Model.IPAddress = machineCommunication.IPAddress;
            //                Model.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
            //                Model.PollRateOverride = machineCommunication?.PollRate ?? 100;
            //            }
            //        }


            //        RenderViewFieldsPageModel objRenderViewFieldsPageModel = (RenderViewFieldsPageModel)Model.Clone();
            //        HttpContext.Cache.Remove("MachineSettings");
            //        HttpContext.Cache["MachineSettings"] = objRenderViewFieldsPageModel;
            //        //24 apr 2019 3.54 pm Model.ViewFieldList = Model.ViewFieldList.Where(v => v.ViewsId == ViewId).ToList();
                    

            //    }
            //    else
            //    {
            //        HttpContext.Cache.Remove("MachineSettings");
            //    }
            //    using (CVCEntities cvcEntities = new CVCEntities())
            //    {
            //        Model.IsMachineSettings = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == ModuleId && a.ViewsId == ViewId)?.IsMachineSettings ?? false;
            //        Model.MachineSettingsViewId = ViewId;
            //        Model.LstViewId = cvcEntities.Views.Where(vs=>vs.ModuleId==ModuleId && vs.StatusId== (int)ClsConstants.StatusType.Active).OrderByDescending(vs=>vs.IsMachineSettings).Select(vs => vs.ViewsId).Distinct().ToList();
            //        var GetLabelRollDetails = cvcEntities.Views?.FirstOrDefault(a => a.ModuleId == ModuleId && a.IslabelRoll == true) ?? null;
            //        if(GetLabelRollDetails!=null)
            //        {
            //            Model.IsLabelRoll = GetLabelRollDetails?.IslabelRoll??false;
            //            Model.LabelRollViewId = GetLabelRollDetails.ViewsId;

            //        }

            //    }
            //    //  Model.LstViewId = Model.ViewFieldList.Select(vf => vf.ViewsId).Distinct().ToList();

            //    return (ActionResult)this.View("~/Modules/Machine/RenderViewFields.cshtml", (object)Model);
            //}
        }
    
        public async Task<ActionResult> GetSettingsPanelDataAsync(int ModuleId, int ViewId)
        {

                var Model = new RenderViewFieldsPageModel() { ModuleId = ModuleId, ViewId = ViewId };
                Model.ViewFieldList =await new DashboardCommon().GetMachineSettingsFieldAsync(ModuleId);
                if (ViewId < 0)
                    Model.ViewName = "Machine Dashboard";
                else
                    Model.ViewName = new DashboardCommon().GetViewName(ViewId);
                if (/*ViewId == 1*/ ViewId > 0)
                {
                    var rec = new DashboardCommon().GetRecepe(ModuleId);
                    Model.RecipeId = rec.Item1;
                    Model.RecipeName = rec.Item2;
                    Model.PackName =string.IsNullOrEmpty(Model.RecipeId)?"": new DashboardCommon().GetPackNameByPackId(Convert.ToInt32(Model?.RecipeId??"0"));
                }
                if (Model.ViewFieldList.Count > 0)
                {
                    Model.MachineParameterId = Model.ViewFieldList.Where(a => a.MachineParameterId > 0).FirstOrDefault().MachineParameterId;

                    var machineCommunication = new CVC.BusinessServices.Common.CommonServices().GetMachineCommunicationDetails(Model.MachineParameterId);
                    if (machineCommunication != null)
                    {
                        Model.ProtocolType = machineCommunication.Protocol.ProtocolName;
                        Model.IPAddress = machineCommunication.IPAddress;
                        Model.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
                        Model.PollRateOverride = machineCommunication?.PollRate ?? 100;

                    if (Model.ProtocolType.ToUpper() ==ProtocolType.MDB.ToUpper())
                        {
                            Model.MDBPath = machineCommunication.MDBPath;
                        }
                      else if ( (Model.ProtocolType.ToUpper() == ProtocolType.OPCUaClient.ToUpper()))
                      {
                          
                            Model.UserName = machineCommunication.UserName;
                            Model.Password = machineCommunication.Password;
                    }
                    else if (Model.ProtocolType.ToUpper() == ProtocolType.SiemensS7Net.ToUpper())
                    {
                        Model.CpuType = machineCommunication?.PickListValue6?.PickList?.PickListName;
                        Model.Rack = machineCommunication.Rack;
                        Model.Slot = machineCommunication.Slot;
                    }

                }


                RenderViewFieldsPageModel objRenderViewFieldsPageModel = (RenderViewFieldsPageModel)Model.Clone();
                    HttpContext.Cache.Remove("MachineSettings");
                    HttpContext.Cache["MachineSettings"] = objRenderViewFieldsPageModel;
                    //24 apr 2019 3.54 pm Model.ViewFieldList = Model.ViewFieldList.Where(v => v.ViewsId == ViewId).ToList();


                }
                else
                {
                    HttpContext.Cache.Remove("MachineSettings");
                }
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    Model.IsMachineSettings = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == ModuleId && a.ViewsId == ViewId)?.IsMachineSettings ?? false;
                    Model.MachineSettingsViewId = ViewId;
                    Model.LstViewId = cvcEntities.Views.Where(vs => vs.ModuleId == ModuleId && vs.StatusId == (int)ClsConstants.StatusType.Active).OrderByDescending(vs => vs.IsMachineSettings).Select(vs => vs.ViewsId).Distinct().ToList();
                    var GetLabelRollDetails = cvcEntities.Views?.FirstOrDefault(a => a.ModuleId == ModuleId && a.IslabelRoll == true) ?? null;
                    if (GetLabelRollDetails != null)
                    {
                        Model.IsLabelRoll = GetLabelRollDetails?.IslabelRoll ?? false;
                        Model.LabelRollViewId = GetLabelRollDetails.ViewsId;

                    }
                var machineId = cvcEntities.Modules.FirstOrDefault(m => m.ModuleId == ModuleId).MachineId;
                 var isWrite = cvcEntities.TerminalMachineMappings.FirstOrDefault(mtm => mtm.MachineId == machineId)?.MasterTerminal.TerminalType.IsWrite??false;
                Model.isWriteTerminalType = isWrite;
            }
            //  Model.LstViewId = Model.ViewFieldList.Select(vf => vf.ViewsId).Distinct().ToList();

            var roleId = 0;
            if(Session!=null)
            {
              roleId=  Session["CVCRoleId"] != null ? Convert.ToInt32(Session["CVCRoleId"]) : 0;
            }

            var rolePermissions = objCommonServices.GetRolePermission(roleId);

            var selectRecipeRead = rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "MachineCustomization:SelectRecipe:Read");
            var saveRecipeRead = rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "MachineCustomization:SaveRecipe:Read");
            var updateRecipeRead = rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "MachineCustomization:UpdateRecipe:Read");

            var selectRecipeModify = rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "MachineCustomization:SelectRecipe:Modify");
            var saveRecipeModify = rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "MachineCustomization:SaveRecipe:Modify");
            var updateRecipeModify = rolePermissions.FirstOrDefault(rp => rp.PermissionKey == "MachineCustomization:UpdateRecipe:Modify");


            Model.IsReadSelectRecipe = selectRecipeRead != null ? true : false;
            Model.IsReadSaveRecipe = saveRecipeRead != null ? true : false;
            Model.IsReadUpdateRecipe = updateRecipeRead != null ? true : false;

            Model.IsModifySelectRecipe = selectRecipeModify != null ? true : false;
            Model.IsModifySaveRecipe = saveRecipeModify != null ? true : false;
            Model.IsModifyUpdateRecipe = updateRecipeModify != null ? true : false;

            return (ActionResult)this.View("~/Modules/Machine/RenderViewFields.cshtml", (object)Model);
            
        }

        public async Task<ActionResult> IndexAjax(int ModuleId, int ViewId, bool IsLoadDefaultRecipe,int LabelRollViewId)
        {

            if (HttpContext.Cache["MachineSettings"] != null)
            {
                RenderViewFieldsPageModel Model = ReadSettingsPanel(ModuleId,ViewId, IsLoadDefaultRecipe);
                if (ViewId != LabelRollViewId)
                {
                    return Json(Model, JsonRequestBehavior.AllowGet);
                }
                else
                {
                     return (ActionResult)this.View("~/Modules/Machine/LabelRollPartialPage.cshtml", (object)Model);

                }

            }
            else
            {
                if (ViewId != LabelRollViewId)
                {
                    return await GetSettingsPanelDataAsync(ModuleId, ViewId);
                }
            }

            return null;
        }

        public RenderViewFieldsPageModel ReadSettingsPanel(int ModuleId, int ViewId, bool IsLoadDefaultRecipe)
        {

            var SettingsPanel = new RenderViewFieldsPageModel();
            SettingsPanel = (RenderViewFieldsPageModel)HttpContext.Cache["MachineSettings"];

            if (SettingsPanel.ProtocolType.ToUpper() ==ProtocolType.MDB.ToUpper())
            {
                return CallMDBMachineSettingsPanel(SettingsPanel, ModuleId, ViewId, IsLoadDefaultRecipe);
            }
           else if (SettingsPanel.ProtocolType.ToUpper().Contains(ProtocolType.Modbus.ToUpper()))
            {
                return CallPLCMachineSettingsPanel(SettingsPanel, ModuleId, ViewId, IsLoadDefaultRecipe);
            }
           else if (SettingsPanel.ProtocolType.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
            {
               return CallOPCUaClientSettingsPanel(SettingsPanel, ModuleId, ViewId, IsLoadDefaultRecipe);

            }
            return SettingsPanel;

        }

        public RenderViewFieldsPageModel CallMDBMachineSettingsPanel(RenderViewFieldsPageModel MachineSettings, int ModuleId, int ViewId, bool IsLoadDefaultRecipe)
        {

            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    //if (IsLoadDefaultRecipe == true)
                    //{
                    //    var MachineId = new DashboardCommon().GetMachineId(ModuleId.ToString());
                    //    var PackId = cvcEntities.Batches.OrderByDescending(b => b.BatchId).FirstOrDefault().PackId;
                    //    var MachineRecipeId = cvcEntities.MachineRecipes.FirstOrDefault(mr => mr.PackId == PackId && mr.MachineId == MachineId && mr.IsDefaultRecipe == true)?.MachineRecipeId ?? null;
                    //    if (MachineRecipeId != null)
                    //    {
                    //        bool IsAppliedRecipe = new DashboardCommon().ApplyRecipe((int)MachineRecipeId);
                    //        var ViewsId = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == ModuleId && a.IsMachineSettings == true)?.ViewsId ?? null;
                    //        ViewId = (int)ViewsId;
                    //    }
                    //}
                    using (OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + MachineSettings.MDBPath + ";Jet OLEDB:Database Password=slkfnsdfkn2148sad;"))
                    {
                        //RenderViewFieldsPageModel objRenderViewFieldsPageModel = (RenderViewFieldsPageModel)MachineSettings.Clone();
                        //HttpContext.Cache.Remove("MachineSettings");
                        //HttpContext.Cache["MachineSettings"] = objRenderViewFieldsPageModel;

                        //MachineSettings.ViewFieldList = MachineSettings.ViewFieldList.Where(v => v.ViewsId == ViewId).ToList();
                        //MachineSettings.IsMachineSettings = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == ModuleId && a.ViewsId == ViewId)?.IsMachineSettings ?? false;
                        //if (MachineSettings.IsMachineSettings == true)
                        //{
                        //    var recipe = new DashboardCommon().GetRecepe(ModuleId);
                        //    MachineSettings.RecipeId = recipe.Item1;
                        //    MachineSettings.RecipeName = recipe.Item2;

                        //}
                        //MachineSettings.IsLabelRoll = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == ModuleId && a.ViewsId == ViewId)?.IslabelRoll ?? false;


                        //if (MachineSettings.IsLabelRoll == true)
                        //{
                        //    MachineSettings.ViewName = "Label Roll";
                        //}
                        //else
                        //{
                        //    MachineSettings.ViewName = MachineSettings.ViewFieldList.FirstOrDefault().ViewName;
                        //}

                        MachineSettings = ReadMachineSettingsPanel(MachineSettings, ModuleId, ViewId, IsLoadDefaultRecipe);

                        OleDbCommand oleDbCommand = new OleDbCommand();
                        oleDbCommand.Connection = oleDbConnection;
                        oleDbConnection.Open();
                        foreach (var item in MachineSettings.ViewFieldList)
                        {
                            try
                            {

                                oleDbCommand.CommandText = item.Bit32RowId != null ? "select RowID,DataArrey,WriteRequest from interDB where RowID=" + item.RowId + " or RowID=" + item.Bit32RowId + "" : "select RowID,DataArrey,WriteRequest from interDB where RowID = " + item.RowId + "";
                                if (oleDbConnection.State == ConnectionState.Closed)
                                {
                                    oleDbConnection.Open();
                                }

                                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
                                DataTable dataTable = new DataTable();
                                dataTable.Load((IDataReader)oleDbDataReader);
                                oleDbConnection.Close();
                                string RowIdValueExpression = "RowId=" + item.RowId + "";
                                // var RowIdValue = dataTable.Rows[(int)item.RowId]["DataArrey"].ToString();
                                var RowIdValue = dataTable.Select(RowIdValueExpression).FirstOrDefault().ItemArray.Skip(1).Take(1).SingleOrDefault();

                                item.Value = Convert.ToString(RowIdValue);

                                if (item.IsBitWise == true)
                                {
                                    string binaryValue = DecimalToBinary(int.Parse(RowIdValue.ToString()));
                                    item.Value = ReverseString(binaryValue).ToString().Substring(item.BitWiseIndex.Value, 1);

                                }

                                if (item.Is32Bit == true)
                                {
                                    string Bit32RowIdValueExpression = "RowId=" + item.Bit32RowId + "";
                                    var Bit32RowIdValue = dataTable.Select(Bit32RowIdValueExpression).FirstOrDefault().ItemArray.Skip(1).Take(1).SingleOrDefault();
                                    string lowerbit = DecimalToBinary(int.Parse(item.Value));
                                    string higherbit = DecimalToBinary(int.Parse(Bit32RowIdValue.ToString()));
                                    item.Value = Convert.ToInt32(higherbit + lowerbit, 2).ToString();

                                }

                                if (item.OperationTypeIPC > 0)
                                {
                                    item.Value = GetParsedValue(item.Value, item.OperationTypeIPC, item.OperationValueIPC.Value);

                                }
                            }
                            catch(System.Exception ex)
                            {
                                continue;
                            }
                        }


                    }
                }
            }
            catch (System.Exception ex)
            {

            }


            return MachineSettings;
        }

        public RenderViewFieldsPageModel CallPLCMachineSettingsPanel(RenderViewFieldsPageModel MachineSettings, int ModuleId, int ViewId, bool IsLoadDefaultRecipe)
        {

            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    //if (IsLoadDefaultRecipe == true)
                    //{
                    //    var MachineId = new DashboardCommon().GetMachineId(ModuleId.ToString());
                    //    var PackId = cvcEntities.Batches.OrderByDescending(b => b.BatchId).FirstOrDefault().PackId;
                    //    var MachineRecipeId = cvcEntities.MachineRecipes.FirstOrDefault(mr => mr.PackId == PackId && mr.MachineId == MachineId && mr.IsDefaultRecipe == true)?.MachineRecipeId ?? null;
                    //    if (MachineRecipeId != null)
                    //    {
                    //        bool IsAppliedRecipe = new DashboardCommon().ApplyRecipe((int)MachineRecipeId);
                    //        var ViewsId = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == ModuleId && a.IsMachineSettings == true)?.ViewsId ?? null;
                    //        ViewId = (int)ViewsId;
                    //    }
                    //}
                    using (ModbusTCPCom modbusTCP = new ModbusTCPCom())

                    {

                        //RenderViewFieldsPageModel objRenderViewFieldsPageModel = (RenderViewFieldsPageModel)MachineSettings.Clone();
                        //HttpContext.Cache.Remove("MachineSettings");
                        //HttpContext.Cache["MachineSettings"] = objRenderViewFieldsPageModel;

                        //MachineSettings.ViewFieldList = MachineSettings.ViewFieldList.Where(v => v.ViewsId == ViewId).ToList();
                        //MachineSettings.IsMachineSettings = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == ModuleId && a.ViewsId == ViewId)?.IsMachineSettings ?? false;
                        //if (MachineSettings.IsMachineSettings == true)
                        //{
                        //    var recipe = new DashboardCommon().GetRecepe(ModuleId);
                        //    MachineSettings.RecipeId = recipe.Item1;
                        //    MachineSettings.RecipeName = recipe.Item2;

                        //}
                        //MachineSettings.IsLabelRoll = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == ModuleId && a.ViewsId == ViewId)?.IslabelRoll ?? false;


                        //if (MachineSettings.IsLabelRoll == true)
                        //{
                        //    MachineSettings.ViewName = "Label Roll";
                        //}
                        //else
                        //{
                        //    MachineSettings.ViewName = MachineSettings.ViewFieldList.FirstOrDefault().ViewName;
                        //}

                        MachineSettings = ReadMachineSettingsPanel(MachineSettings, ModuleId, ViewId, IsLoadDefaultRecipe);


                        modbusTCP.IPAddress = MachineSettings.IPAddress;
                        modbusTCP.TcpipPort = MachineSettings.TcpipPort;
                        modbusTCP.PollRateOverride = MachineSettings.PollRateOverride;

                        foreach (var item in MachineSettings.ViewFieldList)
                        {
                            try
                            {
                                var LblModBusReadCall = 0;
                                var LblModBusReadHigherbitCall = 0;
                                var IPCAddress = GetFormatedIPCAddress(item.IPCAddress, item?.DataTypeId ?? 0);

                                if (item.IsByteSwap == true)
                                {
                                    modbusTCP.SwapBytes = true;
                                }

                                if (item.IsWordSwap == true)
                                {
                                    modbusTCP.SwapWords = true;
                                }

                                LblModBusRead: string TechnicalSettingValueFromModBus =modbusTCP.Read(IPCAddress);


                                if (string.IsNullOrEmpty(TechnicalSettingValueFromModBus))
                                {
                                    if (LblModBusReadCall <= 3)
                                    {
                                        LblModBusReadCall = LblModBusReadCall++;
                                        goto LblModBusRead;
                                    }

                                }

                               

                                item.Value = TechnicalSettingValueFromModBus;

                                if (item.Is32Bit == true)
                                {
                                    string lowerbit = DecimalToBinary(int.Parse(TechnicalSettingValueFromModBus));

                                    LblModBusReadHigherbit: string higherbit = DecimalToBinary(int.Parse(modbusTCP.Read(item.Bit32Address)));

                                    if (string.IsNullOrEmpty(higherbit))
                                    {
                                        if (LblModBusReadHigherbitCall <= 3)
                                        {
                                            LblModBusReadHigherbitCall = LblModBusReadHigherbitCall++;
                                            goto LblModBusReadHigherbit;
                                        }
                                    }


                                    TechnicalSettingValueFromModBus = Convert.ToInt32(higherbit + lowerbit, 2).ToString();
                                }

                                if (item.IsBitWise == true)
                                {
                                    string binaryValue = DecimalToBinary(int.Parse(TechnicalSettingValueFromModBus));
                                    TechnicalSettingValueFromModBus = ReverseString(binaryValue).ToString().Substring(item.BitWiseIndex.Value, 1);
                                }

                                if (item.OperationTypeIPC > 0)
                                {
                                    item.Value = GetParsedValue(TechnicalSettingValueFromModBus, item.OperationTypeIPC, item.OperationValueIPC.Value);
                                }
                                else
                                {
                                    item.Value = TechnicalSettingValueFromModBus;
                                }
                            }
                            catch(System.Exception ex)
                            {
                                //throw new Serenity.Services.ValidationError("Error", ex.Message);
                                continue;
                            }
                            }
                        


                    }
                }
            }
            catch (System.Exception ex)
            {
               // throw new Serenity.Services.ValidationError("Error", ex.Message);
            }


            return MachineSettings;
        }

        public RenderViewFieldsPageModel CallOPCUaClientSettingsPanel(RenderViewFieldsPageModel renderViewFieldsPageModel, int ModuleId, int ViewId, bool IsLoadDefaultRecipe)
        {

            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    //if (IsLoadDefaultRecipe == true)
                    //{
                    //    var MachineId = new DashboardCommon().GetMachineId(ModuleId.ToString());
                    //    var PackId = cvcEntities.Batches.OrderByDescending(b => b.BatchId).FirstOrDefault().PackId;
                    //    var MachineRecipeId = cvcEntities.MachineRecipes.FirstOrDefault(mr => mr.PackId == PackId && mr.MachineId == MachineId && mr.IsDefaultRecipe == true)?.MachineRecipeId ?? null;
                    //    if (MachineRecipeId != null)
                    //    {
                    //        bool IsAppliedRecipe = new DashboardCommon().ApplyRecipe((int)MachineRecipeId);
                    //        var ViewsId = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == ModuleId && a.IsMachineSettings == true)?.ViewsId ?? null;
                    //        ViewId = (int)ViewsId;
                    //    }
                    //}

                    // RenderViewFieldsPageModel objRenderViewFieldsPageModel = (RenderViewFieldsPageModel)renderViewFieldsPageModel.Clone();
                    // HttpContext.Cache.Remove("MachineSettings");
                    // HttpContext.Cache["MachineSettings"] = objRenderViewFieldsPageModel;

                    // renderViewFieldsPageModel.ViewFieldList = renderViewFieldsPageModel.ViewFieldList.Where(v => v.ViewsId == ViewId).ToList();
                    // renderViewFieldsPageModel.IsMachineSettings = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == ModuleId && a.ViewsId == ViewId)?.IsMachineSettings ?? false;
                    // if (renderViewFieldsPageModel.IsMachineSettings == true)
                    // {
                    //     var recipe = new DashboardCommon().GetRecepe(ModuleId);
                    //     renderViewFieldsPageModel.RecipeId = recipe.Item1;
                    //     renderViewFieldsPageModel.RecipeName = recipe.Item2;

                    // }
                    //renderViewFieldsPageModel.IsLabelRoll = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == ModuleId && a.ViewsId == ViewId)?.IslabelRoll ?? false;


                    // if (renderViewFieldsPageModel.IsLabelRoll == true)
                    // {
                    //    renderViewFieldsPageModel.ViewName = "Label Roll";
                    // }
                    // else
                    // {
                    //    renderViewFieldsPageModel.ViewName = renderViewFieldsPageModel.ViewFieldList.FirstOrDefault().ViewName;
                    // }

                    renderViewFieldsPageModel = ReadMachineSettingsPanel(renderViewFieldsPageModel, ModuleId, ViewId, IsLoadDefaultRecipe);


                    ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
                    clsOpcUaClient.ReadSettingsPanel(renderViewFieldsPageModel);
                    
                }
            }
            catch (System.Exception ex)
            {
                // throw new Serenity.Services.ValidationError("Error", ex.Message);
            }


            return renderViewFieldsPageModel;
        }

        public RenderViewFieldsPageModel CallSiemensS7SettingsPanel(RenderViewFieldsPageModel renderViewFieldsPageModel, int ModuleId, int ViewId, bool IsLoadDefaultRecipe)
        {
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                   
                    renderViewFieldsPageModel = ReadMachineSettingsPanel(renderViewFieldsPageModel, ModuleId, ViewId, IsLoadDefaultRecipe);

                    ClsSiemensS7Net clsSiemensS7Net  = new ClsSiemensS7Net();
                    clsSiemensS7Net.ReadSettingsPanel(renderViewFieldsPageModel);

                }
            }
            catch (System.Exception ex)
            {
                // throw new Serenity.Services.ValidationError("Error", ex.Message);
            }


            return renderViewFieldsPageModel;
        }

            //public RenderViewFieldsPageModel ReadMachineSettings(int ModuleId,int ViewId,bool IsLoadDefaultRecipe)
            //{
            //    var MachineSettings = new RenderViewFieldsPageModel();

            //    try
            //    {
            //        using (CVCEntities cvcEntities = new CVCEntities())
            //        {
            //            if (IsLoadDefaultRecipe == true)
            //            {
            //                var MachineId = new DashboardCommon().GetMachineId(ModuleId.ToString());
            //                var PackId = cvcEntities.Batches.OrderByDescending(b => b.BatchId).FirstOrDefault().PackId;
            //                var MachineRecipeId = cvcEntities.MachineRecipes.FirstOrDefault(mr =>mr.PackId==PackId && mr.MachineId == MachineId && mr.IsDefaultRecipe == true)?.MachineRecipeId ?? null;
            //                if (MachineRecipeId != null)
            //                {
            //                    bool IsAppliedRecipe = new DashboardCommon().ApplyRecipe((int)MachineRecipeId);
            //                    var ViewsId = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == ModuleId && a.IsMachineSettings == true)?.ViewsId ?? null;
            //                    ViewId = (int)ViewsId;
            //                }
            //            }
            //            using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
            //            {

            //                MachineSettings =  (RenderViewFieldsPageModel)HttpContext.Cache["MachineSettings"];
            //                RenderViewFieldsPageModel objRenderViewFieldsPageModel = (RenderViewFieldsPageModel)MachineSettings.Clone();
            //                HttpContext.Cache.Remove("MachineSettings");
            //                HttpContext.Cache["MachineSettings"] = objRenderViewFieldsPageModel;

            //                MachineSettings.ViewFieldList = MachineSettings.ViewFieldList.Where(v => v.ViewsId == ViewId).ToList();
            //                MachineSettings.IsMachineSettings = cvcEntities.Views.FirstOrDefault(a => a.ModuleId ==ModuleId && a.ViewsId==ViewId)?.IsMachineSettings??false;
            //                if (MachineSettings.IsMachineSettings==true)
            //                {
            //                    var rec = new DashboardCommon().GetRecepe(ModuleId);
            //                    MachineSettings.RecipeId = rec.Item1;
            //                    MachineSettings.RecipeName = rec.Item2;

            //                }
            //                MachineSettings.IsLabelRoll = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == ModuleId && a.ViewsId == ViewId)?.IslabelRoll ?? false;


            //                if(MachineSettings.IsLabelRoll==true)
            //                {
            //                    MachineSettings.ViewName ="Label Roll";
            //                }
            //                else
            //                {
            //                    MachineSettings.ViewName = MachineSettings.ViewFieldList.FirstOrDefault().ViewName;
            //                }
            //                var machinePara = new MachineParameter();
            //                machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == MachineSettings.MachineParameterId);
            //                // var machinePara = CVCDaoFactory.GetMachineParameter(MaChineSummary.MachineParameterId);
            //                // var machineCommunication = CVCDaoFactory.GetMachineCommunication(machinePara.MachineId.Value);
            //                var machineCommunication = new MachineCommunication();
            //                if (cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().Count > 0)
            //                {
            //                    machineCommunication = cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().First<MachineCommunication>();
            //                }
            //                if (machineCommunication != null)
            //                {
            //                    var ipcpara = machinePara.IPCParameters;
            //                    if (ipcpara.Any())
            //                    {
            //                       modbusTCP.IPAddress = machineCommunication.IPAddress;
            //                       modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
            //                        modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;

            //                        foreach (var item in MachineSettings.ViewFieldList)
            //                        {
            //                            string address = item.IPCAddress;

            //                            if (item.DataTypeId == 9) // Siemens Float or SWAP FLOAT
            //                            {
            //                                // this.modbusTCP.SwapWords = true;
            //                                address = "F" + item.IPCAddress;
            //                            }

            //                            if (item.DataTypeId == 10 || item.DataTypeId == 1) //D-WORD
            //                            {
            //                                // this.modbusTCP.SwapWords = false;
            //                                address = "U" + item.IPCAddress;
            //                            }

            //                            if (item.DataTypeId == 8 || item.DataTypeId == 5) //WORD
            //                            {
            //                                // this.modbusTCP.SwapWords = false;
            //                                address = "L" + item.IPCAddress;
            //                            }

            //                            if (item.IsByteSwap == true)
            //                            {
            //                                modbusTCP.SwapBytes = true;
            //                            }

            //                            if (item.IsWordSwap == true)
            //                            {
            //                                modbusTCP.SwapWords = true;
            //                            }
            //                            string TechnicalSettingValueFromModBus = modbusTCP.Read(address);



            //                            if (item.Is32Bit == true)
            //                            {
            //                                string lowerbit = DecimalToBinary(int.Parse(TechnicalSettingValueFromModBus));
            //                                string higherbit = DecimalToBinary(int.Parse(modbusTCP.Read(item.Bit32Address)));
            //                                TechnicalSettingValueFromModBus = Convert.ToInt32(higherbit + lowerbit, 2).ToString();
            //                            }

            //                            if (item.IsBitWise == true)
            //                            {
            //                                string binaryValue = DecimalToBinary(int.Parse(TechnicalSettingValueFromModBus));
            //                                TechnicalSettingValueFromModBus = ReverseString(binaryValue).ToString().Substring(item.BitWiseIndex.Value, 1);
            //                            }

            //                            if (item.OperationTypeIPC == 50)
            //                            {
            //                                item.Value = (Decimal.Parse(TechnicalSettingValueFromModBus) - item.OperationValueIPC.Value).ToString();
            //                            }
            //                            else if (item.OperationTypeIPC == 51)
            //                            {
            //                                item.Value = (Decimal.Parse(TechnicalSettingValueFromModBus) + item.OperationValueIPC.Value).ToString();
            //                            }
            //                            else if (item.OperationTypeIPC == 52)
            //                            {
            //                                item.Value = (Math.Round(Decimal.Parse(TechnicalSettingValueFromModBus) / item.OperationValueIPC.Value, 2)).ToString();
            //                            }
            //                            else if (item.OperationTypeIPC == 53)
            //                            {
            //                                item.Value = (Decimal.Parse(TechnicalSettingValueFromModBus) * item.OperationValueIPC.Value).ToString();
            //                            }
            //                            else
            //                            {
            //                                item.Value = TechnicalSettingValueFromModBus;
            //                            }

            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //    catch (System.Exception ex)
            //    {

            //    }
            //    return MachineSettings;
            //}


            public RenderViewFieldsPageModel ReadMachineSettingsPanel(RenderViewFieldsPageModel MachineSettings, int ModuleId, int ViewId, bool IsLoadDefaultRecipe)
        {

            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    if (IsLoadDefaultRecipe == true)
                    {
                        var MachineId = new DashboardCommon().GetMachineId(ModuleId.ToString());
                        var PackId = cvcEntities.Batches.OrderByDescending(b => b.BatchId).FirstOrDefault().PackId;
                        var MachineRecipeId = cvcEntities.MachineRecipes.FirstOrDefault(mr => mr.PackId == PackId && mr.MachineId == MachineId && mr.IsDefaultRecipe == true)?.MachineRecipeId ?? null;
                        if (MachineRecipeId != null)
                        {
                            bool IsAppliedRecipe = new DashboardCommon().ApplyRecipe((int)MachineRecipeId);
                            var ViewsId = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == ModuleId && a.IsMachineSettings == true)?.ViewsId ?? null;
                            ViewId = (int)ViewsId;
                        }
                    }

                    
                        RenderViewFieldsPageModel objRenderViewFieldsPageModel = (RenderViewFieldsPageModel)MachineSettings.Clone();
                        HttpContext.Cache.Remove("MachineSettings");
                        HttpContext.Cache["MachineSettings"] = objRenderViewFieldsPageModel;

                        MachineSettings.ViewFieldList = MachineSettings.ViewFieldList.Where(v => v.ViewsId == ViewId).ToList();
                        MachineSettings.IsMachineSettings = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == ModuleId && a.ViewsId == ViewId)?.IsMachineSettings ?? false;
                        if (MachineSettings.IsMachineSettings == true)
                        {
                            var recipe = new DashboardCommon().GetRecepe(ModuleId);
                            MachineSettings.RecipeId = recipe.Item1;
                            MachineSettings.RecipeName = recipe.Item2;

                        }
                        MachineSettings.IsLabelRoll = cvcEntities.Views.FirstOrDefault(a => a.ModuleId == ModuleId && a.ViewsId == ViewId)?.IslabelRoll ?? false;


                        if (MachineSettings.IsLabelRoll == true)
                        {
                            MachineSettings.ViewName = "Label Roll";
                        }
                        else
                        {
                            MachineSettings.ViewName = MachineSettings.ViewFieldList.FirstOrDefault().ViewName;
                        }


                  
                }
            }
            catch (System.Exception ex)
            {
                // throw new Serenity.Services.ValidationError("Error", ex.Message);
            }


            return MachineSettings;
        }

        public JsonResult SendHeartBeat(int MachineParameterId, int Value, int IncrementalNumber, int EndNumber)
        {
            try
            {
                WriteHeartBeat(MachineParameterId, Value.ToString());
                // Value =  Value + IncrementalNumber;
                Value = (EndNumber == 1 ? (Value == 0 ? 1 : 0) : (Value + IncrementalNumber));
                //var result = Value;
                return Json(Value, JsonRequestBehavior.AllowGet);
            }
            catch (System.Exception ex)
            {
                Value = Value + IncrementalNumber;
                return Json(Value, JsonRequestBehavior.AllowGet);
                //    Value = Value + IncrementalNumber;
                //    var result = Value;
                //    return Json(result, JsonRequestBehavior.AllowGet);

            }
            //return Json("", JsonRequestBehavior.AllowGet);
        }

        public JsonResult ReadHeartBeat(int MachineParameterId, string IPCAddress)
        {
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
                    {
                        var SettingsPanel = new RenderViewFieldsPageModel();
                        SettingsPanel = (RenderViewFieldsPageModel)HttpContext.Cache["MachineSettings"];


                        modbusTCP.IPAddress = SettingsPanel.IPAddress;
                        modbusTCP.TcpipPort = ushort.Parse(SettingsPanel.TcpipPort.ToString());
                        modbusTCP.PollRateOverride = SettingsPanel.PollRateOverride;

                        var HeartBeatValue = modbusTCP.Read(IPCAddress);
                        return Json(HeartBeatValue, JsonRequestBehavior.AllowGet);

                    }
                }

            }
            catch (System.Exception ex)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

           // return null;
        }


        public string DecimalToBinary(int num)
        {
            int quot;
            string rem = "";
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
            int len = (16 - bin.Length);
            for (int i = 0; i < len; i++)
                bin = "0" + bin;
            return bin;
        }

        public string ReverseString(string val)
        {
            return new string(val.ToCharArray().Reverse().ToArray());
        }

        public string GetParsedValue(string ParaValue, int OperationType, decimal OperationValue)
        {
            switch (OperationType)
            {
                case 50:
                    ParaValue = (Decimal.Parse(ParaValue) - OperationValue).ToString();
                    break;
                case 51:
                    ParaValue = (Decimal.Parse(ParaValue) + OperationValue).ToString();
                    break;
                case 52:
                    ParaValue = (Math.Round(Decimal.Parse(ParaValue) / OperationValue, 2)).ToString();
                    break;
                case 53:
                    ParaValue = (Decimal.Parse(ParaValue) * OperationValue).ToString();
                    break;
                default:

                    break;
            }

            return ParaValue;


        }

        public string GetFormatedIPCAddress(string IPCAddress, int DataTypeId)
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

        [HttpPost]
        public ActionResult ChangeParameter(Parameter parameter/*int ParamterId, string Value*/)
        {
            // var CommandPanel = (CommandPanelPageModel)HttpContext.Cache["CommandPanel"];
            var machineCommunication =objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.MachineCommunication);



            //var ModuleId = 0;
            //if (Session["ModuleId"] != null)
            //{
            //    ModuleId = Convert.ToInt32(Session["ModuleId"]);

            //}

            //ms.CommonServices commonServices = new ms.CommonServices();
            //var machineId = (int)new DashboardCommon().GetMachineId(Convert.ToString(ModuleId));
            //commonServices.IsWriteToPLC(machineId, "1");


            if (parameter.WriteToPLCIPCMachineParameterId > 0)
            {

                if (machineCommunication.ProtocolType.ToUpper().Contains(ProtocolType.Modbus.ToUpper()))
                {
                    Write(parameter.WriteToPLCIPCMachineParameterId, "", parameter.DefaultValue);
                }
                else if (machineCommunication.ProtocolType.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                {
                    object value = null;

                    if (parameter.DataTypeId == 2)
                    {
                        value = parameter.DefaultValue == "1" ? true : false;

                    }
                    if (parameter.DataTypeId == 7)
                    {
                        value = parameter.Value == "1" ? true : false;

                    }
                    else if (parameter.DataTypeId != 2 && parameter.DataTypeId != 7)
                    {
                        value = parameter.Value;

                    }

                    ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
                    OPCUaClientViewModel oPCUaClientViewModel = new OPCUaClientViewModel
                    {
                        ServerAddress = machineCommunication.IPAddress,
                        ServerPortNumber = machineCommunication.TcpipPort.ToString(),
                        UserName = machineCommunication.UserName,
                        Password = machineCommunication.Password,
                        NodeId = parameter.NodeId,
                        AttributeId = parameter.AttributeId,
                        Value = value,
                        DataTypeId = (int)parameter.DataTypeId
                    };
                    clsOpcUaClient.Write(oPCUaClientViewModel);
                }

                else if (machineCommunication.ProtocolType.ToUpper().Contains(ProtocolType.SiemensS7Net.ToUpper()))
                {

                    ClsSiemensS7Net clsSiemensS7Net = new ClsSiemensS7Net();
                    DashBoardField dashBoardField = new DashBoardField();
                    List<DashBoardField> lstDashBoardFields = new List<DashBoardField>();
                    //DashBoardViewModel objDashBoardViewModel = new DashBoardViewModel
                    //{
                    //    IPAddress=machineCommunication.
                    //};
                }

            }

            var result = false;
            if (machineCommunication.ProtocolType.ToUpper().Contains(ProtocolType.Modbus.ToUpper()))
            {
               result = Write(parameter.ParamterId, parameter.Value, parameter.DefaultValue);

            }
            else if (machineCommunication.ProtocolType.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
            {
                object value = null;

                if (parameter.DataTypeId == 2)
                {
                    value = parameter.DefaultValue == "1" ? true : false;

                }
                if (parameter.DataTypeId == 7)
                {
                    value = parameter.Value == "1" ? true : false;

                }
                else if(parameter.DataTypeId!=2 && parameter.DataTypeId!=7)
                {
                    value = parameter.Value;

                }

                ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
                OPCUaClientViewModel oPCUaClientViewModel = new OPCUaClientViewModel
                {
                    ServerAddress = machineCommunication.IPAddress,
                    ServerPortNumber = machineCommunication.TcpipPort.ToString(),
                    UserName = machineCommunication.UserName,
                    Password = machineCommunication.Password,
                    NodeId = parameter.NodeId,
                    AttributeId = parameter.AttributeId,
                    Value = value,
                    DataTypeId = (int)parameter.DataTypeId

                };
                clsOpcUaClient.Write(oPCUaClientViewModel);
            }

            else if (machineCommunication.ProtocolType.ToUpper().Contains(ProtocolType.SiemensS7Net.ToUpper()))
            {

                ClsSiemensS7Net clsSiemensS7Net = new ClsSiemensS7Net();
                DashBoardField dashBoardField ;
                List<DashBoardField> lstDashBoardFields = new List<DashBoardField>();
                DashBoardViewModel objDashBoardViewModel = new DashBoardViewModel
                {
                    IPAddress = machineCommunication.IPAddress,
                    TCPIPPort = machineCommunication.TCPIPPort,
                    Rack = machineCommunication.Rack,
                    Slot = machineCommunication.Slot,
                    CpuType = ""

                };
                //dashBoardField=new DashBoardField
                //{
                //    IPCAddress=
                //}
              
            }


            if (parameter.RequestPanel.ToUpper()=="SETTINGS PANEL" && machineCommunication.ProtocolType.ToUpper().Contains(ProtocolType.Modbus.ToUpper()))
            {
                LblModBusRead: var Newvalue = new ConnectMachine().Read(parameter.ParamterId);

                if(Newvalue!= parameter.Value)
                {
                  
                    if (string.IsNullOrEmpty(Newvalue))
                    {
                        goto LblModBusRead;
                    }
                }

            }

            var dashObj = new DashboardCommon();
            using (CVCEntities cvcEntities = new CVCEntities())
            {

                var machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == parameter.ParamterId);
                var ViewFieldName = machinePara.ViewFields?.FirstOrDefault(a => a.MachineParameterId == parameter.ParamterId)?.ViewFieldName ?? "";

                if (parameter.RequestPanel.ToUpper() == "SETTINGS PANEL" && parameter.InputType.ToUpper() == "CHECKBOX")
                {
                    parameter.OldValue = parameter.Value == "1" ? "OFF" : "ON";
                    parameter.Value = parameter.Value == "0" ? "OFF" : "ON";
                }
                else if (parameter.RequestPanel.ToUpper() == "COMMAND PANEL")
                {
                    parameter.OldValue = parameter.Value == "1" ? "OFF" : "ON";
                    parameter.Value = parameter.Value == "0" ? "OFF" : "ON";

                }

                dashObj.AddAuditLog("Change Machine Parameter", "Machine", "Dashboard", ViewFieldName, parameter.OldValue, parameter.Value, dashObj.GetBatchForLebelRoll(), machinePara.MachineId, null, parameter.PickListValueId, parameter.Comments, parameter.AuthenticationId);
                return Content(result.ToString());
            }
            
        }
        
        public bool Write(int machineParaId, string Value,string DefaultValue)
        {
            // using (CVCEntities cvcEntities = new CVCEntities())
            CVCEntities cvcEntities = new CVCEntities();
            {
               // ModbusTCPCom modbusTCP = new ModbusTCPCom();
                using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
                {

                    try
                    {

                        var machinePara = new MachineParameter();
                        machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == machineParaId);


                        var ipcpara = machinePara.IPCParameters;
                        if (ipcpara.Any())
                        {
                            string address = ipcpara.FirstOrDefault().IPCAddress;

                            if (machinePara.DataTypeId == 2) // Bit Momentary
                            {
                                Value = DefaultValue;
                            }
                            else if (machinePara.DataTypeId == 3) // Bit Reset
                            {
                                Value = "0";
                            }
                            else if (machinePara.DataTypeId == 4) // Bit Set
                            {
                                Value = "1";
                            }
                            else if (machinePara.DataTypeId == 9) //  Float or SWAP FLOAT
                            {

                                address = "F" + address;
                            }

                            if (machinePara.DataTypeId == 10) //D-WORD
                            {


                                address = "U" + address;
                            }

                            if (machinePara.DataTypeId == 8) //WORD
                            {


                                address = "L" + address;
                            }

                            if (ipcpara.FirstOrDefault().IsByteSwap == true)
                            {
                                modbusTCP.SwapBytes = true;
                            }


                            if (ipcpara.FirstOrDefault().IsWordSwap == true)
                            {
                                modbusTCP.SwapWords = true;
                            }

                            //  var CommandPanel = new CommandPanelPageModel();                         
                           // CommandPanel = (CommandPanelPageModel)HttpContext.Cache["CommandPanel"];

                            var machineCommunication = objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.MachineCommunication);
                            modbusTCP.IPAddress = machineCommunication.IPAddress;
                            modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TcpipPort.ToString());
                            modbusTCP.PollRateOverride = machineCommunication.PollRateOverride;

                            string value32bit = null;
                            if (ipcpara.FirstOrDefault().Is32Bit == true)
                            {
                                var binary32bit = DecimalToBinary32(long.Parse(Value));
                                Value = Convert.ToInt32(binary32bit.Substring(16, 16), 2).ToString();
                                value32bit = Convert.ToInt32(binary32bit.Substring(0, 16), 2).ToString();
                            }
                            if (ipcpara.FirstOrDefault().IsBitWise == true)
                            {
                                string binaryValue = ReverseString(DecimalToBinary(int.Parse(modbusTCP.Read(ipcpara.FirstOrDefault().IPCAddress)))).ToString();
                                binaryValue = ReverseString(binaryValue.Remove(ipcpara.FirstOrDefault().BitWiseIndex.Value, 1).Insert(ipcpara.FirstOrDefault().BitWiseIndex.Value, Value));
                                Value = Convert.ToInt32(binaryValue, 2).ToString();
                            }

                            if (machinePara.IPCParameters.FirstOrDefault().OperationTypeIPC == 50)
                            {
                                
                                    Value = (Decimal.Parse(Value) + machinePara.IPCParameters.FirstOrDefault().OperationValueIPC.Value).ToString();

                            }
                            if (machinePara.IPCParameters.FirstOrDefault().OperationTypeIPC == 51)
                            {
                               
                                    Value = (Decimal.Parse(Value) - machinePara.IPCParameters.FirstOrDefault().OperationValueIPC.Value).ToString();
                                

                            }
                            if (machinePara.IPCParameters.FirstOrDefault().OperationTypeIPC == 52)
                            { 
                               
                                    Value = (Math.Round(Decimal.Parse(Value) * machinePara.IPCParameters.FirstOrDefault().OperationValueIPC.Value, 2)).ToString();

                            }
                            if (machinePara.IPCParameters.FirstOrDefault().OperationTypeIPC == 53)
                            {
                               
                                    Value = (Decimal.Parse(Value) / machinePara.IPCParameters.FirstOrDefault().OperationValueIPC.Value).ToString();

                            }

                            if (machinePara.DataTypeId == 8)
                            {
                                if (Value.Contains("."))
                                {
                                    var splitValue = Value.Split('.');
                                    Value = splitValue[0];
                                }
                            }



                            var result = modbusTCP.Write(address, Value);
                            if (ipcpara.FirstOrDefault().Is32Bit == true)
                            {
                                // System.Threading.Thread.Sleep(500);
                         var response=       modbusTCP.Write(ipcpara.FirstOrDefault().Bit32Address, value32bit);
                            }
                            //if (machinePara.DataTypeId == 2) // Bit Momentary
                            //{


                            //    string binaryValue = ReverseString(DecimalToBinary(int.Parse(modbusTCP.Read(ipcpara.FirstOrDefault().IPCAddress)))).ToString();
                            //    binaryValue = ReverseString(binaryValue.Remove(ipcpara.FirstOrDefault().BitWiseIndex.Value, 1).Insert(ipcpara.FirstOrDefault().BitWiseIndex.Value, "0"));
                            //    Value = Convert.ToInt32(binaryValue, 2).ToString();
                            //    modbusTCP.Write(ipcpara.FirstOrDefault().IPCAddress, Value);
                            //}
                        }
                    }
                    catch(System.Exception ex)
                    {

                    }
                    finally
                    {
                        cvcEntities.Dispose();
                    }
                }
            }
            return true;
        }

        public string DecimalToBinary32(long num)
        {
            long quot;
            string rem = "";
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

        public string WriteHeartBeat(int machineParaId, string Value)
        {
            // using (CVCEntities cvcEntities = new CVCEntities())
            CVCEntities cvcEntities = new CVCEntities();
            {
               // ModbusTCPCom modbusTCP = new ModbusTCPCom();
               using(ModbusTCPCom modbusTCP = new ModbusTCPCom())
                try
                {

                    var machinePara = new MachineParameter();
                    machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == machineParaId);


                    var ipcpara = machinePara.IPCParameters;
                    if (ipcpara.Any())
                    {
                        string address = ipcpara.FirstOrDefault().IPCAddress;

                        if (machinePara.DataTypeId == 2) // Bit Momentary
                        {
                            Value = "1";
                        }
                        else if (machinePara.DataTypeId == 3) // Bit Reset
                        {
                            Value = "0";
                        }
                        else if (machinePara.DataTypeId == 4) // Bit Set
                        {
                            Value = "1";
                        }
                        else if (machinePara.DataTypeId == 9) // Siemens Float or SWAP FLOAT
                        {

                            address = "F" + address;
                        }

                        if (machinePara.DataTypeId == 10) //D-WORD
                        {


                            address = "U" + address;
                        }

                        if (machinePara.DataTypeId == 8) //WORD
                        {
                            address = "L" + address;
                        }

                        if (ipcpara.FirstOrDefault().IsByteSwap == true)
                        {
                            modbusTCP.SwapBytes = true;
                        }


                        if (ipcpara.FirstOrDefault().IsWordSwap == true)
                        {
                            modbusTCP.SwapWords = true;
                        }

                            //  var CommandPanel = new CommandPanelPageModel();
                            // CommandPanel = (CommandPanelPageModel)HttpContext.Cache["CommandPanel"];
                        var machineCommunication =objCommonServices.GetCacheData(ClsCacheConfig.CacheKeys.MachineCommunication);

                        modbusTCP.IPAddress = machineCommunication.IPAddress;
                        modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TcpipPort.ToString());
                        modbusTCP.PollRateOverride = machineCommunication?.PollRateOverride??0;

                        string value32bit = null;
                        if (ipcpara.FirstOrDefault().Is32Bit == true)
                        {
                            var binary32bit = DecimalToBinary32(long.Parse(Value));
                            Value = Convert.ToInt32(binary32bit.Substring(16, 16), 2).ToString();
                            value32bit = Convert.ToInt32(binary32bit.Substring(0, 16), 2).ToString();
                        }
                        if (ipcpara.FirstOrDefault().IsBitWise == true)
                        {
                            string binaryValue = ReverseString(DecimalToBinary(int.Parse(modbusTCP.Read(ipcpara.FirstOrDefault().IPCAddress)))).ToString();
                            binaryValue = ReverseString(binaryValue.Remove(ipcpara.FirstOrDefault().BitWiseIndex.Value, 1).Insert(ipcpara.FirstOrDefault().BitWiseIndex.Value, Value));
                            Value = Convert.ToInt32(binaryValue, 2).ToString();
                        }

                        if (machinePara.IPCParameters.FirstOrDefault().OperationTypeIPC == 50)
                        {
                            Value = (Decimal.Parse(Value) + machinePara.IPCParameters.FirstOrDefault().OperationValueIPC.Value).ToString();
                        }
                        if (machinePara.IPCParameters.FirstOrDefault().OperationTypeIPC == 51)
                        {
                            Value = (Decimal.Parse(Value) - machinePara.IPCParameters.FirstOrDefault().OperationValueIPC.Value).ToString();
                        }
                        if (machinePara.IPCParameters.FirstOrDefault().OperationTypeIPC == 52)
                        {
                            Value = (Math.Round(Decimal.Parse(Value) * machinePara.IPCParameters.FirstOrDefault().OperationValueIPC.Value, 2)).ToString();
                        }
                        if (machinePara.IPCParameters.FirstOrDefault().OperationTypeIPC == 53)
                        {
                            Value = (Decimal.Parse(Value) / machinePara.IPCParameters.FirstOrDefault().OperationValueIPC.Value).ToString();
                        }

                            if (machinePara.DataTypeId == 8)
                            {
                                if (Value.Contains("."))
                                {
                                    var splitValue = Value.Split('.');
                                    Value = splitValue[0];
                                }
                            }


                            var result = modbusTCP.Write(address, Value);
                        if (ipcpara.FirstOrDefault().Is32Bit == true)
                        {
                            // System.Threading.Thread.Sleep(500);
                            modbusTCP.Write(ipcpara.FirstOrDefault().Bit32Address, value32bit);
                        }
                        if (machinePara.DataTypeId == 2) // Bit Momentary
                        {
                            //System.Threading.Thread.Sleep(500);
                            string binaryValue = ReverseString(DecimalToBinary(int.Parse(modbusTCP.Read(ipcpara.FirstOrDefault().IPCAddress)))).ToString();
                            binaryValue = ReverseString(binaryValue.Remove(ipcpara.FirstOrDefault().BitWiseIndex.Value, 1).Insert(ipcpara.FirstOrDefault().BitWiseIndex.Value, "0"));
                            Value = Convert.ToInt32(binaryValue, 2).ToString();
                            modbusTCP.Write(ipcpara.FirstOrDefault().IPCAddress, Value);
                        }
                    }

                }
                catch
                {

                }
                finally
                {
                    cvcEntities.Dispose();
                }
            }
            return Value;
        }

      

    }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Machine.Pages.MachineSummaryController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Newtonsoft.Json.Linq;
using AdvancedHMIDrivers;
using CVC.Data;
using CVC.Data.EDMX;
using CVC.MDB;
using CVC.Modules.Common.CommonServices;
using CVC.Modules.Common.Dashboard;
using CVC.ViewModels;
using Microsoft.Ajax.Utilities;
using Serenity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.SessionState;
using static CVC.BusinessServices.Common.ClsConstants;
using Newtonsoft.Json;
using System.Data.Entity;

namespace CVC.Machine.Pages
{
    [RoutePrefix("MachineSummaryMachine")]
    [Route("{action=index}")]
    [SessionState(SessionStateBehavior.Disabled)]

    public class MachineSummaryController : Controller
    {
        [Authorize]
        [HttpGet]
        public async Task<ActionResult> Index(int ModuleId)
        {
            if (System.Web.HttpContext.Current.Cache["ActiveModuleId"] != null)
            {
                int CacheModuleId = (int)(System.Web.HttpContext.Current.Cache["ActiveModuleId"]);
                if (CacheModuleId != ModuleId)
                {
                    return await GetMachineSummaryDataAsync(ModuleId);
                }
                MachineSummaryPageModel Model = ReadMachineSummary();
                return (ActionResult)this.View("~/Modules/Machine/MachineSummary.cshtml", (object)Model);

            }
            else
            {
                return await GetMachineSummaryDataAsync(ModuleId);
            }
            //else
            //{
            //    CommonServices objCommonServices = new CommonServices();
            //    var moduledata = new CVC.Modules.Common.Dashboard.DashboardCommon().GetModule(ModuleId.ToString());
            //    var Model = new MachineSummaryPageModel() { ViewFieldList = new List<DashBoardField>() };
            //    Model.ViewFieldList = new List<DashBoardField>();
            //    if (moduledata.MachineSummary != null)
            //        Model.ViewFieldList = new DashboardCommon().GetDashBoardField(ModuleId, moduledata.MachineSummary.Value);
            //    // var batchForLabel = new DashboardCommon().GetBatchForLebelRoll();

            //    var LabelRoll = new LabelRoll();

            //    if (objCommonServices.CheckIsLabelRoll(ModuleId) == true)
            //    {
            //        Model.IsLabelRoll = true;
            //        int? machineId = 0;
            //        if (Session["ModuleId"] != null)
            //        {
            //            string moduleId = Session["ModuleId"].ToString();
            //            machineId = new DashboardCommon().GetMachineId(moduleId);
            //            LabelRoll = objCommonServices.GetLabelRollDetails(machineId);
            //            if (LabelRoll != null)
            //            {
            //                Model.ViewFieldList.Add(new DashBoardField() { ParameterName = "Label Roll", Value = LabelRoll.LabelRollNumber.ToString(), IPCAddress = "NA" });
            //                HttpContext.Cache["LabelRollNumber"] = LabelRoll.LabelRollNumber;
            //                HttpContext.Cache["NumberOfLabels"] = LabelRoll.NumberOfLabels;
            //                HttpContext.Cache["LabelRollId"] = LabelRoll.LabelRollId;
            //                //  Model.ViewFieldList.Add(new DashBoardField() { ParameterName = "Label On Rolls", Value = LabelRoll.NumberOfLabels.ToString(), IPCAddress = "NA" });

            //            }


            //        }


            //    }


            //    Model.ViewFieldList = Model.ViewFieldList.Where(a => a.IPCAddress != null).OrderByDescending(a => a.IsMachineSpeed).ToList();
            //    if (Model.ViewFieldList.Count > 0)
            //    {
            //        Model.MachineParameterId = Model.ViewFieldList?.Where(a => a.MachineParameterId > 0)?.FirstOrDefault()?.MachineParameterId ?? 0;
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
            //        HttpContext.Cache.Remove("MachineSummary");
            //        HttpContext.Cache["MachineSummary"] = Model;
            //    }
            //    else
            //    {
            //        HttpContext.Cache.Remove("MachineSummary");
            //    }

            //    if (LabelRoll == null)
            //    {
            //        HttpContext.Cache.Remove("LabelRollNumber");
            //        HttpContext.Cache.Remove("NumberOfLabels");
            //        HttpContext.Cache.Remove("LabelRollId");
            //    }

            //    return (ActionResult)this.View("~/Modules/Machine/MachineSummary.cshtml", (object)Model);
            //}
        }

        public async Task<ActionResult> GetMachineSummaryDataAsync(int ModuleId)
        {

            CommonServices objCommonServices = new CommonServices();
            var moduledata = new CVC.Modules.Common.Dashboard.DashboardCommon().GetModule(ModuleId.ToString());
            var Model = new MachineSummaryPageModel() { ViewFieldList = new List<DashBoardField>() };
            Model.ViewFieldList = new List<DashBoardField>();
            if (moduledata.MachineSummary != null)
                Model.ViewFieldList = await new DashboardCommon().GetDashBoardFieldAsync(ModuleId, moduledata.MachineSummary.Value);
            // var batchForLabel = new DashboardCommon().GetBatchForLebelRoll();

            var LabelRoll = new LabelRoll();

            if (objCommonServices.CheckIsLabelRoll(ModuleId) == true)
            {
                Model.IsLabelRoll = true;
                int? machineId = 0;
                if (Session["ModuleId"] != null)
                {
                    string moduleId = Session["ModuleId"].ToString();
                    machineId = new DashboardCommon().GetMachineId(moduleId);
                    LabelRoll = objCommonServices.GetLabelRollDetails(machineId);
                    if (LabelRoll != null)
                    {
                        Model.ViewFieldList.Add(new DashBoardField() { ParameterName = "Label Roll", Value = LabelRoll.LabelRollNumber.ToString(), IPCAddress = "NA" });
                        System.Web.HttpContext.Current.Cache["LabelRollNumber"] = LabelRoll.LabelRollNumber;
                        System.Web.HttpContext.Current.Cache["NumberOfLabels"] = LabelRoll.NumberOfLabels;
                        System.Web.HttpContext.Current.Cache["LabelRollId"] = LabelRoll.LabelRollId;
                        //  Model.ViewFieldList.Add(new DashBoardField() { ParameterName = "Label On Rolls", Value = LabelRoll.NumberOfLabels.ToString(), IPCAddress = "NA" });
                    }
                }
            }
            Model.ViewFieldList = Model.ViewFieldList.Where(a => a.IPCAddress != null).ToList();


            // Model.ViewFieldList = Model.ViewFieldList.Where(a => a.IPCAddress != null).OrderByDescending(a => a.IsMachineSpeed).ToList();
            if (Model.ViewFieldList.Count > 0)
            {
                Model.MachineParameterId = Model.ViewFieldList?.Where(a => a.MachineParameterId > 0)?.FirstOrDefault()?.MachineParameterId ?? 0;
                var machineCommunication = new CVC.BusinessServices.Common.CommonServices().GetMachineCommunicationDetails(Model.MachineParameterId);
                if (machineCommunication != null)
                {
                    Model.ProtocolType = machineCommunication.Protocol.ProtocolName;
                    Model.IPAddress = machineCommunication.IPAddress;
                    Model.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
                    Model.PollRateOverride = machineCommunication?.PollRate ?? 100;

                    if (Model.ProtocolType.ToUpper() == ProtocolType.MDB.ToUpper())
                    {
                        Model.MDBPath = machineCommunication.MDBPath;
                    }
                    else if (Model.ProtocolType.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
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
                Model.MachineId = new DashboardCommon().GetMachineId(Convert.ToString(ModuleId));
                System.Web.HttpContext.Current.Cache.Remove("MachineSummary");
                System.Web.HttpContext.Current.Cache["MachineSummary"] = Model;
            }
            else
            {
                System.Web.HttpContext.Current.Cache.Remove("MachineSummary");
            }

            if (LabelRoll == null)
            {
                System.Web.HttpContext.Current.Cache.Remove("LabelRollNumber");
                System.Web.HttpContext.Current.Cache.Remove("NumberOfLabels");
                System.Web.HttpContext.Current.Cache.Remove("LabelRollId");
            }

            return (ActionResult)this.View("~/Modules/Machine/MachineSummary.cshtml", (object)Model);

        }

        [HttpPost]
        public async Task<ActionResult> GetCustomizePreviewDataAsync(int ViewId)
        {

            CommonServices objCommonServices = new CommonServices();
            int ModuleId = 0;
            var Model = new MachineSummaryPageModel() { ViewFieldList = new List<DashBoardField>() };
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var moduleId = cvcEntities?.Views?.FirstOrDefault(a => a.ViewsId == ViewId)?.ModuleId ?? 0;
                var module = cvcEntities.Modules.FirstOrDefault(a => a.ModuleId == ModuleId);
                ModuleId = module.ModuleId;

                Model.ViewFieldList = await new DashboardCommon().GetDashBoardFieldAsync(ModuleId, ViewId);
                // var batchForLabel = new DashboardCommon().GetBatchForLebelRoll();

                var LabelRoll = new LabelRoll();

                // if (objCommonServices.CheckIsLabelRoll(ModuleId) == true)
                // {
                //     Model.IsLabelRoll = true;
                //     int? machineId = 0;
                //     if (Session["ModuleId"] != null)
                //     {
                //         string moduleId = Session["ModuleId"].ToString();
                //         machineId = new DashboardCommon().GetMachineId(moduleId);
                //         LabelRoll = objCommonServices.GetLabelRollDetails(machineId);
                //         if (LabelRoll != null)
                //         {
                //             Model.ViewFieldList.Add(new DashBoardField() { ParameterName = "Label Roll", Value = LabelRoll.LabelRollNumber.ToString(), IPCAddress = "NA" });
                //             System.Web.HttpContext.Current.Cache["LabelRollNumber"] = LabelRoll.LabelRollNumber;
                //             System.Web.HttpContext.Current.Cache["NumberOfLabels"] = LabelRoll.NumberOfLabels;
                //             System.Web.HttpContext.Current.Cache["LabelRollId"] = LabelRoll.LabelRollId;
                //             //  Model.ViewFieldList.Add(new DashBoardField() { ParameterName = "Label On Rolls", Value = LabelRoll.NumberOfLabels.ToString(), IPCAddress = "NA" });
                //         }
                //     }
                // }
                Model.ViewFieldList = Model.ViewFieldList.Where(a => a.IPCAddress != null).ToList();


                // Model.ViewFieldList = Model.ViewFieldList.Where(a => a.IPCAddress != null).OrderByDescending(a => a.IsMachineSpeed).ToList();
                if (Model.ViewFieldList.Count > 0)
                {
                    Model.MachineParameterId = Model.ViewFieldList?.Where(a => a.MachineParameterId > 0)?.FirstOrDefault()?.MachineParameterId ?? 0;
                    var machineCommunication = new CVC.BusinessServices.Common.CommonServices().GetMachineCommunicationDetails(Model.MachineParameterId);
                    if (machineCommunication != null)
                    {
                        Model.ProtocolType = machineCommunication.Protocol.ProtocolName;
                        Model.IPAddress = machineCommunication.IPAddress;
                        Model.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
                        Model.PollRateOverride = machineCommunication?.PollRate ?? 100;

                        if (Model.ProtocolType.ToUpper() == ProtocolType.MDB.ToUpper())
                        {
                            Model.MDBPath = machineCommunication.MDBPath;
                        }
                        else if (Model.ProtocolType.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
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
                    Model.MachineId = new DashboardCommon().GetMachineId(Convert.ToString(ModuleId));
                    System.Web.HttpContext.Current.Cache.Remove("CustomizePreview");
                    System.Web.HttpContext.Current.Cache["CustomizePreview"] = Model;
                }
                else
                {
                    System.Web.HttpContext.Current.Cache.Remove("CustomizePreview");
                }

                if (LabelRoll == null)
                {
                    System.Web.HttpContext.Current.Cache.Remove("LabelRollNumber");
                    System.Web.HttpContext.Current.Cache.Remove("NumberOfLabels");
                    System.Web.HttpContext.Current.Cache.Remove("LabelRollId");
                }
            }

            JArray jDataArr = new JArray();
            foreach (var item in Model.ViewFieldList)
            {
                JObject jObj = new JObject{
                    {"ParameterName", item.ParameterName},
                    {"Value", item.Value}
                };
                jDataArr.Add(jObj);
            }

            return Json(jDataArr.ToString(), JsonRequestBehavior.AllowGet); // part to customize
            // return "hi, checked";
        }

        public ActionResult IndexAjax(int ModuleId)
        {
            MachineSummaryPageModel Model = new MachineSummaryPageModel();
            try
            {

                if (System.Web.HttpContext.Current.Cache["MachineSummary"] != null)
                {
                    Model = ReadMachineSummary();
                    return Json(Model.ViewFieldList, JsonRequestBehavior.AllowGet);

                    //  return (ActionResult)this.View("~/Modules/Machine/MachineSummary.cshtml", (object)Model);

                }
            }
            catch (System.Exception ex)
            {
                ex = null;
            }
            finally
            {
                Model = null;
            }

            return null;
        }

        //public MachineSummaryPageModel ReadMachineSummary()
        //{

        //    var MaChineSummary = new MachineSummaryPageModel();

        //    try
        //    {
        //        using (CVCEntities cvcEntities = new CVCEntities())
        //        {
        //            using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
        //            {
        //              MaChineSummary = (MachineSummaryPageModel)HttpContext.Cache["MachineSummary"];
        //            var machinePara = new MachineParameter();
        //            machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == MaChineSummary.MachineParameterId);
        //           // var machinePara = CVCDaoFactory.GetMachineParameter(MaChineSummary.MachineParameterId);
        //           // var machineCommunication = CVCDaoFactory.GetMachineCommunication(machinePara.MachineId.Value);
        //            var machineCommunication = new MachineCommunication();
        //            if (cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().Count > 0)
        //            {
        //                machineCommunication = cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().First<MachineCommunication>();
        //            }
        //            if (machineCommunication != null)
        //            {
        //                var ipcpara = machinePara.IPCParameters;
        //                    if (ipcpara.Any())
        //                    {

        //                        modbusTCP.IPAddress = machineCommunication.IPAddress;
        //                        modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
        //                        modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;

        //                        if (MaChineSummary.IsLabelRoll && HttpContext.Cache["LabelRollNumber"] != null)
        //                        {

        //                            if (MaChineSummary.ViewFieldList.Any(v => v.IPCAddress == "NA") == true)
        //                            {
        //                                MaChineSummary.ViewFieldList.Where(v => v.IPCAddress == "NA").Select(v => { v.Value = HttpContext.Cache["LabelRollNumber"].ToString(); return v; }).ToList();
        //                            }
        //                            else
        //                            {
        //                                MaChineSummary.ViewFieldList.Add(new DashBoardField() { ParameterName = "Label Roll", Value = HttpContext.Cache["LabelRollNumber"].ToString(), IPCAddress = "NA" });
        //                            }


        //                            // MaChineSummary.ViewFieldList.Add(new DashBoardField() { ParameterName = "Label On Rolls", Value = HttpContext.Cache["NumberOfLabels"].ToString(), IPCAddress = "NA" });
        //                        }

        //                        foreach (var item in MaChineSummary.ViewFieldList.Where(v => v.IPCAddress != "NA"))
        //                        {
        //                            string address = item.IPCAddress;

        //                           // if(address== "48097")
        //                           // {

        //                           // }
        //                           //else if (address == "48107")
        //                           // {

        //                           // }
        //                           //else if (address == "46721")
        //                           // {

        //                           // }
        //                           //else if (address == "44947")
        //                           // {

        //                           // }
        //                           // else
        //                           // {
        //                           //     continue;
        //                           // }

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


        //                            string SummaryValueFromModBus = modbusTCP.Read(item.IPCAddress);
        //                            // decimal SummaryValue = Convert.ToDecimal(SummaryValueFromModBus);

        //                            if (item.Is32Bit == true)
        //                            {
        //                                string lowerbit = DecimalToBinary(int.Parse(SummaryValueFromModBus));
        //                                string higherbit = DecimalToBinary(int.Parse(modbusTCP.Read(item.Bit32Address)));
        //                                SummaryValueFromModBus = Convert.ToInt32(higherbit + lowerbit, 2).ToString();
        //                            }

        //                            if (item.IsBitWise == true)
        //                            {
        //                                string binaryValue = DecimalToBinary(int.Parse(SummaryValueFromModBus));
        //                                SummaryValueFromModBus = ReverseString(binaryValue).ToString().Substring(item.BitWiseIndex.Value, 1);
        //                            }

        //                            if (item.OperationTypeIPC == 50)
        //                            {
        //                                item.Value = (Decimal.Parse(SummaryValueFromModBus) - item.OperationValueIPC.Value).ToString();
        //                            }

        //                            else if (item.OperationTypeIPC == 51)
        //                            {
        //                                item.Value = (Decimal.Parse(SummaryValueFromModBus) + item.OperationValueIPC.Value).ToString();
        //                            }

        //                            else if (item.OperationTypeIPC == 52)
        //                            {
        //                                item.Value = (Math.Round(Decimal.Parse(SummaryValueFromModBus) / item.OperationValueIPC.Value, 2)).ToString();
        //                            }
        //                            else if (item.OperationTypeIPC == 53)
        //                            {
        //                                item.Value = (Decimal.Parse(SummaryValueFromModBus) * item.OperationValueIPC.Value).ToString();
        //                            }
        //                            else
        //                            {
        //                                item.Value = SummaryValueFromModBus.ToString();
        //                            }

        //                            if (item.IsLabelRollIPC==true)
        //                            {
        //                                var LabelRemaining = 0;
        //                                LabelRemaining =Convert.ToInt32 (item.Value);
        //                                item.BackgroundColor = LabelRemaining <= 500 ? "red" : LabelRemaining <= 1000 ?"yellow":"green";                                        
        //                            }

        //                            if (item.IsGoodBottles==true)
        //                            {
        //                                var GoodBottles = 0;
        //                                var BatchSize= 0;                                       
        //                                GoodBottles = Convert.ToInt32(item.Value);                                 
        //                                BatchSize = item.BatchSizeIPCAddress!=null?Convert.ToInt32(modbusTCP.Read(item.BatchSizeIPCAddress)):0;
        //                                item.BackgroundColor = GoodBottles == BatchSize ? "green" : "yellow";

        //                            }
        //                            if (item.IsRejectBottles==true)
        //                            {
        //                                var TotalBottles = 0;
        //                                var GoodBottles = 0;
        //                                var RejectBottles = 0;
        //                               // var RejectBottlesPercentage = 0;
        //                                RejectBottles = Convert.ToInt32(item.Value);
        //                                GoodBottles = Convert.ToInt32(MaChineSummary.ViewFieldList.Where(vf => vf.IsGoodBottles == true)?.FirstOrDefault()?.Value ?? "0");
        //                                TotalBottles = GoodBottles + RejectBottles;

        //                                var RejectBottlesPercentage = Math.Round(((RejectBottles / (TotalBottles + 0.00)) * 100.00), 2);



        //                                item.BackgroundColor = RejectBottlesPercentage <= 2 ? "green" : RejectBottlesPercentage <= 4 ? "yellow" : "red";

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

        //    return MaChineSummary;
        //}

        public MachineSummaryPageModel ReadMachineSummary()
        {
            var MachineSummaryPanel = new MachineSummaryPageModel();
            try
            {

                MachineSummaryPanel = (MachineSummaryPageModel)System.Web.HttpContext.Current.Cache["MachineSummary"];

                if (MachineSummaryPanel.ProtocolType.ToUpper() == ProtocolType.MDB.ToUpper())
                {
                    return CallMDBMachineSummaryPanel(MachineSummaryPanel);
                }
                else if (MachineSummaryPanel.ProtocolType.ToUpper().Contains(ProtocolType.Modbus.ToUpper()))
                {
                    return CallPLCMachineSummaryPanel(MachineSummaryPanel);
                }


            }
            catch (System.Exception ex)
            {
                ex = null;
            }
            finally
            {
                MachineSummaryPanel = null;
            }
            return null;
        }

        public MachineSummaryPageModel CallMDBMachineSummaryPanel(MachineSummaryPageModel objMachineSummaryPageModel)
        {
            try
            {
                using (OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + objMachineSummaryPageModel.MDBPath + ";Jet OLEDB:Database Password=slkfnsdfkn2148sad;"))
                {
                    if (objMachineSummaryPageModel.IsLabelRoll && (System.Web.HttpContext.Current.Cache["LabelRollNumber"] != null))
                    {
                        if (objMachineSummaryPageModel.ViewFieldList.Any(v => v.IPCAddress == "NA") == true)
                        {
                            objMachineSummaryPageModel.ViewFieldList.Where(v => v.IPCAddress == "NA").Select(v =>
                            {
                                v.Value = (System.Web.HttpContext.Current.Cache["LabelRollNumber"]).ToString();
                                return v;
                            }).ToList();
                        }
                        else
                        {
                            objMachineSummaryPageModel.ViewFieldList.Add(
                                new DashBoardField()
                                {
                                    ParameterName = "Label Roll",
                                    Value = (System.Web.HttpContext.Current.Cache["LabelRollNumber"]).ToString(),
                                    IPCAddress = "NA"
                                });
                        }

                    }


                    OleDbCommand oleDbCommand = new OleDbCommand();
                    oleDbCommand.Connection = oleDbConnection;
                    oleDbConnection.Open();
                    foreach (var item in objMachineSummaryPageModel.ViewFieldList)
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

                            if (item.IsLabelRollIPC == true)
                            {
                                var LabelRemaining = 0;
                                LabelRemaining = Convert.ToInt32(item.Value);
                                item.BackgroundColor = LabelRemaining <= 500 ? "red" : LabelRemaining <= 1000 ? "yellow" : "green";
                            }
                            // denis will see later
                            if (item.IsGoodBottles == true)
                            {
                                var GoodBottles = 0;
                                var BatchSize = 0;
                                GoodBottles = Convert.ToInt32(item.Value);
                                var GetBatchSizeFromMDB = new InterDB().GetMDBDataRowIdWise(objMachineSummaryPageModel.MDBPath, item.BatchSizeRowId);
                                BatchSize = GetBatchSizeFromMDB != null ? Convert.ToInt32(GetBatchSizeFromMDB.Rows[0]["DataArrey"].ToString()) : 0;
                                item.BackgroundColor = GoodBottles == BatchSize ? "green" : "yellow";

                            }

                            if (item.IsRejectBottles == true)
                            {
                                var TotalBottles = 0;
                                var GoodBottles = 0;
                                var RejectBottles = 0;

                                RejectBottles = Convert.ToInt32(item.Value);
                                GoodBottles = Convert.ToInt32(objMachineSummaryPageModel.ViewFieldList.Where(vf => vf.IsGoodBottles == true)?.FirstOrDefault()?.Value ?? "0");
                                TotalBottles = GoodBottles + RejectBottles;
                                var RejectBottlesPercentage = Math.Round(((RejectBottles / (TotalBottles + 0.00)) * 100.00), 2);
                                item.BackgroundColor = RejectBottlesPercentage <= 2 ? "green" : RejectBottlesPercentage <= 4 ? "yellow" : "red";

                            }
                            // denis will see later, end

                        }
                        catch (System.Exception ex)
                        {
                            continue;

                        }

                    }



                }
            }
            catch (System.Exception ex)
            {

            }
            return objMachineSummaryPageModel;
        }
        #region Sr.No.65 Machine Summary Panel Data
        public MachineSummaryPageModel CallPLCMachineSummaryPanel(MachineSummaryPageModel objMachineSummaryPageModel)
        {

            var IPCAddress = "";
            var MachineSummaryValueFromModBus = "";
            string lowerbit = "";
            string higherbit = "";
            string binaryValue = "";

            try
            {

                using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
                {
                    modbusTCP.IPAddress = objMachineSummaryPageModel.IPAddress;
                    modbusTCP.TcpipPort = objMachineSummaryPageModel.TcpipPort;
                    modbusTCP.PollRateOverride = objMachineSummaryPageModel.PollRateOverride;

                    if (objMachineSummaryPageModel.IsLabelRoll && (HttpContext?.Cache["LabelRollNumber"] != null || System.Web.HttpContext.Current.Cache["LabelRollNumber"] != null))
                    {

                        if (objMachineSummaryPageModel.ViewFieldList.Any(v => v.IPCAddress == "NA") == true)
                        {
                            objMachineSummaryPageModel.ViewFieldList.Where(v => v.IPCAddress == "NA")
                                .Select(v =>
                                {
                                    v.Value = (System.Web.HttpContext.Current.Cache["LabelRollNumber"]).ToString();
                                    return v;
                                }).ToList();
                        }
                        else
                        {
                            objMachineSummaryPageModel.ViewFieldList.Add(
                                new DashBoardField()
                                {
                                    ParameterName = "Label Roll",
                                    Value = (System.Web.HttpContext.Current.Cache["LabelRollNumber"]).ToString(),
                                    IPCAddress = "NA"
                                });
                        }

                    }

                    foreach (var item in objMachineSummaryPageModel.ViewFieldList.Where(a => a.IPCAddress != "NA"))
                    {
                        try
                        {

                            IPCAddress = GetFormatedIPCAddress(item.IPCAddress, item?.DataTypeId ?? 0);

                            if (item.IsByteSwap == true)
                            {
                                modbusTCP.SwapBytes = true;
                            }

                            if (item.IsWordSwap == true)
                            {
                                modbusTCP.SwapWords = true;
                            }

                            MachineSummaryValueFromModBus = modbusTCP.Read(IPCAddress);
                            item.Value = MachineSummaryValueFromModBus;

                            if (item.Is32Bit == true)
                            {
                                lowerbit = DecimalToBinary(int.Parse(MachineSummaryValueFromModBus));
                                higherbit = DecimalToBinary(int.Parse(modbusTCP.Read(item.Bit32Address)));
                                MachineSummaryValueFromModBus = Convert.ToInt32(higherbit + lowerbit, 2).ToString();
                                item.Value = MachineSummaryValueFromModBus;
                            }

                            else if (item.IsBitWise == true)
                            {
                                binaryValue = DecimalToBinary(int.Parse(MachineSummaryValueFromModBus));
                                MachineSummaryValueFromModBus = ReverseString(binaryValue).ToString().Substring(item.BitWiseIndex.Value, 1);
                                item.Value = MachineSummaryValueFromModBus;
                            }

                            if (item.OperationTypeIPC > 0)
                            {
                                item.Value = GetParsedValue(MachineSummaryValueFromModBus, item.OperationTypeIPC, item.OperationValueIPC.Value);
                            }

                            if (item.IsLabelRollIPC == true)
                            {
                                var LabelRemaining = 0;
                                LabelRemaining = Convert.ToInt32(item.Value);
                                item.BackgroundColor = LabelRemaining <= 500 ? "red" : LabelRemaining <= 1000 ? "yellow" : "green";
                            }

                            if (item.IsGoodBottles == true)
                            {
                                var GoodBottles = 0;
                                var BatchSize = 0;
                                GoodBottles = Convert.ToInt32(item.Value);
                                BatchSize = item.BatchSizeIPCAddress != null ? Convert.ToInt32(modbusTCP.Read(item.BatchSizeIPCAddress)) : 0;
                                item.BackgroundColor = GoodBottles == BatchSize ? "green" : "yellow";

                            }

                            if (item.IsRejectBottles == true)
                            {
                                var TotalBottles = 0;
                                var GoodBottles = 0;
                                var RejectBottles = 0;

                                RejectBottles = Convert.ToInt32(item.Value);
                                GoodBottles = Convert.ToInt32(objMachineSummaryPageModel.ViewFieldList.Where(vf => vf.IsGoodBottles == true)?.FirstOrDefault()?.Value ?? "0");
                                TotalBottles = GoodBottles + RejectBottles;
                                var RejectBottlesPercentage = Math.Round(((RejectBottles / (TotalBottles + 0.00)) * 100.00), 2);
                                item.BackgroundColor = RejectBottlesPercentage <= 2 ? "green" : RejectBottlesPercentage <= 4 ? "yellow" : "red";

                            }

                        }
                        catch (System.Exception ex)
                        {
                            ex = null;
                            //new DashboardCommon().WriteToFile("Machine Summary", ex.Message, item.Value);
                            continue;
                        }

                    }


                }
                return objMachineSummaryPageModel;
            }
            catch (System.Exception ex)
            {
                ex = null;
            }
            finally
            {
                IPCAddress = null;
                MachineSummaryValueFromModBus = null;
                lowerbit = null;
                higherbit = null;
                binaryValue = null;
                objMachineSummaryPageModel = null;

            }
            return objMachineSummaryPageModel;
        }
        #endregion
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

        public string ReverseString(string val)
        {
            try
            {
                return new string(val.ToCharArray().Reverse().ToArray());

            }
            catch (System.Exception ex)
            {

            }
            finally
            {
                val = null;

            }
            return new string(val.ToCharArray().Reverse().ToArray());

        }

        public string GetParsedValue(string ParaValue, int OperationType, decimal OperationValue)
        {
            try
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
            catch (System.Exception ex)
            {
                ex = null;
            }
            finally
            {
                ParaValue = null;
            }
            return ParaValue;


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


        //public void WriteToFile(string Message)
        //{
        //    string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
        //    if (!Directory.Exists(path))
        //    {
        //        Directory.CreateDirectory(path);
        //    }
        //    string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
        //    if (!File.Exists(filepath))
        //    {
        //        // Create a file to write to.   
        //        using (StreamWriter sw = File.CreateText(filepath))
        //        {
        //            sw.WriteLine(Message);
        //        }
        //    }
        //    else
        //    {
        //        using (StreamWriter sw = File.AppendText(filepath))
        //        {
        //            sw.WriteLine(Message);
        //        }
        //    }
        //}
    }
}



using AdvancedHMIDrivers;
using CVC.Data;
using CVC.Data.EDMX;
using CVC.MDB;
using CVC.Modules.Common.Dashboard;
using CVC.ViewModels;
using Serenity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.SessionState;
using static CVC.BusinessServices.Common.ClsConstants;

namespace CVC.Machine.Pages
{
    [RoutePrefix("CommandPanelMachine")]
    [Route("{action=index}")]
    [SessionState(SessionStateBehavior.Disabled)]
    public class CommandPanelController : Controller
    {
        //  private ModbusTCPCom modbusTCP = new ModbusTCPCom();

        [Authorize]
        [HttpGet]
        public async Task<ActionResult> Index(int ModuleId)
        {

            if (System.Web.HttpContext.Current.Cache["ActiveModuleId"] != null)
            {
                int CacheModuleId = (int)System.Web.HttpContext.Current.Cache["ActiveModuleId"];
                if (CacheModuleId != ModuleId)
                {
                    return await GetCommandPanelDataAsync(ModuleId);
                }

                CommandPanelPageModel Model = ReadCommandPanel();
                return (ActionResult)this.View("~/Modules/Machine/CommandPanel.cshtml", (object)Model);

            }
            else
            {
                return await GetCommandPanelDataAsync(ModuleId);
            }
            //else
            //{

            //    //  HttpContext.Cache.Remove("ModuleId");
            //    // HttpContext.Cache["ModuleId"] = ModuleId;

            //    var moduledata = new CVC.Modules.Common.Dashboard.DashboardCommon().GetModule(ModuleId.ToString());
            //    var Model = new CommandPanelPageModel() { ViewFieldList = new List<DashBoardField>() };
            //    Model.ViewFieldList = new List<DashBoardField>();
            //    if (moduledata.CommandPanel != null && ModuleId == 1)
            //    {

            //        Model.ViewFieldList = new DashboardCommon().GetDashBoardField(ModuleId, moduledata.CommandPanel.Value).Where(a => a.Type == 49).ToList(); // Get Only Button


            //        // ViewBag.MachineType = Model.ViewFieldList.FirstOrDefault().Type;
            //        var mdbVal = new DashboardCommon().CheckCommuniation();

            //        if (Session["Machinevalue"] == null)
            //        {
            //            Session["Machinevalue"] = mdbVal;
            //            ViewBag.notConnected = null;
            //        }
            //        else
            //        {
            //            if (Session["Machinevalue"].ToString() != mdbVal.ToString())
            //            {
            //                Session["Machinevalue"] = mdbVal;
            //                ViewBag.notConnected = null;
            //            }
            //            else
            //            {
            //                ViewBag.notConnected = "true";
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Model.ViewFieldList = new DashboardCommon().GetDashBoardField(ModuleId, moduledata.CommandPanel.Value).Where(a => a.Type != 49).ToList(); // Get Only Button
            //                                                                                                                                                  //if (!Model.ViewFieldList.Any(a=>a.IsConnected == true))
            //                                                                                                                                                  //{
            //                                                                                                                                                  //    ViewBag.notConnected = "True";
            //                                                                                                                                                  //}
            //    }
            //    Model.ViewFieldList = Model.ViewFieldList.Where(a => a.IPCAddress != null).ToList();


            //    if (Model.ViewFieldList.Count > 0)
            //    {
            //        CVCEntities objCVCEntities = new CVCEntities();

            //        var MachineId = objCVCEntities.Modules.Where(a => a.ModuleId == ModuleId).FirstOrDefault().MachineId;

            //        var ProtocolTypeId = objCVCEntities.MachineCommunications.Where(a => a.MachineId == MachineId).FirstOrDefault().ProtocolTypeId;

            //        ViewBag.MachineType = ProtocolTypeId;
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
            //        HttpContext.Cache.Remove("CommandPanel");
            //        HttpContext.Cache["CommandPanel"] = Model;

            //    }
            //    else
            //    {
            //        HttpContext.Cache.Remove("CommandPanel");
            //    }
            //    return (ActionResult)this.View("~/Modules/Machine/CommandPanel.cshtml", (object)Model);
            //}
        }

        public async Task<ActionResult> GetCommandPanelDataAsync(int ModuleId)
        {


            var moduledata = new CVC.Modules.Common.Dashboard.DashboardCommon().GetModule(ModuleId.ToString());
            var Model = new CommandPanelPageModel() { ViewFieldList = new List<DashBoardField>() };
            Model.ViewFieldList = new List<DashBoardField>();
            if (moduledata.CommandPanel != null && ModuleId == 1)
            {

                Model.ViewFieldList =await new DashboardCommon().GetDashBoardFieldAsync(ModuleId, moduledata.CommandPanel.Value); // Get Only Button


                // ViewBag.MachineType = Model.ViewFieldList.FirstOrDefault().Type;
                var mdbVal = new DashboardCommon().CheckCommuniation();

                if (Session["Machinevalue"] == null)
                {
                    Session["Machinevalue"] = mdbVal;
                    ViewBag.notConnected = null;
                }
                else
                {
                    if (Session["Machinevalue"].ToString() != mdbVal.ToString())
                    {
                        Session["Machinevalue"] = mdbVal;
                        ViewBag.notConnected = null;
                    }
                    else
                    {
                        ViewBag.notConnected = "true";
                    }
                }
            }
            else
            {
                Model.ViewFieldList = await new DashboardCommon().GetDashBoardFieldAsync(ModuleId, moduledata.CommandPanel.Value); // Get Only Button
                                                                                                                                                               //if (!Model.ViewFieldList.Any(a=>a.IsConnected == true))                                                                                                                                                         //{
                                                                                                                                                               //    ViewBag.notConnected = "True";                                                                                                                                                        //}
            }

           
                Model.ViewFieldList = Model.ViewFieldList.Where(a => a.IPCAddress != null).ToList();


            int? MachineId = 0;
            if (Model.ViewFieldList.Count > 0)
            {
                CVCEntities objCVCEntities = new CVCEntities();

                 MachineId = objCVCEntities.Modules.Where(a => a.ModuleId == ModuleId).FirstOrDefault().MachineId;

                var ProtocolTypeId = objCVCEntities.MachineCommunications.Where(a => a.MachineId == MachineId).FirstOrDefault().ProtocolTypeId;

                ViewBag.MachineType = ProtocolTypeId;
            }

            if (Model.ViewFieldList.Count > 0)
            {
                Model.MachineParameterId = Model.ViewFieldList.Where(a => a.MachineParameterId > 0).FirstOrDefault().MachineParameterId;
                var machineCommunication = new CVC.BusinessServices.Common.CommonServices().GetMachineCommunicationDetails(Model.MachineParameterId);
                if (machineCommunication != null)
                {
                    Model.ProtocolType = machineCommunication?.Protocol?.ProtocolName?.ToUpper();
                    Model.IPAddress = machineCommunication?.IPAddress;
                    Model.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
                    Model.PollRateOverride = machineCommunication?.PollRate ?? 100;
                    if (Model.ProtocolType.ToUpper() ==ProtocolType.MDB.ToUpper())
                    {
                        Model.MDBPath = machineCommunication.MDBPath;
                    }
                    else if(Model.ProtocolType.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                    {
                       
                        Model.UserName = machineCommunication.UserName;
                        Model.Password = machineCommunication.Password;
                        if (Model.ProtocolType.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                        {
                            OPCUaClientViewModel oPCUaClientViewModel = new OPCUaClientViewModel
                            {
                                ServerAddress = Model.IPAddress,
                                ServerPortNumber =Convert.ToString( Model.TcpipPort),
                            
                            };
                            System.Web.HttpContext.Current.Cache.Remove("OPCUaClientViewModel");
                            System.Web.HttpContext.Current.Cache["OPCUaClientViewModel"] =oPCUaClientViewModel;
                        }
                    }
                    else if (Model.ProtocolType.ToUpper() == ProtocolType.SiemensS7Net.ToUpper())
                    {
                        Model.CpuType = machineCommunication?.PickListValue6?.PickList?.PickListName;
                        Model.Rack = machineCommunication?.Rack;
                        Model.Slot = machineCommunication?.Slot;
                    }
                }
                Model.MachineId = MachineId;
                System.Web.HttpContext.Current.Cache.Remove("CommandPanel");
                System.Web.HttpContext.Current.Cache["CommandPanel"] = Model;

            }
            else
            {
                System.Web.HttpContext.Current.Cache.Remove("CommandPanel");
            }

            using (CVC.BusinessServices.Common.CommonServices objCommonServices = new CVC.BusinessServices.Common.CommonServices())
            {
               var sendHeartBeatViewModel = objCommonServices.CheckHeartBeatSend(ModuleId);
                System.Web.HttpContext.Current.Cache.Remove("SendHeartBeatModelCache");
                if (sendHeartBeatViewModel != null)
                {
                   System.Web.HttpContext.Current.Cache["SendHeartBeatModelCache"] = sendHeartBeatViewModel;                 

                    if (sendHeartBeatViewModel.IsHeartBeatSend == true)
                    {
                        HttpContext.Application["IsSendHeartHeat"] =true;
                        //  Task.Run(()=> new CVC.Modules.Common.Dashboard.DashboardCommon().SendHeartBeat((int)sendHeartBeatViewModel.MachineParameterId, (int)sendHeartBeatViewModel.StartNumber,(int) sendHeartBeatViewModel.IncrementalNumber, (int)sendHeartBeatViewModel.EndNumber));
                    }
                }
            }
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var machineId = cvcEntities.Modules.FirstOrDefault(m => m.ModuleId == ModuleId).MachineId;
                var isWrite = cvcEntities.TerminalMachineMappings.FirstOrDefault(mtm => mtm.MachineId == machineId)?.MasterTerminal.TerminalType.IsWrite ?? false;
                Model.isWriteTerminalType = isWrite;

            }
              
            return (ActionResult)this.View("~/Modules/Machine/CommandPanel.cshtml", (object)Model);


        }

        public ActionResult IndexAjax(int ModuleId)
        {
            CommandPanelPageModel Model = new CommandPanelPageModel();
            try
            {
                System.Web.HttpContext.Current.Cache["ActiveModuleId"] = ModuleId;

                if (System.Web.HttpContext.Current.Cache["CommandPanel"] != null)
                {
                    Model = ReadCommandPanel();
                    return Json(Model.ViewFieldList, JsonRequestBehavior.AllowGet);
                    // return (ActionResult)this.View("~/Modules/Machine/CommandPanel.cshtml", (object)Model);
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

        //public CommandPanelPageModel ReadCommandPanel()
        //{
        //   var CommandPanel = new CommandPanelPageModel();

        //    try
        //    {
        //        using (CVCEntities cvcEntities = new CVCEntities())
        //        {
        //            using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
        //            {
        //                CommandPanel = (CommandPanelPageModel)HttpContext.Cache["CommandPanel"];
        //                var machinePara = new MachineParameter();
        //                machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == CommandPanel.MachineParameterId);
        //                // var machinePara = CVCDaoFactory.GetMachineParameter(CommandPanel.MachineParameterId);
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
        //                        modbusTCP.IPAddress = machineCommunication.IPAddress;
        //                        modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
        //                        modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;

        //                        foreach (var item in CommandPanel.ViewFieldList)
        //                        {
        //                            string address = item.IPCAddress;

        //                            if (item.DataTypeId == 9) 
        //                            {

        //                                address = "F" + item.IPCAddress;
        //                            }

        //                            if (item.DataTypeId == 10 || item.DataTypeId == 1) 
        //                            {

        //                                address = "U" + item.IPCAddress;
        //                            }

        //                            if (item.DataTypeId == 8 || item.DataTypeId == 5) 
        //                            {

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

        //                            var CommandPanelValueFromModBus=modbusTCP.Read(address);


        //                            if (item.Is32Bit == true)
        //                            {
        //                                string lowerbit = DecimalToBinary(int.Parse(CommandPanelValueFromModBus));
        //                                string higherbit = DecimalToBinary(int.Parse(modbusTCP.Read(item.Bit32Address)));
        //                                CommandPanelValueFromModBus = Convert.ToInt32(higherbit + lowerbit, 2).ToString();
        //                                item.Value = CommandPanelValueFromModBus;
        //                            }

        //                           else if (item.IsBitWise == true)
        //                            {
        //                                string binaryValue = DecimalToBinary(int.Parse(CommandPanelValueFromModBus));
        //                                CommandPanelValueFromModBus = ReverseString(binaryValue).ToString().Substring(item.BitWiseIndex.Value, 1);
        //                                item.Value = CommandPanelValueFromModBus;
        //                            }

        //                            else
        //                            {
        //                                item.Value = CommandPanelValueFromModBus;
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

        //    return CommandPanel;
        //}

        public CommandPanelPageModel ReadCommandPanel()
        {
            var CommandPanel = new CommandPanelPageModel();
            try
            {

                CommandPanel = (CommandPanelPageModel)System.Web.HttpContext.Current.Cache["CommandPanel"];

                if (CommandPanel.ProtocolType.ToUpper() ==ProtocolType.MDB.ToUpper())
                {
                    return CallMDBMachineCommandPanel(CommandPanel);
                }
                else if (CommandPanel.ProtocolType.ToUpper().Contains(ProtocolType.Modbus.ToUpper()))
                {
                    return CallPLCMachineCommandPanel(CommandPanel);
                }
                else if (CommandPanel.ProtocolType.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                {
                }
            }
            catch (System.Exception ex)
            {
                ex = null;
            }
            finally
            {
                CommandPanel = null;
            }
            return null;
        }

        public CommandPanelPageModel CallMDBMachineCommandPanel(CommandPanelPageModel objCommandPanelPageModel)
        {
            try
            {

                using (OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + objCommandPanelPageModel.MDBPath + ";Jet OLEDB:Database Password=slkfnsdfkn2148sad;"))
                {
                    OleDbCommand oleDbCommand = new OleDbCommand();
                    oleDbCommand.Connection = oleDbConnection;
                    oleDbConnection.Open();
                    foreach (var item in objCommandPanelPageModel.ViewFieldList)
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
            return objCommandPanelPageModel;
        }

        #region Sr.No.65 Command Panel Data
        public CommandPanelPageModel CallPLCMachineCommandPanel(CommandPanelPageModel objCommandPanelPageModel)
        {
            var IPCAddress = "";
            var CommandPanelValueFromModBus = "";
            string lowerbit = "";
            string higherbit = "";
            string binaryValue = "";

            try
            {
              //  System.Web.HttpContext.Current.Cache["ActiveModuleId"] = objCommandPanelPageModel.ModuleId;

                using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
                {
                    modbusTCP.IPAddress = objCommandPanelPageModel.IPAddress;
                    modbusTCP.TcpipPort = objCommandPanelPageModel.TcpipPort;
                    modbusTCP.PollRateOverride = objCommandPanelPageModel.PollRateOverride;

                    foreach (var item in objCommandPanelPageModel.ViewFieldList)
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
                            CommandPanelValueFromModBus = modbusTCP.Read(IPCAddress);
                            /* ModBusRead:*/

                            //if (string.IsNullOrEmpty(CommandPanelValueFromModBus))
                            //{
                            //    goto ModBusRead;
                            //}

                            if (item.Is32Bit == true)
                            {
                                lowerbit = DecimalToBinary(int.Parse(CommandPanelValueFromModBus));
                                higherbit = DecimalToBinary(int.Parse(modbusTCP.Read(item.Bit32Address)));
                                CommandPanelValueFromModBus = Convert.ToInt32(higherbit + lowerbit, 2).ToString();
                                item.Value = CommandPanelValueFromModBus;
                            }

                            else if (item.IsBitWise == true)
                            {
                                binaryValue = DecimalToBinary(int.Parse(CommandPanelValueFromModBus));
                                CommandPanelValueFromModBus = ReverseString(binaryValue).ToString().Substring(item.BitWiseIndex.Value, 1);
                                item.Value = CommandPanelValueFromModBus;
                            }

                            else
                            {
                                item.Value = CommandPanelValueFromModBus;
                            }
                        }
                        catch (System.Exception ex)
                        {
                            ex = null;
                            //WriteToFile("exception" + ex.Message);
                            continue;
                        }

                    }


                }
                return objCommandPanelPageModel;
            }
            catch (System.Exception ex)
            {

                ex = null;

            }
            finally
            {
                IPCAddress = null;
                CommandPanelValueFromModBus = null;
                lowerbit = null;
                higherbit = null;
                binaryValue = null;
                objCommandPanelPageModel = null;

            }
            return objCommandPanelPageModel;
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

    }


}

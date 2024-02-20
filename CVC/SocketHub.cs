using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using CVC.Machine;
using CVC.Machine.Pages;
using CVC.Modules.Common.Dashboard;
using Newtonsoft.Json;
using System.Web.Mvc;
using System.IO;
using static CVC.BusinessServices.Common.ClsConstants;
using CVC.OpcUaClient;
using CVC.ViewModels;
using CVC.SiemensS7Net;
using System.Threading.Tasks;

namespace CVC
{
    public class SocketHub : Hub
    {

        //public void Hello()
        //{
        //    Clients.All.hello();
        //}


        public void Send(string name, string message)
        {

            int? moduleId = 0;
            int? machineParameterId = 0;
            int? value = 0;
            int? incrementalNumber = 0;
            int? endNumber = 0;
            CommandPanelPageModel model;
            MachineSummaryPageModel msp;
            AlarmSummaryController asc = new AlarmSummaryController();
            var mspResponse = string.Empty;
            var cpResponse = string.Empty;
            var apResponse = string.Empty; ;
            var apJsonResult = new JsonResult();
            var record = new string[] { };
            var shbresponse = string.Empty;
            // var heartBeatValue = "";
            try
            {
                if (name.Contains("alarmmachine") || name.Contains("raisealarm"))
                {
                    record = name.Split('-');
                    moduleId = Convert.ToInt32(record[1]);
                    name = record[0].ToString();
                    //  heartBeatValue= record[2].ToString();
                }
                if (name.Contains("sendheartbeat"))
                {
                    record = name.Split('-');
                    machineParameterId = Convert.ToInt32(record[1]);
                    value = Convert.ToInt32(record[2]);
                    incrementalNumber = Convert.ToInt32(record[3]);
                    endNumber = Convert.ToInt32(record[4]);
                    name = record[0];
                }
                //if (name.Contains("readheartbeat"))
                //{
                //    var record = name.Split('-');
                //    machineParameterId = Convert.ToInt32(record[1]);
                //    IPCAddress = record[2];
                //    name = record[0];
                //}
                switch (name)
                {
                    case "commandpanel":
                        model = ReadCommandPanel();
                        if (model != null)
                        {
                            cpResponse = "{\"type\":\"commandpanel\", \"data\":" + JsonConvert.SerializeObject(model.ViewFieldList) + "}";

                            //cpResponse = "{\"type\":\"commandpanel\", \"data\":" + JsonConvert.SerializeObject(model.ViewFieldList.Select(c => new { c.ViewFieldId, c.Value, c.DataTypeId })) + "}";
                            Clients.All.addNewMessageToPage(cpResponse, message);
                        }
                        else
                        {
                            cpResponse = "{\"type\":\"commandpanel\", \"data\":null}";
                            Clients.All.addNewMessageToPage(cpResponse, message);
                        }
                        break;
                    case "machinesummary":
                        msp = ReadMachineSummary();
                        if (msp != null)
                        {
                            mspResponse = "{\"type\":\"machinesummary\", \"data\":" + JsonConvert.SerializeObject(msp.ViewFieldList) + "}";

                            //  mspResponse = "{\"type\":\"machinesummary\", \"data\":" + JsonConvert.SerializeObject(msp.ViewFieldList.Select(s => new { s.ViewFieldId, s.Value, s.BackgroundColor })) + "}";
                            Clients.All.addNewMessageToPage(mspResponse, message);
                        }
                        else
                        {
                            mspResponse = "{\"type\":\"machinesummary\", \"data\":null}";
                            Clients.All.addNewMessageToPage(mspResponse, message);
                        }
                        break;
                    case "raisealarm":
                        // asc = new AlarmSummaryController();
                        apJsonResult = asc.CheckRaisedAlarm((int)moduleId);
                        if (apJsonResult != null)
                        {
                            apResponse = "{\"type\":\"raisealarm\", \"data\":" + JsonConvert.SerializeObject(apJsonResult) + "}";

                            Clients.All.addNewMessageToPage(apResponse, message);
                        }
                        else
                        {
                            apResponse = "{\"type\":\"raisealarm\", \"data\":null}";
                            Clients.All.addNewMessageToPage(apResponse, message);
                        }
                        break;
                    case "customizePreview":
                        msp = ReadCustomizePreview();
                        if (msp != null)
                        {
                            mspResponse = "{\"type\":\"customizePreview\", \"data\":" + JsonConvert.SerializeObject(msp.ViewFieldList) + "}";

                            //  mspResponse = "{\"type\":\"machinesummary\", \"data\":" + JsonConvert.SerializeObject(msp.ViewFieldList.Select(s => new { s.ViewFieldId, s.Value, s.BackgroundColor })) + "}";
                            Clients.All.addNewMessageToPage(mspResponse, message);
                        }
                        else
                        {
                            mspResponse = "{\"type\":\"customizePreview\", \"data\":null}";
                            Clients.All.addNewMessageToPage(mspResponse, message);
                        }
                        break;
                    case "displaypreview":
                        msp = ReadDisplayPreview();
                        if (msp != null)
                        {
                            mspResponse = "{\"type\":\"displaypreview\", \"data\":" + JsonConvert.SerializeObject(msp.ViewFieldList) + "}";

                            //  mspResponse = "{\"type\":\"machinesummary\", \"data\":" + JsonConvert.SerializeObject(msp.ViewFieldList.Select(s => new { s.ViewFieldId, s.Value, s.BackgroundColor })) + "}";
                            Clients.All.addNewMessageToPage(mspResponse, message);
                        }
                        else
                        {
                            mspResponse = "{\"type\":\"displaypreview\", \"data\":null}";
                            Clients.All.addNewMessageToPage(mspResponse, message);
                        }
                        break;
                    //case "alarmmachine":
                    //    AlarmPageModel apm = GetAlarm(moduleId);
                    //    if (apm != null)
                    //    {              
                    //        var response = "{\"type\":\"alarmmachine\", \"data\":" + JsonConvert.SerializeObject(apm) + "}";
                    //        Clients.All.addNewMessageToPage(response, message);
                    //    }
                    //    else
                    //    {
                    //        var response = "{\"type\":\"alarmmachine\", \"data\":null}";
                    //        Clients.All.addNewMessageToPage(response, message);
                    //    }
                    //    break;

                    //case "sendheartbeat":
                    //    apJsonResult = asc.SendHeartBeat((int)machineParameterId,(int)value,(int)incrementalNumber,(int)endNumber);
                    //    if (apJsonResult != null)
                    //    {
                    //        shbresponse = "{\"type\":\"sendheartbeat\", \"data\":" + apJsonResult.Data + "}";
                    //        Clients.All.addNewMessageToPage(shbresponse, message);
                    //    }
                    //    else
                    //    {
                    //        shbresponse = "{\"type\":\"sendheartbeat\", \"data\":null}";
                    //        Clients.All.addNewMessageToPage(shbresponse, message);
                    //    }
                    //    break;
                    //case "readheartbeat":
                    //    RenderViewFieldsController rvfrhb = new RenderViewFieldsController();
                    //    var readHeartBeatResult = rvfrhb.ReadHeartBeat(machineParameterId, IPCAddress);
                    //    if (readHeartBeatResult != null)
                    //    {
                    //        var response = "{\"type\":\"readheartbeat\", \"data\":" + readHeartBeatResult.Data + "}";
                    //        Clients.All.addNewMessageToPage(response,message);
                    //    }
                    //    else
                    //    {
                    //        var response = "{\"type\":\"readheartbeat\", \"data\":null}";
                    //        Clients.All.addNewMessageToPage(response,message);
                    //    }
                    //    break;
                    default:
                        break;
                }
                // Call the addNewMessageToPage method to update clients.
                //Clients.All.addNewMessageToPage(name, message);
            }
            catch (Exception ex)
            {
                ex = null;

            }
            finally
            {
                name = null;
                message = null;
                moduleId = null;
                value = null;
                incrementalNumber = null;
                endNumber = null;
                // IPCAddress = null;
                model = null; ;
                msp = null;
                asc = null;
                mspResponse = null;
                cpResponse = null;
                apResponse = null;
                apJsonResult = null;
                record = null;
                Clients = null;
                machineParameterId = null;
                shbresponse = string.Empty;
            }
        }

        private CommandPanelPageModel ReadCommandPanel()
        {
            CommandPanelController cpc = new CommandPanelController();
            var CommandPanel = new CommandPanelPageModel();
            ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
            ClsSiemensS7Net clsSiemensS7Net = new ClsSiemensS7Net();
            try
            {

                CommandPanel = (CommandPanelPageModel)HttpContext.Current.Cache["CommandPanel"];

                if (CommandPanel.ProtocolType.ToUpper() == ProtocolType.MDB.ToUpper())
                {
                    return cpc.CallMDBMachineCommandPanel(CommandPanel);
                }
                else if (CommandPanel.ProtocolType.ToUpper().Contains(ProtocolType.Modbus.ToUpper()))
                {
                    return cpc.CallPLCMachineCommandPanel(CommandPanel);
                }
                else if (CommandPanel.ProtocolType.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                {
                    return clsOpcUaClient.ReadCommandPanel(CommandPanel);
                }
                else if (CommandPanel.ProtocolType.ToUpper() == ProtocolType.SiemensS7Net.ToUpper())
                {
                    return clsSiemensS7Net.ReadCommandPanel(CommandPanel);
                }
            }
            catch (Exception ex)
            {
                ex = null;
            }
            finally
            {
                cpc = null;
                CommandPanel = null;
                clsOpcUaClient = null;

            }
            return null;
        }

        private MachineSummaryPageModel ReadMachineSummary()
        {
            MachineSummaryController msc = new MachineSummaryController();
            var MachineSummaryPanel = new MachineSummaryPageModel();
            ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
            ClsSiemensS7Net clsSiemensS7Net = new ClsSiemensS7Net();


            try
            {
                MachineSummaryPanel = (MachineSummaryPageModel)HttpContext.Current.Cache["MachineSummary"];

                if (MachineSummaryPanel.ProtocolType.ToUpper() == ProtocolType.MDB.ToUpper())
                {
                    return msc.CallMDBMachineSummaryPanel(MachineSummaryPanel);
                }
                else if (MachineSummaryPanel.ProtocolType.ToUpper().Contains(ProtocolType.Modbus.ToUpper()))
                {
                    return msc.CallPLCMachineSummaryPanel(MachineSummaryPanel);
                }
                else if (MachineSummaryPanel.ProtocolType.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                {
                    return clsOpcUaClient.ReadMachineSummaryPanel(MachineSummaryPanel);
                }
                else if (MachineSummaryPanel.ProtocolType.ToUpper() == ProtocolType.SiemensS7Net.ToUpper())
                {
                    return clsSiemensS7Net.ReadMachineSummaryPanel(MachineSummaryPanel);
                }
            }
            catch (Exception ex)
            {
                ex = null;
            }
            finally
            {
                msc = null;
                MachineSummaryPanel = null;

            }
            return null;


        }

        private MachineSummaryPageModel ReadCustomizePreview()
        {
            MachineSummaryController msc = new MachineSummaryController();
            var MachineSummaryPanel = new MachineSummaryPageModel();
            ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
            ClsSiemensS7Net clsSiemensS7Net = new ClsSiemensS7Net();


            try
            {
                MachineSummaryPanel = (MachineSummaryPageModel)HttpContext.Current.Cache["CustomizePreview"];

                if (MachineSummaryPanel.ProtocolType.ToUpper() == ProtocolType.MDB.ToUpper())
                {
                    return msc.CallMDBMachineSummaryPanel(MachineSummaryPanel);
                }
                else if (MachineSummaryPanel.ProtocolType.ToUpper().Contains(ProtocolType.Modbus.ToUpper()))
                {
                    return msc.CallPLCMachineSummaryPanel(MachineSummaryPanel);
                }
                else if (MachineSummaryPanel.ProtocolType.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                {
                    return clsOpcUaClient.ReadMachineSummaryPanel(MachineSummaryPanel);
                }
                else if (MachineSummaryPanel.ProtocolType.ToUpper() == ProtocolType.SiemensS7Net.ToUpper())
                {
                    return clsSiemensS7Net.ReadMachineSummaryPanel(MachineSummaryPanel);
                }
            }
            catch (Exception ex)
            {
                ex = null;
            }
            finally
            {
                msc = null;
                MachineSummaryPanel = null;

            }
            return null;

        }

        private MachineSummaryPageModel ReadDisplayPreview()
        {
            MachineSummaryController msc = new MachineSummaryController();
            var MachineSummaryPanel = new MachineSummaryPageModel();
            ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
            ClsSiemensS7Net clsSiemensS7Net = new ClsSiemensS7Net();


            try
            {
                MachineSummaryPanel = (MachineSummaryPageModel)HttpContext.Current.Cache["DisplayPreview"];

                if (MachineSummaryPanel.ProtocolType.ToUpper() == ProtocolType.MDB.ToUpper())
                {
                    return msc.CallMDBMachineSummaryPanel(MachineSummaryPanel);
                }
                else if (MachineSummaryPanel.ProtocolType.ToUpper().Contains(ProtocolType.Modbus.ToUpper()))
                {
                    return msc.CallPLCMachineSummaryPanel(MachineSummaryPanel);
                }
                else if (MachineSummaryPanel.ProtocolType.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                {
                    return clsOpcUaClient.ReadMachineSummaryPanel(MachineSummaryPanel);
                }
                else if (MachineSummaryPanel.ProtocolType.ToUpper() == ProtocolType.SiemensS7Net.ToUpper())
                {
                    return clsSiemensS7Net.ReadMachineSummaryPanel(MachineSummaryPanel);
                }
            }
            catch (Exception ex)
            {
                ex = null;
            }
            finally
            {
                msc = null;
                MachineSummaryPanel = null;

            }
            return null;

        }


        //private AlarmPageModel GetAlarm(int moduleId)
        //{
        //    var Model = new AlarmPageModel();
        //    var MachineId = Convert.ToInt32(System.Web.HttpContext.Current.Cache["MachineId"]);
        //    Model.AlarmsExist = new DashboardCommon().GetAlarmExist(moduleId, MachineId);
        //    Model.IsRefreshMachineSettings = Model.AlarmsExist.Any(a => a.Item5 == true);
        //    return Model;

        //}

        //private string RenderViewToString(ControllerContext context, string viewName, object model)
        //{
        //    if (string.IsNullOrEmpty(viewName))
        //        viewName = context.RouteData.GetRequiredString("action");

        //    var viewData = new ViewDataDictionary(model);

        //    using (var sw = new StringWriter())
        //    {
        //        var viewResult = ViewEngines.Engines.FindPartialView(context, viewName);
        //        var viewContext = new ViewContext(context, viewResult.View, viewData, new TempDataDictionary(), sw);
        //        viewResult.View.Render(viewContext, sw);

        //        return sw.GetStringBuilder().ToString();
        //    }
        //}
    }
}
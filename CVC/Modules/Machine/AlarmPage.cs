// Decompiled with JetBrains decompiler
// Type: CVC.Machine.Pages.AlarmController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Data;
using CVC.Data.EDMX;
using CVC.MDB;
using CVC.Modules.Common.Dashboard;
using Serenity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Web;
using CVC.Modules.Common.MachineDashboard;
using System;
using Serenity.Services;
using System.Web.SessionState;
using AdvancedHMIDrivers;
using System.Linq.Expressions;
using System.IO;
using CVC.ViewModels;
using CVC.Modules.Common.CommonServices;
using static CVC.BusinessServices.Common.ClsConstants;
using CVC.OpcUaClient;
using bs = CVC.BusinessServices.Common;
using CVC.BusinessServices.Common;


namespace CVC.Machine.Pages
{
    [RoutePrefix("AlarmMachine")]
    [Route("{action=index}")]
    [SessionState(SessionStateBehavior.Disabled)]

    public class AlarmSummaryController : Controller
    {
        bs.CommonServices commonServices = new bs.CommonServices();

        //  static ConnectMachine mdb = new ConnectMachine();
        //List<string> lstIPCAddress = new List<string>();
        // static string rearHeartBeatValue = "-1";
        //  static CVCEntities cvcEntities = new CVCEntities();
        // List<Alarm> items = cvcEntities.Alarms.Where(a => a.Machine.MachineCommunications.Any(c => (c.ProtocolTypeId == 4 || c.ProtocolTypeId == 1) && c.StatusId == 1)).ToList();
        [Authorize]
        [HttpGet]
        public ActionResult Index(int ModuleId)
        {
        
            var Model = new AlarmPageModel();
            var MachineId = 0;
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                MachineId = cvcEntities.Modules?.FirstOrDefault(a => a.ModuleId == ModuleId)?.MachineId.Value ?? 0;
                System.Web.HttpContext.Current.Cache.Remove("MachineId");
                System.Web.HttpContext.Current.Cache["MachineId"] = MachineId;
            }

            Model.AlarmsExist = new DashboardCommon().GetAlarmExist(ModuleId, MachineId); // changes added by Vinayak On 02.08.2018
            Session["AlarmData"] = Model.AlarmsExist;
            Session["ModuleId"] = ModuleId;
            Model.IsRefreshMachineSettings = Model.AlarmsExist.Any(a => a.Item5 == true);
            var alarmData = new List<AlarmViewModel>();
            using (CVCEntities cvcEntities = new CVCEntities())
            {

                alarmData = (from i in cvcEntities.IPCParameters
                             join a in cvcEntities.Alarms on i.MachineParameterId equals a.MachineParameterId
                             where i.IsAlarm == true && i.MachineId == MachineId && i.StatusId == 1
                             orderby i.IPCAddress
                             select new AlarmViewModel {
                                 AlarmId = a.AlarmId,
                                 AlarmName = a.AlarmName,
                                 IsCommentRequired = (bool)a.IsCommentRequired,
                                 IsRefreshMachineSettings = a.IsRefreshMachineSettings,
                                 IPCAddress = i.IPCAddress,
                                 MachineParameterId = (int)i.MachineParameterId,
                                 IsByteSwap = i.IsByteSwap,
                                 IsWordSwap = i.IsWordSwap,
                                 IsBitWise = i.IsBitWise,
                                 DataTypeId = i.MachineParameter.DataTypeId,
                                 BitWiseIndex = i.BitWiseIndex,
                                 IsHeartBeat = i.IsHeartBeat != true ? false : true,
                                 IsHideEdit =a.IsHideEdit,IsShowAsMessage=i.IsShowAsMessageIPC,
                                 NodeId=i.NodeId,
                                 AttributeId=i.AttributeId

                             }).ToList();

                System.Web.HttpContext.Current.Cache.Remove("AlarmPanelCache");
                System.Web.HttpContext.Current.Cache["AlarmPanelCache"] = alarmData;
                System.Web.HttpContext.Current.Cache.Remove("AlarmIPCAddressCache");
                System.Web.HttpContext.Current.Cache["AlarmIPCAddressCache"] = alarmData.Select(a => a.IPCAddress).Distinct().ToList();
                System.Web.HttpContext.Current.Cache.Remove("HeartBeatCache");
                System.Web.HttpContext.Current.Cache["HeartBeatCache"] = "-1";


                // System.Web.HttpContext.Current.Cache["AlarmIPCAddressCache"] = alarmData.Where(a => a.IPCAddress=="44997").Select(a=>a.IPCAddress).Distinct().ToList();
                var missingLabelAlarms = cvcEntities.Alarms.Where(a =>a.MachineId==MachineId && a.IsAlarmForCounter == true && a.StatusId == (int)CVC.BusinessServices.Common.ClsConstants.StatusType.Active).ToList();
                if (missingLabelAlarms.Any())
                {
                    Model.lstMisssingLabelAlarmModels = missingLabelAlarms.Select(x => new MisssingLabelAlarmModel
                    {
                        MachineParameterId = x.MachineParameterId,
                        MissingLabelAlarmName = x.AlarmName,
                        // MissingLabelTime=x.MissingLabelTime

                    }).ToList();
                    //if(missingLabelInMilliseconds>0)
                    //{
                    //    missingLabelInMilliseconds = missingLabelInMilliseconds * 1000;
                    //}
                    Model.TimerForAlarm = 1000 * (cvcEntities.Machines.FirstOrDefault(m => m.MachineId == MachineId)?.TimerForAlarm ?? 0);
                }
            }


            //06
            return (ActionResult)this.View("~/Modules/Machine/Alarm.cshtml", (object)Model);
        }

        public ActionResult IndexAjax(int ModuleId)
        {
            var Model = new AlarmPageModel();
            var MachineId = Convert.ToInt32(System.Web.HttpContext.Current.Cache["MachineId"]);
            Model.AlarmsExist = new DashboardCommon().GetAlarmExist(ModuleId, MachineId); // changes added by Vinayak On 02.08.2018
                                                                                          //  Session["AlarmData"] = Model.AlarmsExist;
                                                                                          // Session["ModuleId"] = ModuleId;
            Model.IsRefreshMachineSettings = Model.AlarmsExist.Any(a => a.Item5 == true);
            return (ActionResult)this.View("~/Modules/Machine/Alarm.cshtml", (object)Model);
        }

        public string RenderRazorViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                var controller = new AlarmSummaryController();
                System.Web.Routing.RouteData route = new System.Web.Routing.RouteData();
                route.Values.Add("action", "AlarmSummary"); // ActionName, but it not required
                route.Values.Add("controller", controller.GetType().Name
                                                    .ToLower()
                                                    .Replace("controller", ""));
                var ctxt = new ControllerContext(new HttpContextWrapper(System.Web.HttpContext.Current), route, controller);
                var viewResult = ViewEngines.Engines.FindPartialView(ctxt,
                                                                         viewName);
                var viewContext = new ViewContext(ctxt, viewResult.View,
                                             ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(ctxt, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }

        //public AlarmPageModel CheckAlarm2()
        //{
        //    var alarmModel = new AlarmPageModel() { AlarmsExist = new List<Tuple<string, string, bool, int,bool?>>() };
        //    try
        //    {

        //        var result = mdb.GetExistingAlarms();
        //        alarmModel.AlarmsExist.AddRange(result);

        //        //               Parallel.ForEach(items, item =>
        //        //               {
        //        //                   //myThread.Start();
        //        //                   if (item.MachineParameterId != null)
        //        //                   {

        //        //                       string value = mdb.Read(item.MachineParameterId.Value);
        //        //                       if (!string.IsNullOrEmpty(value))
        //        //                       {
        //        //                           if (value == "1")
        //        //                           {
        //        //                               alarmModel.AlarmsExist.Add(new Tuple<string, string, bool, int>(item.AlarmName, item.Message, Convert.ToBoolean(item.IsCommentRequired), item.AlarmId));
        //        //                           }
        //        //                       }
        //        //                   }

        //        //               }
        //        //);

        //        // Check For MDB Only As of Now

        //        //foreach (var item in items)
        //        //{
        //        //    //Thread myThread = new Thread(() => this.CheckMDBValue(item));
        //        //    //myThread.Start();
        //        //    if (item.MachineParameterId != null)
        //        //    {

        //        //        string value = mdb.Read(item.MachineParameterId.Value);
        //        //        if (!string.IsNullOrEmpty(value))
        //        //        {
        //        //            if (value == "1")
        //        //            {
        //        //                alarmModel.AlarmsExist.Add(new Tuple<string, string, bool, int>(item.AlarmName, item.Message, Convert.ToBoolean(item.IsCommentRequired), item.AlarmId));
        //        //            }
        //        //        }
        //        //    }
        //        //}
        //        return alarmModel;

        //        // Check For PLC Connection/ ModBus

        //    }
        //    catch (System.Exception ex)
        //    {

        //    }
        //    return alarmModel;
        //}

        //public AlarmPageModel CheckAlarm1()
        //{
        //    var alarmModel = new AlarmPageModel() { AlarmsExist = new List<Tuple<string, string, bool, int>>() };
        //    try
        //    {
        //        // Check For MDB Only As of Now

        //        foreach (var item in items)
        //        {
        //            //Thread myThread = new Thread(() => this.CheckMDBValue(item));
        //            //myThread.Start();
        //            if (item.MachineParameterId != null)
        //            {

        //                string value = mdb.Read(item.MachineParameterId.Value);
        //                if (!string.IsNullOrEmpty(value))
        //                {
        //                    if (value == "1")
        //                    {
        //                        alarmModel.AlarmsExist.Add(new Tuple<string, string, bool, int>(item.AlarmName, item.Message, Convert.ToBoolean(item.IsCommentRequired), item.AlarmId));
        //                    }
        //                }
        //            }
        //        }
        //        return alarmModel;

        //        // Check For PLC Connection/ ModBus

        //    }
        //    catch (System.Exception ex)
        //    {

        //    }
        //    return alarmModel;
        //}

        public string SaveComments(string taboneAddedBoxjsonArr)
        {
            var lstjsonRoomparameter = JsonConvert.DeserializeObject<List<jsonRoomparameter>>(taboneAddedBoxjsonArr);
            string machineId = Session["ModuleId"].ToString();
            foreach (var item in lstjsonRoomparameter)
            {
                bool IsSave = new DashboardCommon().SaveAlarmComments(item.AlarmId, item.Comments, machineId);
            }
            return "";
        }

        public string SessionModuleId(string Mid)
        {
            Session["RequestRecipeSection"] = "ApplyRecipe";
            Session["ModuleIdRecipe"] = Mid;
            return "";
        }

        public JsonResult IndexAjax1(int ModuleId)
        {

            var Model = new AlarmPageModel();
            Model.Alarms = new DashboardCommon().GetAlarmByModule(ModuleId);

            //return ((object)Model);

            return Json(Model.Alarms, JsonRequestBehavior.AllowGet);
        }

        public void CheckAlarm()
        {
            try
            {
                CVCEntities cvcEntities = new CVCEntities();

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
                            ////  In Case Of Alarm Is Raised and Not Changed Since Last Time insert In Log
                            //if (mdbValue && (item.lastvalue == null || (item.lastvalue != null && item.lastvalue != mdbValue)))
                            //{
                            //    AlarmLog log = new AlarmLog();
                            //    log.MachineId = item.MachineId;
                            //    log.AlarmId = item.AlarmId;
                            //    log.LoggedUserId = null;
                            //    log.AlarmDateTime = DateTime.Now;
                            //    log.BatchId = GetCurrentRunningBatch();
                            //    cvcEntities.AlarmLogs.Add(log);
                            //    cvcEntities.SaveChanges();
                            //}


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

                // Check For PLC Connection/ ModBus

            }
            catch (System.Exception ex)
            {

            }
        }

        public int? GetCurrentRunningBatch()
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                if (cvcEntities.Batches.Any(a => a.BatchStatus == "Batch Started"))
                {
                    return cvcEntities.Batches.Where(a => a.BatchStatus == "Batch Started").OrderByDescending(a => a.BatchId).FirstOrDefault().BatchId;
                }
            }
            return null;
        }

        //public ActionResult CheckAlarmNew1(int ModuleId)

        //public JsonResult CheckAlarmNew1(int ModuleId)
        //{
        //    try
        //    {
        //        int MachineId = 0;
        //        MachineId = (int)System.Web.HttpContext.Current.Cache["ActiveMachineId"];
        //        if (lstIPCAddress.Count == 0)
        //        {
        //            using (CVCEntities cvcEntities = new CVCEntities())
        //            {

        //                var data = (from i in cvcEntities.IPCParameters
        //                            join a in cvcEntities.Alarms on i.MachineParameterId equals a.MachineParameterId
        //                            where i.IsAlarm == true && i.MachineId == MachineId && i.StatusId == 1
        //                            select new { IPCAddress = i.IPCAddress }).ToList();
        //                lstIPCAddress = data.Select(a => a.IPCAddress).Distinct().ToList();

        //            }

        //        }
        //        var CommandPanel = new CommandPanelPageModel();
        //        CommandPanel = (CommandPanelPageModel)System.Web.HttpContext.Current.Cache["CommandPanel"];
        //        using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
        //        {
        //            modbusTCP.IPAddress = CommandPanel.IPAddress;
        //            modbusTCP.TcpipPort = CommandPanel.TcpipPort;
        //            modbusTCP.PollRateOverride = CommandPanel.PollRateOverride;

        //            foreach (var IPCAddress in lstIPCAddress)
        //            {
        //                try
        //                {

        //                    using (CVCEntities cvcEntities = new CVCEntities())
        //                    {
        //                        var modbusOutput = "";
        //                        var binaryValue = string.Empty;
        //                        var machinePara = new MachineParameter();
        //                        var MachineParameterId = cvcEntities.IPCParameters.Where(i => i.IPCAddress == IPCAddress && i.MachineId == MachineId && i.IsAlarm == true && i.StatusId == 1).FirstOrDefault()?.MachineParameterId ?? 0;

        //                        machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == MachineParameterId && a.MachineId == MachineId && a.StatusId == 1);

        //                        var ipcpara = machinePara.IPCParameters;
        //                        // if (ipcpara.Any())
        //                        {
        //                            var address = IPCAddress;


        //                            if (machinePara.DataTypeId == 9) // Siemens Float or SWAP FLOAT
        //                            {
        //                                // this.modbusTCP.SwapWords = true;
        //                                address = "F" + address;
        //                            }

        //                            if (machinePara.DataTypeId == 10) //D-WORD
        //                            {
        //                                // this.modbusTCP.SwapWords = false;
        //                                address = "U" + address;
        //                            }

        //                            if (machinePara.DataTypeId == 8) //WORD
        //                            {
        //                                // this.modbusTCP.SwapWords = false;
        //                                // address = "L" + address;
        //                            }

        //                            if (ipcpara.FirstOrDefault().IsByteSwap == true)
        //                            {
        //                                modbusTCP.SwapBytes = true;
        //                            }

        //                            if (ipcpara.FirstOrDefault().IsWordSwap == true)
        //                            {
        //                                modbusTCP.SwapWords = true;
        //                            }

        //                            modbusOutput = modbusTCP.Read(address);


        //                            if (ipcpara.FirstOrDefault().IsBitWise == true)
        //                            {
        //                                binaryValue = DecimalToBinary(int.Parse(modbusOutput));
        //                                modbusOutput = ReverseString(binaryValue).ToString().Substring(ipcpara.FirstOrDefault().BitWiseIndex.Value, 1);
        //                            }
        //                            else
        //                            {

        //                            }



        //                        }
        //                        var res = modbusOutput;
        //                        if (modbusOutput == "t" || modbusOutput == "f")
        //                        {

        //                        }
        //                        if (modbusOutput == "True" || modbusOutput == "False")
        //                        {
        //                            var GetMachineParameterId = cvcEntities.IPCParameters.Where(x => x.IPCAddress == IPCAddress && x.MachineId == MachineId && x.StatusId == 1).FirstOrDefault()?.MachineParameterId ?? 0;
        //                            var updateAlarm = cvcEntities.Alarms.FirstOrDefault(a => a.MachineParameterId == GetMachineParameterId);
        //                            if (updateAlarm != null)
        //                            {  //comment on 04-01-20 
        //                                updateAlarm.lastvalue = modbusOutput == "True" ? true : false;
        //                                cvcEntities.Entry<Alarm>(updateAlarm).State = System.Data.Entity.EntityState.Modified;
        //                                cvcEntities.SaveChanges();
        //                                if (modbusOutput == "True")
        //                                {
        //                                    // AddAlarmLog(updateAlarm, true, cvcEntities);
        //                                }
        //                            }
        //                        }
        //                        else
        //                        {
        //                            binaryValue = ReverseString(binaryValue);

        //                            if (binaryValue.Contains("1"))
        //                            {
        //                                for (int i = 0; i < binaryValue.Length; i++)
        //                                {
        //                                    if (binaryValue[i].ToString() == "1")
        //                                    {
        //                                        var GetMachineParameterId = cvcEntities.IPCParameters.Where(x => x.IPCAddress == IPCAddress && x.MachineId == MachineId && x.BitWiseIndex == i && x.StatusId == 1).FirstOrDefault()?.MachineParameterId ?? 0;
        //                                        var updateAlarm = cvcEntities.Alarms.FirstOrDefault(a => a.MachineParameterId == GetMachineParameterId);
        //                                        if (updateAlarm != null)
        //                                        {  //comment on 04-01-20 
        //                                            updateAlarm.lastvalue = true;
        //                                            cvcEntities.Entry<Alarm>(updateAlarm).State = System.Data.Entity.EntityState.Modified;
        //                                            cvcEntities.SaveChanges();

        //                                            //  AddAlarmLog(updateAlarm, true, cvcEntities);
        //                                        }
        //                                    }
        //                                    else
        //                                    {
        //                                        var GetMachineParameterId = cvcEntities.IPCParameters.Where(x => x.IPCAddress == IPCAddress && x.MachineId == MachineId && x.BitWiseIndex == i && x.StatusId == 1).FirstOrDefault()?.MachineParameterId ?? 0;
        //                                        var updateAlarm = cvcEntities.Alarms.FirstOrDefault(a => a.MachineParameterId == GetMachineParameterId);
        //                                        if (updateAlarm != null)
        //                                        {  //comment on 04-01-20 
        //                                            updateAlarm.lastvalue = false;
        //                                            cvcEntities.Entry<Alarm>(updateAlarm).State = System.Data.Entity.EntityState.Modified;
        //                                            cvcEntities.SaveChanges();
        //                                        }
        //                                    }
        //                                }
        //                            }
        //                            else
        //                            {
        //                                for (int i = 0; i < binaryValue.Length; i++)
        //                                {

        //                                    var GetMachineParameterId = cvcEntities.IPCParameters.Where(x => x.IPCAddress == IPCAddress && x.MachineId == MachineId && x.BitWiseIndex == i && x.StatusId == 1).FirstOrDefault()?.MachineParameterId ?? 0;
        //                                    var updateAlarm = cvcEntities.Alarms.FirstOrDefault(a => a.MachineParameterId == GetMachineParameterId);
        //                                    if (updateAlarm != null)
        //                                    {
        //                                        //comment on 04-01-20 
        //                                        updateAlarm.lastvalue = false;
        //                                        cvcEntities.Entry<Alarm>(updateAlarm).State = System.Data.Entity.EntityState.Modified;
        //                                        cvcEntities.SaveChanges();

        //                                        UpdateAlarmLog(updateAlarm, false, cvcEntities);
        //                                    }


        //                                }
        //                            }

        //                        }

        //                    }
        //                }
        //                catch (System.Exception ex)
        //                {
        //                    continue;
        //                }
        //            }

        //        }




        //        //    foreach (var IPCAddress in lstIPCAddress)
        //        //{
        //        //    using (CVCEntities cvcEntities = new CVCEntities())
        //        //    {
        //        //        var MachineParameterId = cvcEntities.IPCParameters.Where(i => i.IPCAddress == IPCAddress).FirstOrDefault()?.MachineParameterId ?? 0;
        //        //        var GetAlarmBits = ReadAlarm(IPCAddress, MachineParameterId);
        //        //       // var GetAlarmBits = new CVC.PLC.AlarmOperation().ReadAlarm(IPCAddress, MachineParameterId);

        //        //        GetAlarmBits = ReverseString(GetAlarmBits);



        //        //        if (GetAlarmBits.Contains("1"))
        //        //        {
        //        //            for (int i = 0; i < GetAlarmBits.Length - 1; i++)
        //        //            {
        //        //                if (GetAlarmBits[i].ToString() == "1")
        //        //                {
        //        //                    var GetMachineParameterId = cvcEntities.IPCParameters.Where(x => x.IPCAddress == IPCAddress && x.BitWiseIndex == i).FirstOrDefault()?.MachineParameterId ?? 0;
        //        //                    var updateAlarm = cvcEntities.Alarms.FirstOrDefault(a => a.MachineParameterId == GetMachineParameterId);
        //        //                    if (updateAlarm != null)
        //        //                    {
        //        //                        updateAlarm.lastvalue = true;
        //        //                        cvcEntities.Entry<Alarm>(updateAlarm).State = System.Data.Entity.EntityState.Modified;
        //        //                        cvcEntities.SaveChanges();

        //        //                        AddAlarmLog(updateAlarm, true, cvcEntities);
        //        //                    }
        //        //                }
        //        //                else
        //        //                {
        //        //                    var GetMachineParameterId = cvcEntities.IPCParameters.Where(x => x.IPCAddress == IPCAddress && x.BitWiseIndex == i).FirstOrDefault()?.MachineParameterId ?? 0;
        //        //                    var updateAlarm = cvcEntities.Alarms.FirstOrDefault(a => a.MachineParameterId == GetMachineParameterId);
        //        //                    if (updateAlarm != null)
        //        //                    {
        //        //                        updateAlarm.lastvalue = false;
        //        //                        cvcEntities.Entry<Alarm>(updateAlarm).State = System.Data.Entity.EntityState.Modified;
        //        //                        cvcEntities.SaveChanges();
        //        //                    }
        //        //                }
        //        //            }
        //        //        }
        //        //        else
        //        //        {
        //        //            for (int i = 0; i < GetAlarmBits.Length - 1; i++)
        //        //            {

        //        //                var GetMachineParameterId = cvcEntities.IPCParameters.Where(x => x.IPCAddress == IPCAddress && x.BitWiseIndex == i).FirstOrDefault()?.MachineParameterId ?? 0;
        //        //                var updateAlarm = cvcEntities.Alarms.FirstOrDefault(a => a.MachineParameterId == GetMachineParameterId);
        //        //                if (updateAlarm != null)
        //        //                {
        //        //                    updateAlarm.lastvalue = false;
        //        //                    cvcEntities.Entry<Alarm>(updateAlarm).State = System.Data.Entity.EntityState.Modified;
        //        //                    cvcEntities.SaveChanges();

        //        //                    UpdateAlarmLog(updateAlarm, false, cvcEntities);
        //        //                }


        //        //            }
        //        //        }



        //        //    }


        //        //}

        //    }
        //    catch (System.Exception ex)
        //    {
        //        ex = null;
        //        //WriteToFile("exception" + ex.Message);
        //    }

        //    finally
        //    {
        //        GC.Collect();
        //    }
        //    return Json("Alarm Successfully updated", JsonRequestBehavior.AllowGet);
        //}
        #region Sr.No.65 Alarm Panel Data
        public JsonResult CheckRaisedAlarm(int ModuleId)
        {
            //   var CommandPanel = new CommandPanelPageModel();
            var machineCommunication = new MachineCommunicationViewModel();
            var alarmData = new List<AlarmViewModel>();
            int MachineId = 0;
            var modbusOutput = "";
            var binaryValue = string.Empty;
            var machineParameterData = new AlarmViewModel();
            var address = "";
            var activeAlarm = new AlarmViewModel();
            var heartBeatValue = "";
            var opcUaClientOutput = "";

            try
            {
                MachineId = (int)System.Web.HttpContext.Current.Cache["ActiveMachineId"];

                var protocolType = System.Web.HttpContext.Current.Cache["ProtocolType"];
                machineCommunication = commonServices.GetCacheData(ClsCacheConfig.CacheKeys.MachineCommunication);

                if (protocolType?.ToString()?.ToUpper() == ProtocolType.MDB.ToUpper())
                {
                }
                else if (protocolType.ToString().ToUpper().Contains(ProtocolType.Modbus.ToUpper()))
                {
                    // CommandPanel = (CommandPanelPageModel)System.Web.HttpContext.Current.Cache["CommandPanel"];

                    var lstIPCAddress = (List<string>)System.Web.HttpContext.Current.Cache["AlarmIPCAddressCache"];
                    alarmData = (List<AlarmViewModel>)System.Web.HttpContext.Current.Cache["AlarmPanelCache"];

                    using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
                    {
                        modbusTCP.IPAddress = machineCommunication.IPAddress;
                        modbusTCP.TcpipPort =(ushort) machineCommunication.TCPIPPort;
                        modbusTCP.PollRateOverride = machineCommunication?.PollRate??0;

                        foreach (var IPCAddress in lstIPCAddress)
                        {
                            try
                            {
                            // var status=   PingHost(modbusTCP.IPAddress, modbusTCP.TcpipPort);
                                machineParameterData = alarmData.Where(i => i.IPCAddress == IPCAddress).FirstOrDefault();
                                address = GetFormatedIPCAddress(IPCAddress, machineParameterData?.DataTypeId ?? 0);

                                if (machineParameterData.IsByteSwap == true)
                                {
                                    modbusTCP.SwapBytes = true;
                                }

                                if (machineParameterData.IsWordSwap == true)
                                {
                                    modbusTCP.SwapWords = true;
                                }

                                modbusOutput = modbusTCP.Read(address);


                                if (machineParameterData.IsBitWise == true)
                                {
                                    binaryValue = DecimalToBinary(int.Parse(modbusOutput));
                                    // modbusOutput = ReverseString(binaryValue).ToString().Substring(machineParameterData.BitWiseIndex.Value, 1);

                                    binaryValue = ReverseString(binaryValue);

                                    if (binaryValue.Contains("1"))
                                    {
                                        for (int i = 0; i < binaryValue.Length; i++)
                                        {
                                            if (binaryValue[i].ToString() == "1")
                                            {

                                                activeAlarm = alarmData.FirstOrDefault(x => x.IPCAddress == IPCAddress && x.BitWiseIndex == i);
                                                if (activeAlarm != null)
                                                {
                                                    if (activeAlarm.IsAlarmRaised != true)
                                                    {
                                                        if (activeAlarm.IsShowAsMessage != true)
                                                        {
                                                            AddAlarmLog(MachineId, activeAlarm.AlarmId, true);
                                                        }
                                                        // Task.Run(() => AddAlarmLog(MachineId, activeAlarm.AlarmId, true));
                                                        activeAlarm.IsAlarmRaised = true;
                                                        var action = (bool)activeAlarm.IsShowAsMessage ? "Message Occured" : "Alarm Occured";
                                                        AddAuditLog(action, "", "", activeAlarm.AlarmName, "", "", null, MachineId);
                                                    }
                                                }
                                            }
                                            else
                                            {

                                                activeAlarm = alarmData.FirstOrDefault(x => x.IPCAddress == IPCAddress && x.BitWiseIndex == i);
                                                if (activeAlarm != null)
                                                {
                                                    var action = (bool)activeAlarm.IsShowAsMessage ? "Message Reset" : "Alarm Reset";

                                                    if (activeAlarm.IsAlarmRaised == true)
                                                    {
                                                        AddAuditLog(action, "", "", activeAlarm.AlarmName, "", "", null, MachineId);

                                                    }
                                                    activeAlarm.IsAlarmRaised = false;
                                                }

                                            }
                                        }
                                    }
                                    else
                                    {
                                        for (int i = 0; i < binaryValue.Length; i++)
                                        {
                                            activeAlarm = alarmData.FirstOrDefault(x => x.IPCAddress == IPCAddress && x.BitWiseIndex == i);
                                            if (activeAlarm != null)
                                            {
                                                var action = (bool)activeAlarm.IsShowAsMessage ? "Message Reset" : "Alarm Reset";

                                                if (activeAlarm.IsAlarmRaised == true)
                                                {
                                                    AddAuditLog(action, "", "", activeAlarm.AlarmName, "", "", null, MachineId);

                                                }
                                                activeAlarm.IsAlarmRaised = false;
                                            }

                                        }
                                    }


                                }
                                else
                                {
                                    if (machineParameterData.IsHeartBeat)
                                    {

                                        activeAlarm = alarmData.FirstOrDefault(x => x.IPCAddress == IPCAddress);
                                        if (activeAlarm != null)
                                        {
                                            var action = (bool)activeAlarm.IsShowAsMessage ? "Message" : "Alarm";


                                            heartBeatValue = Convert.ToString(System.Web.HttpContext.Current.Cache["HeartBeatCache"]);
                                            if (heartBeatValue == modbusOutput)
                                            {
                                                if (activeAlarm.IsAlarmRaised != true)
                                                {
                                                    activeAlarm.IsAlarmRaised = true;
                                                    if (activeAlarm.IsShowAsMessage != true)
                                                    {
                                                        AddAlarmLog(MachineId, activeAlarm.AlarmId, true);
                                                    }
                                                    AddAuditLog($"{action} Occured", "", "", activeAlarm.AlarmName, "", "", null, MachineId);
                                                }

                                            }
                                            else if (activeAlarm.IsAlarmRaised != null && activeAlarm.IsAlarmRaised != false)
                                            {
                                                activeAlarm.IsAlarmRaised = false;
                                                AddAuditLog($"{action} Reset", "", "", activeAlarm.AlarmName, "", "", null, MachineId);
                                            }
                                            // heartBeatValue = modbusOutput;
                                            System.Web.HttpContext.Current.Cache.Remove("HeartBeatCache");
                                            System.Web.HttpContext.Current.Cache["HeartBeatCache"] = modbusOutput;

                                        }
                                    }
                                    else
                                    {
                                        var action = (bool)activeAlarm.IsShowAsMessage ? "Message" : "Alarm";

                                        activeAlarm = alarmData.FirstOrDefault(x => x.IPCAddress == IPCAddress);
                                        if (activeAlarm != null)
                                        {
                                            if (modbusOutput == "1" && activeAlarm.IsAlarmRaised != true)
                                            {
                                                activeAlarm.IsAlarmRaised = true;
                                                if (activeAlarm.IsShowAsMessage != true)
                                                {
                                                    AddAlarmLog(MachineId, activeAlarm.AlarmId, true);
                                                }
                                                AddAuditLog($"{action} Occured", "", "", activeAlarm.AlarmName, "", "", null, MachineId);

                                            }
                                            else if (modbusOutput == "0" && (activeAlarm.IsAlarmRaised != null && activeAlarm.IsAlarmRaised != false))
                                            {
                                                activeAlarm.IsAlarmRaised = false;
                                                AddAuditLog($"{action} Reset", "", "", activeAlarm.AlarmName, "", "", null, MachineId);

                                            }
                                        }
                                    }
                                }




                            }
                            //catch (System.Exception ex)
                            //{
                            //    ex = null;

                            //    if (machineParameterData.IsHeartBeat)
                            //    {
                            //        activeAlarm = alarmData.FirstOrDefault(x => x.IPCAddress == IPCAddress);
                            //        activeAlarm.IsAlarmRaised = true;
                            //        return Json(alarmData.Where(a => a.IsAlarmRaised == true), JsonRequestBehavior.AllowGet);

                            //    }
                            //    continue;
                            //}

                            catch (System.Exception ex)
                            {

                                ex = null;
                                if (machineParameterData.IsHeartBeat)
                                {
                                    activeAlarm = alarmData.FirstOrDefault(x => x.IPCAddress == IPCAddress);
                                    if (activeAlarm != null)
                                    {
                                        if (activeAlarm.IsAlarmRaised != true)
                                        {
                                            activeAlarm.IsAlarmRaised = true;
                                            // Task.Run(() => AddAlarmLog(MachineId, activeAlarm.AlarmId, true));
                                            // Task.Run(() => AddAuditLog("Alarm Occured", "", "", activeAlarm.AlarmName, "", "", null, MachineId)); 
                                            AddAlarmLog(MachineId, activeAlarm.AlarmId, true);
                                            AddAuditLog("Alarm Occured", "", "", activeAlarm.AlarmName, "", "", null, MachineId);
                                        }

                                    }
                                }


                                //if (machineParameterData.IsHeartBeat)
                                //{
                                //    activeAlarm = alarmData.FirstOrDefault(x => x.IPCAddress == IPCAddress);
                                //    activeAlarm.IsAlarmRaised = true;
                                //    AddAlarmLog(MachineId, activeAlarm.AlarmId, true);
                                //    AddAuditLog("Alarm Occured", "", "", activeAlarm.AlarmName, "", "", null, MachineId);

                                //}
                                continue;
                            }
                        }


                        //return Json(alarmData.Where(a => a.IsAlarmRaised == true).Select(a => new
                        //{
                        //    a.AlarmId,
                        //    a.AlarmName,
                        //    a.IsHeartBeat,

                        //}), JsonRequestBehavior.AllowGet);
                        return Json(alarmData.Where(a => a.IsAlarmRaised == true), JsonRequestBehavior.AllowGet);
                    }

                }
                //else if (protocolType?.ToString()?.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                //{
                //    ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();
                //    var response= clsOpcUaClient.ReadAlarmPanel();
                //    return Json(response.Where(a => a.IsAlarmRaised == true), JsonRequestBehavior.AllowGet);

                //}
                else if (protocolType?.ToString()?.ToUpper() == ProtocolType.OPCUaClient.ToUpper())
                {
                     machineCommunication = commonServices.GetCacheData(ClsCacheConfig.CacheKeys.MachineCommunication);

                   // CommandPanel = (CommandPanelPageModel)System.Web.HttpContext.Current.Cache["CommandPanel"];
                    alarmData = (List<AlarmViewModel>)System.Web.HttpContext.Current.Cache["AlarmPanelCache"];
                    var lstNodeId = (List<string>)alarmData.Select(a => a.NodeId).Distinct().ToList(); ;

                    

                        foreach (var nodeId in lstNodeId)
                        {
                            try
                           {
                            machineParameterData = alarmData.Where(i => i.NodeId == nodeId)?.FirstOrDefault();

                            ClsOpcUaClient clsOpcUaClient = new ClsOpcUaClient();

                                OPCUaClientViewModel oPCUaClientViewModel = new OPCUaClientViewModel
                                {
                                    NodeId=nodeId,
                                    AttributeId=13

                                };
                                opcUaClientOutput = clsOpcUaClient.Read(oPCUaClientViewModel);


                                if (machineParameterData.IsBitWise == true)
                                {
                                    binaryValue = DecimalToBinary(int.Parse(opcUaClientOutput));
                                    // modbusOutput = ReverseString(binaryValue).ToString().Substring(machineParameterData.BitWiseIndex.Value, 1);

                                    binaryValue = ReverseString(binaryValue);

                                    if (binaryValue.Contains("1"))
                                    {
                                        for (int i = 0; i < binaryValue.Length; i++)
                                        {
                                            if (binaryValue[i].ToString() == "1")
                                            {

                                                activeAlarm = alarmData.FirstOrDefault(x => x.NodeId == nodeId && x.BitWiseIndex == i);
                                                if (activeAlarm != null)
                                                {
                                                    if (activeAlarm.IsAlarmRaised != true)
                                                    {
                                                        if (activeAlarm.IsShowAsMessage != true)
                                                        {
                                                            AddAlarmLog(MachineId, activeAlarm.AlarmId, true);
                                                        }
                                                        // Task.Run(() => AddAlarmLog(MachineId, activeAlarm.AlarmId, true));
                                                        activeAlarm.IsAlarmRaised = true;
                                                        var action = (bool)activeAlarm.IsShowAsMessage ? "Message Occured" : "Alarm Occured";
                                                        AddAuditLog(action, "", "", activeAlarm.AlarmName, "", "", null, MachineId);
                                                    }
                                                }
                                            }
                                            else
                                            {

                                                activeAlarm = alarmData.FirstOrDefault(x => x.NodeId == nodeId && x.BitWiseIndex == i);
                                                if (activeAlarm != null)
                                                {
                                                    var action = (bool)activeAlarm.IsShowAsMessage ? "Message Reset" : "Alarm Reset";

                                                    if (activeAlarm.IsAlarmRaised == true)
                                                    {
                                                        AddAuditLog(action, "", "", activeAlarm.AlarmName, "", "", null, MachineId);

                                                    }
                                                    activeAlarm.IsAlarmRaised = false;
                                                }

                                            }
                                        }
                                    }
                                    else
                                    {
                                        for (int i = 0; i < binaryValue.Length; i++)
                                        {
                                            activeAlarm = alarmData.FirstOrDefault(x => x.NodeId == nodeId && x.BitWiseIndex == i);
                                            if (activeAlarm != null)
                                            {
                                                var action = (bool)activeAlarm.IsShowAsMessage ? "Message Reset" : "Alarm Reset";

                                                if (activeAlarm.IsAlarmRaised == true)
                                                {
                                                    AddAuditLog(action, "", "", activeAlarm.AlarmName, "", "", null, MachineId);

                                                }
                                                activeAlarm.IsAlarmRaised = false;
                                            }

                                        }
                                    }


                                }
                                else
                                {
                                    if (machineParameterData.IsHeartBeat)
                                    {

                                        activeAlarm = alarmData.FirstOrDefault(x => x.NodeId == nodeId);
                                        if (activeAlarm != null)
                                        {
                                            var action = (bool)activeAlarm.IsShowAsMessage ? "Message" : "Alarm";


                                            heartBeatValue = Convert.ToString(System.Web.HttpContext.Current.Cache["HeartBeatCache"]);
                                            if (heartBeatValue == opcUaClientOutput)
                                            {
                                                if (activeAlarm.IsAlarmRaised != true)
                                                {
                                                    activeAlarm.IsAlarmRaised = true;
                                                    if (activeAlarm.IsShowAsMessage != true)
                                                    {
                                                        AddAlarmLog(MachineId, activeAlarm.AlarmId, true);
                                                    }
                                                    AddAuditLog($"{action} Occured", "", "", activeAlarm.AlarmName, "", "", null, MachineId);
                                                }

                                            }
                                            else if (activeAlarm.IsAlarmRaised != null && activeAlarm.IsAlarmRaised != false)
                                            {
                                                activeAlarm.IsAlarmRaised = false;
                                                AddAuditLog($"{action} Reset", "", "", activeAlarm.AlarmName, "", "", null, MachineId);
                                            }
                                            // heartBeatValue = modbusOutput;
                                            System.Web.HttpContext.Current.Cache.Remove("HeartBeatCache");
                                            System.Web.HttpContext.Current.Cache["HeartBeatCache"] = opcUaClientOutput;

                                        }
                                    }
                                    else
                                    {
                                        var action = (bool)activeAlarm.IsShowAsMessage ? "Message" : "Alarm";

                                        activeAlarm = alarmData.FirstOrDefault(x => x.NodeId == nodeId);
                                        if (activeAlarm != null)
                                        {
                                            if (opcUaClientOutput == "1" && activeAlarm.IsAlarmRaised != true)
                                            {
                                                activeAlarm.IsAlarmRaised = true;
                                                if (activeAlarm.IsShowAsMessage != true)
                                                {
                                                    AddAlarmLog(MachineId, activeAlarm.AlarmId, true);
                                                }
                                                AddAuditLog($"{action} Occured", "", "", activeAlarm.AlarmName, "", "", null, MachineId);

                                            }
                                            else if (opcUaClientOutput == "0" && (activeAlarm.IsAlarmRaised != null && activeAlarm.IsAlarmRaised != false))
                                            {
                                                activeAlarm.IsAlarmRaised = false;
                                                AddAuditLog($"{action} Reset", "", "", activeAlarm.AlarmName, "", "", null, MachineId);

                                            }
                                        }
                                    }
                                }




                            }
                            catch (System.Exception ex)
                            {
                                ex = null;

                                if (machineParameterData.IsHeartBeat)
                                {
                                    activeAlarm = alarmData.FirstOrDefault(x => x.NodeId == nodeId);
                                    activeAlarm.IsAlarmRaised = true;
                                    return Json(alarmData.Where(a => a.IsAlarmRaised == true), JsonRequestBehavior.AllowGet);

                                }
                                continue;
                            }
                        }


                        //return Json(alarmData.Where(a => a.IsAlarmRaised == true).Select(a => new
                        //{
                        //    a.AlarmId,
                        //    a.AlarmName,
                        //    a.IsHeartBeat,

                        //}), JsonRequestBehavior.AllowGet);
                        return Json(alarmData.Where(a => a.IsAlarmRaised == true), JsonRequestBehavior.AllowGet);

                }

                else if(protocolType?.ToString()?.ToUpper()==ProtocolType.SiemensS7Net.ToUpper())
                {
                    alarmData = (List<AlarmViewModel>)System.Web.HttpContext.Current.Cache["AlarmPanelCache"];
                    alarmData = AlarmOperation(machineParameterData, alarmData, activeAlarm);
                     return Json(alarmData, JsonRequestBehavior.AllowGet);

                }



                // var CommandPanel = new CommandPanelPageModel();





            }
            catch (System.Exception ex)
            {
                ex = null;
            }

            finally
            {
                // MachineId = null;

                //CommandPanel = null;
                machineCommunication = null;
                alarmData = null;
                // int MachineId = 0;
                modbusOutput = null;
                binaryValue = null;
                machineParameterData = null;
                address = null;
                activeAlarm = null;
                heartBeatValue = null;
                // rearHeartBeatValue = null;
                // GC.Collect();
            }
            return Json(null, JsonRequestBehavior.AllowGet);

        }
        #endregion

        public List<AlarmViewModel> AlarmOperation( AlarmViewModel machineParameterData, List<AlarmViewModel> alarmData, AlarmViewModel activeAlarm)
        {
            //   var CommandPanel = new CommandPanelPageModel();
            var machineCommunication = new MachineCommunicationViewModel();
            int MachineId = 0;
            var modbusOutput = "";
            var binaryValue = string.Empty;
            var heartBeatValue = "";

            try
            {
                MachineId = (int)System.Web.HttpContext.Current.Cache["ActiveMachineId"];

                var protocolType = System.Web.HttpContext.Current.Cache["ProtocolType"];

                
                // CommandPanel = (CommandPanelPageModel)System.Web.HttpContext.Current.Cache["CommandPanel"];
                machineCommunication = commonServices.GetCacheData(ClsCacheConfig.CacheKeys.MachineCommunication);

                var lstIPCAddress = (List<string>)System.Web.HttpContext.Current.Cache["AlarmIPCAddressCache"];
                alarmData = (List<AlarmViewModel>)System.Web.HttpContext.Current.Cache["AlarmPanelCache"];


                foreach (var IPCAddress in lstIPCAddress)
                {
                    try
                    {
                        if (machineParameterData.IsBitWise == true)
                        {
                            binaryValue = DecimalToBinary(int.Parse(modbusOutput));
                            // modbusOutput = ReverseString(binaryValue).ToString().Substring(machineParameterData.BitWiseIndex.Value, 1);

                            binaryValue = ReverseString(binaryValue);

                            if (binaryValue.Contains("1"))
                            {
                                for (int i = 0; i < binaryValue.Length; i++)
                                {
                                    if (binaryValue[i].ToString() == "1")
                                    {

                                        activeAlarm = alarmData.FirstOrDefault(x => x.IPCAddress == IPCAddress && x.BitWiseIndex == i);
                                        if (activeAlarm != null)
                                        {
                                            if (activeAlarm.IsAlarmRaised != true)
                                            {
                                                if (activeAlarm.IsShowAsMessage != true)
                                                {
                                                    AddAlarmLog(MachineId, activeAlarm.AlarmId, true);
                                                }
                                                // Task.Run(() => AddAlarmLog(MachineId, activeAlarm.AlarmId, true));
                                                activeAlarm.IsAlarmRaised = true;
                                                var action = (bool)activeAlarm.IsShowAsMessage ? "Message Occured" : "Alarm Occured";
                                                AddAuditLog(action, "", "", activeAlarm.AlarmName, "", "", null, MachineId);
                                            }
                                        }
                                    }
                                    else
                                    {

                                        activeAlarm = alarmData.FirstOrDefault(x => x.IPCAddress == IPCAddress && x.BitWiseIndex == i);
                                        if (activeAlarm != null)
                                        {
                                            var action = (bool)activeAlarm.IsShowAsMessage ? "Message Reset" : "Alarm Reset";

                                            if (activeAlarm.IsAlarmRaised == true)
                                            {
                                                AddAuditLog(action, "", "", activeAlarm.AlarmName, "", "", null, MachineId);

                                            }
                                            activeAlarm.IsAlarmRaised = false;
                                        }

                                    }
                                }
                            }
                            else
                            {
                                for (int i = 0; i < binaryValue.Length; i++)
                                {
                                    activeAlarm = alarmData.FirstOrDefault(x => x.IPCAddress == IPCAddress && x.BitWiseIndex == i);
                                    if (activeAlarm != null)
                                    {
                                        var action = (bool)activeAlarm.IsShowAsMessage ? "Message Reset" : "Alarm Reset";

                                        if (activeAlarm.IsAlarmRaised == true)
                                        {
                                            AddAuditLog(action, "", "", activeAlarm.AlarmName, "", "", null, MachineId);

                                        }
                                        activeAlarm.IsAlarmRaised = false;
                                    }

                                }
                            }


                        }
                        else
                        {
                            if (machineParameterData.IsHeartBeat)
                            {

                                activeAlarm = alarmData.FirstOrDefault(x => x.IPCAddress == IPCAddress);
                                if (activeAlarm != null)
                                {
                                    var action = (bool)activeAlarm.IsShowAsMessage ? "Message" : "Alarm";


                                    heartBeatValue = Convert.ToString(System.Web.HttpContext.Current.Cache["HeartBeatCache"]);
                                    if (heartBeatValue == modbusOutput)
                                    {
                                        if (activeAlarm.IsAlarmRaised != true)
                                        {
                                            activeAlarm.IsAlarmRaised = true;
                                            if (activeAlarm.IsShowAsMessage != true)
                                            {
                                                AddAlarmLog(MachineId, activeAlarm.AlarmId, true);
                                            }
                                            AddAuditLog($"{action} Occured", "", "", activeAlarm.AlarmName, "", "", null, MachineId);
                                        }

                                    }
                                    else if (activeAlarm.IsAlarmRaised != null && activeAlarm.IsAlarmRaised != false)
                                    {
                                        activeAlarm.IsAlarmRaised = false;
                                        AddAuditLog($"{action} Reset", "", "", activeAlarm.AlarmName, "", "", null, MachineId);
                                    }
                                    // heartBeatValue = modbusOutput;
                                    System.Web.HttpContext.Current.Cache.Remove("HeartBeatCache");
                                    System.Web.HttpContext.Current.Cache["HeartBeatCache"] = modbusOutput;

                                }
                            }
                            else
                            {
                                var action = (bool)activeAlarm.IsShowAsMessage ? "Message" : "Alarm";

                                activeAlarm = alarmData.FirstOrDefault(x => x.IPCAddress == IPCAddress);
                                if (activeAlarm != null)
                                {
                                    if (modbusOutput == "1" && activeAlarm.IsAlarmRaised != true)
                                    {
                                        activeAlarm.IsAlarmRaised = true;
                                        if (activeAlarm.IsShowAsMessage != true)
                                        {
                                            AddAlarmLog(MachineId, activeAlarm.AlarmId, true);
                                        }
                                        AddAuditLog($"{action} Occured", "", "", activeAlarm.AlarmName, "", "", null, MachineId);

                                    }
                                    else if (modbusOutput == "0" && (activeAlarm.IsAlarmRaised != null && activeAlarm.IsAlarmRaised != false))
                                    {
                                        activeAlarm.IsAlarmRaised = false;
                                        AddAuditLog($"{action} Reset", "", "", activeAlarm.AlarmName, "", "", null, MachineId);

                                    }
                                }
                            }
                        }




                    }

                    catch (System.Exception ex)
                    {

                        ex = null;
                        if (machineParameterData.IsHeartBeat)
                        {
                            activeAlarm = alarmData.FirstOrDefault(x => x.IPCAddress == IPCAddress);
                            if (activeAlarm != null)
                            {
                                if (activeAlarm.IsAlarmRaised != true)
                                {
                                    activeAlarm.IsAlarmRaised = true;
                                    // Task.Run(() => AddAlarmLog(MachineId, activeAlarm.AlarmId, true));
                                    // Task.Run(() => AddAuditLog("Alarm Occured", "", "", activeAlarm.AlarmName, "", "", null, MachineId)); 
                                    AddAlarmLog(MachineId, activeAlarm.AlarmId, true);
                                    AddAuditLog("Alarm Occured", "", "", activeAlarm.AlarmName, "", "", null, MachineId);
                                }

                            }
                        }

                        continue;
                    }
                }


                //return Json(alarmData.Where(a => a.IsAlarmRaised == true).Select(a => new
                //{
                //    a.AlarmId,
                //    a.AlarmName,
                //    a.IsHeartBeat,

                //}), JsonRequestBehavior.AllowGet);
                return alarmData.Where(a => a.IsAlarmRaised == true).ToList();

            }
            catch (System.Exception ex)
            {
                ex = null;
            }

            finally
            {
                // MachineId = null;

                //CommandPanel = null;
                machineCommunication = null;
                alarmData = null;
                // int MachineId = 0;
                modbusOutput = null;
                binaryValue = null;
                machineParameterData = null;
                activeAlarm = null;
                heartBeatValue = null;
                // rearHeartBeatValue = null;
                // GC.Collect();
            }
            return alarmData;

        }


        public static bool PingHost(string hostUri, int portNumber)
        {
            try
            {
                using (var client = new System.Net.Sockets.TcpClient(hostUri, portNumber))
                    return true;
            }
            catch (System.Net.Sockets.SocketException ex)
            {
               // MessageBox.Show("Error pinging host:'" + hostUri + ":" + portNumber.ToString() + "'");
                return false;
            }
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

        public void AddAlarmLog(int machineId, int alarmId, bool IsaAlarmActive)
        {
            AlarmLog log = new AlarmLog();
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {

                    log.MachineId = machineId;
                    log.AlarmId = alarmId;
                    log.LoggedUserId = null;
                    log.AlarmDateTime = DateTime.Now;
                    log.BatchId = GetCurrentRunningBatch();
                    log.IsAlarmActive = IsaAlarmActive;
                    cvcEntities.AlarmLogs.Add(log);
                    cvcEntities.SaveChanges();
                }
            }
            catch (System.Exception ex)
            {
                ex = null;
            }
            finally
            {
                log = null;
            }
        }

        public void UpdateAlarmLog(Alarm updateAlarm, bool IsaAlarmActive, CVCEntities cvcEntities)
        {
            var AlarmLog = cvcEntities.AlarmLogs.Where(a => a.AlarmId == updateAlarm.AlarmId && a.IsAlarmActive == true).OrderByDescending(a => a.AlarmDateTime).FirstOrDefault();
            if (AlarmLog != null)
            {
                AlarmLog.IsAlarmActive = IsaAlarmActive;
                cvcEntities.Entry<AlarmLog>(AlarmLog).State = System.Data.Entity.EntityState.Modified;
                cvcEntities.SaveChanges();
            }
        }

        public string ReadAlarm(string IpcAddress, int MachineParameterId)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
                {
                    var binaryValue = string.Empty;
                    var machinePara = new MachineParameter();
                    //  var machineCommunication = new MachineCommunication();
                    try
                    {
                        machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == MachineParameterId);

                        //if (cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().Count > 0)
                        //{
                        //    machineCommunication = cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().First<MachineCommunication>();

                        //}
                        //var CommandPanel = new CommandPanelPageModel();
                        //CommandPanel = (CommandPanelPageModel)System.Web.HttpContext.Current.Cache["CommandPanel"];
                        var machineCommunication =commonServices. GetCacheData(ClsCacheConfig.CacheKeys.MachineCommunication);

                        var str = "";

                        // if (machineCommunication != null)
                        {
                            var ipcpara = machinePara.IPCParameters;
                            // if (ipcpara.Any())
                            {
                                var address = IpcAddress;

                                modbusTCP.IPAddress = machineCommunication.IPAddress;
                                modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TcpipPort.ToString());
                                modbusTCP.PollRateOverride = machineCommunication.PollRateOverride;

                                if (machinePara.DataTypeId == 9) // Siemens Float or SWAP FLOAT
                                {
                                    // this.modbusTCP.SwapWords = true;
                                    address = "F" + address;
                                }

                                if (machinePara.DataTypeId == 10) //D-WORD
                                {
                                    // this.modbusTCP.SwapWords = false;
                                    address = "U" + address;
                                }

                                if (machinePara.DataTypeId == 8) //WORD
                                {
                                    // this.modbusTCP.SwapWords = false;
                                    // address = "L" + address;
                                }

                                if (ipcpara.FirstOrDefault().IsByteSwap == true)
                                {
                                    modbusTCP.SwapBytes = true;
                                }

                                if (ipcpara.FirstOrDefault().IsWordSwap == true)
                                {
                                    modbusTCP.SwapWords = true;
                                }

                                str = modbusTCP.Read(address);


                                if (ipcpara.FirstOrDefault().IsBitWise == true)
                                {
                                    binaryValue = DecimalToBinary(int.Parse(str));
                                    str = ReverseString(binaryValue).ToString().Substring(ipcpara.FirstOrDefault().BitWiseIndex.Value, 1);
                                }


                            }
                        }

                        return binaryValue;
                    }
                    catch (System.Exception ex)
                    {

                    }
                    finally
                    {

                        //cvcEntities.Dispose();
                        //  machinePara = null;
                        // machineCommunication = null;
                    }

                    return binaryValue;
                }
            }
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

        public void AddAuditLog(string Action, string Module, string Page, string FieldName, string OldValue, string NewValue, int? BatchId, int? MachineId, User user = null, int? PickListValueId = null, string Comments = null, int? AuthenticationId = null)
        {
            AuditLog log = new AuditLog();
            UserDefinition userDefinition = (UserDefinition)Authorization.UserDefinition;
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {

                    if (userDefinition != null)
                    {
                        log.UserId = userDefinition.UserId;
                        log.UserName = userDefinition.Username;
                    }
                    else if (user != null)
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
                    // log.BatchId = BatchId;
                    log.BatchId = GetCurrentRunningBatch();
                    log.MachineId = MachineId;
                    log.Comments = Comments;
                    log.PickListValueId = PickListValueId;
                    log.AuthenticationId = AuthenticationId;

                    if (log.UserId == 0)
                    {
                        log.UserId = null;
                    }

                    cvcEntities.AuditLogs.Add(log);
                    cvcEntities.SaveChanges();
                }
            }
            catch (System.Exception ex)
            {
                ex = null;
            }
            finally
            {
                log = null;
                userDefinition = null;
                Action = null;
                Module = null;
                Page = null;
                FieldName = null;
                OldValue = null;
                NewValue = null;
                BatchId = null;
                MachineId = null;
                user = null;
                PickListValueId = null;
                Comments = null;
                AuthenticationId = null;
            }


        }

        public JsonResult SendHeartBeat(int MachineParameterId, int Value, int IncrementalNumber, int EndNumber)
        {
            try
            {
                WriteHeartBeat(MachineParameterId, Value.ToString());          
                Value = (EndNumber == 1 ? (Value == 0 ? 1 : 0) : (Value + IncrementalNumber));   
                return Json(Value, JsonRequestBehavior.AllowGet);
            }
            catch (System.Exception ex)
            {
                ex = null;
                Value = Value + IncrementalNumber;
                return Json(Value, JsonRequestBehavior.AllowGet);        

            }
            finally
                {
                MachineParameterId = 0;
                Value = 0;
                IncrementalNumber = 0;
                EndNumber = 0;

            }
         
        }

        public string WriteHeartBeat(int machineParaId, string Value)
        {
            var machinePara = new MachineParameter();
            string address = string.Empty;
           // var CommandPanel = new CommandPanelPageModel();
            string value32bit = string.Empty;
            var binary32bit = string.Empty;
            string binaryValue = string.Empty;
            using (CVCEntities cvcEntities = new CVCEntities())
        
            {          
                using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
                    try
                    {                  
                        machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == machineParaId);

                        if (machinePara.IPCParameters.Any())
                        {
                            address = machinePara.IPCParameters.FirstOrDefault().IPCAddress;

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
                            else
                            {
                                address = GetFormatedIPCAddress(address, machinePara?.DataTypeId ?? 0);
                            }
                            

                            if (machinePara.IPCParameters.FirstOrDefault().IsByteSwap == true)
                            {
                                modbusTCP.SwapBytes = true;
                            }


                            if (machinePara.IPCParameters.FirstOrDefault().IsWordSwap == true)
                            {
                                modbusTCP.SwapWords = true;
                            }


                            //CommandPanel = (CommandPanelPageModel)System.Web.HttpContext.Current.Cache["CommandPanel"];
                            var machineCommunication =commonServices.GetCacheData(ClsCacheConfig.CacheKeys.MachineCommunication);

                            modbusTCP.IPAddress = machineCommunication.IPAddress;
                            modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TcpipPort.ToString());
                            modbusTCP.PollRateOverride = machineCommunication.PollRateOverride;
          

                            if (machinePara.IPCParameters.FirstOrDefault().Is32Bit == true)
                            {
                                 binary32bit = DecimalToBinary32(long.Parse(Value));
                                Value = Convert.ToInt32(binary32bit.Substring(16, 16), 2).ToString();
                                value32bit = Convert.ToInt32(binary32bit.Substring(0, 16), 2).ToString();
                            }
                            if (machinePara.IPCParameters.FirstOrDefault().IsBitWise == true)
                            {
                                 binaryValue = ReverseString(DecimalToBinary(int.Parse(modbusTCP.Read(machinePara.IPCParameters.FirstOrDefault().IPCAddress)))).ToString();
                                binaryValue = ReverseString(binaryValue.Remove(machinePara.IPCParameters.FirstOrDefault().BitWiseIndex.Value, 1).Insert(machinePara.IPCParameters.FirstOrDefault().BitWiseIndex.Value, Value));
                                Value = Convert.ToInt32(binaryValue, 2).ToString();
                            }
                            modbusTCP.Write(address, Value);
                            if (machinePara.IPCParameters.FirstOrDefault().Is32Bit == true)
                            {
                             
                                modbusTCP.Write(machinePara.IPCParameters.FirstOrDefault().Bit32Address, value32bit);
                            }
                            if (machinePara.DataTypeId == 2) // Bit Momentary
                            {
                              
                                 binaryValue = ReverseString(DecimalToBinary(int.Parse(modbusTCP.Read(machinePara.IPCParameters.FirstOrDefault().IPCAddress)))).ToString();
                                binaryValue = ReverseString(binaryValue.Remove(machinePara.IPCParameters.FirstOrDefault().BitWiseIndex.Value, 1).Insert(machinePara.IPCParameters.FirstOrDefault().BitWiseIndex.Value, "0"));
                                Value = Convert.ToInt32(binaryValue, 2).ToString();
                                modbusTCP.Write(machinePara.IPCParameters.FirstOrDefault().IPCAddress, Value);
                            }
                        }

                    }
                    catch
                    {

                    }
                    finally
                    {
                        machineParaId = 0;
                        Value = string.Empty;
                        machinePara = null;
                        address = string.Empty;
                       // CommandPanel = null;
                        value32bit = string.Empty;
                        binary32bit = string.Empty;
                        binaryValue = string.Empty;
                      
                    }
            }
            return Value;
        }

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

    }

    public class jsonRoomparameter
    {
        public string AlarmId { get; set; }

        public string Comments { get; set; }
    }
}

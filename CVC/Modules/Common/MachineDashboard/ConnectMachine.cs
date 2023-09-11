using CVC.Data.EDMX;
using CVC.SiemensS7Net;
using CVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static CVC.BusinessServices.Common.ClsConstants;

namespace CVC.Modules.Common.MachineDashboard
{
    public class ConnectMachine
    {
       //CVCEntities cvcEntities = new CVCEntities();

        CVC.MDB.Operations mdb;
        readonly ClsSiemensS7Net clsSiemensS7Net = new ClsSiemensS7Net();
        public ConnectMachine(int? MachineId = null)
        {
            mdb = new MDB.Operations(MachineId);
        }

        public string Read(int machineParaId,DashBoardViewModel dashBoardViewModel=null)
        {
            
            using (CVCEntities cvcEntities = new CVCEntities())
            {
             var protocolType=System.Web.HttpContext.Current.Cache["ProtocolType"];

                //  var machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == machineParaId);
                //if (machinePara.Machine.MachineCommunications.Any(a => a.ProtocolTypeId == 4 && a.StatusId == 1))
                if (protocolType.ToString() == ProtocolType.MDB.ToUpper())
                {
                    if (mdb == null)
                        mdb = new CVC.MDB.Operations();
                    return mdb.Read(machineParaId);
                }
               else  if (protocolType.ToString().Contains(ProtocolType.Modbus.ToUpper()))
                {
                    if (CVC.PLC.Operations.CheckModBusConnection(machineParaId))
                    {
                      
                       return new CVC.PLC.Operations().Read(machineParaId);
                        
                    }
                }
                else if (protocolType.ToString().Contains(ProtocolType.SiemensS7Net.ToUpper()))
                {
                    clsSiemensS7Net.Read(dashBoardViewModel);
                }


                return "";
            }
        }

        public bool Write(int machineParaId, string Value, DashBoardViewModel dashBoardViewModel = null)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var protocolType = System.Web.HttpContext.Current.Cache["ProtocolType"];
               
                if(protocolType.ToString()==ProtocolType.MDB.ToUpper())
                {

                   return new CVC.MDB.Operations().Write(machineParaId, Value);
                }
                else if (protocolType.ToString().Contains(ProtocolType.Modbus.ToUpper()))
                {
                    return new CVC.PLC.Operations().Write(machineParaId, Value);

                }
                else if (protocolType.ToString().Contains(ProtocolType.SiemensS7Net.ToUpper()))
                {
                    clsSiemensS7Net.Write(dashBoardViewModel);
                }


                // if (machinePara.Machine.MachineCommunications.Any(a => a.ProtocolTypeId == 4 && a.StatusId == 1))
                //  {
                //    return new CVC.MDB.Operations().Write(machineParaId, Value);
                //}
                //if (machinePara.Machine.MachineCommunications.Any(a => a.ProtocolTypeId == 1 && a.StatusId == 1))
                //{
                //  return new CVC.PLC.Operations().Write(machineParaId, Value);
                //}
                return true;
            }
        }

        public bool WriteToAllMachine(int machineParaId, string Value,string protocolType)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {              
                if (protocolType.ToString() == ProtocolType.MDB.ToUpper())
                {
                    return new CVC.MDB.Operations().Write(machineParaId, Value);
                }
                else if (protocolType.ToString().Contains(ProtocolType.Modbus.ToUpper()))
                {
                    return new CVC.PLC.Operations().Write(machineParaId, Value);
                }
                return true;
            }
        }


        public bool CheckModBusConnection(int machineParaId)
        {
            return (CVC.PLC.Operations.CheckModBusConnection(machineParaId));
        }

        public string ReadComunication()
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.RowId == 5);
                if (machinePara.Machine.MachineCommunications.Any(a => a.ProtocolTypeId == 4 && a.StatusId == 1))
                {
                    if (mdb == null)
                        mdb = new CVC.MDB.Operations();
                    return mdb.ReadCommunication(machinePara.MachineParameterId);
                }
                return "";
            }
        }

        public List<Tuple<string, string, bool, int>> GetExistingAlarms()
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                List<Alarm> items = (List<Alarm>)HttpContext.Current.Session["alarmitems"];

                List<Tuple<string, string, bool, int>> alarms = new List<Tuple<string, string, bool, int>>();

                List<int> machineParaIds = items.Where(q => q.MachineParameterId != null).Select(q => q.MachineParameterId.Value).ToList();
                var machineParas = cvcEntities.MachineParameters.Where(a => machineParaIds.Contains(a.MachineParameterId)).ToList();

                foreach (var item in machineParas)
                {
                    //if (CVC.PLC.Operations.CheckModBusConnection(item.MachineParameterId))
                    {
                        if (item.Machine.MachineCommunications.Any(a => a.ProtocolTypeId == 1 && a.StatusId == 1))
                        {
                            var status = new CVC.PLC.Operations().Read(item.MachineParameterId);
                            if (!string.IsNullOrEmpty(status))
                            {
                                if (status == "1")
                                {
                                    alarms.Add(
                                        new Tuple<string, string, bool, int>(
                                            items.FirstOrDefault(a => a.MachineParameterId == item.MachineParameterId).AlarmName,
                                            items.FirstOrDefault(a => a.MachineParameterId == item.MachineParameterId).Message,
                                            Convert.ToBoolean(items.FirstOrDefault(a => a.MachineParameterId == item.MachineParameterId).IsCommentRequired),
                                            items.FirstOrDefault(a => a.MachineParameterId == item.MachineParameterId).AlarmId
                                            ));
                                }
                            }
                        }
                    }
                }

                return alarms;
            }
        }

    }
}
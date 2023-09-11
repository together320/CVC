// Decompiled with JetBrains decompiler
// Type: CVC.PLC.PLCToHMI
// Assembly: CVC.PLC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFB0FA40-B101-48D7-B75E-43CA22888CCD
// Assembly location: D:\Anil\CVC\bin\CVC.PLC.dll

using AdvancedHMIDrivers;
using CVC.Data;
using CVC.Data.EDMX;
using MfgControl.AdvancedHMI.Drivers.Common;
using System;
using System.Collections.Generic;
using System.Data;

namespace CVC.PLC
{
    public class PLCToHMI
    {
        private readonly ModbusTCPCom modbusTCP = new ModbusTCPCom();
        private readonly CVCEntities _Entities = new CVCEntities();

        public string Test()
        {
            this.modbusTCP.IPAddress = "127.0.0.1";
            this.modbusTCP.TcpipPort = 502;
            this.modbusTCP.PollRateOverride = 2;
            string str = "";

            str = this.modbusTCP.Read("0005");
            return str;
        }

        public string CheckMachineConnection(int MachineId)
        {
            DataTable dataTable = new DataTable();
            MachineCommunication machineCommunication = CVCDaoFactory.GetMachineCommunication(MachineId);
            this.modbusTCP.IPAddress = machineCommunication.IPAddress;
            this.modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
            this.modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;
            string str = "";
            try
            {
                str = this.modbusTCP.Read("0005");
            }
            catch
            {
            }
            return str;
        }

        //public IList<HMIParameterValue> GetSectionParameterValue(int MachineId, int ScreenSectionId)
        //{
        //  IList<HMIParameterValue> hmiParameterValueList = (IList<HMIParameterValue>) new List<HMIParameterValue>();
        //  MachineCommunication machineCommunication = CVCDaoFactory.GetMachineCommunication(MachineId);
        //  this.modbusTCP.IPAddress = machineCommunication.IPAddress;
        //  this.modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
        //  this.modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;
        //  IList<ViewField> viewFieldList1 = (IList<ViewField>) new List<ViewField>();
        //  IList<ViewField> viewFieldList2 = CVCDaoFactory.GetViewFieldList(ScreenSectionId);
        //  try
        //  {
        //    int num1 = 2;
        //    HMIParameterValue hmiParameterValue1 = new HMIParameterValue();
        //    IPCParameter ipcParameter1 = new IPCParameter();
        //    foreach (ViewField viewField in (IEnumerable<ViewField>) viewFieldList2)
        //    {
        //      HMIParameterValue hmiParameterValue2 = new HMIParameterValue();
        //      hmiParameterValue2.Id = num1 - 1;
        //      hmiParameterValue2.MachineId = 2;
        //      int? ipcParameterId = viewField.IPCParameterId;
        //      if (ipcParameterId.HasValue)
        //      {
        //        HMIParameterValue hmiParameterValue3 = hmiParameterValue2;
        //        ipcParameterId = viewField.IPCParameterId;
        //        int num2 = ipcParameterId.Value;
        //        hmiParameterValue3.HMIParameterId = num2;
        //        ipcParameterId = viewField.IPCParameterId;
        //        IPCParameter ipcParameter2 = CVCDaoFactory.GetIPCParameter(ipcParameterId.Value);
        //        hmiParameterValue2.ParameterValue = ipcParameter2.IPCAddress == null ? "0" : (!(ipcParameter2.IPCAddress != "") ? "0" : this.modbusTCP.Read(ipcParameter2.IPCAddress));
        //      }
        //      else
        //        hmiParameterValue2.ParameterValue = "0";
        //      hmiParameterValue2.FetchedDate = DateTime.Now;
        //      hmiParameterValueList.Add(hmiParameterValue2);
        //      ++num1;
        //    }
        //  }
        //  catch
        //  {
        //  }
        //  return hmiParameterValueList;
        //}

        //public IList<HMIParameterValue> GetMachineSummary(int MachineId, int ScreenSectionId)
        //{
        //  DataTable dataTable = new DataTable();
        //  IList<HMIParameterValue> hmiParameterValueList = (IList<HMIParameterValue>) new List<HMIParameterValue>();
        //  MachineCommunication machineCommunication = CVCDaoFactory.GetMachineCommunication(MachineId);
        //  if (machineCommunication != null)
        //  {
        //    this.modbusTCP.IPAddress = machineCommunication.IPAddress;
        //    this.modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
        //    this.modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;
        //    IList<ViewField> viewFieldList1 = (IList<ViewField>) new List<ViewField>();
        //    IList<ViewField> viewFieldList2 = CVCDaoFactory.GetViewFieldList(ScreenSectionId);
        //    try
        //    {
        //      int num1 = 2;
        //      HMIParameterValue hmiParameterValue1 = new HMIParameterValue();
        //      IPCParameter ipcParameter1 = new IPCParameter();
        //      foreach (ViewField viewField in (IEnumerable<ViewField>) viewFieldList2)
        //      {
        //        HMIParameterValue hmiParameterValue2 = new HMIParameterValue();
        //        hmiParameterValue2.Id = num1 - 1;
        //        hmiParameterValue2.MachineId = 1;
        //        int? ipcParameterId = viewField.IPCParameterId;
        //        if (ipcParameterId.HasValue)
        //        {
        //          HMIParameterValue hmiParameterValue3 = hmiParameterValue2;
        //          ipcParameterId = viewField.IPCParameterId;
        //          int num2 = ipcParameterId.Value;
        //          hmiParameterValue3.HMIParameterId = num2;
        //          ipcParameterId = viewField.IPCParameterId;
        //          IPCParameter ipcParameter2 = CVCDaoFactory.GetIPCParameter(ipcParameterId.Value);
        //          hmiParameterValue2.ParameterValue = ipcParameter2.IPCAddress == null ? "0" : (!(ipcParameter2.IPCAddress != "") ? "0" : this.modbusTCP.Read(ipcParameter2.IPCAddress));
        //        }
        //        else
        //          hmiParameterValue2.ParameterValue = "0";
        //        hmiParameterValue2.FetchedDate = DateTime.Now;
        //        hmiParameterValueList.Add(hmiParameterValue2);
        //        ++num1;
        //      }
        //    }
        //    catch
        //    {
        //    }
        //  }
        //  return hmiParameterValueList;
        //}

        //public IList<HMIParameterValue> GetBatchParameterValue(int MachineId, int ScreenSectionId)
        //{
        //  IList<HMIParameterValue> hmiParameterValueList = (IList<HMIParameterValue>) new List<HMIParameterValue>();
        //  MachineCommunication machineCommunication = CVCDaoFactory.GetMachineCommunication(MachineId);
        //  this.modbusTCP.IPAddress = machineCommunication.IPAddress;
        //  this.modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
        //  this.modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;
        //  try
        //  {
        //    string[] strArray = new string[2]{ "4005", "4007" };
        //    int num = 2;
        //    HMIParameterValue hmiParameterValue = new HMIParameterValue();
        //    foreach (string startAddress in strArray)
        //    {
        //      hmiParameterValueList.Add(new HMIParameterValue()
        //      {
        //        Id = num - 1,
        //        MachineId = 2,
        //        HMIParameterId = num,
        //        ParameterValue = this.modbusTCP.Read(startAddress),
        //        FetchedDate = DateTime.Now
        //      });
        //      ++num;
        //    }
        //  }
        //  catch
        //  {
        //  }
        //  return hmiParameterValueList;
        //}

        //public Alarm GetAlarmValue(int MachineId)
        //{
        //  IList<HMIParameterValue> hmiParameterValueList = (IList<HMIParameterValue>) new List<HMIParameterValue>();
        //  MachineCommunication machineCommunication = CVCDaoFactory.GetMachineCommunication(MachineId);
        //  this.modbusTCP.IPAddress = machineCommunication.IPAddress;
        //  this.modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
        //  this.modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;
        //  IList<Alarm> alarmList1 = (IList<Alarm>) new List<Alarm>();
        //  IList<Alarm> alarmList2 = CVCDaoFactory.GetAlarmList(MachineId);
        //  Alarm alarm1 = new Alarm();
        //  try
        //  {
        //    HMIParameterValue hmiParameterValue = new HMIParameterValue();
        //    IPCParameter ipcParameter1 = new IPCParameter();
        //    foreach (Alarm alarm2 in (IEnumerable<Alarm>) alarmList2)
        //    {
        //      if (alarm2.IPCParameterId.HasValue)
        //      {
        //        IPCParameter ipcParameter2 = CVCDaoFactory.GetIPCParameter(alarm2.IPCParameterId.Value);
        //        if (ipcParameter2.IPCAddress != null && ipcParameter2.IPCAddress != "")
        //        {
        //          int num1 = bool.Parse(this.modbusTCP.Read(ipcParameter2.IPCAddress)) ? 1 : 0;
        //          bool? nullable = alarm2.BitValue;
        //          int num2 = nullable.GetValueOrDefault() ? 1 : 0;
        //          if (num1 == num2 && nullable.HasValue)
        //          {
        //            alarm1 = alarm2;
        //            nullable = alarm1.IsMachineRequiredToStop;
        //            bool flag = true;
        //            if (nullable.GetValueOrDefault() == flag && nullable.HasValue)
        //              new HMIToPLC().OnOffMachine(1, "False");
        //            return alarm1;
        //          }
        //        }
        //      }
        //    }
        //  }
        //  catch
        //  {
        //  }
        //  return alarm1;
        //}

        //public IList<Alarm> GetAlarmOnMachineStartup(int MachineId)
        //{
        //  IList<HMIParameterValue> hmiParameterValueList = (IList<HMIParameterValue>) new List<HMIParameterValue>();
        //  MachineCommunication machineCommunication = CVCDaoFactory.GetMachineCommunication(MachineId);
        //  this.modbusTCP.IPAddress = machineCommunication.IPAddress;
        //  this.modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
        //  this.modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;
        //  IList<Alarm> alarmList1 = (IList<Alarm>) new List<Alarm>();
        //  IList<Alarm> onMachineStartup = CVCDaoFactory.GetAlarmListOnMachineStartup(MachineId);
        //  IList<Alarm> alarmList2 = (IList<Alarm>) new List<Alarm>();
        //  Alarm alarm1 = new Alarm();
        //  try
        //  {
        //    HMIParameterValue hmiParameterValue = new HMIParameterValue();
        //    IPCParameter ipcParameter1 = new IPCParameter();
        //    foreach (Alarm alarm2 in (IEnumerable<Alarm>) onMachineStartup)
        //    {
        //      if (alarm2.IPCParameterId.HasValue)
        //      {
        //        IPCParameter ipcParameter2 = CVCDaoFactory.GetIPCParameter(alarm2.IPCParameterId.Value);
        //        if (ipcParameter2.IPCAddress != null && ipcParameter2.IPCAddress != "")
        //        {
        //          int num1 = bool.Parse(this.modbusTCP.Read(ipcParameter2.IPCAddress)) ? 1 : 0;
        //          bool? bitValue = alarm2.BitValue;
        //          int num2 = bitValue.GetValueOrDefault() ? 1 : 0;
        //          if (num1 == num2 && bitValue.HasValue)
        //          {
        //            alarm1 = new Alarm();
        //            Alarm alarm3 = alarm2;
        //            alarmList2.Add(alarm3);
        //          }
        //        }
        //      }
        //    }
        //  }
        //  catch
        //  {
        //  }
        //  return alarmList2;
        //}

        //public string GetMachineStatus(int MachineId, int ScreenSectionId)
        //{
        //  DataTable dataTable = new DataTable();
        //  string str = "";
        //  MachineCommunication machineCommunication = CVCDaoFactory.GetMachineCommunication(MachineId);
        //  if (machineCommunication != null)
        //  {
        //    this.modbusTCP.IPAddress = machineCommunication.IPAddress;
        //    this.modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
        //    this.modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;
        //    try
        //    {
        //      str = this.modbusTCP.Read("0007");
        //    }
        //    catch (PLCDriverException ex)
        //    {
        //      if (ex.ErrorCode == -34)
        //        str = "noconnection";
        //    }
        //  }
        //  return str;
        //}

        //public string GetHeaderStatus(int MachineId, int ScreenSectionId)
        //{
        //  DataTable dataTable = new DataTable();
        //  MachineCommunication machineCommunication = CVCDaoFactory.GetMachineCommunication(MachineId);
        //  this.modbusTCP.IPAddress = machineCommunication.IPAddress;
        //  this.modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
        //  this.modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;
        //  string str = "";
        //  try
        //  {
        //    str = this.modbusTCP.Read("0005");
        //  }
        //  catch
        //  {
        //  }
        //  return str;
        //}

        public string GetSeparatorStatus(int MachineId, int ScreenSectionId)
        {
            DataTable dataTable = new DataTable();
            MachineCommunication machineCommunication = CVCDaoFactory.GetMachineCommunication(MachineId);
            this.modbusTCP.IPAddress = machineCommunication.IPAddress;
            this.modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
            this.modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;
            string str = "";
            try
            {
                str = this.modbusTCP.Read("0006");
            }
            catch
            {
            }
            return str;
        }

        public string GetPLCVersion(int MachineId, int ScreenSectionId)
        {
            MachineCommunication machineCommunication = CVCDaoFactory.GetMachineCommunication(MachineId);
            this.modbusTCP.IPAddress = machineCommunication.IPAddress;
            this.modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
            this.modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;
            string str = string.Empty;
            try
            {
                str = this.modbusTCP.Read("4001");
            }
            catch
            {
            }
            return str;
        }

        public string GetSelfsetStatus(int MachineId, int ScreenSectionId)
        {
            DataTable dataTable = new DataTable();
            string str = "";
            MachineCommunication machineCommunication = CVCDaoFactory.GetMachineCommunication(MachineId);
            if (machineCommunication != null)
            {
                this.modbusTCP.IPAddress = machineCommunication.IPAddress;
                this.modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
                this.modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;
                IPCParameter ipcParameter = CVCDaoFactory.GetIPCParameter(83);
                try
                {
                    str = this.modbusTCP.Read(ipcParameter.IPCAddress);
                }
                catch (PLCDriverException ex)
                {
                    if (ex.ErrorCode == -34)
                        str = "noconnection";
                }
            }
            return str;
        }
    }
}

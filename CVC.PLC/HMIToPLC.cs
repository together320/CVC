// Decompiled with JetBrains decompiler
// Type: CVC.PLC.HMIToPLC
// Assembly: CVC.PLC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFB0FA40-B101-48D7-B75E-43CA22888CCD
// Assembly location: D:\Anil\CVC\bin\CVC.PLC.dll

using AdvancedHMIDrivers;
using CVC.Data;
using CVC.Data.EDMX;

namespace CVC.PLC
{
  public class HMIToPLC
  {
    private readonly ModbusTCPCom modbusTCP = new ModbusTCPCom();
    private readonly CVCEntities _Entities = new CVCEntities();

    public string OnOffMachine(int MachineId, string sOnOff)
    {
      MachineCommunication machineCommunication = CVCDaoFactory.GetMachineCommunication(MachineId);
      if (machineCommunication != null)
      {
        this.modbusTCP.IPAddress = machineCommunication.IPAddress;
        this.modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
        this.modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;
        this.modbusTCP.Write(CVCDaoFactory.GetIPCParameter(86).IPCAddress, sOnOff);
      }
      return sOnOff;
    }

    public string OnOffHeader(int MachineId, string sOnOff)
    {
      MachineCommunication machineCommunication = CVCDaoFactory.GetMachineCommunication(MachineId);
      if (machineCommunication != null)
      {
        this.modbusTCP.IPAddress = machineCommunication.IPAddress;
        this.modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
        this.modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;
        this.modbusTCP.Write(CVCDaoFactory.GetIPCParameter(84).IPCAddress, sOnOff);
      }
      return sOnOff;
    }

    public string OnOffSeparator(int MachineId, string sOnOff)
    {
      MachineCommunication machineCommunication = CVCDaoFactory.GetMachineCommunication(MachineId);
      if (machineCommunication != null)
      {
        this.modbusTCP.IPAddress = machineCommunication.IPAddress;
        this.modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
        this.modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;
        this.modbusTCP.Write(CVCDaoFactory.GetIPCParameter(85).IPCAddress, sOnOff);
      }
      return sOnOff;
    }

    public string OnOffSelfset(int MachineId, string sOnOff)
    {
      MachineCommunication machineCommunication = CVCDaoFactory.GetMachineCommunication(MachineId);
      if (machineCommunication != null)
      {
        this.modbusTCP.IPAddress = machineCommunication.IPAddress;
        this.modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
        this.modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;
        this.modbusTCP.Write(CVCDaoFactory.GetIPCParameter(83).IPCAddress, sOnOff);
                
      }
      return sOnOff;
    }

    public string OnOffCounter(int MachineId, string sOnOff)
    {
      MachineCommunication machineCommunication = CVCDaoFactory.GetMachineCommunication(MachineId);
      if (machineCommunication != null)
      {
        this.modbusTCP.IPAddress = machineCommunication.IPAddress;
        this.modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
        this.modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;
        this.modbusTCP.Write("000014", sOnOff);
      }
      return sOnOff;
    }

    public string ResetAlarm(int MachineId, int AlarmId, string sOnOff)
    {
      //MachineCommunication machineCommunication = CVCDaoFactory.GetMachineCommunication(MachineId);
      //if (machineCommunication != null)
      //{
      //  this.modbusTCP.IPAddress = machineCommunication.IPAddress;
      //  this.modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
      //  this.modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;
      //  this.modbusTCP.Write(CVCDaoFactory.GetIPCParameter(CVCDaoFactory.GetAlarmDetails(AlarmId).IPCParameterId.Value).IPCAddress, sOnOff);
      //}
      return sOnOff;
    }
  }
}

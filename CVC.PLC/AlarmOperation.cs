using AdvancedHMIDrivers;
using CVC.Data.EDMX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CVC.PLC
{
    public class AlarmOperation
    {
        public string ReadAlarm(string IpcAddress, int MachineParameterId)
        {
            //using (CVCEntities cvcEntities = new CVCEntities())
            CVCEntities cvcEntities = new CVCEntities();
            {
                using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
                {
                    var binaryValue = string.Empty;
                    var machinePara = new MachineParameter();
                    var machineCommunication = new MachineCommunication();
                    try
                    {
                        machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == MachineParameterId);
                       
                        if (cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().Count > 0)
                        {
                            machineCommunication = cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().First<MachineCommunication>();

                        }

                        var str = "";

                        if (machineCommunication != null)
                        {
                            var ipcpara = machinePara.IPCParameters;
                            if (ipcpara.Any())
                            {
                                var address = ipcpara.FirstOrDefault().IPCAddress;

                                modbusTCP.IPAddress = machineCommunication.IPAddress;
                                modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
                                modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;

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

                        cvcEntities.Dispose();
                        machinePara = null;
                        machineCommunication = null;
                    }

                    return binaryValue;
                }
            }
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
    }
}

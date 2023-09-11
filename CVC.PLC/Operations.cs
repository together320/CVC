using AdvancedHMIDrivers;
using CVC.Data;
using CVC.Data.EDMX;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CVC.PLC
{
    public class Operations
    {

       // private ModbusTCPCom modbusTCP = new ModbusTCPCom();

        public string Read(int machineParaId)
        {
            string str = "";
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
                {
                    // var machinePara = CVCDaoFactory.GetMachineParameter(machineParaId);
                    //  var machineCommunication = CVCDaoFactory.GetMachineCommunication(machinePara.MachineId.Value);
                    var machinePara = new MachineParameter();
                    machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == machineParaId);

                    var machineCommunication = new MachineCommunication();
                    if (cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().Count > 0)
                    {
                        machineCommunication = cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().First<MachineCommunication>();
                    }
                   

                    if (machineCommunication != null)
                    {
                        var ipcpara = machinePara.IPCParameters;
                        if (ipcpara.Any())
                        {
                            string address = ipcpara.FirstOrDefault().IPCAddress;

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

                             str = modbusTCP.Read(address);

                            //System.Threading.Thread.Sleep(50);

                            //if (string.IsNullOrEmpty(str))
                            //{
                            //    goto LblModBusRead;
                            //}

                            if (ipcpara.FirstOrDefault().Is32Bit == true)
                            {
                                string lowerbit = DecimalToBinary(int.Parse(str));
                                string higherbit = DecimalToBinary(int.Parse(modbusTCP.Read(ipcpara.FirstOrDefault().Bit32Address)));
                                str = Convert.ToInt32(higherbit + lowerbit, 2).ToString();
                            }

                            if (ipcpara.FirstOrDefault().IsBitWise == true)
                            {
                                string binaryValue = DecimalToBinary(int.Parse(str));
                                str = ReverseString(binaryValue).ToString().Substring(ipcpara.FirstOrDefault().BitWiseIndex.Value, 1);
                            }

                            var OperationValueIPC =Convert.ToDecimal( 0.0);
                            if (machinePara.IPCParameters.FirstOrDefault().OperationValueIPC != null)
                            {

                                OperationValueIPC =(decimal) IntegerExtension(machinePara.IPCParameters.FirstOrDefault().OperationValueIPC.Value);
                                
                            }

                                if (machinePara.IPCParameters.FirstOrDefault().OperationTypeIPC == 50)
                            {
                                str = (Decimal.Parse(str) - OperationValueIPC).ToString();
                            }
                            if (machinePara.IPCParameters.FirstOrDefault().OperationTypeIPC == 51)
                            {
                                str = (Decimal.Parse(str) + OperationValueIPC).ToString();
                            }
                            if (machinePara.IPCParameters.FirstOrDefault().OperationTypeIPC == 52)
                            {
                                str = (Math.Round(Decimal.Parse(str) / OperationValueIPC, 2)).ToString();
                            }
                            if (machinePara.IPCParameters.FirstOrDefault().OperationTypeIPC == 53)
                            {
                                str = (Decimal.Parse(str) * OperationValueIPC).ToString();
                            }
                        }
                    }
                }
            }
            return str;
        }

        public bool Write(int machineParaId, string Value)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
                {
                    // var machinePara = CVCDaoFactory.GetMachineParameter(machineParaId);
                    //  var machineCommunication = CVCDaoFactory.GetMachineCommunication(machinePara.MachineId.Value);
                    var machinePara = new MachineParameter();
                    machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == machineParaId);

                    var machineCommunication = new MachineCommunication();
                    if (cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().Count > 0)
                    {
                        machineCommunication = cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().First<MachineCommunication>();
                    }


                    if (machineCommunication != null)
                    {
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
                                //this.modbusTCP.SwapWords = false;

                                address = "L" + address;
                            }

                            if (ipcpara.FirstOrDefault().IsByteSwap == true)
                            {
                                modbusTCP.SwapBytes = true;
                            }
                            ////else
                            ////{
                            ////    this.modbusTCP.SwapBytes = false;
                            ////}

                            if (ipcpara.FirstOrDefault().IsWordSwap == true)
                            {
                                modbusTCP.SwapWords = true;
                            }
                            ////else
                            ////{
                            ////    this.modbusTCP.SwapWords = false;
                            ////}

                            modbusTCP.IPAddress = machineCommunication.IPAddress;
                            modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
                            modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;

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
                            var result= modbusTCP.Write(address, Value);
                            if (ipcpara.FirstOrDefault().Is32Bit == true)
                            {
                                System.Threading.Thread.Sleep(500);
                                modbusTCP.Write(ipcpara.FirstOrDefault().Bit32Address, value32bit);
                            }
                            if (machinePara.DataTypeId == 2) // Bit Momentary
                            {
                                System.Threading.Thread.Sleep(500);
                                string binaryValue = ReverseString(DecimalToBinary(int.Parse(modbusTCP.Read(ipcpara.FirstOrDefault().IPCAddress)))).ToString();
                                binaryValue = ReverseString(binaryValue.Remove(ipcpara.FirstOrDefault().BitWiseIndex.Value, 1).Insert(ipcpara.FirstOrDefault().BitWiseIndex.Value, "0"));
                                Value = Convert.ToInt32(binaryValue, 2).ToString();
                                modbusTCP.Write(ipcpara.FirstOrDefault().IPCAddress, Value);
                            }
                        }
                    }
                }
            }
            return true;
        }

        public string ReverseString(string val)
        {
            return new string(val.ToCharArray().Reverse().ToArray());
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

        public static bool CheckModBusConnection(int machineParaId)
        {
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
                    {
                        string str = "";
                        // var machinePara = CVCDaoFactory.GetMachineParameter(machineParaId);
                        // var machineCommunication = CVCDaoFactory.GetMachineCommunication(machinePara.MachineId.Value);
                        var machinePara = new MachineParameter();
                        machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == machineParaId);

                        var machineCommunication = new MachineCommunication();
                        if (cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().Count > 0)
                        {
                            machineCommunication = cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().First<MachineCommunication>();
                        }
                        if (machineCommunication != null)
                        {
                            var ipcpara = machinePara.IPCParameters;
                            if (ipcpara.Any())
                            {
                                string address = ipcpara.FirstOrDefault().IPCAddress;

                                modbusTCP.IPAddress = machineCommunication.IPAddress;
                                modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
                                modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;

                                if (machinePara.DataTypeId == 9) // Siemens Float or SWAP FLOAT
                                {
                                    modbusTCP.SwapWords = true;
                                    address = "F" + address;
                                }

                                if (machinePara.DataTypeId == 10) //D-WORD
                                {
                                    modbusTCP.SwapWords = true;
                                    address = "U" + address;
                                }

                                if (machinePara.DataTypeId == 8) //WORD
                                {
                                    modbusTCP.SwapWords = true;
                                    address = "L" + address;
                                }
                                str = modbusTCP.Read(address);
                            }
                        }
                        return true;
                    }
                }
            }
            catch(System.Exception ex)
            {
                return false;
            }
        }

        public string ReadAlarm(string IpcAddress, int MachineParameterId)
        {
            var binaryValue = string.Empty;
            try
            {
                using (CVCEntities cvcEntities = new CVCEntities())
                {
                    using (ModbusTCPCom modbusTCP = new ModbusTCPCom())
                    {
                        // string binaryValue = string.Empty;
                        var str = "";
                        // var machinePara = CVCDaoFactory.GetMachineParameter(MachineParameterId);
                        // var machineCommunication = CVCDaoFactory.GetMachineCommunication(machinePara.MachineId.Value);
                        var machinePara = new MachineParameter();
                        machinePara = cvcEntities.MachineParameters.FirstOrDefault(a => a.MachineParameterId == MachineParameterId);

                        var machineCommunication = new MachineCommunication();
                        if (cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().Count > 0)
                        {
                            machineCommunication = cvcEntities.MachineCommunications.Where<MachineCommunication>((Expression<Func<MachineCommunication, bool>>)(c => c.MachineId == (int?)machinePara.MachineId.Value && c.StatusId == 1)).ToList<MachineCommunication>().First<MachineCommunication>();
                        }

                        if (machineCommunication != null)
                        {
                            var ipcpara = machinePara.IPCParameters;
                            if (ipcpara.Any())
                            {
                                string address = ipcpara.FirstOrDefault().IPCAddress;

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
                                    //address = "L" + address;
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
                }
            }
            catch (System.Exception ex)
            {

            }
            finally
            {
                GC.Collect();
            }
            return binaryValue;
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

        //public string[] ReadMachineSummary(string IpcAddress, int MachineParameterId, int NumberOfElements)
        //{
        //    string[] summaryValue = new string[] { };
        //    try
        //    {

        //        var machinePara = CVCDaoFactory.GetMachineParameter(MachineParameterId);
        //        var machineCommunication = CVCDaoFactory.GetMachineCommunication(machinePara.MachineId.Value);
        //        if (machineCommunication != null)
        //        {
        //            var ipcpara = machinePara.IPCParameters;
        //            if (ipcpara.Any())
        //            {
        //                this.modbusTCP.IPAddress = machineCommunication.IPAddress;
        //                this.modbusTCP.TcpipPort = ushort.Parse(machineCommunication.TCPIPPort.ToString());
        //                this.modbusTCP.PollRateOverride = machineCommunication.PollRate.Value;

        //                summaryValue = this.modbusTCP.Read(IpcAddress, NumberOfElements + 1);

        //            }
        //        }

        //    }
        //    catch(Exception ex)
        //    {


        //    }
        //    return summaryValue;
        //}


    }
}

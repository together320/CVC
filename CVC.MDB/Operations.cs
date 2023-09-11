using CVC.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVC.MDB
{
    public class Operations
    {
        private List<InterDBData> data;

        public Operations(int? MachineId = null)
        {
            if (MachineId != null)
            {
                var machineComm = CVCDaoFactory.GetMachineCommunication(MachineId.Value);
                if (machineComm != null)
                    if (machineComm.ProtocolTypeId == 4)
                        data = new InterDB().GetLocalLabelData(machineComm.MDBPath);
            }
        }

        public string ReverseString(string val)
        {
            return new string(val.ToCharArray().Reverse().ToArray());
        }

        public string Read(int machineParaId)
        {
            string paraValue = "";
            var machinePara = CVCDaoFactory.GetMachineParameter(machineParaId);
            var machineComm = CVCDaoFactory.GetMachineCommunication(machinePara.MachineId.Value);
            if (machineComm != null)
            {
                if (data == null) // If Data is cached used from cache
                    data = new InterDB().GetLocalLabelData(machineComm.MDBPath);
                var rowData = data[machinePara.RowId.Value];
                paraValue = rowData.DataArrey.ToString();
                if (machinePara.IsBitWise == true)
                {
                    string binaryValue = DecimalToBinary(int.Parse(paraValue));
                    paraValue = ReverseString(binaryValue).ToString().Substring(machinePara.BitWiseIndex.Value, 1);

                }
                if (machinePara.Is32Bit == true)
                {
                    string lowerbit = DecimalToBinary(int.Parse(paraValue));
                    string higherbit = DecimalToBinary(int.Parse(data[machinePara.Bit32RowId.Value].DataArrey.ToString()));
                    paraValue = Convert.ToInt32(higherbit + lowerbit, 2).ToString();
                    //string binary32bit = higherbit + lowerbit;

                    //var higher = Convert.ToInt32(higherbit + "0000000000000000", 2);
                    //if (higher > 0)
                    //    paraValue = paraValue + higher.ToString();
                    //paraValue = (Decimal.Parse(paraValue) + data[machinePara.Bit32RowId.Value].DataArrey).ToString();
                }

                var OperationValueIPC = Convert.ToDecimal(0.0);
                if (machinePara.IPCParameters.FirstOrDefault().OperationValueIPC != null)
                {

                    OperationValueIPC = (decimal)IntegerExtension(machinePara.IPCParameters.FirstOrDefault().OperationValueIPC.Value);

                }

                if (machinePara.OperationType == 50)
                {
                    paraValue = (Decimal.Parse(paraValue) - OperationValueIPC).ToString();
                }
                if (machinePara.OperationType == 51)
                {
                    paraValue = (Decimal.Parse(paraValue) + OperationValueIPC).ToString();
                }
                if (machinePara.OperationType == 52)
                {
                    paraValue = (Math.Round(Decimal.Parse(paraValue) / OperationValueIPC, 2)).ToString();
                }
                if (machinePara.OperationType == 53)
                {
                    paraValue = (Decimal.Parse(paraValue) * OperationValueIPC).ToString();
                }
            }
            return paraValue;
        }

        public bool Write(int machineParaId, string Value)
        {
            var machinePara = CVCDaoFactory.GetMachineParameter(machineParaId);
            var machineComm = CVCDaoFactory.GetMachineCommunication(machinePara.MachineId.Value);
            int queryTypeId = 1;
            if (machinePara.Type == 49) // Coil Command
                queryTypeId = 2;
            if (machinePara.IsBitWise == true)
            {
                var data = new InterDB().GetLocalLabelData(machineComm.MDBPath);
                var rowData = data[machinePara.RowId.Value];
                string binaryValue = ReverseString(DecimalToBinary(rowData.DataArrey)).ToString();
                binaryValue = ReverseString(binaryValue.Remove(machinePara.BitWiseIndex.Value, 1).Insert(machinePara.BitWiseIndex.Value, Value));
                Value = Convert.ToInt32(binaryValue, 2).ToString();
            }

            if (machinePara.OperationType == 50)
            {
                Value = (Decimal.Parse(Value) + machinePara.OperationValue.Value).ToString();
            }
            if (machinePara.OperationType == 51)
            {
                Value = (Decimal.Parse(Value) - machinePara.OperationValue.Value).ToString();
            }
            if (machinePara.OperationType == 52)
            {
                Value = (Math.Round(Decimal.Parse(Value) * machinePara.OperationValue.Value, 2)).ToString();
            }
            if (machinePara.OperationType == 53)
            {
                Value = (Decimal.Parse(Value) / machinePara.OperationValue.Value).ToString();
            }
            string value32bit = null;
            if (machinePara.Is32Bit == true)
            {
                var binary32bit = DecimalToBinary32(long.Parse(Value));
                Value = Convert.ToInt32(binary32bit.Substring(16, 16), 2).ToString();
                value32bit = Convert.ToInt32(binary32bit.Substring(0, 16), 2).ToString();
            }
            var ret = new InterDB().SetLocalLabelData(machineComm.MDBPath, queryTypeId, machinePara.RowId.Value, Value, machinePara.QueryTypeRowId.Value);
            if (machinePara.Is32Bit == true)
            {
                System.Threading.Thread.Sleep(500);
                new InterDB().SetLocalLabelData(machineComm.MDBPath, queryTypeId, machinePara.Bit32RowId.Value, value32bit, machinePara.QueryTypeRowId.Value);
            }
            if (machinePara.ReloadMachineParameterId != null) // In Case Reload Require
            {
                System.Threading.Thread.Sleep(500);
                Write(machinePara.ReloadMachineParameterId.Value, "1");
            }
            return ret;
        }

        public string ReadCommunication(int machineParaId)
        {
            string paraValue = "";
            var machinePara = CVCDaoFactory.GetMachineParameter(machineParaId);
            var machineComm = CVCDaoFactory.GetMachineCommunication(machinePara.MachineId.Value);
            string returnval = "0";
            if (machineComm != null)
            {
                if (data == null) // If Data is cached used from cache
                    data = new InterDB().GetLocalLabelData(machineComm.MDBPath);
                var rowData = data[machinePara.RowId.Value];
                paraValue = rowData.DataArrey.ToString();
                if (rowData.RowID == 5)
                {
                    returnval = rowData.WriteRequest.ToString();
                }
            }
            return returnval;
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
    }
}

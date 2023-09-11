using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVC.ViewModels
{
    public class AlarmViewModel
    {
        public int AlarmId { get; set; }

        public string AlarmName { get; set; }

        public int MachineParameterId { get; set; }

        public string IPCAddress { get; set; }

        public int? DataTypeId { get; set; }

        public bool? IsByteSwap { get; set; }

        public bool? IsWordSwap { get; set; }

        public bool? IsBitWise { get; set; }

        public int? BitWiseIndex { get; set; }

        public bool? IsRefreshMachineSettings { get; set; }

        public bool IsCommentRequired { get; set; }

        public bool? IsAlarmRaised { get; set; } = null;

        public bool IsHeartBeat { get; set; }

        public bool? IsHideEdit { get; set; }

        public bool? IsShowAsMessage { get; set; }

        public string NodeId { get; set; }

        public int? AttributeId { get; set; }

        public int ReadValueSequence { get; set; }


    }

    public class SendHeartBeatViewModel
    {

        public int? MachineParameterId { get; set; }

        public string IPCAddress { get; set; }

        public int? DataTypeId { get; set; }

        public bool? IsByteSwap { get; set; }

        public bool? IsWordSwap { get; set; }

        public bool? IsBitWise { get; set; }

        public int? BitWiseIndex { get; set; }

        public bool? IsHeartBeatSend { get; set; }

        public int? IncrementalNumber { get; set; }

        public int? StartNumber { get; set; }

        public int? EndNumber { get; set; }

        public int? Value { get; set; }

        public bool? Is32Bit { get; set; }

        public string Bit32Address { get; set; }

        public string NodeId { get; set; }

        public UInt32 AttributeId { get; set; }
        public string  DataTypeName { get; set; }

    }

    public class DashBoardField
    {
        public int Type { get; set; }

        public int MachineParameterId { get; set; }

        public string ParameterName { get; set; }

        public int DateTypeId { get; set; }

        public string Value { get; set; }

        public bool IsModify { get; set; }

        public string UnitName { get; set; }

        public bool IsRangeUnlimited { get; set; }

        public decimal Min { get; set; }

        public decimal Max { get; set; }

        public bool IsDisabled { get; set; }

        public bool AllowDecimalPoint { get; set; }

        public bool IsConnected { get; set; } // by Vinayak to check plc connection...

        public string ReadCommunication { get; set; }

        public string IPCAddress { get; set; }

        public int OperationTypeIPC { get; set; }

        public decimal? OperationValueIPC { get; set; }

        public int? DataTypeId { get; set; }

        public bool? IsByteSwap { get; set; }

        public bool? IsWordSwap { get; set; }

        public bool? Is32Bit { get; set; }

        public bool? IsBitWise { get; set; }

        public string Bit32Address { get; set; }

        public int? BitWiseIndex { get; set; }

        public bool? IsMachineSpeed { get; set; }

        public bool? IsLabelRollIPC { get; set; }

        public bool? IsRefreshMachineSettings { get; set; }

        public int ViewsId { get; set; }

        public string ViewName { get; set; }

        public bool IsPopUpRequired { get; set; }

        public bool IsCommentRequired { get; set; }

        public bool IsAuthenticationRequired { get; set; }

        public bool IsAuthorisedRole { get; set; }

        public int ViewFieldId { get; set; }

        public string RoleNames { get; set; }

        public int? WriteToPLCIPCMachineParameterId { get; set; }

        public bool? IsIndicatorParameter { get; set; }

        public int? IndicatorParameterId { get; set; }

        public bool? IsGoodBottles { get; set; }

        public bool? IsRejectBottles { get; set; }

        public bool? IsBatchSize { get; set; }

        public string BackgroundColor { get; set; } = "blue";

        public string BatchSizeIPCAddress { get; set; }

        public int? RowId { get; set; }

        public int? Bit32RowId { get; set; }

        public int? BatchSizeRowId { get; set; }

        public string IsConveyerClass { get; set; } = "";

        public bool IsWriteTerminalType { get; set; }

        public bool? IsMissingLabelCounter { get; set; }

        public string OldValue { get; set; }

        public int? AlarmId { get; set; }

        public int AlarmCounterSequence { get; set; }

        public string NodeId { get; set; }

        public int? AttributeId { get; set; }

        public int? ReadValueSequence { get; set; }

        public bool? IsCounterReset { get; set; }
        public string DataTypeName { get; set; }
        public string OperationTypeName { get; set; }


    }

    public class ListViewModel
    {
        public int Value { get; set; }

        public string Text { get; set; }

        public string MappedFieldText { get; set; }


    }
}

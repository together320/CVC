// Decompiled with JetBrains decompiler
// Type: CVC.ExternalApplicationInterface.Forms.IpcParameterForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.Configuration.Scripts;
using CVC.ExternalApplicationInterface.Entities;
using CVC.MachineCustomization.Entities;
using CVC.Modules.Configuration.Status;
using CVC.Modules.ExternalApplicationInterface.IpcParameter;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.ExternalApplicationInterface.Forms
{
    [FormScript("ExternalApplicationInterface.IpcParameter")]
    [BasedOnRow(typeof(IpcParameterRow))]
    public class IpcParameterForm
    {
        [Category("General")]
        [LabelWidth(190)]
        [LookupEditor(typeof(MachineRow))]
        [ReadOnly(true)]
        public int MachineId { get; set; }

        [LabelWidth(190)]
        [LookupEditor(typeof(MachineParameterRow), CascadeField = "MachineId", CascadeFrom = "MachineId")]
        public int MachineParameterId { get; set; }

        [Visible(false)]
        [LabelWidth(190)]
        [LookupEditor(typeof(MachineProtocolCommunication), CascadeField = "MachineId", CascadeFrom = "MachineId")]
        public int ProtocolId { get; set; }


        [DisplayName("Modbus Address")]
        [LabelWidth(190)]
        [HalfWidth]
        public string IpcAddress { get; set; }

        [DisplayName("Node Id")]
        [LabelWidth(190)]
        [HalfWidth]
        public string NodeId { get; set; }


        [LabelWidth(190)]
        [LookupEditor(typeof(Class1Row))]
        [Visible(false)]
        public int AttributeId { get; set; }

        [LabelWidth(190)]
        public string IpcParameterName { get; set; }

        //[LabelWidth(190)]
        //public short IsChangeInRuntime { get; set; }

        [LabelWidth(190)]
        [Category("Status")]
        [LookupEditor(typeof(StatusRow))]
        public int StatusId { get; set; }


        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsBitWise { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public int? BitWiseIndex { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool? Is32Bit { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public string Bit32Address { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsWordSwap { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsByteSwap { get; set; }

        // changes added by Vinayak on 17.07.2018 

        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsStopATIPC { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsShowAsMessageIPC { get; set; }

        [DisplayName("Is Batch Start")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsBatchStartRequiredIPC { get; set; }

        [DisplayName("Is Reset On Batch Create")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsResetOnBatchCreateIPC { get; set; }


        [DisplayName("Is Label Roll (Label remaining)")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsLabelRollIPC { get; set; }

        [DisplayName("Disable Parameter")]
        [LabelWidth(190)]
        [LookupEditor(typeof(MachineParameterRow), CascadeField = "MachineId", CascadeFrom = "MachineId")]
        [HalfWidth]
        public int? DisableParameterIdIPC { get; set; }

        [LabelWidth(190)]
        [DisplayName("Disable Parameter Value")]
        [HalfWidth]
        public string DisableParameterValueIPC { get; set; }

        [DisplayName("Is Stop On Batch Stop")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsStopOnBatchStopIPC { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        [LookupEditor(typeof(PickListValueLookup), CascadeField = "PickListId", CascadeValue = "14")]
        public int? OperationTypeIPC { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public Decimal OperationValueIPC { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsAlarm { get; set; }


        [DisplayName("Is Machine Speed")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsMachineSpeed { get; set; }

        [Visible(false)]

        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsRefreshMachineSettings { get; set; }

        [DisplayName("Is Heart Beat")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsHeartBeat { get; set; }

        [DisplayName("Heart Beat Failed Time (In Secs.)")]
        [LabelWidth(190)]
        [HalfWidth]
        public int? HeartBeatFailedTime { get; set; }

        [DisplayName("Is Heart Beat Send")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsHeartBeatSend { get; set; }

        [DisplayName("Incremental Number")]
        [LabelWidth(190)]
        [HalfWidth]
        public int? IncrementalNumber { get; set; }

        [DisplayName("Start Number")]
        [LabelWidth(190)]
        [HalfWidth]
        public int? StartNumber { get; set; }

        [DisplayName("End Number")]
        [LabelWidth(190)]
        [HalfWidth]
        public int? EndNumber { get; set; }

        [DisplayName("Is Write To PLC")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsWriteToPLC { get; set; }

        [DisplayName("Is Indicator Parameter")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsIndicatorParameter { get; set; }

        [DisplayName("Indicator Parameter")]
        [LabelWidth(190)]
        [LookupEditor(typeof(MachineParameterRow), CascadeField = "MachineId", CascadeFrom = "MachineId")]
        [HalfWidth]
        public int? IndicatorParameterId { get; set; }


        [DisplayName("Is Good Bottles")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsGoodBottles { get; set; }


        [DisplayName("Is Reject Bottles")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsRejectBottles { get; set; }


        [DisplayName("Is Batch Size")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsBatchSize { get; set; }

        [DisplayName("Is Counter Reset")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsCounterReset { get; set; }

        [DisplayName("Is Conveyer")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsConveyer { get; set; }

        [DisplayName("Is Missing Label Counter")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsMissingLabelCounter { get; set; }


    }
}

// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Forms.MachineParameterForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.Configuration.Scripts;
using CVC.MachineCustomization.Entities;
using CVC.MachineCustomization.Scripts;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.MachineCustomization.Forms
{
    [FormScript("MachineCustomization.MachineParameter")]
    [BasedOnRow(typeof(MachineParameterRow))]
    public class MachineParameterForm
    {
        [Category("General")]
        [LabelWidth(190)]
        public string ParameterName { get; set; }

        [LabelWidth(190)]
        // [LookupEditor(typeof(MachineLookUp))]
        [LookupEditor(typeof(MachineRow))]
        [HalfWidth]
        public int MachineId { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public string Description { get; set; }

        [LabelWidth(190)]
        //[HalfWidth]
        public bool? IsRangeUnlimited { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        [DecimalEditor(MinValue = "-67545")]
        public Decimal Min { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public Decimal Max { get; set; }

        [DisplayName("Allow Decimal Point")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? AllowDecimalPoint { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsRead { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsWrite { get; set; }

        [Category("Details for Realtime")]
        [LabelWidth(190)]
        [HalfWidth]
        [LookupEditor(typeof(DataTypeRow))]
        public int DataTypeId { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsUseUnit { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        [LookupEditor(typeof(PickListValueLookup), CascadeField = "PickListId", CascadeValue = "2")]
        public int UnitId { get; set; }

        // added by Denis for RS 3.7 dated 7/20/2021
        [Category("Details for DB related")]
        [LabelWidth(190)]
        [HalfWidth]
        public string ColumnName { get; set; }

        // added by Denis for RS 3.8 dated 7/20/2021
        [LabelWidth(190)]
        [HalfWidth]
        public int PickListId { get; set; }

        //[LabelWidth(190)]
        //[HalfWidth]
        //public string PlcAddress { get; set; }


        [Category("Status")]
        [LabelWidth(190)]
        [LookupEditor(typeof(StatusRow))]
        public int StatusId { get; set; }

        [Category("MDB")]
        [LabelWidth(190)]
        [HalfWidth]
        [LookupEditor(typeof(PickListValueLookup), CascadeField = "PickListId", CascadeValue = "13")]
        public int? Type { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public int? RowId { get; set; }

        [LabelWidth(190)]
        [LookupEditor(typeof(MachineParameterRow), CascadeField = "MachineId", CascadeFrom = "MachineId")]
        [HalfWidth]
        public int ReadMachineParameterId { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public int? QueryTypeRowId { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsStopAt { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsBitWise { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public int? BitWiseIndex { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        [LookupEditor(typeof(PickListValueLookup), CascadeField = "PickListId", CascadeValue = "14")]
        public int? OperationType { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public Decimal OperationValue { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool? Is32Bit { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public int? Bit32RowId { get; set; }

        [DisplayName("Subsequent Call")]
        [LabelWidth(190)]
        [HalfWidth]
        [LookupEditor(typeof(MachineParameterRow), CascadeField = "MachineId", CascadeFrom = "MachineId")]
        public int ReloadMachineParameterId { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsShowAsMessage { get; set; }

        [DisplayName("Is Reset On Batch Create")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsResetOnBatchCreate { get; set; }

        [DisplayName("Is Batch Start Require")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsBatchStartRequired { get; set; }

        [DisplayName("Is Label Roll")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsLabelRoll { get; set; }

        [DisplayName("Disable Parameter")]
        [LabelWidth(190)]
        [LookupEditor(typeof(MachineParameterRow), CascadeField = "MachineId", CascadeFrom = "MachineId")]
        [HalfWidth]
        public int? DisableParameterId { get; set; }

        [LabelWidth(190)]
        [DisplayName("Disable Parameter Value")]
        [HalfWidth]
        public string DisableParameterValue { get; set; }

        [DisplayName("Is Stop On Batch Stop")]
        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsStopOnBatchStop { get; set; }

        [Visible(false)]
        public int CreatedBy { get; set; }

        [Visible(false)]
        public DateTime CreatedDate { get; set; }

        [Visible(false)]
        public int UpdatedBy { get; set; }

        [Visible(false)]
        public DateTime UpdatedDate { get; set; }
    }
}

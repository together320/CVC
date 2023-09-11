// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Forms.AlarmForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.ExternalApplicationInterface.Entities;
using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.MachineCustomization.Forms
{
    [FormScript("MachineCustomization.Alarm")]
    [BasedOnRow(typeof(AlarmRow))]
    public class AlarmForm
    {
        [Category("General")]
        [LabelWidth(190)]
        public string AlarmName { get; set; }

        [Category("Details")]
        [LabelWidth(190)]
        [HalfWidth]
        [LookupEditor(typeof(MachineRow))]
        [ReadOnly(true)]
        public int MachineId { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        [LookupEditor(typeof(MachineParameterRow), CascadeField = "MachineId", CascadeFrom = "MachineId")]
        public int MachineParameterId { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public string Message { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public string Description { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool IsResetRequired { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool IsCommentRequired { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool IsMachineRequiredToStop { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        [LookupEditor(typeof(IpcParameterRow), CascadeField = "MachineId", CascadeFrom = "MachineId")]
        //[LookupEditor(typeof (IpcParameterRow), CascadeFrom = "IsMachineRequiredToStop", CascadeValue = "true")]
        public int MachineStopMachineParameterId { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool IsCountForReject { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool BitValue { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool IsCheckAtMachineStart { get; set; }

        [LabelWidth(190)]
        [Category("Status")]
        [LookupEditor(typeof(StatusRow))]
        public int StatusId { get; set; }

        [Visible(false)]
        public int CreatedBy { get; set; }

        [Visible(false)]
        public DateTime CreatedDate { get; set; }

        [Visible(false)]
        public int UpdatedBy { get; set; }

        [Visible(false)]
        public DateTime UpdatedDate { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsRefreshMachineSettings { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsHideEdit { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public bool? IsAlarmForCounter { get; set; }
    }
}

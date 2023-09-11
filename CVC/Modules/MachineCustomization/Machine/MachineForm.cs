// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Forms.MachineForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;
using System.IO;

namespace CVC.MachineCustomization.Forms
{
    [FormScript("MachineCustomization.Machine")]
    [BasedOnRow(typeof(MachineRow))]
    public class MachineForm
    {
        [Category("General")]
        [LabelWidth(190)]
        public string MachineName { get; set; }

        // added by Denis for RS 3.3 dated 7/20/2021
        [LabelWidth(190)]
        [HalfWidth]
        public Boolean IsRealTime { get; set; }

        // added by Denis for RS 3.4 dated 7/20/2021
        [LabelWidth(190)]
        [HalfWidth]
        public Int32 TableId { get; set; }

        // added by Denis for RS 3.4 dated 7/20/2021
        [Visible(false)]
        public string TableName { get; set; }

        [Visible(false)]
        public int MachineLineId { get; set; }

        [Category("For Realtime Entity")]
        [LabelWidth(190)]
        [HalfWidth]
        public string AccessIpAddress { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public int MachineSequence { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public Stream MachineImage { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public string Description { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public string ModelNumber { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public string SerialNumber { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public string Make { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public int Year { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public int? TimerForAlarm { get; set; }

        [Category("PLC")]
        [LabelWidth(190)]
        [HalfWidth]
        public string PlcMake { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public string PlcModelNumber { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public string PlcSerialNumber { get; set; }

        [LabelWidth(190)]
        [HalfWidth]
        public string PlcAddress { get; set; }

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
    }
}

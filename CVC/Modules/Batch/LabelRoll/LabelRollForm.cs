// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Forms.LabelRollForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using Serenity.ComponentModel;
using System;

namespace CVC.Batch.Forms
{
    [FormScript("Batch.LabelRoll")]
    [BasedOnRow(typeof(LabelRollRow))]
    public class LabelRollForm
    {
        [Visible(false)]
        public int BatchId { get; set; }

        [Visible(false)]
        public int MachineId { get; set; }

        [Required]
        public int LabelRollNumber { get; set; }
        [Required]
        public long NumberOfLabels { get; set; }

        public string Remark { get; set; }

        [Visible(false)]
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

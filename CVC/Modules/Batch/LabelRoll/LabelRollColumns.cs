// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Columns.LabelRollColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using Serenity.ComponentModel;

namespace CVC.Batch.Columns
{
    [ColumnsScript("Batch.LabelRoll")]
    [BasedOnRow(typeof(LabelRollRow))]
    public class LabelRollColumns
    {
        [EditLink]
        [Width(250)]
        public int LabelRollNumber { get; set; }

        [Width(250)]
        public long NumberOfLabels { get; set; }

        [Width(250)]
        public long NumberOfLabelsUsed { get; set; }

        [Width(250)]
        public long LabelRemaining { get; set; }

        [Width(500)]
        public string Remark { get; set; }

        [Visible(false)]
        [Width(500)]
        public bool IsApplied { get; set; }
    }
}

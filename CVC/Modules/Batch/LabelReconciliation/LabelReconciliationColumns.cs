// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Columns.LabelReconciliationColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.Batch.Columns
{
  [ColumnsScript("Batch.LabelReconciliation")]
  [BasedOnRow(typeof (LabelReconciliationRow))]
  public class LabelReconciliationColumns
  {
    [EditLink]
    [DisplayName("Db.Shared.RecordId")]
    [AlignRight]
    public int LabelRecId { get; set; }

    public string BatchBatchName { get; set; }

    public string MachineMachineName { get; set; }

    public string LabelRollRemark { get; set; }

    public int RejectedLabels { get; set; }

    public int LabelLost { get; set; }

    public int NoLabelOnRoll { get; set; }

    public int LabelBalance { get; set; }

    public string StatusStatusName { get; set; }

    public string CreatedByEmployeeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string UpdatedByEmployeeId { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}

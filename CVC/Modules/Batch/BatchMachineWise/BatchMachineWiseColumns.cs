// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Columns.BatchMachineWiseColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.Batch.Columns
{
  [ColumnsScript("Batch.BatchMachineWise")]
  [BasedOnRow(typeof (BatchMachineWiseRow))]
  public class BatchMachineWiseColumns
  {
    [EditLink]
    [DisplayName("Db.Shared.RecordId")]
    [AlignRight]
    public int BatchMachineId { get; set; }

    public string MachineMachineName { get; set; }

    public string BatchBatchName { get; set; }

    public string RecipeRecipeName { get; set; }

    public short IsMachineInUse { get; set; }

    public string StatusStatusName { get; set; }

    public string CreatedByEmployeeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string UpdatedByEmployeeId { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}

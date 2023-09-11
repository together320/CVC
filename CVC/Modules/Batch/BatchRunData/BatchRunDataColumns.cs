// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Columns.BatchRunDataColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.Batch.Columns
{
  [ColumnsScript("Batch.BatchRunData")]
  [BasedOnRow(typeof (BatchRunDataRow))]
  public class BatchRunDataColumns
  {
    [EditLink]
    [DisplayName("Db.Shared.RecordId")]
    [AlignRight]
    public long BatchRunDataId { get; set; }

    public int BatchMachineWiseId { get; set; }

    public string IpcParameterIpcParameterName { get; set; }

    [EditLink]
    public string IpcParameterValue { get; set; }

    public DateTime UpdatedDateTime { get; set; }

    public string LoggedInUserEmployeeId { get; set; }
  }
}

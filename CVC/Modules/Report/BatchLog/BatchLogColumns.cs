// Decompiled with JetBrains decompiler
// Type: CVC.Report.Columns.BatchLogColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Report.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.Report.Columns
{
  [ColumnsScript("Report.BatchLog")]
  [BasedOnRow(typeof (BatchLogRow))]
  public class BatchLogColumns
  {
    //[EditLink]
    [DisplayName("Db.Shared.RecordId")]
    [AlignRight]
    public long BatchLogId { get; set; }

    public int MachineId { get; set; }

    public int BatchId { get; set; }

    [EditLink]
    public string Description { get; set; }

    public int UserId { get; set; }
        [CustomDisplayFormatAttribute("")]
        public DateTime UpdatedDateTime { get; set; }

       // public string BatchVersion { get; set;}
  }
}

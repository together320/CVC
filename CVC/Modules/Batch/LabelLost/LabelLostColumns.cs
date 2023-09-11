// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Columns.LabelLostColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.Batch.Columns
{
  [ColumnsScript("Batch.LabelLost")]
  [BasedOnRow(typeof (LabelLostRow))]
  public class LabelLostColumns
  {
    [EditLink]
    [DisplayName("Db.Shared.RecordId")]
    [AlignRight]
    public int LabelLostId { get; set; }

    public int LabelRecId { get; set; }

    public string ActivityPickListValueName { get; set; }

    [EditLink]
    public string ActivityText { get; set; }

    public int NumberOfLabels { get; set; }

    public string StatusStatusName { get; set; }

    public string CreatedByEmployeeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string UpdatedByEmployeeId { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}

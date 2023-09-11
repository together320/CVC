// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Columns.MachineHistoryColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.MachineCustomization.Columns
{
  [ColumnsScript("MachineCustomization.MachineHistory")]
  [BasedOnRow(typeof (MachineHistoryRow))]
  public class MachineHistoryColumns
  {
    [EditLink]
    [DisplayName("Db.Shared.RecordId")]
    [AlignRight]
    public int MachineHistoryId { get; set; }

    public string MachineMachineName { get; set; }

    public DateTime IssueStartDate { get; set; }

    public DateTime IssueCloseDate { get; set; }

    public string ProblemNaturePickListValueName { get; set; }

    public string SparePartPartNumber { get; set; }

    [EditLink]
    public string ProblemDescription { get; set; }

    public string StatusStatusName { get; set; }

    public string CreatedByEmployeeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string UpdatedByEmployeeId { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}

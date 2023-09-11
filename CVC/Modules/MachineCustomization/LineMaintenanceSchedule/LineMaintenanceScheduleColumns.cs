// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Columns.LineMaintenanceScheduleColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.MachineCustomization.Columns
{
  [ColumnsScript("MachineCustomization.LineMaintenanceSchedule")]
  [BasedOnRow(typeof (LineMaintenanceScheduleRow))]
  public class LineMaintenanceScheduleColumns
  {
    [EditLink]
    [DisplayName("Db.Shared.RecordId")]
    [AlignRight]
    public int LineMainSchId { get; set; }

    public int MachineLineId { get; set; }

    public DateTime StartDateTime { get; set; }

    public DateTime EndDateTime { get; set; }

    public string Description { get; set; }

    public string Remark { get; set; }

    public string StatusStatusName { get; set; }

    public string UpdatedByEmployeeId { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}

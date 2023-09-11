// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Columns.AlarmResetIdColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.MachineCustomization.Columns
{
  [ColumnsScript("MachineCustomization.AlarmResetId")]
  [BasedOnRow(typeof (AlarmResetIdRow))]
  public class AlarmResetIdColumns
  {
    [EditLink]
    [DisplayName("Db.Shared.RecordId")]
    [AlignRight]
    public int AlarmResetRoleId { get; set; }

    public int AlarmId { get; set; }

    public int RoleId { get; set; }

    public string StatusStatusName { get; set; }

    public string CreatedByEmployeeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string UpdatedByEmployeeId { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}

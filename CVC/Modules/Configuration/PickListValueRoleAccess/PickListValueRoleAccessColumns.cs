// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Columns.PickListValueRoleAccessColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.Configuration.Columns
{
  [ColumnsScript("Configuration.PickListValueRoleAccess")]
  [BasedOnRow(typeof (PickListValueRoleAccessRow))]
  public class PickListValueRoleAccessColumns
  {
    [EditLink]
    [DisplayName("Db.Shared.RecordId")]
    [AlignRight]
    public int PickListValueRoleAccessId { get; set; }

    public string PickListValuePickListValueName { get; set; }

    public string RoleRoleName { get; set; }

    public string StatusStatusName { get; set; }

    public string CreatedByEmployeeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string UpdatedByEmployeeId { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}

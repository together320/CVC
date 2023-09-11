// Decompiled with JetBrains decompiler
// Type: CVC.Data.ModuleAccess
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;

namespace CVC.Data
{
  public class ModuleAccess
  {
    public int ModuleAccessId { get; set; }

    public int? ModuleId { get; set; }

    public int? RoleId { get; set; }

    public bool? IsAccess { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Module Module { get; set; }

    public virtual Role Role { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }
  }
}

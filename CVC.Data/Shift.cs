// Decompiled with JetBrains decompiler
// Type: CVC.Data.Shift
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class Shift
  {
    public Shift()
    {
      this.MachineLineUsers = (ICollection<MachineLineUser>) new HashSet<MachineLineUser>();
      this.MachineUsers = (ICollection<MachineUser>) new HashSet<MachineUser>();
    }

    public int ShiftId { get; set; }

    public string ShiftName { get; set; }

    public string StartTime { get; set; }

    public string EndTime { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<MachineLineUser> MachineLineUsers { get; set; }

    public virtual ICollection<MachineUser> MachineUsers { get; set; }

    public virtual Status Status { get; set; }
  }
}

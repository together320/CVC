// Decompiled with JetBrains decompiler
// Type: CVC.Data.MachineLine
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class MachineLine
  {
    public MachineLine()
    {
      this.Batches = (ICollection<Batch>) new HashSet<Batch>();
      this.LineMaintenanceSchedules = (ICollection<LineMaintenanceSchedule>) new HashSet<LineMaintenanceSchedule>();
      this.Machines = (ICollection<Machine>) new HashSet<Machine>();
      this.MachineLineUsers = (ICollection<MachineLineUser>) new HashSet<MachineLineUser>();
    }

    public int MachineLineId { get; set; }

    public string LineName { get; set; }

    public string LineRatedSpeed { get; set; }

    public int? NumberOfMachines { get; set; }

    public DateTime? InstalledDate { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<Batch> Batches { get; set; }

    public virtual ICollection<LineMaintenanceSchedule> LineMaintenanceSchedules { get; set; }

    public virtual ICollection<Machine> Machines { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }

    public virtual ICollection<MachineLineUser> MachineLineUsers { get; set; }
  }
}

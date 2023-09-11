// Decompiled with JetBrains decompiler
// Type: CVC.Data.MachineType
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System.Collections.Generic;

namespace CVC.Data
{
  public class MachineType
  {
    public MachineType()
    {
      this.Machines = (ICollection<Machine>) new HashSet<Machine>();
      this.PLCs = (ICollection<PLC>) new HashSet<PLC>();
    }

    public int MachineTypeId { get; set; }

    public string MachineTypeName { get; set; }

    public int? StatusId { get; set; }

    public virtual ICollection<Machine> Machines { get; set; }

    public virtual ICollection<PLC> PLCs { get; set; }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Data.MachineSparePart
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class MachineSparePart
  {
    public MachineSparePart()
    {
      this.MachineHistories = (ICollection<MachineHistory>) new HashSet<MachineHistory>();
    }

    public int MachineSparePartId { get; set; }

    public int? MachineId { get; set; }

    public string PartNumber { get; set; }

    public string PartName { get; set; }

    public string PartDescription { get; set; }

    public int? NoOfUnitsRequired { get; set; }

    public string PartImage { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Machine Machine { get; set; }

    public virtual ICollection<MachineHistory> MachineHistories { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }
  }
}

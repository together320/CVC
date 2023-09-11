// Decompiled with JetBrains decompiler
// Type: CVC.Data.MachineSpecification
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;

namespace CVC.Data
{
  public class MachineSpecification
  {
    public int MachineSpecId { get; set; }

    public int? MachineId { get; set; }

    public string Description { get; set; }

    public string Details { get; set; }

    public string MachineImage { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Machine Machine { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }
  }
}

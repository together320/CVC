// Decompiled with JetBrains decompiler
// Type: CVC.Data.MachineHistory
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;

namespace CVC.Data
{
  public class MachineHistory
  {
    public int MachineHistoryId { get; set; }

    public int? MachineId { get; set; }

    public DateTime? IssueStartDate { get; set; }

    public DateTime? IssueCloseDate { get; set; }

    public int? ProblemNatureId { get; set; }

    public int? SparePartId { get; set; }

    public string ProblemDescription { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Machine Machine { get; set; }

    public virtual MachineSparePart MachineSparePart { get; set; }

    public virtual PickListValue PickListValue { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }
  }
}

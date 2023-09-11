// Decompiled with JetBrains decompiler
// Type: CVC.Data.LabelRoll
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class LabelRoll
  {
    public LabelRoll()
    {
      this.LabelReconciliations = (ICollection<LabelReconciliation>) new HashSet<LabelReconciliation>();
    }

    public int LabelRollId { get; set; }

    public int? BatchId { get; set; }

    public int? MachineId { get; set; }

    public int? LabelRollNumber { get; set; }

    public int? NumberOfLabels { get; set; }

    public string Remark { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Batch Batch { get; set; }

    public virtual ICollection<LabelReconciliation> LabelReconciliations { get; set; }

    public virtual Machine Machine { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }
  }
}

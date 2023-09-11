// Decompiled with JetBrains decompiler
// Type: CVC.Data.LabelReconciliation
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class LabelReconciliation
  {
    public LabelReconciliation()
    {
      this.LabelLosts = (ICollection<CVC.Data.LabelLost>) new HashSet<CVC.Data.LabelLost>();
    }

    public int LabelRecId { get; set; }

    public int? BatchId { get; set; }

    public int? MachineId { get; set; }

    public int? LabelRollId { get; set; }

    public int? RejectedLabels { get; set; }

    public int? LabelLost { get; set; }

    public int? NoLabelOnRoll { get; set; }

    public int? LabelBalance { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Batch Batch { get; set; }

    public virtual ICollection<CVC.Data.LabelLost> LabelLosts { get; set; }

    public virtual LabelRoll LabelRoll { get; set; }

    public virtual Machine Machine { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }
  }
}

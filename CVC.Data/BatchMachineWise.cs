// Decompiled with JetBrains decompiler
// Type: CVC.Data.BatchMachineWise
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class BatchMachineWise
  {
    public BatchMachineWise()
    {
      this.BatchRecipeModifies = (ICollection<BatchRecipeModify>) new HashSet<BatchRecipeModify>();
      this.BatchRunDatas = (ICollection<BatchRunData>) new HashSet<BatchRunData>();
    }

    public int BatchMachineId { get; set; }

    public int? MachineId { get; set; }

    public int? BatchId { get; set; }

    public int? RecipeId { get; set; }

    public bool? IsMachineInUse { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Batch Batch { get; set; }

    public virtual Machine Machine { get; set; }

    public virtual MachineRecipe MachineRecipe { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }

    public virtual ICollection<BatchRecipeModify> BatchRecipeModifies { get; set; }

    public virtual ICollection<BatchRunData> BatchRunDatas { get; set; }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Data.BatchRecipeModify
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;

namespace CVC.Data
{
  public class BatchRecipeModify
  {
    public int BatchRecipeModifyId { get; set; }

    public int? BatchMachineId { get; set; }

    public int? RecipeSettingsParameterId { get; set; }

    public string OldValue { get; set; }

    public string NewValue { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual BatchMachineWise BatchMachineWise { get; set; }

    public virtual RecipeSettingsParameter RecipeSettingsParameter { get; set; }

    public virtual User User { get; set; }
  }
}

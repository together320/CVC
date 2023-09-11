﻿// Decompiled with JetBrains decompiler
// Type: CVC.Data.MachineRecipe
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class MachineRecipe
  {
    public MachineRecipe()
    {
      this.BatchMachineWises = (ICollection<BatchMachineWise>) new HashSet<BatchMachineWise>();
      this.MachineRecipeParameters = (ICollection<MachineRecipeParameter>) new HashSet<MachineRecipeParameter>();
    }

    public int MachineRecipeId { get; set; }

    public int? MachineId { get; set; }

    public int? RecipeSettingsId { get; set; }

    public string RecipeName { get; set; }

    public string Description { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<BatchMachineWise> BatchMachineWises { get; set; }

    public virtual Machine Machine { get; set; }

    public virtual RecipeSetting RecipeSetting { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }

    public virtual ICollection<MachineRecipeParameter> MachineRecipeParameters { get; set; }
  }
}

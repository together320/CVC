// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Forms.BatchRecipeModifyForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using Serenity.ComponentModel;
using System;

namespace CVC.Batch.Forms
{
  [FormScript("Batch.BatchRecipeModify")]
  [BasedOnRow(typeof (BatchRecipeModifyRow))]
  public class BatchRecipeModifyForm
  {
    public int BatchMachineId { get; set; }

    public int RecipeSettingsParameterId { get; set; }

    public string OldValue { get; set; }

    public string NewValue { get; set; }

    public int UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}

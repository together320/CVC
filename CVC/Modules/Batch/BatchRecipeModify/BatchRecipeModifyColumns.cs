// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Columns.BatchRecipeModifyColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.Batch.Columns
{
  [ColumnsScript("Batch.BatchRecipeModify")]
  [BasedOnRow(typeof (BatchRecipeModifyRow))]
  public class BatchRecipeModifyColumns
  {
    [EditLink]
    [DisplayName("Db.Shared.RecordId")]
    [AlignRight]
    public int BatchRecipeModifyId { get; set; }

    public int BatchMachineId { get; set; }

    public int RecipeSettingsParameterId { get; set; }

    [EditLink]
    public string OldValue { get; set; }

    public string NewValue { get; set; }

    public string UpdatedByEmployeeId { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}

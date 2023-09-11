// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Columns.RecipeSettingsParameterColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.MachineCustomization.Columns
{
  [ColumnsScript("MachineCustomization.RecipeSettingsParameter")]
  [BasedOnRow(typeof (RecipeSettingsParameterRow))]
  public class RecipeSettingsParameterColumns
  {
    [EditLink]
    [DisplayName("Db.Shared.RecordId")]
    [AlignRight]
    public int RecipeParameterId { get; set; }

    public string RecipeSettingsRecipeSettingsName { get; set; }

    public string IpcParameterIpcParameterName { get; set; }

    public short IsFetchOnSelfSet { get; set; }

    public string StatusStatusName { get; set; }

    public string CreatedByEmployeeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string UpdatedByEmployeeId { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}

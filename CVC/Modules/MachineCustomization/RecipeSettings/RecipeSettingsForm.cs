// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Forms.RecipeSettingsForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;
using System;

namespace CVC.MachineCustomization.Forms
{
  [FormScript("MachineCustomization.RecipeSettings")]
  [BasedOnRow(typeof (RecipeSettingsRow))]
  public class RecipeSettingsForm
  {
    public string RecipeSettingsName { get; set; }

    public int MachineId { get; set; }

    public int StatusId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}

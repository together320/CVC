// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Columns.MachineRecipeColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;

namespace CVC.MachineCustomization.Columns
{
  [ColumnsScript("MachineCustomization.MachineRecipe")]
  [BasedOnRow(typeof (MachineRecipeRow))]
  public class MachineRecipeColumns
  {
        public string MachineMachineName { get; set; }
        [QuickFilter]
        [LookupEditor(typeof(MachineRecipeRow))]

        public string RecipeName { get; set; }

    public string Description { get; set; }

    public bool IsDefaultRecipe { get; set; }

       
    }
}

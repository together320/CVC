// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Forms.MachineRecipeForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;
using System.ComponentModel;

namespace CVC.MachineCustomization.Forms
{
  [FormScript("MachineCustomization.MachineRecipe")]
  [BasedOnRow(typeof (MachineRecipeRow))]
  public class MachineRecipeForm
  {
    [Width(300)]
        [Updatable(false)]
        public string RecipeName { get; set; }

    [Width(300)]
        [Updatable(false)]
        public string Description { get; set; }
     //[Width(300)]
     //public bool IsDefaultRecipe { get; set; }

    }
}

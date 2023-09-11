// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Columns.MachineRecipeParameterColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.MachineCustomization.Columns
{
    [ColumnsScript("MachineCustomization.MachineRecipeParameter")]
    [BasedOnRow(typeof(MachineRecipeParameterRow))]
    public class MachineRecipeParameterColumns
    {
        [DisplayName("Recipe Name")]
        [QuickFilter]
        [LookupEditor(typeof(MachineRecipeRow))]
        public string MachineRecipeName { get; set; }

        [DisplayName("Machine Parameter Name")]
        public string MachineParameterName { get; set; }


        [DisplayName("Machine Parameter Value")]
        public string MachineParameterValue { get; set; }

    }
}

// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Columns.MachineParameterColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using CVC.MachineCustomization.Scripts;
using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using System;

namespace CVC.MachineCustomization.Columns
{
    [ColumnsScript("MachineCustomization.MachineParameter")]
    [BasedOnRow(typeof(MachineParameterRow))]
    public class MachineParameterColumns
    {
        [Width(250)]
        [EditLink]
        public string ParameterName { get; set; }

        [QuickFilter]
        [LookupEditor(typeof(MachineLookUp))]
      // [LookupEditor(typeof(MachineRow))]
     //   [LookupEditor(typeof(MachineRow), CascadeField = "MachineName", CascadeValue = "MachineID",FilterField ="StatusId",FilterValue="1")]

        public string MachineMachineName { get; set; }

        // added by Denis for RS 3.7 dated 7/20/2021
        public string ColumnName { get; set; }

        // added by Denis for RS 3.8 dated 7/20/2021
        public string PickListName { get; set; }

        public string PlcAddress { get; set; }

        [Width(200)]
        public string DataTypeName { get; set; }

        [Width(150)]
        public Decimal Min { get; set; }

        [Width(150)]
        public Decimal Max { get; set; }

        [Width(150)]
        public string UnitPickListValueName { get; set; }

        [Width(200)]
        public string StatusStatusName { get; set; }
    }
}

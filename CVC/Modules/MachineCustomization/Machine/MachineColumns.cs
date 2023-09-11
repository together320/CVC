// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Columns.MachineColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.MachineCustomization.Columns
{
    [ColumnsScript("MachineCustomization.Machine")]
    [BasedOnRow(typeof(MachineRow))]
    public class MachineColumns
    {
        public string MachineName { get; set; }

        // added by Denis for RS 3.3 dated 7/20/2021
        public bool IsRealTime { get; set; }

        //[CssClass("table-id")]
        //public Int32 TableId { get; set; }

        // added by Denis for RS 3.4 dated 7/20/2021
        public string TableName { get; set; }

        public string ModelNumber { get; set; }

        public string SerialNumber { get; set; }

        public string Make { get; set; }

        public int Year { get; set; }

        public string PlcMake { get; set; }

        public string PlcModelNumber { get; set; }

        public string PlcSerialNumber { get; set; }

        public string PlcAddress { get; set; }

        public string AccessIpAddress { get; set; }

        public int MachineSequence { get; set; }

        public string StatusStatusName { get; set; }
    }
}

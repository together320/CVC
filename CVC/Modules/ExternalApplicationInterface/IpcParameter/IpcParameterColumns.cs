// Decompiled with JetBrains decompiler
// Type: CVC.ExternalApplicationInterface.Columns.IpcParameterColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.ExternalApplicationInterface.Entities;
using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;

namespace CVC.ExternalApplicationInterface.Columns
{
    [ColumnsScript("ExternalApplicationInterface.IpcParameter")]
    [BasedOnRow(typeof(IpcParameterRow))]
    public class IpcParameterColumns
    {
        [QuickFilter]
        [LookupEditor(typeof(MachineRow))]
        public string MachineMachineName { get; set; }

      
        public string IpcParameterName { get; set; }

        [EditLink]
        public string MachineParameterName { get; set; }

        public string IpcAddress { get; set; }

        //public short IsChangeInRuntime { get; set; }
        public int? BitWiseIndex { get; set; }

        [QuickFilter]
        public bool? IsAlarm { get; set; }

        public string StatusStatusName { get; set; }
    }
}

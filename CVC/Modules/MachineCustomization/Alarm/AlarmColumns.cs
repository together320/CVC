// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Columns.AlarmColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;

namespace CVC.MachineCustomization.Columns
{
  [ColumnsScript("MachineCustomization.Alarm")]
  [BasedOnRow(typeof (AlarmRow))]
  public class AlarmColumns
  {
    [EditLink]
    [Width(200)]
    public string AlarmName { get; set; }

        [Width(200)]
        [QuickFilter]
        [LookupEditor(typeof(MachineRow))]
        public string MachineMachineName { get; set; }

        [Width(200)]
    public string MachineParameterMachineParameterName { get; set; }

    [Width(200)]
    public string Message { get; set; }

    //[Width(200)]
    //public string IsResetRequiredString { get; set; }

    //[Width(150)]
    //public string IsCommentRequiredString { get; set; }

    //[Width(150)]
    //public string IsMachineRequiredToStopString { get; set; }

    [Width(200)]
    public string MachineStopIpcParameterIpcParameterName { get; set; }

    //[Width(200)]
    //public string IsCountForRejectString { get; set; }

    //[Width(150)]
    //public string BitValueString { get; set; }

    //[Width(150)]
    //public string IsCheckAtMachineStartString { get; set; }

    [Width(150)]
    public string StatusStatusName { get; set; }
  }
}

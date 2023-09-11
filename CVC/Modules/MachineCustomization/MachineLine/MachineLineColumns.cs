// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Columns.MachineLineColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;
using System;

namespace CVC.MachineCustomization.Columns
{
  [ColumnsScript("MachineCustomization.MachineLine")]
  [BasedOnRow(typeof (MachineLineRow))]
  public class MachineLineColumns
  {
    [EditLink]
    [Width(200)]
    public string LineName { get; set; }

    [Width(200)]
    public string LineRatedSpeed { get; set; }

    [Width(200)]
    public int NumberOfMachines { get; set; }

    [Width(200)]
    public DateTime InstalledDate { get; set; }

    [Width(200)]
    public string StatusStatusName { get; set; }

    [Width(200)]
    public string UpdatedByEmployeeId { get; set; }

    [Width(200)]
    public DateTime UpdatedDate { get; set; }
  }
}

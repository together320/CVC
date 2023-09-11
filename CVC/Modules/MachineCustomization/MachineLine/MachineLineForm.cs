// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Forms.MachineLineForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.MachineCustomization.Entities;
using Serenity.ComponentModel;
using System;

namespace CVC.MachineCustomization.Forms
{
  [FormScript("MachineCustomization.MachineLine")]
  [BasedOnRow(typeof (MachineLineRow))]
  public class MachineLineForm
  {
    [LabelWidth(200)]
    public string LineName { get; set; }

    [LabelWidth(200)]
    [HalfWidth]
    public string LineRatedSpeed { get; set; }

    [LabelWidth(200)]
    [HalfWidth]
    public int NumberOfMachines { get; set; }

    [LabelWidth(200)]
    [HalfWidth]
    public DateTime InstalledDate { get; set; }

    [LabelWidth(200)]
    [HalfWidth]
    [Updatable(false)]
    [LookupEditor(typeof (StatusRow), FilterField = "StatusId", FilterValue = "1")]
    public int StatusId { get; set; }
  }
}

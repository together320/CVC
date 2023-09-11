// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Forms.OutsertForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.PackSettings.Entities;
using Serenity.ComponentModel;
using System.ComponentModel;

namespace CVC.PackSettings.Forms
{
  [FormScript("PackSettings.Outsert")]
  [BasedOnRow(typeof (OutsertRow))]
  public class OutsertForm
  {
    [Category("General")]
    [LabelWidth(190)]
    public string OutsertName { get; set; }

    [Category("Specification")]
    [LabelWidth(190)]
    [HalfWidth]
    public string OutsertLength { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string OutsertWidth { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string OutsertThickness { get; set; }

    [LabelWidth(190)]
    [Category("Supplier")]
    [LookupEditor(typeof (SupplierRow))]
    public int SupplierId { get; set; }

    [Category("Status")]
    [LabelWidth(190)]
    [LookupEditor(typeof (StatusRow))]
    public int StatusId { get; set; }
  }
}

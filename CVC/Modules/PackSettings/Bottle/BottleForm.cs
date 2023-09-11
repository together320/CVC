// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Forms.BottleForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.Configuration.Scripts;
using CVC.PackSettings.Entities;
using Serenity.ComponentModel;
using System.ComponentModel;

namespace CVC.PackSettings.Forms
{
  [FormScript("PackSettings.Bottle")]
  [BasedOnRow(typeof (BottleRow))]
  public class BottleForm
  {
    [Category("General")]
    [LabelWidth(190)]
    public string BottleName { get; set; }

    [Category("Specification")]
    [LabelWidth(190)]
    [HalfWidth]
    public string BottleCc { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
   // [LookupFiltering()]
    [LookupEditor(typeof (PickListValueLookup), CascadeField = "PickListId", CascadeValue = "3")]
    public int ContainerTypeId { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string BottleHeight { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string BottleDiameter { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string BottleMouthOpeningId { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string BottleMouthOpeningOd { get; set; }

    [LabelWidth(190)]
    [Category("Supplier")]
    [LookupEditor(typeof (SupplierRow))]
    public int SupplierId { get; set; }

    [LabelWidth(190)]
    [Category("Status")]
    [LookupEditor(typeof (StatusRow))]
    public int StatusId { get; set; }
  }
}

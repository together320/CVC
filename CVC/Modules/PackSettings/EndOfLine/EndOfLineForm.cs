// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Forms.EndOfLineForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.PackSettings.Entities;
using Serenity.ComponentModel;
using System.ComponentModel;

namespace CVC.PackSettings.Forms
{
  [FormScript("PackSettings.EndOfLine")]
  [BasedOnRow(typeof (EndOfLineRow))]
  public class EndOfLineForm
  {
    [Category("General")]
    [LabelWidth(190)]
    public string EndOfLineName { get; set; }

    [Category("Carton")]
    [LabelWidth(190)]
    [HalfWidth]
    public string CartonLength { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string CartonHeight { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string CartonWidth { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string CartonType { get; set; }

    [Category("Bottle")]
    [LabelWidth(190)]
    [HalfWidth]
    public string BottleConfiguration { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string MedicationLength { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string MedicationWidth { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string NoOfMedication { get; set; }

    [Category("Inner Shipper Box")]
    [LabelWidth(190)]
    [HalfWidth]
    public string InnerShipperBoxType { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string InnerShipperBoxLength { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string InnerShipperBoxWidth { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string InnerShipperBoxHeight { get; set; }

    [Category("Outer Shipper Box")]
    [LabelWidth(190)]
    [HalfWidth]
    public string OuterShipperBoxLength { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string OuterShipperBoxWidth { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string OuterShipperBoxHeight { get; set; }

    [Category("Shipper")]
    [HalfWidth]
    [LabelWidth(190)]
    public string InnerShipperMatrix { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string OuterShipperQuantity { get; set; }

    [Category("Status")]
    [LabelWidth(190)]
    [LookupEditor(typeof (StatusRow))]
    public int StatusId { get; set; }
  }
}

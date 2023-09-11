// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Columns.EndOfLineColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.PackSettings.Entities;
using Serenity.ComponentModel;

namespace CVC.PackSettings.Columns
{
  [ColumnsScript("PackSettings.EndOfLine")]
  [BasedOnRow(typeof (EndOfLineRow))]
  public class EndOfLineColumns
  {
    [EditLink]
    public string EndOfLineName { get; set; }

    public string CartonLength { get; set; }

    public string CartonHeight { get; set; }

    public string CartonWidth { get; set; }

    public string CartonType { get; set; }

    public string BottleConfiguration { get; set; }

    public string MedicationLength { get; set; }

    public string MedicationWidth { get; set; }

    public string NoOfMedication { get; set; }

    public string InnerShipperBoxType { get; set; }

    public string InnerShipperBoxLength { get; set; }

    public string InnerShipperBoxWidth { get; set; }

    public string InnerShipperBoxHeight { get; set; }

    public string OuterShipperBoxLength { get; set; }

    public string OuterShipperBoxWidth { get; set; }

    public string OuterShipperBoxHeight { get; set; }

    public string InnerShipperMatrix { get; set; }

    public string OuterShipperQuantity { get; set; }

    public string StatusStatusName { get; set; }
  }
}

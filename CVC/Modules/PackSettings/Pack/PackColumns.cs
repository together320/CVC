// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Columns.PackColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.PackSettings.Entities;
using Serenity.ComponentModel;

namespace CVC.PackSettings.Columns
{
  [ColumnsScript("PackSettings.Pack")]
  [BasedOnRow(typeof (PackRow))]
  public class PackColumns
  {
    [EditLink]
    [Width(150)]
    public string PackName { get; set; }

    [Width(150)]
    public string TabletName { get; set; }

    [Width(150)]
    public int TabletCount { get; set; }

    [Width(150)]
    public string BottleName { get; set; }

    [Width(150)]
    public string CapName { get; set; }

    [Width(150)]
    public string CottonName { get; set; }

    [Width(150)]
    public string CottonLength { get; set; }

    [Width(200)]
    public int NumberOfCottonPieces { get; set; }

    [Width(150)]
    public string DesiccantName { get; set; }

    [Width(200)]
    public int NumberOfDesicantPieces { get; set; }

    [Width(150)]
    public string OutsertName { get; set; }

    [Width(150)]
    public string LabelLabelName { get; set; }

    [Width(150)]
    public string EndOfLineEndOfLineName { get; set; }

    [Width(150)]
    public string StatusStatusName { get; set; }
  }
}

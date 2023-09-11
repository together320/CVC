// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Columns.OutsertColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.PackSettings.Entities;
using Serenity.ComponentModel;

namespace CVC.PackSettings.Columns
{
  [ColumnsScript("PackSettings.Outsert")]
  [BasedOnRow(typeof (OutsertRow))]
  public class OutsertColumns
  {
    [EditLink]
    [Width(250)]
    public string OutsertName { get; set; }

    [Width(150)]
    public string OutsertLength { get; set; }

    [Width(150)]
    public string OutsertWidth { get; set; }

    [Width(150)]
    public string OutsertThickness { get; set; }

    [Width(250)]
    public string SupplierSupplierName { get; set; }

    [Width(150)]
    public string StatusStatusName { get; set; }
  }
}

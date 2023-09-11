// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Columns.BottleColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.PackSettings.Entities;
using Serenity.ComponentModel;

namespace CVC.PackSettings.Columns
{
  [ColumnsScript("PackSettings.Bottle")]
  [BasedOnRow(typeof (BottleRow))]
  public class BottleColumns
  {
    [EditLink]
    [Width(150)]
    public string BottleName { get; set; }

    [Width(150)]
    public string BottleCc { get; set; }

    [Width(200)]
    public string ContainerTypePickListValueName { get; set; }

    [Width(150)]
    public string BottleHeight { get; set; }

    [Width(150)]
    public string BottleDiameter { get; set; }

    [Width(200)]
    public string BottleMouthOpeningId { get; set; }

    [Width(200)]
    public string BottleMouthOpeningOd { get; set; }

    [Width(200)]
    public string SupplierSupplierName { get; set; }

    [Width(150)]
    public string StatusStatusName { get; set; }
  }
}

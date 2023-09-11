// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Columns.CapColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.PackSettings.Entities;
using Serenity.ComponentModel;

namespace CVC.PackSettings.Columns
{
  [ColumnsScript("PackSettings.Cap")]
  [BasedOnRow(typeof (CapRow))]
  public class CapColumns
  {
    [EditLink]
    [Width(250)]
    public string CapName { get; set; }

    [Width(150)]
    public string CapCc { get; set; }

    [Width(200)]
    public string CapTypePickListValueName { get; set; }

    [Width(150)]
    public string CapDiameter { get; set; }

    [Width(150)]
    public string CapHeight { get; set; }

    [Width(250)]
    public string SupplierSupplierName { get; set; }

    [Width(150)]
    public string StatusStatusName { get; set; }
  }
}

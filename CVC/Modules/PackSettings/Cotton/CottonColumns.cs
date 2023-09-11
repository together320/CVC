// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Columns.CottonColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.PackSettings.Entities;
using Serenity.ComponentModel;

namespace CVC.PackSettings.Columns
{
  [ColumnsScript("PackSettings.Cotton")]
  [BasedOnRow(typeof (CottonRow))]
  public class CottonColumns
  {
    [EditLink]
    [Width(250)]
    public string CottonName { get; set; }

    [Width(250)]
    public string CottonTypePickListValueName { get; set; }

    [Width(150)]
    public string GmOrYard { get; set; }

    [Width(250)]
    public string SupplierSupplierName { get; set; }

    [Width(150)]
    public string StatusStatusName { get; set; }
  }
}

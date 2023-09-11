// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Columns.LabelColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.PackSettings.Entities;
using Serenity.ComponentModel;

namespace CVC.PackSettings.Columns
{
  [ColumnsScript("PackSettings.Label")]
  [BasedOnRow(typeof (LabelRow))]
  public class LabelColumns
  {
    [EditLink]
    public string LabelName { get; set; }

    public string LabelLength { get; set; }

    public string LabelHeight { get; set; }

    public string LabelType { get; set; }

    public string LabelImage { get; set; }

    public string SupplierSupplierName { get; set; }

    public string StatusStatusName { get; set; }
  }
}

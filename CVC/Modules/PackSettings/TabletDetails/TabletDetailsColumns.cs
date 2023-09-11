// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Columns.TabletDetailsColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.PackSettings.Entities;
using Serenity.ComponentModel;

namespace CVC.PackSettings.Columns
{
  [ColumnsScript("PackSettings.TabletDetails")]
  [BasedOnRow(typeof (TabletDetailsRow))]
  public class TabletDetailsColumns
  {
    [EditLink]
    [Width(200)]
    public string TabletName { get; set; }

    public string TabletStrength { get; set; }

    [Width(200)]
    public string TabletTypePickListValueName { get; set; }

    [Width(200)]
    public string TabletCharOnePickListValueName { get; set; }

    [Width(200)]
    public string TabletCharTwoPickListValueName { get; set; }

    [Width(150)]
    public string TabletShapePickListValueName { get; set; }

    public string TabletLength { get; set; }

    public string TabletThickness { get; set; }

    public string TabletWidth { get; set; }

    public string StatusStatusName { get; set; }
  }
}

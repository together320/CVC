// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Columns.DesiccantColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.PackSettings.Entities;
using Serenity.ComponentModel;

namespace CVC.PackSettings.Columns
{
  [ColumnsScript("PackSettings.Desiccant")]
  [BasedOnRow(typeof (DesiccantRow))]
  public class DesiccantColumns
  {
    [EditLink]
    [Width(250)]
    public string DesiccantName { get; set; }

    [Width(250)]
    public string DesiccantTypePickListValueName { get; set; }

    [Width(200)]
    public string Grammage { get; set; }

    [Width(200)]
    public string LengthOrHeight { get; set; }

    [Width(200)]
    public string DiameterOrWidth { get; set; }

    [Width(200)]
    public string IdentificationPickListValueName { get; set; }

    [Width(200)]
    public string StatusStatusName { get; set; }
  }
}

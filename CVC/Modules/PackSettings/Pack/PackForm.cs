// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Forms.PackForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.PackSettings.Entities;
using Serenity.ComponentModel;
using System.ComponentModel;

namespace CVC.PackSettings.Forms
{
  [FormScript("PackSettings.Pack")]
  [BasedOnRow(typeof (PackRow))]
  public class PackForm
  {
    [Category("General")]
    [LabelWidth(190)]
    public string PackName { get; set; }

    [Category("Specification")]
    [LabelWidth(190)]
    [HalfWidth]
    [LookupEditor(typeof (TabletDetailsRow))]
    public int TabletId { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public int TabletCount { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    [LookupEditor(typeof (BottleRow))]
    public int BottleId { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    [LookupEditor(typeof (CapRow))]
    public int CapId { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    [LookupEditor(typeof (CottonRow))]
    public int CottonId { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string CottonLength { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public int NumberOfCottonPieces { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    [LookupEditor(typeof (DesiccantRow))]
    public int DesiccantId { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public int NumberOfDesicantPieces { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    [LookupEditor(typeof (OutsertRow))]
    public int OutsertId { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    [LookupEditor(typeof (LabelRow))]
    public int LabelId { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    [LookupEditor(typeof (EndOfLineRow))]
    public int EndOfLineId { get; set; }

    [Category("Status")]
    [LabelWidth(190)]
    [LookupEditor(typeof (StatusRow))]
    public int StatusId { get; set; }
  }
}

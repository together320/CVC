// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Forms.TabletDetailsForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.Configuration.Scripts;
using CVC.PackSettings.Entities;
using Serenity.ComponentModel;
using System.ComponentModel;

namespace CVC.PackSettings.Forms
{
  [FormScript("PackSettings.TabletDetails")]
  [BasedOnRow(typeof (TabletDetailsRow))]
  public class TabletDetailsForm
  {
    [Category("General")]
    [LabelWidth(190)]
    public string TabletName { get; set; }

    [Category("Specification")]
    [LabelWidth(190)]
    [HalfWidth]
    public string TabletStrength { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    [LookupEditor(typeof (PickListValueLookup), CascadeField = "PickListId", CascadeValue = "5")]
    public int TabletTypeId { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    [LookupEditor(typeof (PickListValueLookup), CascadeField = "PickListId", CascadeValue = "6")]
    public int TabletCharOneId { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    [LookupEditor(typeof (PickListValueLookup), CascadeField = "PickListId", CascadeValue = "7")]
    public int TabletCharTwoId { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    [LookupEditor(typeof (PickListValueLookup), CascadeField = "PickListId", CascadeValue = "8")]
    public int TabletShapeId { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string TabletLength { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string TabletThickness { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string TabletWidth { get; set; }

    [Category("Status")]
    [LabelWidth(190)]
    [LookupEditor(typeof (StatusRow))]
    public int StatusId { get; set; }
  }
}

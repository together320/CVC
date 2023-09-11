// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Forms.CottonForm
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
  [FormScript("PackSettings.Cotton")]
  [BasedOnRow(typeof (CottonRow))]
  public class CottonForm
  {
    [Category("General")]
    [LabelWidth(190)]
    public string CottonName { get; set; }

    [Category("Specification")]
    [LabelWidth(190)]
    [HalfWidth]
    [LookupEditor(typeof (PickListValueLookup), CascadeField = "PickListId", CascadeValue = "10")]
    public int CottonTypeId { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    public string GmOrYard { get; set; }

    [Category("Supplier")]
    [LookupEditor(typeof (SupplierRow))]
    [LabelWidth(190)]
    public int SupplierId { get; set; }

    [Category("Status")]
    [LabelWidth(190)]
    [LookupEditor(typeof (StatusRow))]
    public int StatusId { get; set; }
  }
}

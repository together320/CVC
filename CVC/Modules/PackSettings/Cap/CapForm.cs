﻿// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Forms.CapForm
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
  [FormScript("PackSettings.Cap")]
  [BasedOnRow(typeof (CapRow))]
  public class CapForm
  {
    [Category("General")]
    [LabelWidth(190)]
    public string CapName { get; set; }

    [Category("Specification")]
    [LabelWidth(190)]
    [HalfWidth]
    public string CapCc { get; set; }

    [LabelWidth(190)]
    [HalfWidth]
    [LookupEditor(typeof (PickListValueLookup), CascadeField = "PickListId", CascadeValue = "4")]
    public int CapTypeId { get; set; }

    [HalfWidth]
    [LabelWidth(190)]
    public string CapDiameter { get; set; }

    [HalfWidth]
    [LabelWidth(190)]
    public string CapHeight { get; set; }

    [Category("Supplier")]
    [LabelWidth(190)]
    [LookupEditor(typeof (SupplierRow))]
    public int SupplierId { get; set; }

    [Category("Status")]
    [LabelWidth(190)]
    [LookupEditor(typeof (StatusRow))]
    public int StatusId { get; set; }
  }
}

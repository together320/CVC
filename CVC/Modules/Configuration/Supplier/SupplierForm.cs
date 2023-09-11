// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Forms.SupplierForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.Configuration.Scripts;
using Serenity.ComponentModel;
using System.ComponentModel;

namespace CVC.Configuration.Forms
{
  [FormScript("Configuration.Supplier")]
  [BasedOnRow(typeof (SupplierRow))]
  public class SupplierForm
  {
    [Category("General")]
    [LabelWidth(150)]
    public string SupplierName { get; set; }

    [Category("Address")]
    [LabelWidth(150)]
    public string SupplierAddress { get; set; }

    [LabelWidth(150)]
    [HalfWidth]
    [LookupEditor(typeof (CountryLookup))]
    public string CityCountry { get; set; }

    [LabelWidth(150)]
    [HalfWidth]
    [LookupEditor(typeof (StateLookup), CascadeField = "Country", CascadeFrom = "CityCountry")]
    public string CityState { get; set; }

    [LabelWidth(150)]
    [HalfWidth]
    [LookupEditor(typeof (CityLookup), CascadeField = "State", CascadeFrom = "CityState")]
    public int CityId { get; set; }

    [LabelWidth(150)]
    [HalfWidth]
    public string PinCode { get; set; }

    [LabelWidth(150)]
    [HalfWidth]
    public int MobileCode { get; set; }

    [LabelWidth(150)]
    [HalfWidth]
    [MaxLength(10)]
    public long MobileNumber { get; set; }

    [LookupEditor(typeof (StatusRow))]
    [Category("Status")]
    [LabelWidth(150)]
    public int StatusId { get; set; }
  }
}

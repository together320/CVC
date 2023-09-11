// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Forms.CompanyForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.Configuration.Scripts;
using Serenity.ComponentModel;
using System.IO;

namespace CVC.Configuration.Forms
{
  [FormScript("Configuration.Company")]
  [BasedOnRow(typeof (CompanyRow))]
  public class CompanyForm
  {
    [LabelWidth(150)]
    public string CompanyName { get; set; }

    [LabelWidth(150)]
    public string Address { get; set; }

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
    public string PinCode { get; set; }

    [LabelWidth(150)]
    public string Website { get; set; }

    [LabelWidth(150)]
  
    public string CompanyLogo { get; set; }
  }
}

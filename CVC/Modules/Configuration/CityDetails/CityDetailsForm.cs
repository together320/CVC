// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Forms.CityDetailsForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.Configuration.Scripts;
using Serenity.ComponentModel;

namespace CVC.Configuration.Forms
{
  [FormScript("Configuration.CityDetails")]
  [BasedOnRow(typeof (CityDetailsRow))]
  public class CityDetailsForm
  {
    [LookupEditor(typeof (CountryLookup))]
    public string Country { get; set; }

    [LookupEditor(typeof (StateLookup), CascadeField = "Country", CascadeFrom = "Country")]
    public string State { get; set; }

    public string City { get; set; }

    [LookupEditor(typeof (StatusRow))]
    public int StatusId { get; set; }
  }
}

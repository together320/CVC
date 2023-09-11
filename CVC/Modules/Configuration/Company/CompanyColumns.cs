// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Columns.CompanyColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.ComponentModel;
using System;
using System.IO;

namespace CVC.Configuration.Columns
{
  [ColumnsScript("Configuration.Company")]
  [BasedOnRow(typeof (CompanyRow))]
  public class CompanyColumns
  {
    [EditLink]
    public string CompanyName { get; set; }

    public string Address { get; set; }

    public string CityCountry { get; set; }

    public string PinCode { get; set; }

    public string Website { get; set; }

    public Stream CompanyLogo { get; set; }

    public string UpdatedByEmployeeId { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}

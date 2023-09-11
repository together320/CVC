// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Columns.CityDetailsColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.ComponentModel;

namespace CVC.Configuration.Columns
{
  [ColumnsScript("Configuration.CityDetails")]
  [BasedOnRow(typeof (CityDetailsRow))]
  public class CityDetailsColumns
  {
    [EditLink]
    public string City { get; set; }

    public string State { get; set; }

    public string Country { get; set; }

    public string StatusStatusName { get; set; }
  }
}

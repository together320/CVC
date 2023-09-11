// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Scripts.CountryLookup
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Web;

namespace CVC.Configuration.Scripts
{
  [LookupScript("Configuration.Country", Permission = "Lookup")]
  public class CountryLookup : RowLookupScript<CityDetailsRow>
  {
    public CountryLookup()
    {
      this.IdField = this.TextField = "Country";
    }

    protected override void PrepareQuery(SqlQuery query)
    {
      CityDetailsRow.RowFields fields = CityDetailsRow.Fields;
      query.Distinct(true).Select((IField) fields.Country).Where<SqlQuery>((ICriteria) ((BaseCriteria) new Criteria((IField) fields.Country) != "" & new Criteria((IField) fields.Country).IsNotNull()));
    }

    protected override void ApplyOrder(SqlQuery query)
    {
    }
  }
}

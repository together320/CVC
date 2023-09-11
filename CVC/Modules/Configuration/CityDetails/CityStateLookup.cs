// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Scripts.CityStateLookup
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
  [LookupScript("Configuration.CityState", Permission = "Lookup")]
  public class CityStateLookup : RowLookupScript<CityDetailsRow>
  {
    public CityStateLookup()
    {
      this.IdField = this.TextField = "State";
    }

    protected override void PrepareQuery(SqlQuery query)
    {
      CityDetailsRow.RowFields fields = CityDetailsRow.Fields;
      query.Distinct(true).Select((IField) fields.Country).Select((IField) fields.State).Where<SqlQuery>((ICriteria) ((BaseCriteria) new Criteria((IField) fields.Country) != "" & new Criteria((IField) fields.Country).IsNotNull() & (BaseCriteria) new Criteria((IField) fields.State) != "" & new Criteria((IField) fields.State).IsNotNull()));
    }

    protected override void ApplyOrder(SqlQuery query)
    {
    }
  }
}

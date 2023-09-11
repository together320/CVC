// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Scripts.CityLookup
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
  [LookupScript("Configuration.City", Permission = "Lookup")]
  public class CityLookup : RowLookupScript<CityDetailsRow>
  {
    public CityLookup()
    {
      this.IdField = "CityDetailsId";
      this.TextField = "City";
    }

    protected override void PrepareQuery(SqlQuery query)
    {
      CityDetailsRow.RowFields fields = CityDetailsRow.Fields;
      query.Distinct(true).Select((IField) fields.CityDetailsId).Select((IField) fields.State).Select((IField) fields.City).Where<SqlQuery>((ICriteria) ((BaseCriteria) new Criteria((IField) fields.City) != "" & new Criteria((IField) fields.City).IsNotNull() & (BaseCriteria) new Criteria((IField) fields.State) != "" & new Criteria((IField) fields.State).IsNotNull()));
    }

    protected override void ApplyOrder(SqlQuery query)
    {
    }
  }
}

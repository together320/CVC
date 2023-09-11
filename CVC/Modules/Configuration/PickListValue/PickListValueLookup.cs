// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Scripts.PickListValueLookup
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
  [LookupScript("Configuration.PickListValueLookup", Permission = "Lookup")]
  public class PickListValueLookup : RowLookupScript<PickListValueRow>
  {
    public PickListValueLookup()
    {
      this.IdField = "PickListValueId";
      this.TextField = "PickListValueName";
    }

    protected override void PrepareQuery(SqlQuery query)
    {
            var GetUserId = Serenity.Authorization.UserId;
            PickListValueRow.RowFields fields = PickListValueRow.Fields;
      query.Distinct(true).Select((IField) fields.PickListValueId).Select((IField) fields.PickListValueName).Select((IField) fields.PickListId).Where<SqlQuery>((ICriteria) ((BaseCriteria) new Criteria((IField) fields.PickListValueName) != "" & new Criteria((IField) fields.PickListValueName).IsNotNull()));
    }

    protected override void ApplyOrder(SqlQuery query)
    {
    }
  }
}

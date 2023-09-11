// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.LanguageLookup
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Web;

namespace CVC.Configuration
{
  [LookupScript("Configuration.Language", Permission = "Lookup")]
  public sealed class LanguageLookup : RowLookupScript<LanguageRow>
  {
    public LanguageLookup()
    {
      this.IdField = LanguageRow.Fields.LanguageId.PropertyName;
      this.Permission = "*";
    }

    protected override void PrepareQuery(SqlQuery query)
    {
      base.PrepareQuery(query);
      query.Select((IField) LanguageRow.Fields.LanguageId);
    }
  }
}

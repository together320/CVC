// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Entities.LanguageRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Modules.Common.BaseClass;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace CVC.Configuration.Entities
{
  [ConnectionKey("Default")]
  [DisplayName("Languages")]
  [InstanceName("Language")]
  [TwoLevelCached(new string[] {})]
  [ReadPermission("Administration:Translation")]
  [ModifyPermission("Administration:Translation")]
  [LookupScript(typeof (LanguageLookup))]
  public sealed class LanguageRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
    public static readonly LanguageRow.RowFields Fields = new LanguageRow.RowFields().Init<LanguageRow.RowFields>();

    [DisplayName("Id")]
    [Identity]
    public int? Id
    {
      get
      {
        return LanguageRow.Fields.Id[(Row) this];
      }
      set
      {
        LanguageRow.Fields.Id[(Row) this] = value;
      }
    }

    [DisplayName("Language Id")]
    [Size(10)]
    [NotNull]
    [QuickSearch(SearchType.Auto, -1, false)]
    public string LanguageId
    {
      get
      {
        return LanguageRow.Fields.LanguageId[(Row) this];
      }
      set
      {
        LanguageRow.Fields.LanguageId[(Row) this] = value;
      }
    }

    [DisplayName("Language Name")]
    [Size(50)]
    [NotNull]
    [QuickSearch(SearchType.Auto, -1, false)]
    [Unique]
    public string LanguageName
    {
      get
      {
        return LanguageRow.Fields.LanguageName[(Row) this];
      }
      set
      {
        LanguageRow.Fields.LanguageName[(Row) this] = value;
      }
    }

    IIdField IIdRow.IdField
    {
      get
      {
        return (IIdField) LanguageRow.Fields.Id;
      }
    }

    StringField INameRow.NameField
    {
      get
      {
        return LanguageRow.Fields.LanguageName;
      }
    }

    public LanguageRow()
      : base((RowFieldsBase) LanguageRow.Fields)
    {
    }

    public class RowFields : RowFieldsBase
    {
      public Int32Field Id;
      public StringField LanguageId;
      public StringField LanguageName;

      public RowFields()
        : base("Languages", "")
      {
        this.LocalTextPrefix = "Administration.Language";
      }
    }
  }
}

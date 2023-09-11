// Decompiled with JetBrains decompiler
// Type: CVC.Common.Entities.UserPreferenceRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace CVC.Common.Entities
{
  [ConnectionKey("Default")]
  [DisplayName("User Preferences")]
  [InstanceName("UserPreference")]
  [TwoLevelCached(new string[] {})]
  [ReadPermission("")]
  [ModifyPermission("")]
  public sealed class UserPreferenceRow : Row, IIdRow, IEntity, INameRow
  {
    public static readonly UserPreferenceRow.RowFields Fields = new UserPreferenceRow.RowFields().Init<UserPreferenceRow.RowFields>();

    [DisplayName("ID")]
    [Identity]
    public int? UserPreferenceId
    {
      get
      {
        return UserPreferenceRow.Fields.UserPreferenceId[(Row) this];
      }
      set
      {
        UserPreferenceRow.Fields.UserPreferenceId[(Row) this] = value;
      }
    }

    [DisplayName("User ID")]
    public int? UserId
    {
      get
      {
        return UserPreferenceRow.Fields.UserId[(Row) this];
      }
      set
      {
        UserPreferenceRow.Fields.UserId[(Row) this] = value;
      }
    }

    [DisplayName("PreferenceType")]
    [Size(100)]
    [NotNull]
    public string PreferenceType
    {
      get
      {
        return UserPreferenceRow.Fields.PreferenceType[(Row) this];
      }
      set
      {
        UserPreferenceRow.Fields.PreferenceType[(Row) this] = value;
      }
    }

    [DisplayName("Name")]
    [Size(100)]
    [NotNull]
    [QuickSearch(SearchType.Auto, -1, false)]
    public string Name
    {
      get
      {
        return UserPreferenceRow.Fields.Name[(Row) this];
      }
      set
      {
        UserPreferenceRow.Fields.Name[(Row) this] = value;
      }
    }

    [DisplayName("Value")]
    public string Value
    {
      get
      {
        return UserPreferenceRow.Fields.Value[(Row) this];
      }
      set
      {
        UserPreferenceRow.Fields.Value[(Row) this] = value;
      }
    }

    IIdField IIdRow.IdField
    {
      get
      {
        return (IIdField) UserPreferenceRow.Fields.UserPreferenceId;
      }
    }

    StringField INameRow.NameField
    {
      get
      {
        return UserPreferenceRow.Fields.Name;
      }
    }

    public UserPreferenceRow()
      : base((RowFieldsBase) UserPreferenceRow.Fields)
    {
    }

    public class RowFields : RowFieldsBase
    {
      public readonly Int32Field UserPreferenceId;
      public readonly Int32Field UserId;
      public readonly StringField PreferenceType;
      public readonly StringField Name;
      public readonly StringField Value;

      public RowFields()
        : base("UserPreferences", "")
      {
        this.LocalTextPrefix = "Common.UserPreference";
      }
    }
  }
}

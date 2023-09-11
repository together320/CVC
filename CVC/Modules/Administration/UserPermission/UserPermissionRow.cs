// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Entities.UserPermissionRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Modules.Common.BaseClass;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace CVC.Administration.Entities
{
  [ConnectionKey("Default")]
  [DisplayName("UserPermissions")]
  [InstanceName("UserPermissions")]
  [TwoLevelCached(new string[] {})]
    //[ReadPermission("Administration:Security")]
    //[ModifyPermission("Administration:Security")]
    [ReadPermission("")]
    [ModifyPermission("")]

    public sealed class UserPermissionRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
    public static readonly UserPermissionRow.RowFields Fields = new UserPermissionRow.RowFields().Init<UserPermissionRow.RowFields>();

    [DisplayName("User Permission Id")]
    [Identity]
    public long? UserPermissionId
    {
      get
      {
        return UserPermissionRow.Fields.UserPermissionId[(Row) this];
      }
      set
      {
        UserPermissionRow.Fields.UserPermissionId[(Row) this] = value;
      }
    }

    [DisplayName("User Id")]
    [NotNull]
    [ForeignKey("Users", "UserId")]
    [LeftJoin("jUser")]
    public int? UserId
    {
      get
      {
        return UserPermissionRow.Fields.UserId[(Row) this];
      }
      set
      {
        UserPermissionRow.Fields.UserId[(Row) this] = value;
      }
    }

    [DisplayName("Permission Key")]
    [Size(100)]
    [NotNull]
    [QuickSearch(SearchType.Auto, -1, false)]
    public string PermissionKey
    {
      get
      {
        return UserPermissionRow.Fields.PermissionKey[(Row) this];
      }
      set
      {
        UserPermissionRow.Fields.PermissionKey[(Row) this] = value;
      }
    }

    [DisplayName("Grant")]
    public bool? Granted
    {
      get
      {
        return UserPermissionRow.Fields.Granted[(Row) this];
      }
      set
      {
        UserPermissionRow.Fields.Granted[(Row) this] = value;
      }
    }

    [DisplayName("User Username")]
    [Expression("jUser.[Username]")]
    public string Username
    {
      get
      {
        return UserPermissionRow.Fields.Username[(Row) this];
      }
      set
      {
        UserPermissionRow.Fields.Username[(Row) this] = value;
      }
    }

    [DisplayName("User Display Name")]
    [Expression("jUser.[DisplayName]")]
    public string User
    {
      get
      {
        return UserPermissionRow.Fields.User[(Row) this];
      }
      set
      {
        UserPermissionRow.Fields.User[(Row) this] = value;
      }
    }

    IIdField IIdRow.IdField
    {
      get
      {
        return (IIdField) UserPermissionRow.Fields.UserPermissionId;
      }
    }

    StringField INameRow.NameField
    {
      get
      {
        return UserPermissionRow.Fields.PermissionKey;
      }
    }

    public UserPermissionRow()
      : base((RowFieldsBase) UserPermissionRow.Fields)
    {
    }

    public class RowFields : RowFieldsBase
    {
      public Int64Field UserPermissionId;
      public Int32Field UserId;
      public StringField PermissionKey;
      public BooleanField Granted;
      public StringField Username;
      public StringField User;

      public RowFields()
        : base("UserPermissions", "")
      {
        this.LocalTextPrefix = "Administration.UserPermission";
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Entities.UserRoleRow
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
  [DisplayName("UserRoles")]
  [InstanceName("UserRoles")]
  [TwoLevelCached(new string[] {})]
 [ReadPermission("")]
  [ModifyPermission("")]
   // [ReadPermission("Administration:Security")]
   //  [ModifyPermission("Administration:Security")]

    public sealed class UserRoleRow : Row, IIdRow, IEntity, IAuditLog
    {
    public static readonly UserRoleRow.RowFields Fields = new UserRoleRow.RowFields().Init<UserRoleRow.RowFields>();

    [DisplayName("User Role Id")]
    [Identity]
    public long? UserRoleId
    {
      get
      {
        return UserRoleRow.Fields.UserRoleId[(Row) this];
      }
      set
      {
        UserRoleRow.Fields.UserRoleId[(Row) this] = value;
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
        return UserRoleRow.Fields.UserId[(Row) this];
      }
      set
      {
        UserRoleRow.Fields.UserId[(Row) this] = value;
      }
    }

    [DisplayName("Role Id")]
    [NotNull]
    public int? RoleId
    {
      get
      {
        return UserRoleRow.Fields.RoleId[(Row) this];
      }
      set
      {
        UserRoleRow.Fields.RoleId[(Row) this] = value;
      }
    }

    [DisplayName("User Username")]
    [Expression("jUser.[Username]")]
    public string Username
    {
      get
      {
        return UserRoleRow.Fields.Username[(Row) this];
      }
      set
      {
        UserRoleRow.Fields.Username[(Row) this] = value;
      }
    }

    [DisplayName("User Display Name")]
    [Expression("jUser.[DisplayName]")]
    public string User
    {
      get
      {
        return UserRoleRow.Fields.User[(Row) this];
      }
      set
      {
        UserRoleRow.Fields.User[(Row) this] = value;
      }
    }

    IIdField IIdRow.IdField
    {
      get
      {
        return (IIdField) UserRoleRow.Fields.UserRoleId;
      }
    }

    public UserRoleRow()
      : base((RowFieldsBase) UserRoleRow.Fields)
    {
    }

    public class RowFields : RowFieldsBase
    {
      public Int64Field UserRoleId;
      public Int32Field UserId;
      public Int32Field RoleId;
      public StringField Username;
      public StringField User;

      public RowFields()
        : base("UserRoles", "")
      {
        this.LocalTextPrefix = "Administration.UserRole";
      }
    }
  }
}

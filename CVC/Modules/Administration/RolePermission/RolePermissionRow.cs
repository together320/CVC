// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Entities.RolePermissionRow
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
  [DisplayName("Role Permissions")]
  [InstanceName("Role Permission")]
  [TwoLevelCached(new string[] {})]
    //[ReadPermission("Administration:Security")]
    //[ModifyPermission("Administration:Security")]
    [ReadPermission("")]
    [ModifyPermission("")]

    public sealed class RolePermissionRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
    public static readonly RolePermissionRow.RowFields Fields = new RolePermissionRow.RowFields().Init<RolePermissionRow.RowFields>();

    [DisplayName("Role Permission Id")]
    [Identity]
    public long? RolePermissionId
    {
      get
      {
        return RolePermissionRow.Fields.RolePermissionId[(Row) this];
      }
      set
      {
        RolePermissionRow.Fields.RolePermissionId[(Row) this] = value;
      }
    }

    [DisplayName("Role Id")]
    [NotNull]
    [ForeignKey("Roles", "RoleId")]
    [LeftJoin("jRole")]
    public int? RoleId
    {
      get
      {
        return RolePermissionRow.Fields.RoleId[(Row) this];
      }
      set
      {
        RolePermissionRow.Fields.RoleId[(Row) this] = value;
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
        return RolePermissionRow.Fields.PermissionKey[(Row) this];
      }
      set
      {
        RolePermissionRow.Fields.PermissionKey[(Row) this] = value;
      }
    }

    [DisplayName("Role Role Name")]
    [Expression("jRole.[RoleName]")]
    public string RoleRoleName
    {
      get
      {
        return RolePermissionRow.Fields.RoleRoleName[(Row) this];
      }
      set
      {
        RolePermissionRow.Fields.RoleRoleName[(Row) this] = value;
      }
    }

    IIdField IIdRow.IdField
    {
      get
      {
        return (IIdField) RolePermissionRow.Fields.RolePermissionId;
      }
    }

    StringField INameRow.NameField
    {
      get
      {
        return RolePermissionRow.Fields.PermissionKey;
      }
    }

    public RolePermissionRow()
      : base((RowFieldsBase) RolePermissionRow.Fields)
    {
    }

    public class RowFields : RowFieldsBase
    {
      public Int64Field RolePermissionId;
      public Int32Field RoleId;
      public StringField PermissionKey;
      public StringField RoleRoleName;

      public RowFields()
        : base("RolePermissions", "")
      {
        this.LocalTextPrefix = "Administration.RolePermission";
      }
    }
  }
}

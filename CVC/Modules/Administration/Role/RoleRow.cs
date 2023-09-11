// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Entities.RoleRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Modules.Common.BaseClass;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.Collections.Generic;
using System.ComponentModel;

namespace CVC.Administration.Entities
{
    [ConnectionKey("Default")]
    [DisplayName("Roles")]
    [InstanceName("Role")]
    [TwoLevelCached(new string[] { })]

    [ReadPermission("Administration:Role:Read")]
    [ModifyPermission("Administration:Role:Modify")]
    [LookupScript("Role", Permission = "Lookup")]
    public sealed class RoleRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly RoleRow.RowFields Fields = new RoleRow.RowFields().Init<RoleRow.RowFields>();

        [DisplayName("Role Id")]
        [Identity]
        [ForeignKey("Roles", "RoleId")]
        [LeftJoin("jRole")]
        public int? RoleId
        {
            get
            {
                return RoleRow.Fields.RoleId[(Row)this];
            }
            set
            {
                RoleRow.Fields.RoleId[(Row)this] = value;
            }
        }

        [DisplayName("Role Name")]
        [Size(25)]//[Size(100)]
        [NotNull]
        [QuickSearch(SearchType.Auto, -1, false)]
        [Unique]
        public string RoleName
        {
            get
            {
                return RoleRow.Fields.RoleName[(Row)this];
            }
            set
            {
                RoleRow.Fields.RoleName[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [ForeignKey("Status", "StatusId")]
        [LeftJoin("jStatus")]
        [TextualField("StatusStatusName")]
        //To make status as default "Active"
        [DefaultValue(1)]
        [NotNull]
        public int? StatusId
        {
            get
            {
                return RoleRow.Fields.StatusId[(Row)this];
            }
            set
            {
                RoleRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return RoleRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                RoleRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        [DisplayName("Hide Role")]
        public bool? IsHidden
        {
            get
            {
                return RoleRow.Fields.IsHidden[(Row)this];
            }
            set
            {
                RoleRow.Fields.IsHidden[(Row)this] = value;
            }
        }

        [DisplayName("Parent")]
        [Column("ParentRoleId")]
        [ForeignKey("Roles", "RoleId")]
        [LeftJoin("jRoles")]
        [TextualField("RolesRoleName")]
        public int? ParentRoleId
        {
            get
            {
                return RoleRow.Fields.ParentRoleId[(Row)this];
            }
            set
            {
                RoleRow.Fields.ParentRoleId[(Row)this] = value;
            }
        }

      

        [DisplayName("Parent Role")]
        [Expression("jRoles.[RoleName]")]
        public string RolesRoleName
        {
            get
            {
                return RoleRow.Fields.RolesRoleName[(Row)this];
            }
            set
            {
                RoleRow.Fields.RolesRoleName[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return RoleRow.Fields.RecordAddedSource[(Row)this];

            }
            set
            {
                RoleRow.Fields.RecordAddedSource[(Row)this] = value;

            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)RoleRow.Fields.RoleId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return RoleRow.Fields.RoleName;
            }
        }

        public RoleRow()
          : base((RowFieldsBase)RoleRow.Fields)
        {
            
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field RoleId;
            public StringField RoleName;
            public Int32Field StatusId;
            public StringField StatusStatusName;
            public BooleanField IsHidden;
            public Int32Field ParentRoleId;
            public StringField RolesRoleName;
            public StringField RecordAddedSource;

            public RowFields()
              : base("Roles", (string)null)
            {
                this.LocalTextPrefix = "Administration.Role";
            }
        }
       
    }
}

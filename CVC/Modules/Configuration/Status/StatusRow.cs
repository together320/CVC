// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Entities.StatusRow
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
    [TableName("Status")]
    [DisplayName("Status")]
    [InstanceName("Status")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Lookup")]
    [ModifyPermission("Lookup")]
    [LookupScript("Configuration.Status", Permission = "Lookup")]
    public sealed class StatusRow : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly StatusRow.RowFields Fields = new StatusRow.RowFields().Init<StatusRow.RowFields>();

        [DisplayName("Status Id")]
        [PrimaryKey]
        public int? StatusId
        {
            get
            {
                return StatusRow.Fields.StatusId[(Row)this];
            }
            set
            {
                StatusRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Status Name")]
        [Size(20)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string StatusName
        {
            get
            {
                return StatusRow.Fields.StatusName[(Row)this];
            }
            set
            {
                StatusRow.Fields.StatusName[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)StatusRow.Fields.StatusId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return StatusRow.Fields.StatusName;
            }
        }

        public StatusRow()
          : base((RowFieldsBase)StatusRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field StatusId;
            public StringField StatusName;

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "Configuration.Status";
            }
        }
    }
}

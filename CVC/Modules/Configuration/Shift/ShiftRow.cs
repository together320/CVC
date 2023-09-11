// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Entities.ShiftRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Modules.Common.BaseClass;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace CVC.Configuration.Entities
{
    [ConnectionKey("Default")]
    [TableName("Shift")]
    [DisplayName("Shift")]
    [InstanceName("Shift")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Configuration:Shift:Read")]
    [ModifyPermission("Configuration:Shift:Modify")]
    [LookupScript("Configuration.Shift", Permission = "Lookup")]
    public sealed class ShiftRow : LoggingRow, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly ShiftRow.RowFields Fields = new ShiftRow.RowFields().Init<ShiftRow.RowFields>();

        [DisplayName("Shift Id")]
        [Identity]
        public int? ShiftId
        {
            get
            {
                return ShiftRow.Fields.ShiftId[(Row)this];
            }
            set
            {
                ShiftRow.Fields.ShiftId[(Row)this] = value;
            }
        }

        [DisplayName("Shift Name")]
        [Size(50)]
        [NotNull]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string ShiftName
        {
            get
            {
                return ShiftRow.Fields.ShiftName[(Row)this];
            }
            set
            {
                ShiftRow.Fields.ShiftName[(Row)this] = value;
            }
        }

        [DisplayName("Start Time")]
        [Size(20)]
        [NotNull]
        public string StartTime
        {
            get
            {
                return ShiftRow.Fields.StartTime[(Row)this];
            }
            set
            {
                ShiftRow.Fields.StartTime[(Row)this] = value;
            }
        }

        [DisplayName("End Time")]
        [Size(20)]
        [NotNull]
        public string EndTime
        {
            get
            {
                return ShiftRow.Fields.EndTime[(Row)this];
            }
            set
            {
                ShiftRow.Fields.EndTime[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [ForeignKey("Status", "StatusId")]
        [LeftJoin("jStatus")]
        [TextualField("StatusStatusName")]
        //To make status as default "Active"
        [DefaultValue(1)]
        public int? StatusId
        {
            get
            {
                return ShiftRow.Fields.StatusId[(Row)this];
            }
            set
            {
                ShiftRow.Fields.StatusId[(Row)this] = value;
            }
        }

        [DisplayName("Created By")]
        public int? CreatedBy
        {
            get
            {
                return ShiftRow.Fields.CreatedBy[(Row)this];
            }
            set
            {
                ShiftRow.Fields.CreatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return ShiftRow.Fields.CreatedDate[(Row)this];
            }
            set
            {
                ShiftRow.Fields.CreatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Updated By")]
        public int? UpdatedBy
        {
            get
            {
                return ShiftRow.Fields.UpdatedBy[(Row)this];
            }
            set
            {
                ShiftRow.Fields.UpdatedBy[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get
            {
                return ShiftRow.Fields.UpdatedDate[(Row)this];
            }
            set
            {
                ShiftRow.Fields.UpdatedDate[(Row)this] = value;
            }
        }

        [DisplayName("Status")]
        [Expression("jStatus.[StatusName]")]
        public string StatusStatusName
        {
            get
            {
                return ShiftRow.Fields.StatusStatusName[(Row)this];
            }
            set
            {
                ShiftRow.Fields.StatusStatusName[(Row)this] = value;
            }
        }

        public string RecordAddedSource
        {
            get
            {
                return ShiftRow.Fields.RecordAddedSource[(Row)this];
            }
            set
            {
                ShiftRow.Fields.RecordAddedSource[(Row)this] = value;
            }
        }



        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)ShiftRow.Fields.ShiftId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return ShiftRow.Fields.ShiftName;
            }
        }

        public ShiftRow()
          : base((RowFieldsBase)ShiftRow.Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        //  public class RowFields : RowFieldsBase
        {
            public Int32Field ShiftId;
            public StringField ShiftName;
            public StringField StartTime;
            public StringField EndTime;
            public Int32Field StatusId;
           /* public Int32Field CreatedBy;
            public DateTimeField CreatedDate;
            public Int32Field UpdatedBy;
            public DateTimeField UpdatedDate;*/
            public StringField StatusStatusName;
            public StringField RecordAddedSource;

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "Configuration.Shift";
            }
        }
    }
}

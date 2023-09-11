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
    [TableName("TimeFormatType")]
    [DisplayName("TimeFormatType")]
    [InstanceName("TimeFormatType")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Lookup")]
    [ModifyPermission("Lookup")]
    [LookupScript("Configuration.TimeFormatType", Permission = "Lookup")]
    public sealed class TimeFormatTypeLookUp : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly TimeFormatTypeLookUp.RowFields Fields = new TimeFormatTypeLookUp.RowFields().Init<TimeFormatTypeLookUp.RowFields>();

        [DisplayName("Time Format Type")]
        [PrimaryKey]
        public int? TimeFormatTypeID
        {
            get
            {
                return TimeFormatTypeLookUp.Fields.TimeFormatTypeID[(Row)this];
            }
            set
            {
                TimeFormatTypeLookUp.Fields.TimeFormatTypeID[(Row)this] = value;
            }
        }

        [DisplayName("TimeFormatType Name")]
        [Size(20)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string TimeFormatValue
        {
            get
            {
                return TimeFormatTypeLookUp.Fields.TimeFormatValue[(Row)this];
            }
            set
            {
                TimeFormatTypeLookUp.Fields.TimeFormatValue[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)TimeFormatTypeLookUp.Fields.TimeFormatTypeID;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return TimeFormatTypeLookUp.Fields.TimeFormatValue;
            }
        }

        public TimeFormatTypeLookUp()
          : base((RowFieldsBase)TimeFormatTypeLookUp.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field TimeFormatTypeID;
            public StringField TimeFormatValue;

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "Configuration.TimeFormatTypeLookUp";
            }
        }
    }
}

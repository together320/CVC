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
    [TableName("DateFormatType")]
    [DisplayName("DateFormatType")]
    [InstanceName("DateFormatType")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Lookup")]
    [ModifyPermission("Lookup")]
    [LookupScript("Configuration.DateFormatType", Permission = "Lookup")]
    public sealed class DateFormatTypeLookUp : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly DateFormatTypeLookUp.RowFields Fields = new DateFormatTypeLookUp.RowFields().Init<DateFormatTypeLookUp.RowFields>();

        [DisplayName("Date Format Type")]
        [PrimaryKey]
        public int? DateFormatTypeID
        {
            get
            {
                return DateFormatTypeLookUp.Fields.DateFormatTypeID[(Row)this];
            }
            set
            {
                DateFormatTypeLookUp.Fields.DateFormatTypeID[(Row)this] = value;
            }
        }

        [DisplayName("DateFormatType Name")]
        [Size(20)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string DateFormatTypeValue
        {
            get
            {
                return DateFormatTypeLookUp.Fields.DateFormatTypeValue[(Row)this];
            }
            set
            {
                DateFormatTypeLookUp.Fields.DateFormatTypeValue[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)DateFormatTypeLookUp.Fields.DateFormatTypeID;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return DateFormatTypeLookUp.Fields.DateFormatTypeValue;
            }
        }

        public DateFormatTypeLookUp()
          : base((RowFieldsBase)DateFormatTypeLookUp.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field DateFormatTypeID;
            public StringField DateFormatTypeValue;

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "Configuration.DateFormatTypeLookUp";
            }
        }
    }
}

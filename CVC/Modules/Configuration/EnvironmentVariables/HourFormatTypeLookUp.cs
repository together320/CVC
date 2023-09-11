using CVC.Configuration.Entities;
using CVC.Modules.Common.BaseClass;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;
namespace CVC.Modules.Configuration.EnvironmentVariables
{
    [ConnectionKey("Default")]
    [TableName("HourFormatType")]
    [DisplayName("HourFormatType")]
    [InstanceName("HourFormatType")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Lookup")]
    [ModifyPermission("Lookup")]
    [LookupScript("Configuration.HourFormatType", Permission = "Lookup")]
    public sealed class HourFormatTypeLookUp : Row, IIdRow, IEntity, INameRow, IAuditLog
    {
        public static readonly HourFormatTypeLookUp.RowFields Fields = new HourFormatTypeLookUp.RowFields().Init<HourFormatTypeLookUp.RowFields>();

        [DisplayName("Hour Format Type")]
        [PrimaryKey]
        public int? HourFormatTypeID
        {
            get
            {
                return HourFormatTypeLookUp.Fields.HourFormatTypeID[(Row)this];
            }
            set
            {
                HourFormatTypeLookUp.Fields.HourFormatTypeID[(Row)this] = value;
            }
        }

        [DisplayName("HourFormatType Name")]
        [Size(20)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string HourFormatTypeValue
        {
            get
            {
                return HourFormatTypeLookUp.Fields.HourFormatTypeValue[(Row)this];
            }
            set
            {
                HourFormatTypeLookUp.Fields.HourFormatTypeValue[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)HourFormatTypeLookUp.Fields.HourFormatTypeID;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return HourFormatTypeLookUp.Fields.HourFormatTypeValue;
            }
        }

        public HourFormatTypeLookUp()
          : base((RowFieldsBase)HourFormatTypeLookUp.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field HourFormatTypeID;
            public StringField HourFormatTypeValue;

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "Configuration.HourFormatTypeLookUp";
            }
        }


    }
}

using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace CVC.Report.Entities
{
    [ConnectionKey("Default")]
    [TableName("Exception")]
    [DisplayName("Exception Log")]
    [InstanceName("Exception Log")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Report:ExceptionLog:Read")]
    // [ModifyPermission("Administration:General")]
    public sealed class ExceptionLogRow : Row, IIdRow, IEntity, INameRow
    {
        public static readonly ExceptionLogRow.RowFields Fields = new ExceptionLogRow.RowFields().Init<ExceptionLogRow.RowFields>();

        [DisplayName("Id")]
        [Identity]
        public long? Id
        {
            get
            {
                return ExceptionLogRow.Fields.Id[(Row)this];
            }
            set
            {
                ExceptionLogRow.Fields.Id[(Row)this] = value;
            }
        }


        [DisplayName("Application Name")]

        public string ApplicationName
        {
            get
            {
                return ExceptionLogRow.Fields.ApplicationName[(Row)this];
            }
            set
            {
                ExceptionLogRow.Fields.ApplicationName[(Row)this] = value;
            }
        }

        [DisplayName("Type")]

        public string Type
        {
            get
            {
                return ExceptionLogRow.Fields.Type[(Row)this];
            }
            set
            {
                ExceptionLogRow.Fields.Type[(Row)this] = value;
            }
        }

        [DisplayName("Url")]

        public string Url
        {
            get
            {
                return ExceptionLogRow.Fields.Url[(Row)this];
            }
            set
            {
                ExceptionLogRow.Fields.Url[(Row)this] = value;
            }
        }
        [DisplayName("Message")]

        public string Message
        {
            get
            {
                return ExceptionLogRow.Fields.Message[(Row)this];
            }
            set
            {
                ExceptionLogRow.Fields.Message[(Row)this] = value;
            }
        }


        [DisplayName("Created Date")]
        public DateTime? CreationDate
        {
            get
            {
                return ExceptionLogRow.Fields.CreationDate[(Row)this];
            }
            set
            {
                ExceptionLogRow.Fields.CreationDate[(Row)this] = value;
            }
        }


        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)ExceptionLogRow.Fields.Id;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return ExceptionLogRow.Fields.Message;
            }
        }

        public ExceptionLogRow()
          : base((RowFieldsBase)ExceptionLogRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public StringField ApplicationName;
            public StringField Type;
            public StringField Url;
            public StringField Message;
            public DateTimeField CreationDate;

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "Report.ExceptionLog";
            }
        }
    }
}

using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace CVC.Report.Entities
{
    [ConnectionKey("Default")]
    [TableName("UserLog")]
    [DisplayName("User Log")]
    [InstanceName("User Log")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Report:UserLog:Read")]
    // [ModifyPermission("Administration:General")]
    public sealed class UserLogRow : Row, IIdRow, IEntity, INameRow
    {
        public static readonly UserLogRow.RowFields Fields = new UserLogRow.RowFields().Init<UserLogRow.RowFields>();

        [DisplayName("User Log Id")]
        [Identity]
        public long? UserLogId
        {
            get
            {
                return UserLogRow.Fields.UserLogId[(Row)this];
            }
            set
            {
                UserLogRow.Fields.UserLogId[(Row)this] = value;
            }
        }

        [DisplayName("User Id")]
        public int? UserId
        {
            get
            {
                return UserLogRow.Fields.UserId[(Row)this];
            }
            set
            {
                UserLogRow.Fields.UserId[(Row)this] = value;
            }
        }

        [DisplayName("UserName")]
        
        public string UserName
        {
            get
            {
                return UserLogRow.Fields.UserName[(Row)this];
            }
            set
            {
                UserLogRow.Fields.UserName[(Row)this] = value;
            }
        }

        [DisplayName("Action")]
        public string Action
        {
            get
            {
                return UserLogRow.Fields.Action[(Row)this];
            }
            set
            {
                UserLogRow.Fields.Action[(Row)this] = value;
            }
        }

        [DisplayName("ChangedOne")]
        public DateTime? ChangedOn
        {
            get
            {
                return UserLogRow.Fields.ChangedOn[(Row)this];
            }
            set
            {
                UserLogRow.Fields.ChangedOn[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)UserLogRow.Fields.UserLogId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return UserLogRow.Fields.UserName;
            }
        }

        public UserLogRow()
          : base((RowFieldsBase)UserLogRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field UserLogId;
            public Int32Field UserId;
            public StringField UserName;
            public StringField Action;
            public DateTimeField ChangedOn;

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "Report.UserLog";
            }
        }
    }
}
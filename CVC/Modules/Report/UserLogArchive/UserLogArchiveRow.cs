
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace CVC.Report.Entities
{
    [ConnectionKey("Default")]
    [TableName("UserLogArchive")]
    [DisplayName("User Log Archive")]
    [InstanceName("User Log Archive")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Report:UserLogArchive:Read")]
    // [ModifyPermission("Administration:General")]
    public sealed class UserLogArchiveRow : Row, IIdRow, IEntity, INameRow
    {
        public static readonly UserLogArchiveRow.RowFields Fields = new UserLogArchiveRow.RowFields().Init<UserLogArchiveRow.RowFields>();

        [DisplayName("User Log Archive Id")]
        [Identity]
        public long? UserLogArchiveId
        {
            get
            {
                return UserLogArchiveRow.Fields.UserLogArchiveId[(Row)this];
            }
            set
            {
                UserLogArchiveRow.Fields.UserLogArchiveId[(Row)this] = value;
            }
        }

        [DisplayName("User Id")]
        public int? UserId
        {
            get
            {
                return UserLogArchiveRow.Fields.UserId[(Row)this];
            }
            set
            {
                UserLogArchiveRow.Fields.UserId[(Row)this] = value;
            }
        }

        [DisplayName("UserName")]

        public string UserName
        {
            get
            {
                return UserLogArchiveRow.Fields.UserName[(Row)this];
            }
            set
            {
                UserLogArchiveRow.Fields.UserName[(Row)this] = value;
            }
        }

        [DisplayName("Action")]
        public string Action
        {
            get
            {
                return UserLogArchiveRow.Fields.Action[(Row)this];
            }
            set
            {
                UserLogArchiveRow.Fields.Action[(Row)this] = value;
            }
        }

        [DisplayName("ChangedOne")]
        public DateTime? ChangedOn
        {
            get
            {
                return UserLogArchiveRow.Fields.ChangedOn[(Row)this];
            }
            set
            {
                UserLogArchiveRow.Fields.ChangedOn[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)UserLogArchiveRow.Fields.UserLogArchiveId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return UserLogArchiveRow.Fields.UserName;
            }
        }

        public UserLogArchiveRow()
          : base((RowFieldsBase)UserLogArchiveRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field UserLogArchiveId;
            public Int32Field UserId;
            public StringField UserName;
            public StringField Action;
            public DateTimeField ChangedOn;

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "Report.UserLogArchive";
            }
        }
    }
}
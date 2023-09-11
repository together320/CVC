

using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace CVC.Report.Entities
{
    [ConnectionKey("Default")]
    [TableName("BatchLogArchive")]
    [DisplayName("Batch Log Archive")]
    [InstanceName("Batch Log Archive")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class BatchLogArchiveRow : Row, IIdRow, IEntity, INameRow
    {
        public static readonly BatchLogArchiveRow.RowFields Fields = new BatchLogArchiveRow.RowFields().Init<BatchLogArchiveRow.RowFields>();

        [DisplayName("Batch Log Archive Id")]
        [Identity]
        public long? BatchLogArchiveId
        {
            get
            {
                return BatchLogArchiveRow.Fields.BatchLogArchiveId[(Row)this];
            }
            set
            {
                BatchLogArchiveRow.Fields.BatchLogArchiveId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Id")]
        public int? MachineId
        {
            get
            {
                return BatchLogArchiveRow.Fields.MachineId[(Row)this];
            }
            set
            {
                BatchLogArchiveRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("Batch Id")]
        public int? BatchId
        {
            get
            {
                return BatchLogArchiveRow.Fields.BatchId[(Row)this];
            }
            set
            {
                BatchLogArchiveRow.Fields.BatchId[(Row)this] = value;
            }
        }

        [DisplayName("Description")]
        [Size(1000)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string Description
        {
            get
            {
                return BatchLogArchiveRow.Fields.Description[(Row)this];
            }
            set
            {
                BatchLogArchiveRow.Fields.Description[(Row)this] = value;
            }
        }

        [DisplayName("User Id")]
        public int? UserId
        {
            get
            {
                return BatchLogArchiveRow.Fields.UserId[(Row)this];
            }
            set
            {
                BatchLogArchiveRow.Fields.UserId[(Row)this] = value;
            }
        }

        [DisplayName("Updated Date Time")]
        public DateTime? UpdatedDateTime
        {
            get
            {
                return BatchLogArchiveRow.Fields.UpdatedDateTime[(Row)this];
            }
            set
            {
                BatchLogArchiveRow.Fields.UpdatedDateTime[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)BatchLogArchiveRow.Fields.BatchLogArchiveId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return BatchLogArchiveRow.Fields.Description;
            }
        }

        public BatchLogArchiveRow()
          : base((RowFieldsBase)BatchLogArchiveRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field BatchLogArchiveId;
            public Int32Field MachineId;
            public Int32Field BatchId;
            public StringField Description;
            public Int32Field UserId;
            public DateTimeField UpdatedDateTime;

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "Report.BatchLogArchive";
            }
        }
    }
}

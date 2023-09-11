
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace CVC.Report.Entities
{
    [ConnectionKey("Default")]
    [TableName("AlarmLogArchive")]
    [DisplayName("Alarm Log Archive")]
    [InstanceName("Alarm Log Archive")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Report:AlarmLogArchive:Read")]
    public sealed class AlarmLogArchiveRow : Row, IIdRow, IEntity, INameRow
    {
        public static readonly AlarmLogArchiveRow.RowFields Fields = new AlarmLogArchiveRow.RowFields().Init<AlarmLogArchiveRow.RowFields>();

        [DisplayName("Alarm Log Archive Id")]
        [Identity]
        public long? AlarmLogArchiveId
        {
            get
            {
                return AlarmLogArchiveRow.Fields.AlarmLogArchiveId[(Row)this];
            }
            set
            {
                AlarmLogArchiveRow.Fields.AlarmLogArchiveId[(Row)this] = value;
            }
        }

        [DisplayName("Machine Id")]
        [LeftJoin("jMachine")]
        [ForeignKey("Machine", "MachineId")]
        [TextualField("MachineMachineName")]
        public int? MachineId
        {
            get
            {
                return AlarmLogArchiveRow.Fields.MachineId[(Row)this];
            }
            set
            {
                AlarmLogArchiveRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("Business Entity")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return AlarmLogArchiveRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                AlarmLogArchiveRow.Fields.MachineMachineName[(Row)this] = value;
            }
        }

        [LeftJoin("jAlarm")]
        [ForeignKey("Alarm", "AlarmId")]
        [TextualField("AlarmAlarmName")]
        [DisplayName("Alarm Id")]
        public int? AlarmId
        {
            get
            {
                return AlarmLogArchiveRow.Fields.AlarmId[(Row)this];
            }
            set
            {
                AlarmLogArchiveRow.Fields.AlarmId[(Row)this] = value;
            }
        }

        [DisplayName("Alarm")]
        [Expression("jAlarm.[AlarmName]")]
        public string AlarmAlarmName
        {
            get
            {
                return AlarmLogArchiveRow.Fields.AlarmAlarmName[(Row)this];
            }
            set
            {
                AlarmLogArchiveRow.Fields.AlarmAlarmName[(Row)this] = value;
            }
        }

        [LeftJoin("jBatch")]
        [ForeignKey("Batch", "BatchId")]
        [TextualField("BatchBatchName")]
        [DisplayName("Batch Id")]
        public int? BatchId
        {
            get
            {
                return AlarmLogArchiveRow.Fields.BatchId[(Row)this];
            }
            set
            {
                AlarmLogArchiveRow.Fields.BatchId[(Row)this] = value;
            }
        }

        [DisplayName("Batch")]
        [Expression("jBatch.[BatchName]")]
        public string BatchBatchName
        {
            get
            {
                return AlarmLogArchiveRow.Fields.BatchBatchName[(Row)this];
            }
            set
            {
                AlarmLogArchiveRow.Fields.BatchBatchName[(Row)this] = value;
            }
        }

        [DisplayName("Logged User Id")]
        public int? LoggedUserId
        {
            get
            {
                return AlarmLogArchiveRow.Fields.LoggedUserId[(Row)this];
            }
            set
            {
                AlarmLogArchiveRow.Fields.LoggedUserId[(Row)this] = value;
            }
        }

        [DisplayName("Comment")]
        [Size(1000)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string Comment
        {
            get
            {
                return AlarmLogArchiveRow.Fields.Comment[(Row)this];
            }
            set
            {
                AlarmLogArchiveRow.Fields.Comment[(Row)this] = value;
            }
        }

        [DisplayName("Description")]
        [Size(500)]
        public string Description
        {
            get
            {
                return AlarmLogArchiveRow.Fields.Description[(Row)this];
            }
            set
            {
                AlarmLogArchiveRow.Fields.Description[(Row)this] = value;
            }
        }

        [DisplayName("Alarm Date Time")]
        public DateTime? AlarmDateTime
        {
            get
            {
                return AlarmLogArchiveRow.Fields.AlarmDateTime[(Row)this];
            }
            set
            {
                AlarmLogArchiveRow.Fields.AlarmDateTime[(Row)this] = value;
            }
        }

        [DisplayName("Pcip Address")]
        [Column("PCIPAddress")]
        [Size(50)]
        public string PcipAddress
        {
            get
            {
                return AlarmLogArchiveRow.Fields.PcipAddress[(Row)this];
            }
            set
            {
                AlarmLogArchiveRow.Fields.PcipAddress[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)AlarmLogArchiveRow.Fields.AlarmLogArchiveId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return AlarmLogArchiveRow.Fields.Comment;
            }
        }

        public AlarmLogArchiveRow()
          : base((RowFieldsBase)AlarmLogArchiveRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field AlarmLogArchiveId;
            public Int32Field MachineId;
            public Int32Field AlarmId;
            public Int32Field BatchId;
            public Int32Field LoggedUserId;
            public StringField Comment;
            public StringField Description;
            public DateTimeField AlarmDateTime;
            public StringField PcipAddress;

            public StringField BatchBatchName;
            public StringField AlarmAlarmName;
            public StringField MachineMachineName;

            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "Report.AlarmLogArchive";
            }
        }
    }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Report.Entities.AlarmLogRow
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace CVC.Report.Entities
{
    [ConnectionKey("Default")]
    [TableName("AlarmLog")]
    [DisplayName("Alarm Log")]
    [InstanceName("Alarm Log")]
    [TwoLevelCached(new string[] { })]
    [ReadPermission("Report:AlarmLog:Read")]
    public sealed class AlarmLogRow : Row, IIdRow, IEntity, INameRow
    {
        public static readonly AlarmLogRow.RowFields Fields = new AlarmLogRow.RowFields().Init<AlarmLogRow.RowFields>();

        [DisplayName("Alarm Log Id")]
        [Identity]
        public long? AlarmLogId
        {
            get
            {
                return AlarmLogRow.Fields.AlarmLogId[(Row)this];
            }
            set
            {
                AlarmLogRow.Fields.AlarmLogId[(Row)this] = value;
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
                return AlarmLogRow.Fields.MachineId[(Row)this];
            }
            set
            {
                AlarmLogRow.Fields.MachineId[(Row)this] = value;
            }
        }

        [DisplayName("Business Entity")]
        [Expression("jMachine.[MachineName]")]
        public string MachineMachineName
        {
            get
            {
                return AlarmLogRow.Fields.MachineMachineName[(Row)this];
            }
            set
            {
                AlarmLogRow.Fields.MachineMachineName[(Row)this] = value;
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
                return AlarmLogRow.Fields.AlarmId[(Row)this];
            }
            set
            {
                AlarmLogRow.Fields.AlarmId[(Row)this] = value;
            }
        }

        [DisplayName("Alarm")]
        [Expression("jAlarm.[AlarmName]")]
        public string AlarmAlarmName
        {
            get
            {
                return AlarmLogRow.Fields.AlarmAlarmName[(Row)this];
            }
            set
            {
                AlarmLogRow.Fields.AlarmAlarmName[(Row)this] = value;
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
                return AlarmLogRow.Fields.BatchId[(Row)this];
            }
            set
            {
                AlarmLogRow.Fields.BatchId[(Row)this] = value;
            }
        }

        [DisplayName("Batch")]
        [Expression("jBatch.[BatchName]")]
        public string BatchBatchName
        {
            get
            {
                return AlarmLogRow.Fields.BatchBatchName[(Row)this];
            }
            set
            {
                AlarmLogRow.Fields.BatchBatchName[(Row)this] = value;
            }
        }

        [DisplayName("Logged User Id")]
        public int? LoggedUserId
        {
            get
            {
                return AlarmLogRow.Fields.LoggedUserId[(Row)this];
            }
            set
            {
                AlarmLogRow.Fields.LoggedUserId[(Row)this] = value;
            }
        }

        [DisplayName("Comment")]
        [Size(1000)]
        [QuickSearch(SearchType.Auto, -1, false)]
        public string Comment
        {
            get
            {
                return AlarmLogRow.Fields.Comment[(Row)this];
            }
            set
            {
                AlarmLogRow.Fields.Comment[(Row)this] = value;
            }
        }

        [DisplayName("Description")]
        [Size(500)]
        public string Description
        {
            get
            {
                return AlarmLogRow.Fields.Description[(Row)this];
            }
            set
            {
                AlarmLogRow.Fields.Description[(Row)this] = value;
            }
        }

        [DisplayName("Alarm Date Time")]
        public DateTime? AlarmDateTime
        {
            get
            {
                return AlarmLogRow.Fields.AlarmDateTime[(Row)this];
            }
            set
            {
                AlarmLogRow.Fields.AlarmDateTime[(Row)this] = value;
            }
        }

        [DisplayName("Pcip Address")]
        [Column("PCIPAddress")]
        [Size(50)]
        public string PcipAddress
        {
            get
            {
                return AlarmLogRow.Fields.PcipAddress[(Row)this];
            }
            set
            {
                AlarmLogRow.Fields.PcipAddress[(Row)this] = value;
            }
        }

        IIdField IIdRow.IdField
        {
            get
            {
                return (IIdField)AlarmLogRow.Fields.AlarmLogId;
            }
        }

        StringField INameRow.NameField
        {
            get
            {
                return AlarmLogRow.Fields.Comment;
            }
        }

        public AlarmLogRow()
          : base((RowFieldsBase)AlarmLogRow.Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field AlarmLogId;
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
                this.LocalTextPrefix = "Report.AlarmLog";
            }
        }
    }
}

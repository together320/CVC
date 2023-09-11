
namespace CVC.MachineCustomization.Entities
{
    using CVC.Administration.Entities;
    using CVC.Configuration.Entities;
    using CVC.Modules.Common.BaseClass;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("MachineCustomization"), TableName("[dbo].[PrimaryRelationship]")]
    [DisplayName("Primary Relationship"), InstanceName("Primary Relationship")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript(Expiration = -1)]
    public sealed class PrimaryRelationshipRow : LoggingRow, IIdRow, INameRow, IAuditLog
    {
        [DisplayName("Primary Relationship Id"), Identity]
        public Int32? PrimaryRelationshipId
        {
            get { return Fields.PrimaryRelationshipId[this]; }
            set { Fields.PrimaryRelationshipId[this] = value; }
        }

        [DisplayName("Relationship Name"), Size(50), QuickSearch]
        [Required]
        public String RelationshipName
        {
            get { return Fields.RelationshipName[this]; }
            set { Fields.RelationshipName[this] = value; }
        }

        [DisplayName("Primary BE"), Column("PrimaryBE"), NotNull, ForeignKey("[dbo].[Machine]", "MachineId"), LeftJoin("jPrimaryBe"), TextualField("PrimaryBeMachineName")]
        [LookupEditor(typeof(MachineRow))]
        public Int32? PrimaryBe
        {
            get { return Fields.PrimaryBe[this]; }
            set { Fields.PrimaryBe[this] = value; }
        }

        // Added by Denis for RS 8.7 and RS 8.8 dated 9/10/2021
        [DisplayName("Primary EF"), NotNull, ForeignKey("[dbo].[MachineParameter]", "MachineParameterId"), LeftJoin("jPrimaryEf"), TextualField("PrimaryEfParameterName")]
        [LookupEditor(typeof(MachineParameterRow), CascadeFrom = "PrimaryBe", CascadeField = "MachineId")]
        public Int32? PrimaryEf
        {
            get { return Fields.PrimaryEf[this]; }
            set { Fields.PrimaryEf[this] = value; }
        }

        // Added by Denis for RS 8.7 and RS 8.8 dated 9/10/2021
        [DisplayName("Primary Entity Field"), Expression("jPrimaryEf.[ParameterName]")]
        public String PrimaryEfParameterName
        {
            get { return Fields.PrimaryEfParameterName[this]; }
            set { Fields.PrimaryEfParameterName[this] = value; }
        }

        [DisplayName("Description"), Size(256)]
        [TextAreaEditor(Rows = 3)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Status"), NotNull, ForeignKey("[dbo].[Status]", "StatusId"), LeftJoin("jStatus"), TextualField("StatusStatusName")]
        [LookupEditor(typeof(StatusRow))]
        public Int32? Status
        {
            get { return Fields.Status[this]; }
            set { Fields.Status[this] = value; }
        }

        [DisplayName("Primary Be Machine Line Id"), Expression("jPrimaryBe.[MachineLineId]")]
        public Int32? PrimaryBeMachineLineId
        {
            get { return Fields.PrimaryBeMachineLineId[this]; }
            set { Fields.PrimaryBeMachineLineId[this] = value; }
        }

        [DisplayName("Primary Business Entity"), Expression("jPrimaryBe.[MachineName]")]
        public String PrimaryBeMachineName
        {
            get { return Fields.PrimaryBeMachineName[this]; }
            set { Fields.PrimaryBeMachineName[this] = value; }
        }

        [DisplayName("Primary Be Model Number"), Expression("jPrimaryBe.[ModelNumber]")]
        public String PrimaryBeModelNumber
        {
            get { return Fields.PrimaryBeModelNumber[this]; }
            set { Fields.PrimaryBeModelNumber[this] = value; }
        }

        [DisplayName("Primary Be Serial Number"), Expression("jPrimaryBe.[SerialNumber]")]
        public String PrimaryBeSerialNumber
        {
            get { return Fields.PrimaryBeSerialNumber[this]; }
            set { Fields.PrimaryBeSerialNumber[this] = value; }
        }

        [DisplayName("Primary Be Make"), Expression("jPrimaryBe.[Make]")]
        public String PrimaryBeMake
        {
            get { return Fields.PrimaryBeMake[this]; }
            set { Fields.PrimaryBeMake[this] = value; }
        }

        [DisplayName("Primary Be Year"), Expression("jPrimaryBe.[Year]")]
        public Int32? PrimaryBeYear
        {
            get { return Fields.PrimaryBeYear[this]; }
            set { Fields.PrimaryBeYear[this] = value; }
        }

        [DisplayName("Primary Be Plc Make"), Expression("jPrimaryBe.[PlcMake]")]
        public String PrimaryBePlcMake
        {
            get { return Fields.PrimaryBePlcMake[this]; }
            set { Fields.PrimaryBePlcMake[this] = value; }
        }

        [DisplayName("Primary Be Plc Model Number"), Expression("jPrimaryBe.[PlcModelNumber]")]
        public String PrimaryBePlcModelNumber
        {
            get { return Fields.PrimaryBePlcModelNumber[this]; }
            set { Fields.PrimaryBePlcModelNumber[this] = value; }
        }

        [DisplayName("Primary Be Plc Serial Number"), Expression("jPrimaryBe.[PlcSerialNumber]")]
        public String PrimaryBePlcSerialNumber
        {
            get { return Fields.PrimaryBePlcSerialNumber[this]; }
            set { Fields.PrimaryBePlcSerialNumber[this] = value; }
        }

        [DisplayName("Primary Be Plc Address"), Expression("jPrimaryBe.[PLCAddress]")]
        public String PrimaryBePlcAddress
        {
            get { return Fields.PrimaryBePlcAddress[this]; }
            set { Fields.PrimaryBePlcAddress[this] = value; }
        }

        [DisplayName("Primary Be Access Ip Address"), Expression("jPrimaryBe.[AccessIPAddress]")]
        public String PrimaryBeAccessIpAddress
        {
            get { return Fields.PrimaryBeAccessIpAddress[this]; }
            set { Fields.PrimaryBeAccessIpAddress[this] = value; }
        }

        [DisplayName("Primary Be Machine Sequence"), Expression("jPrimaryBe.[MachineSequence]")]
        public Int32? PrimaryBeMachineSequence
        {
            get { return Fields.PrimaryBeMachineSequence[this]; }
            set { Fields.PrimaryBeMachineSequence[this] = value; }
        }

        [DisplayName("Primary Be Machine Image"), Expression("jPrimaryBe.[MachineImage]")]
        public byte[] PrimaryBeMachineImage
        {
            get { return Fields.PrimaryBeMachineImage[this]; }
            set { Fields.PrimaryBeMachineImage[this] = value; }
        }

        [DisplayName("Primary Be Machine Type Id"), Expression("jPrimaryBe.[MachineTypeID]")]
        public Int32? PrimaryBeMachineTypeId
        {
            get { return Fields.PrimaryBeMachineTypeId[this]; }
            set { Fields.PrimaryBeMachineTypeId[this] = value; }
        }

        [DisplayName("Primary Be Status Id"), Expression("jPrimaryBe.[StatusId]")]
        public Int32? PrimaryBeStatusId
        {
            get { return Fields.PrimaryBeStatusId[this]; }
            set { Fields.PrimaryBeStatusId[this] = value; }
        }

        [DisplayName("Primary Be Description"), Expression("jPrimaryBe.[Description]")]
        public String PrimaryBeDescription
        {
            get { return Fields.PrimaryBeDescription[this]; }
            set { Fields.PrimaryBeDescription[this] = value; }
        }

        [DisplayName("Primary Be Created By"), Expression("jPrimaryBe.[CreatedBy]")]
        public Int32? PrimaryBeCreatedBy
        {
            get { return Fields.PrimaryBeCreatedBy[this]; }
            set { Fields.PrimaryBeCreatedBy[this] = value; }
        }

        [DisplayName("Primary Be Created Date"), Expression("jPrimaryBe.[CreatedDate]")]
        public DateTime? PrimaryBeCreatedDate
        {
            get { return Fields.PrimaryBeCreatedDate[this]; }
            set { Fields.PrimaryBeCreatedDate[this] = value; }
        }

        [DisplayName("Primary Be Updated By"), Expression("jPrimaryBe.[UpdatedBy]")]
        public Int32? PrimaryBeUpdatedBy
        {
            get { return Fields.PrimaryBeUpdatedBy[this]; }
            set { Fields.PrimaryBeUpdatedBy[this] = value; }
        }

        [DisplayName("Primary Be Updated Date"), Expression("jPrimaryBe.[UpdatedDate]")]
        public DateTime? PrimaryBeUpdatedDate
        {
            get { return Fields.PrimaryBeUpdatedDate[this]; }
            set { Fields.PrimaryBeUpdatedDate[this] = value; }
        }

        [DisplayName("Primary Be Equipment Id"), Expression("jPrimaryBe.[EquipmentID]")]
        public String PrimaryBeEquipmentId
        {
            get { return Fields.PrimaryBeEquipmentId[this]; }
            set { Fields.PrimaryBeEquipmentId[this] = value; }
        }

        [DisplayName("Primary Be Timer For Alarm"), Expression("jPrimaryBe.[TimerForAlarm]")]
        public Int32? PrimaryBeTimerForAlarm
        {
            get { return Fields.PrimaryBeTimerForAlarm[this]; }
            set { Fields.PrimaryBeTimerForAlarm[this] = value; }
        }

        [DisplayName("Primary Be Isactive"), Expression("jPrimaryBe.[isactive]")]
        public Boolean? PrimaryBeIsactive
        {
            get { return Fields.PrimaryBeIsactive[this]; }
            set { Fields.PrimaryBeIsactive[this] = value; }
        }

        [DisplayName("Primary Be Is Show Statistics"), Expression("jPrimaryBe.[IsShowStatistics]")]
        public Boolean? PrimaryBeIsShowStatistics
        {
            get { return Fields.PrimaryBeIsShowStatistics[this]; }
            set { Fields.PrimaryBeIsShowStatistics[this] = value; }
        }

        [DisplayName("Primary Be Record Added Source"), Expression("jPrimaryBe.[RecordAddedSource]")]
        public String PrimaryBeRecordAddedSource
        {
            get { return Fields.PrimaryBeRecordAddedSource[this]; }
            set { Fields.PrimaryBeRecordAddedSource[this] = value; }
        }

        [DisplayName("Primary Be Is Real Time"), Expression("jPrimaryBe.[IsRealTime]")]
        public Boolean? PrimaryBeIsRealTime
        {
            get { return Fields.PrimaryBeIsRealTime[this]; }
            set { Fields.PrimaryBeIsRealTime[this] = value; }
        }

        [DisplayName("Primary Be Table Id"), Expression("jPrimaryBe.[TableId]")]
        public Int32? PrimaryBeTableId
        {
            get { return Fields.PrimaryBeTableId[this]; }
            set { Fields.PrimaryBeTableId[this] = value; }
        }

        [DisplayName("Primary Be Table Name"), Expression("jPrimaryBe.[TableName]")]
        public String PrimaryBeTableName
        {
            get { return Fields.PrimaryBeTableName[this]; }
            set { Fields.PrimaryBeTableName[this] = value; }
        }

        [DisplayName("Status"), Expression("jStatus.[StatusName]")]
        public String StatusStatusName
        {
            get { return Fields.StatusStatusName[this]; }
            set { Fields.StatusStatusName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.PrimaryRelationshipId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.RelationshipName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PrimaryRelationshipRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field PrimaryRelationshipId;
            public StringField RelationshipName;
            public Int32Field PrimaryBe;
            // Added by Denis for RS 8.7 and RS 8.8 dated 9/10/2021
            public Int32Field PrimaryEf;
            public StringField Description;
            public Int32Field Status;

            public Int32Field PrimaryBeMachineLineId;
            public StringField PrimaryBeMachineName;
            public StringField PrimaryBeModelNumber;
            public StringField PrimaryBeSerialNumber;
            public StringField PrimaryBeMake;
            public Int32Field PrimaryBeYear;
            public StringField PrimaryBePlcMake;
            public StringField PrimaryBePlcModelNumber;
            public StringField PrimaryBePlcSerialNumber;
            public StringField PrimaryBePlcAddress;
            public StringField PrimaryBeAccessIpAddress;
            public Int32Field PrimaryBeMachineSequence;
            public ByteArrayField PrimaryBeMachineImage;
            public Int32Field PrimaryBeMachineTypeId;
            public Int32Field PrimaryBeStatusId;
            public StringField PrimaryBeDescription;
            public Int32Field PrimaryBeCreatedBy;
            public DateTimeField PrimaryBeCreatedDate;
            public Int32Field PrimaryBeUpdatedBy;
            public DateTimeField PrimaryBeUpdatedDate;
            public StringField PrimaryBeEquipmentId;
            public Int32Field PrimaryBeTimerForAlarm;
            public BooleanField PrimaryBeIsactive;
            public BooleanField PrimaryBeIsShowStatistics;
            public StringField PrimaryBeRecordAddedSource;
            public BooleanField PrimaryBeIsRealTime;
            public Int32Field PrimaryBeTableId;
            public StringField PrimaryBeTableName;

            // Added by Denis for RS 8.7 and RS 8.8 dated 9/10/2021
            public StringField PrimaryEfParameterName;

            public StringField StatusStatusName;
        }
    }
}

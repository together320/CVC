
namespace CVC.MachineCustomization.Entities
{
    using CVC.Administration.Entities;
    using CVC.MachineCustomization.Scripts;
    using CVC.Modules.Common.BaseClass;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("MachineCustomization"), TableName("[dbo].[SecondaryRelationship]")]
    [DisplayName("Secondary Relationship"), InstanceName("Secondary Relationship")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class SecondaryRelationshipRow : LoggingRow, IIdRow, INameRow, IAuditLog
    {
        [DisplayName("Secondary Relationship Id"), Identity]
        public Int32? SecondaryRelationshipId
        {
            get { return Fields.SecondaryRelationshipId[this]; }
            set { Fields.SecondaryRelationshipId[this] = value; }
        }

        [DisplayName("Primary Relationship"), NotNull, ForeignKey("[dbo].[PrimaryRelationship]", "PrimaryRelationshipId"), LeftJoin("jPrimaryRelationship"), TextualField("PrimaryRelationshipRelationshipName")]
        //[LookupEditor(typeof(PrimaryRelationshipRow))]
        //[LookupEditor(typeof(PrimaryRelationshipLookup))]
        [PrimaryRelationshipLookupEditor]
        public Int32? PrimaryRelationshipId
        {
            get { return Fields.PrimaryRelationshipId[this]; }
            set { Fields.PrimaryRelationshipId[this] = value; }
        }

        [DisplayName("Secondary BE"), Column("SecondaryBE"), NotNull, ForeignKey("[dbo].[Machine]", "MachineId"), LeftJoin("jSecondaryBe"), TextualField("SecondaryBeMachineName")]
        //[LookupEditor(typeof(MachineRow))]
        [SecondaryBELookupEditor]
        public Int32? SecondaryBe
        {
            get { return Fields.SecondaryBe[this]; }
            set { Fields.SecondaryBe[this] = value; }
        }

        [DisplayName("Secondary EF"), NotNull, ForeignKey("[dbo].[MachineParameter]", "MachineParameterId"), LeftJoin("jSecondaryEf"), TextualField("SecondaryEfParameterName")]
        //[LookupEditor(typeof(MachineParameterRow), CascadeFrom = "SecondaryBe", CascadeField = "MachineId")]
        [SecondaryEFLookupEditor]
        public Int32? SecondaryEf
        {
            get { return Fields.SecondaryEf[this]; }
            set { Fields.SecondaryEf[this] = value; }
        }

        [DisplayName("Secondary Entity Field"), Expression("jSecondaryEf.[ParameterName]")]
        public String SecondaryEfParameterName
        {
            get { return Fields.SecondaryEfParameterName[this]; }
            set { Fields.SecondaryEfParameterName[this] = value; }
        }

        [DisplayName("Description"), Size(256), QuickSearch]
        [TextAreaEditor(Rows = 5)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Relationship Name"), Expression("jPrimaryRelationship.[RelationshipName]")]
        public String PrimaryRelationshipRelationshipName
        {
            get { return Fields.PrimaryRelationshipRelationshipName[this]; }
            set { Fields.PrimaryRelationshipRelationshipName[this] = value; }
        }

        [DisplayName("Primary Relationship Primary Be"), Expression("jPrimaryRelationship.[PrimaryBE]")]
        [ForeignKey("[dbo].[Machine]", "MachineId"), LeftJoin("jPrimaryBe"), TextualField("PrimaryBeMachineName")]
        public Int32? PrimaryRelationshipPrimaryBe
        {
            get { return Fields.PrimaryRelationshipPrimaryBe[this]; }
            set { Fields.PrimaryRelationshipPrimaryBe[this] = value; }
        }

        [DisplayName("Primary Business Entity"), Expression("jPrimaryBe.[MachineName]")]
        public String PrimaryBeMachineName
        {
            get { return Fields.PrimaryBeMachineName[this]; }
            set { Fields.PrimaryBeMachineName[this] = value; }
        }

        // Added by Denis for RS 8.7 and RS 8.8 dated 9/10/2021
        [DisplayName("Primary Relationship Primary Ef"), Expression("jPrimaryRelationship.[PrimaryEF]")]
        [ForeignKey("[dbo].[MachineParameter]", "MachineParameterId"), LeftJoin("jPrimaryEf"), TextualField("PrimaryEfParameterName")]
        public Int32? PrimaryRelationshipPrimaryEf
        {
            get { return Fields.PrimaryRelationshipPrimaryEf[this]; }
            set { Fields.PrimaryRelationshipPrimaryEf[this] = value; }
        }

        // Added by Denis for RS 8.7 and RS 8.8 dated 9/10/2021
        [DisplayName("Primary Entity Field"), Expression("jPrimaryEf.[ParameterName]")]
        public String PrimaryEfParameterName
        {
            get { return Fields.PrimaryEfParameterName[this]; }
            set { Fields.PrimaryEfParameterName[this] = value; }
        }

        [DisplayName("Primary Relationship Description"), Expression("jPrimaryRelationship.[Description]")]
        public String PrimaryRelationshipDescription
        {
            get { return Fields.PrimaryRelationshipDescription[this]; }
            set { Fields.PrimaryRelationshipDescription[this] = value; }
        }

        [DisplayName("Primary Relationship Status"), Expression("jPrimaryRelationship.[Status]")]
        public Int32? PrimaryRelationshipStatus
        {
            get { return Fields.PrimaryRelationshipStatus[this]; }
            set { Fields.PrimaryRelationshipStatus[this] = value; }
        }

        [DisplayName("Primary Relationship Created By"), Expression("jPrimaryRelationship.[CreatedBy]")]
        public Int32? PrimaryRelationshipCreatedBy
        {
            get { return Fields.PrimaryRelationshipCreatedBy[this]; }
            set { Fields.PrimaryRelationshipCreatedBy[this] = value; }
        }

        [DisplayName("Primary Relationship Created Date"), Expression("jPrimaryRelationship.[CreatedDate]")]
        public DateTime? PrimaryRelationshipCreatedDate
        {
            get { return Fields.PrimaryRelationshipCreatedDate[this]; }
            set { Fields.PrimaryRelationshipCreatedDate[this] = value; }
        }

        [DisplayName("Primary Relationship Updated By"), Expression("jPrimaryRelationship.[UpdatedBy]")]
        public Int32? PrimaryRelationshipUpdatedBy
        {
            get { return Fields.PrimaryRelationshipUpdatedBy[this]; }
            set { Fields.PrimaryRelationshipUpdatedBy[this] = value; }
        }

        [DisplayName("Primary Relationship Updated Date"), Expression("jPrimaryRelationship.[UpdatedDate]")]
        public DateTime? PrimaryRelationshipUpdatedDate
        {
            get { return Fields.PrimaryRelationshipUpdatedDate[this]; }
            set { Fields.PrimaryRelationshipUpdatedDate[this] = value; }
        }

        [DisplayName("Secondary Be Machine Line Id"), Expression("jSecondaryBe.[MachineLineId]")]
        public Int32? SecondaryBeMachineLineId
        {
            get { return Fields.SecondaryBeMachineLineId[this]; }
            set { Fields.SecondaryBeMachineLineId[this] = value; }
        }

        [DisplayName("Secondary Business Entity"), Expression("jSecondaryBe.[MachineName]")]
        public String SecondaryBeMachineName
        {
            get { return Fields.SecondaryBeMachineName[this]; }
            set { Fields.SecondaryBeMachineName[this] = value; }
        }

        [DisplayName("Secondary Be Model Number"), Expression("jSecondaryBe.[ModelNumber]")]
        public String SecondaryBeModelNumber
        {
            get { return Fields.SecondaryBeModelNumber[this]; }
            set { Fields.SecondaryBeModelNumber[this] = value; }
        }

        [DisplayName("Secondary Be Serial Number"), Expression("jSecondaryBe.[SerialNumber]")]
        public String SecondaryBeSerialNumber
        {
            get { return Fields.SecondaryBeSerialNumber[this]; }
            set { Fields.SecondaryBeSerialNumber[this] = value; }
        }

        [DisplayName("Secondary Be Make"), Expression("jSecondaryBe.[Make]")]
        public String SecondaryBeMake
        {
            get { return Fields.SecondaryBeMake[this]; }
            set { Fields.SecondaryBeMake[this] = value; }
        }

        [DisplayName("Secondary Be Year"), Expression("jSecondaryBe.[Year]")]
        public Int32? SecondaryBeYear
        {
            get { return Fields.SecondaryBeYear[this]; }
            set { Fields.SecondaryBeYear[this] = value; }
        }

        [DisplayName("Secondary Be Plc Make"), Expression("jSecondaryBe.[PlcMake]")]
        public String SecondaryBePlcMake
        {
            get { return Fields.SecondaryBePlcMake[this]; }
            set { Fields.SecondaryBePlcMake[this] = value; }
        }

        [DisplayName("Secondary Be Plc Model Number"), Expression("jSecondaryBe.[PlcModelNumber]")]
        public String SecondaryBePlcModelNumber
        {
            get { return Fields.SecondaryBePlcModelNumber[this]; }
            set { Fields.SecondaryBePlcModelNumber[this] = value; }
        }

        [DisplayName("Secondary Be Plc Serial Number"), Expression("jSecondaryBe.[PlcSerialNumber]")]
        public String SecondaryBePlcSerialNumber
        {
            get { return Fields.SecondaryBePlcSerialNumber[this]; }
            set { Fields.SecondaryBePlcSerialNumber[this] = value; }
        }

        [DisplayName("Secondary Be Plc Address"), Expression("jSecondaryBe.[PLCAddress]")]
        public String SecondaryBePlcAddress
        {
            get { return Fields.SecondaryBePlcAddress[this]; }
            set { Fields.SecondaryBePlcAddress[this] = value; }
        }

        [DisplayName("Secondary Be Access Ip Address"), Expression("jSecondaryBe.[AccessIPAddress]")]
        public String SecondaryBeAccessIpAddress
        {
            get { return Fields.SecondaryBeAccessIpAddress[this]; }
            set { Fields.SecondaryBeAccessIpAddress[this] = value; }
        }

        [DisplayName("Secondary Be Machine Sequence"), Expression("jSecondaryBe.[MachineSequence]")]
        public Int32? SecondaryBeMachineSequence
        {
            get { return Fields.SecondaryBeMachineSequence[this]; }
            set { Fields.SecondaryBeMachineSequence[this] = value; }
        }

        [DisplayName("Secondary Be Machine Image"), Expression("jSecondaryBe.[MachineImage]")]
        public byte[] SecondaryBeMachineImage
        {
            get { return Fields.SecondaryBeMachineImage[this]; }
            set { Fields.SecondaryBeMachineImage[this] = value; }
        }

        [DisplayName("Secondary Be Machine Type Id"), Expression("jSecondaryBe.[MachineTypeID]")]
        public Int32? SecondaryBeMachineTypeId
        {
            get { return Fields.SecondaryBeMachineTypeId[this]; }
            set { Fields.SecondaryBeMachineTypeId[this] = value; }
        }

        [DisplayName("Secondary Be Status Id"), Expression("jSecondaryBe.[StatusId]")]
        public Int32? SecondaryBeStatusId
        {
            get { return Fields.SecondaryBeStatusId[this]; }
            set { Fields.SecondaryBeStatusId[this] = value; }
        }

        [DisplayName("Secondary Be Description"), Expression("jSecondaryBe.[Description]")]
        public String SecondaryBeDescription
        {
            get { return Fields.SecondaryBeDescription[this]; }
            set { Fields.SecondaryBeDescription[this] = value; }
        }

        [DisplayName("Secondary Be Created By"), Expression("jSecondaryBe.[CreatedBy]")]
        public Int32? SecondaryBeCreatedBy
        {
            get { return Fields.SecondaryBeCreatedBy[this]; }
            set { Fields.SecondaryBeCreatedBy[this] = value; }
        }

        [DisplayName("Secondary Be Created Date"), Expression("jSecondaryBe.[CreatedDate]")]
        public DateTime? SecondaryBeCreatedDate
        {
            get { return Fields.SecondaryBeCreatedDate[this]; }
            set { Fields.SecondaryBeCreatedDate[this] = value; }
        }

        [DisplayName("Secondary Be Updated By"), Expression("jSecondaryBe.[UpdatedBy]")]
        public Int32? SecondaryBeUpdatedBy
        {
            get { return Fields.SecondaryBeUpdatedBy[this]; }
            set { Fields.SecondaryBeUpdatedBy[this] = value; }
        }

        [DisplayName("Secondary Be Updated Date"), Expression("jSecondaryBe.[UpdatedDate]")]
        public DateTime? SecondaryBeUpdatedDate
        {
            get { return Fields.SecondaryBeUpdatedDate[this]; }
            set { Fields.SecondaryBeUpdatedDate[this] = value; }
        }

        [DisplayName("Secondary Be Equipment Id"), Expression("jSecondaryBe.[EquipmentID]")]
        public String SecondaryBeEquipmentId
        {
            get { return Fields.SecondaryBeEquipmentId[this]; }
            set { Fields.SecondaryBeEquipmentId[this] = value; }
        }

        [DisplayName("Secondary Be Timer For Alarm"), Expression("jSecondaryBe.[TimerForAlarm]")]
        public Int32? SecondaryBeTimerForAlarm
        {
            get { return Fields.SecondaryBeTimerForAlarm[this]; }
            set { Fields.SecondaryBeTimerForAlarm[this] = value; }
        }

        [DisplayName("Secondary Be Isactive"), Expression("jSecondaryBe.[isactive]")]
        public Boolean? SecondaryBeIsactive
        {
            get { return Fields.SecondaryBeIsactive[this]; }
            set { Fields.SecondaryBeIsactive[this] = value; }
        }

        [DisplayName("Secondary Be Is Show Statistics"), Expression("jSecondaryBe.[IsShowStatistics]")]
        public Boolean? SecondaryBeIsShowStatistics
        {
            get { return Fields.SecondaryBeIsShowStatistics[this]; }
            set { Fields.SecondaryBeIsShowStatistics[this] = value; }
        }

        [DisplayName("Secondary Be Record Added Source"), Expression("jSecondaryBe.[RecordAddedSource]")]
        public String SecondaryBeRecordAddedSource
        {
            get { return Fields.SecondaryBeRecordAddedSource[this]; }
            set { Fields.SecondaryBeRecordAddedSource[this] = value; }
        }

        [DisplayName("Secondary Be Is Real Time"), Expression("jSecondaryBe.[IsRealTime]")]
        public Boolean? SecondaryBeIsRealTime
        {
            get { return Fields.SecondaryBeIsRealTime[this]; }
            set { Fields.SecondaryBeIsRealTime[this] = value; }
        }

        [DisplayName("Secondary Be Table Id"), Expression("jSecondaryBe.[TableId]")]
        public Int32? SecondaryBeTableId
        {
            get { return Fields.SecondaryBeTableId[this]; }
            set { Fields.SecondaryBeTableId[this] = value; }
        }

        [DisplayName("Secondary Be Table Name"), Expression("jSecondaryBe.[TableName]")]
        public String SecondaryBeTableName
        {
            get { return Fields.SecondaryBeTableName[this]; }
            set { Fields.SecondaryBeTableName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.SecondaryRelationshipId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Description; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public SecondaryRelationshipRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field SecondaryRelationshipId;
            public Int32Field PrimaryRelationshipId;
            public Int32Field SecondaryBe;
            // Added by Denis for RS 8.7 and RS 8.8 dated 9/10/2021
            public Int32Field SecondaryEf;
            public StringField Description;

            public StringField PrimaryRelationshipRelationshipName;
            public Int32Field PrimaryRelationshipPrimaryBe;
            public StringField PrimaryBeMachineName;
            // Added by Denis for RS 8.7 and RS 8.8 dated 9/10/2021
            public Int32Field PrimaryRelationshipPrimaryEf;
            public StringField PrimaryEfParameterName;

            public StringField PrimaryRelationshipDescription;
            public Int32Field PrimaryRelationshipStatus;
            public Int32Field PrimaryRelationshipCreatedBy;
            public DateTimeField PrimaryRelationshipCreatedDate;
            public Int32Field PrimaryRelationshipUpdatedBy;
            public DateTimeField PrimaryRelationshipUpdatedDate;

            public Int32Field SecondaryBeMachineLineId;
            public StringField SecondaryBeMachineName;
            public StringField SecondaryBeModelNumber;
            public StringField SecondaryBeSerialNumber;
            public StringField SecondaryBeMake;
            public Int32Field SecondaryBeYear;
            public StringField SecondaryBePlcMake;
            public StringField SecondaryBePlcModelNumber;
            public StringField SecondaryBePlcSerialNumber;
            public StringField SecondaryBePlcAddress;
            public StringField SecondaryBeAccessIpAddress;
            public Int32Field SecondaryBeMachineSequence;
            public ByteArrayField SecondaryBeMachineImage;
            public Int32Field SecondaryBeMachineTypeId;
            public Int32Field SecondaryBeStatusId;
            public StringField SecondaryBeDescription;
            public Int32Field SecondaryBeCreatedBy;
            public DateTimeField SecondaryBeCreatedDate;
            public Int32Field SecondaryBeUpdatedBy;
            public DateTimeField SecondaryBeUpdatedDate;
            public StringField SecondaryBeEquipmentId;
            public Int32Field SecondaryBeTimerForAlarm;
            public BooleanField SecondaryBeIsactive;
            public BooleanField SecondaryBeIsShowStatistics;
            public StringField SecondaryBeRecordAddedSource;
            public BooleanField SecondaryBeIsRealTime;
            public Int32Field SecondaryBeTableId;
            public StringField SecondaryBeTableName;

            // Added by Denis for RS 8.7 and RS 8.8 dated 9/10/2021
            public StringField SecondaryEfParameterName;
        }
    }
}

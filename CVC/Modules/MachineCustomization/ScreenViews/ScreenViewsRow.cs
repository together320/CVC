
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

    [ConnectionKey("Default"), Module("MachineCustomization"), TableName("[dbo].[ScreenViews]")]
    [DisplayName("Screen Views"), InstanceName("Screen Views")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ScreenViewsRow : LoggingRow, IIdRow, INameRow, IAuditLog
    {
        [DisplayName("Screen View Id"), Identity]
        public Int32? ScreenViewId
        {
            get { return Fields.ScreenViewId[this]; }
            set { Fields.ScreenViewId[this] = value; }
        }

        [DisplayName("Screen View Name"), Size(50), NotNull, QuickSearch]
        public String ScreenViewName
        {
            get { return Fields.ScreenViewName[this]; }
            set { Fields.ScreenViewName[this] = value; }
        }

        [DisplayName("Relationship"), NotNull, ForeignKey("[dbo].[PrimaryRelationship]", "PrimaryRelationshipId"), LeftJoin("jPrimaryRelationship"), TextualField("PrimaryRelationshipRelationshipName")]
        [LookupEditor(typeof(PrimaryRelationshipRow))]
        public Int32? PrimaryRelationshipId
        {
            get { return Fields.PrimaryRelationshipId[this]; }
            set { Fields.PrimaryRelationshipId[this] = value; }
        }

        [DisplayName("Is No BER"), Column("IsNoBER")]
        public Boolean? IsNoBer
        {
            get { return Fields.IsNoBer[this]; }
            set { Fields.IsNoBer[this] = value; }
        }

        [DisplayName("Status"), NotNull, ForeignKey("[dbo].[Status]", "StatusId"), LeftJoin("jStatus"), TextualField("StatusStatusName")]
        [LookupEditor(typeof(StatusRow))]
        [DefaultValue(1)]
        public Int32? StatusId
        {
            get { return Fields.StatusId[this]; }
            set { Fields.StatusId[this] = value; }
        }

        [DisplayName("Created By"), ForeignKey("[dbo].[Users]", "UserId"), LeftJoin("jCreatedBy"), TextualField("CreatedByUsername")]
        public Int32? CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Updated By"), ForeignKey("[dbo].[Users]", "UserId"), LeftJoin("jUpdatedBy"), TextualField("UpdatedByUsername")]
        public Int32? UpdatedBy
        {
            get { return Fields.UpdatedBy[this]; }
            set { Fields.UpdatedBy[this] = value; }
        }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate
        {
            get { return Fields.UpdatedDate[this]; }
            set { Fields.UpdatedDate[this] = value; }
        }

        [DisplayName("Created By"), Expression("jCreatedBy.[Username]")]
        public String CreatedByUsername
        {
            get { return Fields.CreatedByUsername[this]; }
            set { Fields.CreatedByUsername[this] = value; }
        }

        [DisplayName("Updated By"), Expression("jUpdatedBy.[Username]")]
        public String UpdatedByUsername
        {
            get { return Fields.UpdatedByUsername[this]; }
            set { Fields.UpdatedByUsername[this] = value; }
        }

        [DisplayName("Relationship Name"), Expression("jPrimaryRelationship.[RelationshipName]")]
        public String PrimaryRelationshipRelationshipName
        {
            get { return Fields.PrimaryRelationshipRelationshipName[this]; }
            set { Fields.PrimaryRelationshipRelationshipName[this] = value; }
        }

        [DisplayName("Primary Relationship Primary Be"), Expression("jPrimaryRelationship.[PrimaryBE]")]
        public Int32? PrimaryRelationshipPrimaryBe
        {
            get { return Fields.PrimaryRelationshipPrimaryBe[this]; }
            set { Fields.PrimaryRelationshipPrimaryBe[this] = value; }
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

        [DisplayName("Primary Relationship Primary Ef"), Expression("jPrimaryRelationship.[PrimaryEF]")]
        public Int32? PrimaryRelationshipPrimaryEf
        {
            get { return Fields.PrimaryRelationshipPrimaryEf[this]; }
            set { Fields.PrimaryRelationshipPrimaryEf[this] = value; }
        }

        [DisplayName("Status"), Expression("jStatus.[StatusName]")]
        public String StatusStatusName
        {
            get { return Fields.StatusStatusName[this]; }
            set { Fields.StatusStatusName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ScreenViewId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ScreenViewName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ScreenViewsRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field ScreenViewId;
            public StringField ScreenViewName;
            public Int32Field PrimaryRelationshipId;
            public BooleanField IsNoBer;
            public Int32Field StatusId;
            //public Int32Field CreatedBy;
            //public DateTimeField CreatedDate;
            //public Int32Field UpdatedBy;
            //public DateTimeField UpdatedDate;
            public StringField CreatedByUsername;
            public StringField UpdatedByUsername;

            public StringField PrimaryRelationshipRelationshipName;
            public Int32Field PrimaryRelationshipPrimaryBe;
            public StringField PrimaryRelationshipDescription;
            public Int32Field PrimaryRelationshipStatus;
            public Int32Field PrimaryRelationshipCreatedBy;
            public DateTimeField PrimaryRelationshipCreatedDate;
            public Int32Field PrimaryRelationshipUpdatedBy;
            public DateTimeField PrimaryRelationshipUpdatedDate;
            public Int32Field PrimaryRelationshipPrimaryEf;

            public StringField StatusStatusName;
        }
    }
}

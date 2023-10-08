
namespace CVC.MachineCustomization.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("MachineCustomization"), TableName("[dbo].[DisplayObjectColor]")]
    [DisplayName("Display Object Color"), InstanceName("Display Object Color")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class DisplayObjectColorRow : Row, IIdRow, INameRow
    {
        [DisplayName("Color Id"), Identity]
        public Int32? ColorId
        {
            get { return Fields.ColorId[this]; }
            set { Fields.ColorId[this] = value; }
        }

        [DisplayName("Range From")]
        public Double? RangeFrom
        {
            get { return Fields.RangeFrom[this]; }
            set { Fields.RangeFrom[this] = value; }
        }

        [DisplayName("Range To")]
        public Double? RangeTo
        {
            get { return Fields.RangeTo[this]; }
            set { Fields.RangeTo[this] = value; }
        }

        [DisplayName("Color"), Size(50), NotNull, QuickSearch]
        public String Color
        {
            get { return Fields.Color[this]; }
            set { Fields.Color[this] = value; }
        }

        [DisplayName("Views"), NotNull, ForeignKey("[dbo].[Views]", "ViewsId"), LeftJoin("jViews"), TextualField("ViewsViewName")]
        public Int32? ViewsId
        {
            get { return Fields.ViewsId[this]; }
            set { Fields.ViewsId[this] = value; }
        }

        [DisplayName("Views Module Id"), Expression("jViews.[ModuleId]")]
        public Int32? ViewsModuleId
        {
            get { return Fields.ViewsModuleId[this]; }
            set { Fields.ViewsModuleId[this] = value; }
        }

        [DisplayName("Views View Name"), Expression("jViews.[ViewName]")]
        public String ViewsViewName
        {
            get { return Fields.ViewsViewName[this]; }
            set { Fields.ViewsViewName[this] = value; }
        }

        [DisplayName("Views Is Access Field Wise"), Expression("jViews.[IsAccessFieldWise]")]
        public Boolean? ViewsIsAccessFieldWise
        {
            get { return Fields.ViewsIsAccessFieldWise[this]; }
            set { Fields.ViewsIsAccessFieldWise[this] = value; }
        }

        [DisplayName("Views Status Id"), Expression("jViews.[StatusId]")]
        public Int32? ViewsStatusId
        {
            get { return Fields.ViewsStatusId[this]; }
            set { Fields.ViewsStatusId[this] = value; }
        }

        [DisplayName("Views Created By"), Expression("jViews.[CreatedBy]")]
        public Int32? ViewsCreatedBy
        {
            get { return Fields.ViewsCreatedBy[this]; }
            set { Fields.ViewsCreatedBy[this] = value; }
        }

        [DisplayName("Views Created Date"), Expression("jViews.[CreatedDate]")]
        public DateTime? ViewsCreatedDate
        {
            get { return Fields.ViewsCreatedDate[this]; }
            set { Fields.ViewsCreatedDate[this] = value; }
        }

        [DisplayName("Views Updated By"), Expression("jViews.[UpdatedBy]")]
        public Int32? ViewsUpdatedBy
        {
            get { return Fields.ViewsUpdatedBy[this]; }
            set { Fields.ViewsUpdatedBy[this] = value; }
        }

        [DisplayName("Views Updated Date"), Expression("jViews.[UpdatedDate]")]
        public DateTime? ViewsUpdatedDate
        {
            get { return Fields.ViewsUpdatedDate[this]; }
            set { Fields.ViewsUpdatedDate[this] = value; }
        }

        [DisplayName("Views Is Machine Settings"), Expression("jViews.[IsMachineSettings]")]
        public Boolean? ViewsIsMachineSettings
        {
            get { return Fields.ViewsIsMachineSettings[this]; }
            set { Fields.ViewsIsMachineSettings[this] = value; }
        }

        [DisplayName("Views Is Machine Summary"), Expression("jViews.[IsMachineSummary]")]
        public Boolean? ViewsIsMachineSummary
        {
            get { return Fields.ViewsIsMachineSummary[this]; }
            set { Fields.ViewsIsMachineSummary[this] = value; }
        }

        [DisplayName("Views Islabel Roll"), Expression("jViews.[IslabelRoll]")]
        public Boolean? ViewsIslabelRoll
        {
            get { return Fields.ViewsIslabelRoll[this]; }
            set { Fields.ViewsIslabelRoll[this] = value; }
        }

        [DisplayName("Views Is Command Panel"), Expression("jViews.[IsCommandPanel]")]
        public Boolean? ViewsIsCommandPanel
        {
            get { return Fields.ViewsIsCommandPanel[this]; }
            set { Fields.ViewsIsCommandPanel[this] = value; }
        }

        [DisplayName("Views Is Factory Setting"), Expression("jViews.[IsFactorySetting]")]
        public Boolean? ViewsIsFactorySetting
        {
            get { return Fields.ViewsIsFactorySetting[this]; }
            set { Fields.ViewsIsFactorySetting[this] = value; }
        }

        [DisplayName("Views Display Object Type Id"), Expression("jViews.[DisplayObjectTypeId]")]
        public Int32? ViewsDisplayObjectTypeId
        {
            get { return Fields.ViewsDisplayObjectTypeId[this]; }
            set { Fields.ViewsDisplayObjectTypeId[this] = value; }
        }

        [DisplayName("Views Machine Id"), Expression("jViews.[MachineId]")]
        public Int32? ViewsMachineId
        {
            get { return Fields.ViewsMachineId[this]; }
            set { Fields.ViewsMachineId[this] = value; }
        }

        [DisplayName("Views List Display Id"), Expression("jViews.[ListDisplayId]")]
        public Int32? ViewsListDisplayId
        {
            get { return Fields.ViewsListDisplayId[this]; }
            set { Fields.ViewsListDisplayId[this] = value; }
        }

        [DisplayName("Views Form Display Id"), Expression("jViews.[FormDisplayId]")]
        public Int32? ViewsFormDisplayId
        {
            get { return Fields.ViewsFormDisplayId[this]; }
            set { Fields.ViewsFormDisplayId[this] = value; }
        }

        [DisplayName("Views Button Display Id"), Expression("jViews.[ButtonDisplayId]")]
        public Int32? ViewsButtonDisplayId
        {
            get { return Fields.ViewsButtonDisplayId[this]; }
            set { Fields.ViewsButtonDisplayId[this] = value; }
        }

        [DisplayName("Views Realtime Parameter Display Id"), Expression("jViews.[RealtimeParameterDisplayId]")]
        public Int32? ViewsRealtimeParameterDisplayId
        {
            get { return Fields.ViewsRealtimeParameterDisplayId[this]; }
            set { Fields.ViewsRealtimeParameterDisplayId[this] = value; }
        }

        [DisplayName("Views Line Chart Display Id"), Expression("jViews.[LineChartDisplayId]")]
        public Int32? ViewsLineChartDisplayId
        {
            get { return Fields.ViewsLineChartDisplayId[this]; }
            set { Fields.ViewsLineChartDisplayId[this] = value; }
        }

        [DisplayName("Views Pie Chart Display Id"), Expression("jViews.[PieChartDisplayId]")]
        public Int32? ViewsPieChartDisplayId
        {
            get { return Fields.ViewsPieChartDisplayId[this]; }
            set { Fields.ViewsPieChartDisplayId[this] = value; }
        }

        [DisplayName("Views Tree Display Id"), Expression("jViews.[TreeDisplayId]")]
        public Int32? ViewsTreeDisplayId
        {
            get { return Fields.ViewsTreeDisplayId[this]; }
            set { Fields.ViewsTreeDisplayId[this] = value; }
        }

        [DisplayName("Views Attachment Display Id"), Expression("jViews.[AttachmentDisplayId]")]
        public Int32? ViewsAttachmentDisplayId
        {
            get { return Fields.ViewsAttachmentDisplayId[this]; }
            set { Fields.ViewsAttachmentDisplayId[this] = value; }
        }

        [DisplayName("Views Alarm Display Id"), Expression("jViews.[AlarmDisplayId]")]
        public Int32? ViewsAlarmDisplayId
        {
            get { return Fields.ViewsAlarmDisplayId[this]; }
            set { Fields.ViewsAlarmDisplayId[this] = value; }
        }

        [DisplayName("Views Notification Display Id"), Expression("jViews.[NotificationDisplayId]")]
        public Int32? ViewsNotificationDisplayId
        {
            get { return Fields.ViewsNotificationDisplayId[this]; }
            set { Fields.ViewsNotificationDisplayId[this] = value; }
        }

        [DisplayName("Views Container Display Id"), Expression("jViews.[ContainerDisplayId]")]
        public Int32? ViewsContainerDisplayId
        {
            get { return Fields.ViewsContainerDisplayId[this]; }
            set { Fields.ViewsContainerDisplayId[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ColorId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Color; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public DisplayObjectColorRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ColorId;
            public DoubleField RangeFrom;
            public DoubleField RangeTo;
            public StringField Color;
            public Int32Field ViewsId;

            public Int32Field ViewsModuleId;
            public StringField ViewsViewName;
            public BooleanField ViewsIsAccessFieldWise;
            public Int32Field ViewsStatusId;
            public Int32Field ViewsCreatedBy;
            public DateTimeField ViewsCreatedDate;
            public Int32Field ViewsUpdatedBy;
            public DateTimeField ViewsUpdatedDate;
            public BooleanField ViewsIsMachineSettings;
            public BooleanField ViewsIsMachineSummary;
            public BooleanField ViewsIslabelRoll;
            public BooleanField ViewsIsCommandPanel;
            public BooleanField ViewsIsFactorySetting;
            public Int32Field ViewsDisplayObjectTypeId;
            public Int32Field ViewsMachineId;
            public Int32Field ViewsListDisplayId;
            public Int32Field ViewsFormDisplayId;
            public Int32Field ViewsButtonDisplayId;
            public Int32Field ViewsRealtimeParameterDisplayId;
            public Int32Field ViewsLineChartDisplayId;
            public Int32Field ViewsPieChartDisplayId;
            public Int32Field ViewsTreeDisplayId;
            public Int32Field ViewsAttachmentDisplayId;
            public Int32Field ViewsAlarmDisplayId;
            public Int32Field ViewsNotificationDisplayId;
            public Int32Field ViewsContainerDisplayId;
        }
    }
}

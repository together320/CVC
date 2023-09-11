
namespace CVC.MachineCustomization.Entities
{
    using CVC.Administration.Entities;
    using CVC.Common.CustomColumnFormatters;
    using CVC.Common.CustomEditors;
    using CVC.Modules.Common.BaseClass;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[Views]")]
    [DisplayName("Display Object"), InstanceName("Display Object")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("MachineCustomization.DisplayObject")]
    public sealed class DisplayObjectRow : LoggingRow, IIdRow, INameRow, IAuditLog
    {
        [DisplayName("Views Id"), Identity]
        public Int32? ViewsId
        {
            get { return Fields.ViewsId[this]; }
            set { Fields.ViewsId[this] = value; }
        }

        [DisplayName("Module"), ForeignKey("[dbo].[Module]", "ModuleId"), LeftJoin("jModule"), TextualField("ModuleModuleName")]
        public Int32? ModuleId
        {
            get { return Fields.ModuleId[this]; }
            set { Fields.ModuleId[this] = value; }
        }

        [DisplayName("Name"), Size(50), QuickSearch]
        [NotNull]
        public String ViewName
        {
            get { return Fields.ViewName[this]; }
            set { Fields.ViewName[this] = value; }
        }

        [DisplayName("Is Access Field Wise")]
        public Boolean? IsAccessFieldWise
        {
            get { return Fields.IsAccessFieldWise[this]; }
            set { Fields.IsAccessFieldWise[this] = value; }
        }

        [DisplayName("Status"), ForeignKey("[dbo].[Status]", "StatusId"), LeftJoin("jStatus"), TextualField("StatusStatusName")]
        [NotNull]
        //To make status as default "Active"
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

        [DisplayName("Is Machine Settings")]
        public Boolean? IsMachineSettings
        {
            get { return Fields.IsMachineSettings[this]; }
            set { Fields.IsMachineSettings[this] = value; }
        }

        [DisplayName("Is Machine Summary")]
        public Boolean? IsMachineSummary
        {
            get { return Fields.IsMachineSummary[this]; }
            set { Fields.IsMachineSummary[this] = value; }
        }

        [DisplayName("Islabel Roll")]
        public Boolean? IslabelRoll
        {
            get { return Fields.IslabelRoll[this]; }
            set { Fields.IslabelRoll[this] = value; }
        }

        [DisplayName("Is Command Panel")]
        public Boolean? IsCommandPanel
        {
            get { return Fields.IsCommandPanel[this]; }
            set { Fields.IsCommandPanel[this] = value; }
        }

        [DisplayName("Is Factory Setting")]
        public Boolean? IsFactorySetting
        {
            get { return Fields.IsFactorySetting[this]; }
            set { Fields.IsFactorySetting[this] = value; }
        }

        [DisplayName("Display Object Type")/*, ForeignKey("[dbo].[DisplayObjectTypes]", "DOTypeID"), LeftJoin("jDisplayObjectType"), TextualField("DisplayObjectTypeDoName")*/]
        [DOTypeValueEditor, DOTypeColumnFormatter]
        [NotNull]
        public Int32? DisplayObjectTypeId
        {
            get { return Fields.DisplayObjectTypeId[this]; }
            set { Fields.DisplayObjectTypeId[this] = value; }
        }

        [DisplayName("Display Object Style"), NotMapped]
        public String DisplayObjectStyle
        {
            get { return Fields.DisplayObjectStyle[this]; }
            set { Fields.DisplayObjectStyle[this] = value; }
        }

        [DisplayName("Business Entity"), ForeignKey("[dbo].[Machine]", "MachineId"), LeftJoin("jMachine"), TextualField("MachineMachineName")]
        [NotNull]
        public Int32? MachineId
        {
            get { return Fields.MachineId[this]; }
            set { Fields.MachineId[this] = value; }
        }

        [DisplayName("Status"), Expression("jStatus.[StatusName]")]
        public String StatusStatusName
        {
            get { return Fields.StatusStatusName[this]; }
            set { Fields.StatusStatusName[this] = value; }
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

        //[DisplayName("Display Object Type"), Expression("jDisplayObjectType.[DOName]")]
        //public String DisplayObjectTypeDoName
        //{
        //    get { return Fields.DisplayObjectTypeDoName[this]; }
        //    set { Fields.DisplayObjectTypeDoName[this] = value; }
        //}

        [DisplayName("Business Entity"), Expression("jMachine.[MachineName]")]
        public String MachineMachineName
        {
            get { return Fields.MachineMachineName[this]; }
            set { Fields.MachineMachineName[this] = value; }
        }

        // added by Denis for RS 6.5 dated 8/6/2021
        [DisplayName("List Display"), ForeignKey("[dbo].[ListDisplay]", "ListDisplayId"), LeftJoin("jListDisplay")]
        [Required]
        public Int32? ListDisplayId
        {
            get { return Fields.ListDisplayId[this]; }
            set { Fields.ListDisplayId[this] = value; }
        }

        // added by Denis for RS 6.5 dated 8/17/2021
        [Expression("jListDisplay.[ListDisplayName]")]
        public String ListDisplayName
        {
            get { return Fields.ListDisplayName[this]; }
            set { Fields.ListDisplayName[this] = value; }
        }

        [DisplayName("Form Display"), ForeignKey("[dbo].[FormDisplay]", "FormDisplayId"), LeftJoin("jFormDisplay")]
        [Required]
        public Int32? FormDisplayId
        {
            get { return Fields.FormDisplayId[this]; }
            set { Fields.FormDisplayId[this] = value; }
        }

        // added by Denis for RS 6.5 dated 8/17/2021
        [Expression("jFormDisplay.[FormDisplayName]")]
        public String FormDisplayName
        {
            get { return Fields.FormDisplayName[this]; }
            set { Fields.FormDisplayName[this] = value; }
        }

        [DisplayName("Button Display"), ForeignKey("[dbo].[ButtonDisplay]", "ButtonDisplayId"), LeftJoin("jButtonDisplay")]
        [Required]
        public Int32? ButtonDisplayId
        {
            get { return Fields.ButtonDisplayId[this]; }
            set { Fields.ButtonDisplayId[this] = value; }
        }

        // added by Denis for RS 6.5 dated 8/17/2021
        [Expression("jButtonDisplay.[ButtonDisplayName]")]
        public String ButtonDisplayName
        {
            get { return Fields.ButtonDisplayName[this]; }
            set { Fields.ButtonDisplayName[this] = value; }
        }

        [DisplayName("Realtime Parameter Display"), ForeignKey("[dbo].[RealtimeParameterDisplay]", "RealtimeParameterDisplayId"), LeftJoin("jRealtimeParameterDisplay")]
        [Required]
        public Int32? RealtimeParameterDisplayId
        {
            get { return Fields.RealtimeParameterDisplayId[this]; }
            set { Fields.RealtimeParameterDisplayId[this] = value; }
        }

        // added by Denis for RS 6.5 dated 8/17/2021
        [Expression("jRealtimeParameterDisplay.[RealtimeParameterDisplayName]")]
        public String RealtimeParameterDisplayName
        {
            get { return Fields.RealtimeParameterDisplayName[this]; }
            set { Fields.RealtimeParameterDisplayName[this] = value; }
        }

        [DisplayName("Line Chart Display"), ForeignKey("[dbo].[LineChartDisplay]", "LineChartDisplayId"), LeftJoin("jLineChartDisplay")]
        [Required]
        public Int32? LineChartDisplayId
        {
            get { return Fields.LineChartDisplayId[this]; }
            set { Fields.LineChartDisplayId[this] = value; }
        }

        // added by Denis for RS 6.5 dated 8/17/2021
        [Expression("jLineChartDisplay.[LineChartDisplayName]")]
        public String LineChartDisplayName
        {
            get { return Fields.LineChartDisplayName[this]; }
            set { Fields.LineChartDisplayName[this] = value; }
        }

        [DisplayName("Pie Chart Display"), ForeignKey("[dbo].[PieChartDisplay]", "PieChartDisplayId"), LeftJoin("jPieChartDisplay")]
        [Required]
        public Int32? PieChartDisplayId
        {
            get { return Fields.PieChartDisplayId[this]; }
            set { Fields.PieChartDisplayId[this] = value; }
        }

        // added by Denis for RS 6.5 dated 8/17/2021
        [Expression("jPieChartDisplay.[PieChartDisplayName]")]
        public String PieChartDisplayName
        {
            get { return Fields.PieChartDisplayName[this]; }
            set { Fields.PieChartDisplayName[this] = value; }
        }

        [DisplayName("Tree Display"), ForeignKey("[dbo].[TreeDisplay]", "TreeDisplayId"), LeftJoin("jTreeDisplay")]
        [Required]
        public Int32? TreeDisplayId
        {
            get { return Fields.TreeDisplayId[this]; }
            set { Fields.TreeDisplayId[this] = value; }
        }

        // added by Denis for RS 6.5 dated 8/17/2021
        [Expression("jTreeDisplay.[TreeDisplayName]")]
        public String TreeDisplayName
        {
            get { return Fields.TreeDisplayName[this]; }
            set { Fields.TreeDisplayName[this] = value; }
        }

        [DisplayName("Attachment Display"), ForeignKey("[dbo].[AttachmentDisplay]", "AttachmentDisplayId"), LeftJoin("jAttachmentDisplay")]
        [Required]
        public Int32? AttachmentDisplayId
        {
            get { return Fields.AttachmentDisplayId[this]; }
            set { Fields.AttachmentDisplayId[this] = value; }
        }

        // added by Denis for RS 6.5 dated 8/17/2021
        [Expression("jAttachmentDisplay.[AttachmentDisplayName]")]
        public String AttachmentDisplayName
        {
            get { return Fields.AttachmentDisplayName[this]; }
            set { Fields.AttachmentDisplayName[this] = value; }
        }

        [DisplayName("Alarm Display"), ForeignKey("[dbo].[AlarmDisplay]", "AlarmDisplayId"), LeftJoin("jAlarmDisplay")]
        [Required]
        public Int32? AlarmDisplayId
        {
            get { return Fields.AlarmDisplayId[this]; }
            set { Fields.AlarmDisplayId[this] = value; }
        }

        // added by Denis for RS 6.5 dated 8/17/2021
        [Expression("jAlarmDisplay.[AlarmDisplayName]")]
        public String AlarmDisplayName
        {
            get { return Fields.AlarmDisplayName[this]; }
            set { Fields.AlarmDisplayName[this] = value; }
        }

        [DisplayName("Notification Display"), ForeignKey("[dbo].[NotificationDisplay]", "NotificationDisplayId"), LeftJoin("jNotificationDisplay")]
        [Required]
        public Int32? NotificationDisplayId
        {
            get { return Fields.NotificationDisplayId[this]; }
            set { Fields.NotificationDisplayId[this] = value; }
        }

        // added by Denis for RS 6.5 dated 8/17/2021
        [Expression("jNotificationDisplay.[NotificationDisplayName]")]
        public String NotificationDisplayName
        {
            get { return Fields.NotificationDisplayName[this]; }
            set { Fields.NotificationDisplayName[this] = value; }
        }

        [DisplayName("Container Display"), ForeignKey("[dbo].[ContainerDisplay]", "ContainerDisplayId"), LeftJoin("jContainerDisplay")]
        [Required]
        public Int32? ContainerDisplayId
        {
            get { return Fields.ContainerDisplayId[this]; }
            set { Fields.ContainerDisplayId[this] = value; }
        }

        // added by Denis for RS 6.5 dated 8/17/2021
        [Expression("jContainerDisplay.[ContainerDisplayName]")]
        public String ContainerDisplayName
        {
            get { return Fields.ContainerDisplayName[this]; }
            set { Fields.ContainerDisplayName[this] = value; }
        }
        //[DisplayName("Details"), MasterDetailRelation(foreignKey: "ViewId"), NotMapped]
        //[ListDisplayEditor]
        //public List<ListDisplayRow> DisplayObjectDetails
        //{
        //    get { return Fields.DisplayObjectDetails[this]; }
        //    set { Fields.DisplayObjectDetails[this] = value; }
        //}

        IIdField IIdRow.IdField
        {
            get { return Fields.ViewsId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ViewName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public DisplayObjectRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRow.LoggingRowFields
        {
            public Int32Field ViewsId;
            public Int32Field ModuleId;
            public StringField ViewName;
            public BooleanField IsAccessFieldWise;
            public Int32Field StatusId;
            //public Int32Field CreatedBy;
            //public DateTimeField CreatedDate;
            //public Int32Field UpdatedBy;
            //public DateTimeField UpdatedDate;
            public BooleanField IsMachineSettings;
            public BooleanField IsMachineSummary;
            public BooleanField IslabelRoll;
            public BooleanField IsCommandPanel;
            public BooleanField IsFactorySetting;
            // added by Denis for RS 6.7 dated 8/3/2021
            public Int32Field DisplayObjectTypeId;
            // added by Denis for RS 6.7 dated 8/17/2021
            public StringField DisplayObjectStyle;
            public Int32Field MachineId;

            public StringField StatusStatusName;
            public StringField CreatedByUsername;
            public StringField UpdatedByUsername;

            //public StringField DisplayObjectTypeDoName;
            public StringField MachineMachineName;

            // added by Denis for RS 6.5 dated 8/6/2021
            public Int32Field ListDisplayId;
            // added by Denis for RS 6.5 dated 8/17/2021
            public StringField ListDisplayName;
            // added by Denis for RS 6.5 dated 8/6/2021
            public Int32Field FormDisplayId;
            // added by Denis for RS 6.5 dated 8/17/2021
            public StringField FormDisplayName;
            // added by Denis for RS 6.5 dated 8/7/2021
            public Int32Field ButtonDisplayId;
            // added by Denis for RS 6.5 dated 8/17/2021
            public StringField ButtonDisplayName;
            // added by Denis for RS 6.5 dated 8/72021
            public Int32Field RealtimeParameterDisplayId;
            // added by Denis for RS 6.5 dated 8/17/2021
            public StringField RealtimeParameterDisplayName;
            // added by Denis for RS 6.5 dated 8/7/2021
            public Int32Field LineChartDisplayId;
            // added by Denis for RS 6.5 dated 8/17/2021
            public StringField LineChartDisplayName;
            // added by Denis for RS 6.5 dated 8/9/2021
            public Int32Field PieChartDisplayId;
            // added by Denis for RS 6.5 dated 8/17/2021
            public StringField PieChartDisplayName;
            // added by Denis for RS 6.5 dated 8/9/2021
            public Int32Field TreeDisplayId;
            // added by Denis for RS 6.5 dated 8/17/2021
            public StringField TreeDisplayName;
            // added by Denis for RS 6.5 dated 8/11/2021
            public Int32Field AttachmentDisplayId;
            // added by Denis for RS 6.5 dated 8/17/2021
            public StringField AttachmentDisplayName;
            // added by Denis for RS 6.5 dated 8/11/2021
            public Int32Field AlarmDisplayId;
            // added by Denis for RS 6.5 dated 8/17/2021
            public StringField AlarmDisplayName;
            // added by Denis for RS 6.5 dated 8/11/2021
            public Int32Field NotificationDisplayId;
            // added by Denis for RS 6.5 dated 8/17/2021
            public StringField NotificationDisplayName;
            // added by Denis for RS 6.5 dated 8/11/2021
            public Int32Field ContainerDisplayId;
            // added by Denis for RS 6.5 dated 8/17/2021
            public StringField ContainerDisplayName;
            //public RowListField<ListDisplayRow> DisplayObjectDetails;
            public RowFields()
              : base((string)null, "")
            {
                this.LocalTextPrefix = "MachineCustomization.DisplayObject";
            }
        }
    }
}

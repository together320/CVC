
namespace CVC.MachineCustomization.Entities
{
    using CVC.Modules.Common.BaseClass;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("MachineCustomization"), TableName("[dbo].[AlarmDisplay]")]
    [DisplayName("Alarm Display"), InstanceName("Alarm Display")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class AlarmDisplayRow : Row, IIdRow, INameRow, IAuditLog
    {
        [DisplayName("Alarm Display Id"), Identity]
        public Int32? AlarmDisplayId
        {
            get { return Fields.AlarmDisplayId[this]; }
            set { Fields.AlarmDisplayId[this] = value; }
        }

        [DisplayName("Alarm Display Name"), Size(50), QuickSearch]
        [NotNull]
        public String AlarmDisplayName
        {
            get { return Fields.AlarmDisplayName[this]; }
            set { Fields.AlarmDisplayName[this] = value; }
        }

        [DisplayName("Background Color"), Size(50)]
        public String BackgroundColor
        {
            get { return Fields.BackgroundColor[this]; }
            set { Fields.BackgroundColor[this] = value; }
        }

        [DisplayName("Border Style")]
        public Int32? BorderStyle
        {
            get { return Fields.BorderStyle[this]; }
            set { Fields.BorderStyle[this] = value; }
        }

        [DisplayName("Is Checkbox")]
        public Boolean? IsCheckbox
        {
            get { return Fields.IsCheckbox[this]; }
            set { Fields.IsCheckbox[this] = value; }
        }

        [DisplayName("Font"), Size(50)]
        public String Font
        {
            get { return Fields.Font[this]; }
            set { Fields.Font[this] = value; }
        }

        [DisplayName("Font Color Selected"), Size(50)]
        public String FontColorSelected
        {
            get { return Fields.FontColorSelected[this]; }
            set { Fields.FontColorSelected[this] = value; }
        }

        [DisplayName("Font Color Unselected"), Size(50)]
        public String FontColorUnselected
        {
            get { return Fields.FontColorUnselected[this]; }
            set { Fields.FontColorUnselected[this] = value; }
        }

        [DisplayName("Caution Color"), Size(50)]
        public String CautionColor
        {
            get { return Fields.CautionColor[this]; }
            set { Fields.CautionColor[this] = value; }
        }

        [DisplayName("Warning Color"), Size(50)]
        public String WarningColor
        {
            get { return Fields.WarningColor[this]; }
            set { Fields.WarningColor[this] = value; }
        }

        [DisplayName("Emergency Color"), Size(50)]
        public String EmergencyColor
        {
            get { return Fields.EmergencyColor[this]; }
            set { Fields.EmergencyColor[this] = value; }
        }

        [DisplayName("Activation")]
        public Int32? Activation
        {
            get { return Fields.Activation[this]; }
            set { Fields.Activation[this] = value; }
        }

        [DisplayName("Appearance")]
        public Int32? Appearance
        {
            get { return Fields.Appearance[this]; }
            set { Fields.Appearance[this] = value; }
        }

        [DisplayName("Is Open In New Window")]
        public Boolean? IsOpenInNewWindow
        {
            get { return Fields.IsOpenInNewWindow[this]; }
            set { Fields.IsOpenInNewWindow[this] = value; }
        }

        [DisplayName("Is Tooltip")]
        public Boolean? IsTooltip
        {
            get { return Fields.IsTooltip[this]; }
            set { Fields.IsTooltip[this] = value; }
        }

        [DisplayName("Is Horizontal Scroll Bar")]
        public Boolean? IsHorizontalScrollBar
        {
            get { return Fields.IsHorizontalScrollBar[this]; }
            set { Fields.IsHorizontalScrollBar[this] = value; }
        }

        [DisplayName("Is Vertical Scroll Bar")]
        public Boolean? IsVerticalScrollBar
        {
            get { return Fields.IsVerticalScrollBar[this]; }
            set { Fields.IsVerticalScrollBar[this] = value; }
        }

        [DisplayName("Alignment")]
        public Int32? Alignment
        {
            get { return Fields.Alignment[this]; }
            set { Fields.Alignment[this] = value; }
        }

        [DisplayName("Is Folder Browse")]
        public Boolean? IsFolderBrowse
        {
            get { return Fields.IsFolderBrowse[this]; }
            set { Fields.IsFolderBrowse[this] = value; }
        }

        [DisplayName("Is Add Attachments")]
        public Boolean? IsAddAttachments
        {
            get { return Fields.IsAddAttachments[this]; }
            set { Fields.IsAddAttachments[this] = value; }
        }

        [DisplayName("Is Collapsible")]
        public Boolean? IsCollapsible
        {
            get { return Fields.IsCollapsible[this]; }
            set { Fields.IsCollapsible[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.AlarmDisplayId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.AlarmDisplayName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AlarmDisplayRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field AlarmDisplayId;
            public StringField AlarmDisplayName;
            public StringField BackgroundColor;
            public Int32Field BorderStyle;
            public BooleanField IsCheckbox;
            public StringField Font;
            public StringField FontColorSelected;
            public StringField FontColorUnselected;
            public StringField CautionColor;
            public StringField WarningColor;
            public StringField EmergencyColor;
            public Int32Field Activation;
            public Int32Field Appearance;
            public BooleanField IsOpenInNewWindow;
            public BooleanField IsTooltip;
            public BooleanField IsHorizontalScrollBar;
            public BooleanField IsVerticalScrollBar;
            public Int32Field Alignment;
            public BooleanField IsFolderBrowse;
            public BooleanField IsAddAttachments;
            public BooleanField IsCollapsible;
        }
    }
}

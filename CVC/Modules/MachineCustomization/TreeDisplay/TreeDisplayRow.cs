
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

    [ConnectionKey("Default"), Module("MachineCustomization"), TableName("[dbo].[TreeDisplay]")]
    [DisplayName("Tree Display"), InstanceName("Tree Display")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class TreeDisplayRow : Row, IIdRow, INameRow, IAuditLog
    {
        [DisplayName("Tree Display Id"), Identity]
        public Int32? TreeDisplayId
        {
            get { return Fields.TreeDisplayId[this]; }
            set { Fields.TreeDisplayId[this] = value; }
        }

        [DisplayName("Tree Display Name"), Size(50), QuickSearch]
        [NotNull]
        public String TreeDisplayName
        {
            get { return Fields.TreeDisplayName[this]; }
            set { Fields.TreeDisplayName[this] = value; }
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

        [DisplayName("Font"), Size(50)]
        public String Font
        {
            get { return Fields.Font[this]; }
            set { Fields.Font[this] = value; }
        }

        [DisplayName("Font Color"), Size(50)]
        public String FontColor
        {
            get { return Fields.FontColor[this]; }
            set { Fields.FontColor[this] = value; }
        }

        [DisplayName("Is Full Row Select")]
        public Boolean? IsFullRowSelect
        {
            get { return Fields.IsFullRowSelect[this]; }
            set { Fields.IsFullRowSelect[this] = value; }
        }

        [DisplayName("Line Color"), Size(50)]
        public String LineColor
        {
            get { return Fields.LineColor[this]; }
            set { Fields.LineColor[this] = value; }
        }

        [DisplayName("Default View")]
        public Int32? DefaultView
        {
            get { return Fields.DefaultView[this]; }
            set { Fields.DefaultView[this] = value; }
        }

        [DisplayName("Alignment")]
        public Int32? Alignment
        {
            get { return Fields.Alignment[this]; }
            set { Fields.Alignment[this] = value; }
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

        [DisplayName("Is Realtime")]
        public Boolean? IsRealtime
        {
            get { return Fields.IsRealtime[this]; }
            set { Fields.IsRealtime[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.TreeDisplayId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.TreeDisplayName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TreeDisplayRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field TreeDisplayId;
            public StringField TreeDisplayName;
            public StringField BackgroundColor;
            public Int32Field BorderStyle;
            public StringField Font;
            public StringField FontColor;
            public BooleanField IsFullRowSelect;
            public StringField LineColor;
            public Int32Field DefaultView;
            public Int32Field Alignment;
            public BooleanField IsTooltip;
            public BooleanField IsHorizontalScrollBar;
            public BooleanField IsVerticalScrollBar;
            public BooleanField IsRealtime;
        }
    }
}

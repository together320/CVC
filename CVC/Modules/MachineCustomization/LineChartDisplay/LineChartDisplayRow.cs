
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

    [ConnectionKey("Default"), Module("MachineCustomization"), TableName("[dbo].[LineChartDisplay]")]
    [DisplayName("Line Chart Display"), InstanceName("Line Chart Display")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class LineChartDisplayRow : Row, IIdRow, INameRow, IAuditLog
    {
        [DisplayName("Line Chart Display Id"), Identity]
        public Int32? LineChartDisplayId
        {
            get { return Fields.LineChartDisplayId[this]; }
            set { Fields.LineChartDisplayId[this] = value; }
        }

        [DisplayName("Line Chart Display Name"), Size(50), QuickSearch]
        [NotNull]
        public String LineChartDisplayName
        {
            get { return Fields.LineChartDisplayName[this]; }
            set { Fields.LineChartDisplayName[this] = value; }
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

        [DisplayName("Is Collapsible")]
        public Boolean? IsCollapsible
        {
            get { return Fields.IsCollapsible[this]; }
            set { Fields.IsCollapsible[this] = value; }
        }

        [DisplayName("Is Legends")]
        public Boolean? IsLegends
        {
            get { return Fields.IsLegends[this]; }
            set { Fields.IsLegends[this] = value; }
        }

        [DisplayName("Is Gridlines")]
        public Boolean? IsGridlines
        {
            get { return Fields.IsGridlines[this]; }
            set { Fields.IsGridlines[this] = value; }
        }

        [DisplayName("Gridline Color")]
        public String GridlineColor
        {
            get { return Fields.GridlineColor[this]; }
            set { Fields.GridlineColor[this] = value; }
        }

        [DisplayName("Is Realtime")]
        public Boolean? IsRealtime
        {
            get { return Fields.IsRealtime[this]; }
            set { Fields.IsRealtime[this] = value; }
        }

        [DisplayName("Axis Color")]
        public String AxisColor
        {
            get { return Fields.AxisColor[this]; }
            set { Fields.AxisColor[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.LineChartDisplayId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.LineChartDisplayName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public LineChartDisplayRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field LineChartDisplayId;
            public StringField LineChartDisplayName;
            public StringField BackgroundColor;
            public Int32Field BorderStyle;
            public StringField Font;
            public StringField FontColor;
            public Int32Field Alignment;
            public BooleanField IsTooltip;
            public BooleanField IsHorizontalScrollBar;
            public BooleanField IsVerticalScrollBar;
            public BooleanField IsCollapsible;
            public BooleanField IsLegends;
            public BooleanField IsGridlines;
            public StringField GridlineColor;
            public BooleanField IsRealtime;
            public StringField AxisColor;
        }
    }
}

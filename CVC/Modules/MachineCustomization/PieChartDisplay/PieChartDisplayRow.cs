
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

    [ConnectionKey("Default"), Module("MachineCustomization"), TableName("[dbo].[PieChartDisplay]")]
    [DisplayName("Pie Chart Display"), InstanceName("Pie Chart Display")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class PieChartDisplayRow : Row, IIdRow, INameRow, IAuditLog
    {
        [DisplayName("Pie Chart Display Id"), Identity]
        public Int32? PieChartDisplayId
        {
            get { return Fields.PieChartDisplayId[this]; }
            set { Fields.PieChartDisplayId[this] = value; }
        }

        [DisplayName("Pie Chart Display Name"), Size(50), QuickSearch]
        [NotNull]
        public String PieChartDisplayName
        {
            get { return Fields.PieChartDisplayName[this]; }
            set { Fields.PieChartDisplayName[this] = value; }
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

        [DisplayName("Is Legends")]
        public Boolean? IsLegends
        {
            get { return Fields.IsLegends[this]; }
            set { Fields.IsLegends[this] = value; }
        }

        [DisplayName("Legend Font Size")]
        public Int32? LegendFontSize
        {
            get { return Fields.LegendFontSize[this]; }
            set { Fields.LegendFontSize[this] = value; }
        }

        [DisplayName("Is Show Values As Percentage")]
        public Boolean? IsShowValuesAsPercentage
        {
            get { return Fields.IsShowValuesAsPercentage[this]; }
            set { Fields.IsShowValuesAsPercentage[this] = value; }
        }

        [DisplayName("Is Show Total"), Column("isShowTotal")]
        public Boolean? IsShowTotal
        {
            get { return Fields.IsShowTotal[this]; }
            set { Fields.IsShowTotal[this] = value; }
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
            get { return Fields.PieChartDisplayId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.PieChartDisplayName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PieChartDisplayRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field PieChartDisplayId;
            public StringField PieChartDisplayName;
            public StringField BackgroundColor;
            public Int32Field BorderStyle;
            public StringField Font;
            public StringField FontColor;
            public BooleanField IsLegends;
            public Int32Field LegendFontSize;
            public BooleanField IsShowValuesAsPercentage;
            public BooleanField IsShowTotal;
            public Int32Field Alignment;
            public BooleanField IsTooltip;
            public BooleanField IsHorizontalScrollBar;
            public BooleanField IsVerticalScrollBar;
            public BooleanField IsRealtime;
        }
    }
}

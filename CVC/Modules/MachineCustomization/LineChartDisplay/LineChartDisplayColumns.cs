
namespace CVC.MachineCustomization.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using CVC.Common.CustomColumnFormatters;

    [ColumnsScript("MachineCustomization.LineChartDisplay")]
    [BasedOnRow(typeof(Entities.LineChartDisplayRow), CheckNames = true)]
    public class LineChartDisplayColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 LineChartDisplayId { get; set; }
        [EditLink]
        public String LineChartDisplayName { get; set; }
        [ColoredColumnFormatter(BackgroundProperty = "BackgroundColor", HideText = true)]
        public String BackgroundColor { get; set; }
        [BorderStyleColumnFormatter]
        public Int32 BorderStyle { get; set; }
        public String Font { get; set; }
        [ColoredColumnFormatter(BackgroundProperty = "FontColor", HideText = true)]
        public String FontColor { get; set; }
        public Boolean IsLegends { get; set; }
        [ColoredColumnFormatter(BackgroundProperty = "AxisColor", HideText = true)]
        public String AxisColor { get; set; }
        public Boolean IsGridlines { get; set; }
        [ColoredColumnFormatter(BackgroundProperty = "GridlineColor", HideText = true)]
        public String GridlineColor { get; set; }
        [AlignmentColumnFormatter]
        public Int32 Alignment { get; set; }
        public Boolean IsTooltip { get; set; }
        public Boolean IsRealtime { get; set; }
        public Boolean IsHorizontalScrollBar { get; set; }
        public Boolean IsVerticalScrollBar { get; set; }
        public Boolean IsCollapsible { get; set; }
    }
}
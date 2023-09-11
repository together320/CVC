
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

    [ColumnsScript("MachineCustomization.PieChartDisplay")]
    [BasedOnRow(typeof(Entities.PieChartDisplayRow), CheckNames = true)]
    public class PieChartDisplayColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 PieChartDisplayId { get; set; }
        [EditLink]
        public String PieChartDisplayName { get; set; }
        [ColoredColumnFormatter(BackgroundProperty = "BackgroundColor", HideText = true)]
        public String BackgroundColor { get; set; }
        [BorderStyleColumnFormatter]
        public Int32 BorderStyle { get; set; }
        public String Font { get; set; }
        [ColoredColumnFormatter(BackgroundProperty = "FontColor", HideText = true)]
        public String FontColor { get; set; }
        public Boolean IsLegends { get; set; }
        public Int32 LegendFontSize { get; set; }
        public Boolean IsShowValuesAsPercentage { get; set; }
        public Boolean IsShowTotal { get; set; }
        [AlignmentColumnFormatter]
        public Int32 Alignment { get; set; }
        public Boolean IsTooltip { get; set; }
        public Boolean IsHorizontalScrollBar { get; set; }
        public Boolean IsVerticalScrollBar { get; set; }
        public Boolean IsRealtime { get; set; }
    }
}
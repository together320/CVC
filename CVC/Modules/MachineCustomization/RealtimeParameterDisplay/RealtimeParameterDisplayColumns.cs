
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

    [ColumnsScript("MachineCustomization.RealtimeParameterDisplay")]
    [BasedOnRow(typeof(Entities.RealtimeParameterDisplayRow), CheckNames = true)]
    public class RealtimeParameterDisplayColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 RealtimeParameterDisplayId { get; set; }
        [EditLink]
        public String RealtimeParameterDisplayName { get; set; }
        [ColoredColumnFormatter(BackgroundProperty = "BackgroundColor", HideText = true)]
        public String BackgroundColor { get; set; }
        [BorderStyleColumnFormatter]
        public Int32 BorderStyle { get; set; }
        public String Font { get; set; }
        [ColoredColumnFormatter(BackgroundProperty = "FontColor", HideText = true)]
        public String FontColor { get; set; }
        [AlignmentColumnFormatter]
        public Int32 Alignment { get; set; }
        public Boolean IsTooltip { get; set; }
        public Boolean IsHorizontalScrollBar { get; set; }
        public Boolean IsVerticalScrollBar { get; set; }
        public Boolean IsCollapsible { get; set; }
    }
}
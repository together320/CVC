
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

    [ColumnsScript("MachineCustomization.TreeDisplay")]
    [BasedOnRow(typeof(Entities.TreeDisplayRow), CheckNames = true)]
    public class TreeDisplayColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 TreeDisplayId { get; set; }
        [EditLink]
        public String TreeDisplayName { get; set; }
        [ColoredColumnFormatter(BackgroundProperty = "BackgroundColor", HideText = true)]
        public String BackgroundColor { get; set; }
        [BorderStyleColumnFormatter]
        public Int32 BorderStyle { get; set; }
        public String Font { get; set; }
        [ColoredColumnFormatter(BackgroundProperty = "FontColor", HideText = true)]
        public String FontColor { get; set; }
        public Boolean IsFullRowSelect { get; set; }
        [ColoredColumnFormatter(BackgroundProperty = "LineColor", HideText = true)]
        public String LineColor { get; set; }
        [DefaultViewColumnFormatters]
        public Int32 DefaultView { get; set; }
        [AlignmentColumnFormatter]
        public Int32 Alignment { get; set; }
        public Boolean IsTooltip { get; set; }
        public Boolean IsHorizontalScrollBar { get; set; }
        public Boolean IsVerticalScrollBar { get; set; }
        public Boolean IsRealtime { get; set; }
    }
}
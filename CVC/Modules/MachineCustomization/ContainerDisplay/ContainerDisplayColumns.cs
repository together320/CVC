
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

    [ColumnsScript("MachineCustomization.ContainerDisplay")]
    [BasedOnRow(typeof(Entities.ContainerDisplayRow), CheckNames = true)]
    public class ContainerDisplayColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ContainerDisplayId { get; set; }
        [EditLink]
        public String ContainerDisplayName { get; set; }
        [ColoredColumnFormatter(BackgroundProperty = "BackgroundColor", HideText = true)]
        public String BackgroundColor { get; set; }
        [BorderStyleColumnFormatter]
        public Int32 BorderStyle { get; set; }
        public String Font { get; set; }
        [ColoredColumnFormatter(BackgroundProperty = "FontColorSelected", HideText = true)]
        public String FontColorSelected { get; set; }
        [ColoredColumnFormatter(BackgroundProperty = "FontColorUnselected", HideText = true)]
        public String FontColorUnselected { get; set; }
        [ActivationColumnFormatter]
        public Int32 Activation { get; set; }
        public Boolean IsOpenInNewWindow { get; set; }
        public Boolean IsTooltip { get; set; }
        public Boolean IsHorizontalScrollBar { get; set; }
        public Boolean IsVerticalScrollBar { get; set; }
        [AlignmentColumnFormatter]
        public Int32 Alignment { get; set; }
        public Boolean IsCollapsible { get; set; }
    }
}
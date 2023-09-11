
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

    [ColumnsScript("MachineCustomization.FormDisplay")]
    [BasedOnRow(typeof(Entities.FormDisplayRow), CheckNames = true)]
    public class FormDisplayColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 FormDisplayId { get; set; }
        [EditLink]
        public String FormDisplayName { get; set; }
        [ColoredColumnFormatter(BackgroundProperty = "BackgroundColor", HideText = true)]
        public String BackgroundColor { get; set; }
        [BorderStyleColumnFormatter]
        public Int32 BorderStyle { get; set; }
        public Boolean IsCheckbox { get; set; }
        public String Font { get; set; }
        [ColoredColumnFormatter(BackgroundProperty = "FontColorSelected", HideText = true)]
        public String FontColorSelected { get; set; }
        [ColoredColumnFormatter(BackgroundProperty = "FontColorUnselected", HideText = true)]
        public String FontColorUnselected { get; set; }
        [ActivationColumnFormatter]
        public Int32 Activation { get; set; }
        [AlignmentColumnFormatter]
        public Int32 Alignment { get; set; }
        public Boolean IsTooltip { get; set; }
        public Boolean IsHorizontalScrollBar { get; set; }
        public Boolean IsVerticalScrollBar { get; set; }
        public Boolean IsCollapsible { get; set; }
    }
}

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

    [ColumnsScript("MachineCustomization.AttachmentDisplay")]
    [BasedOnRow(typeof(Entities.AttachmentDisplayRow), CheckNames = true)]
    public class AttachmentDisplayColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 AttachmentDisplayId { get; set; }
        [EditLink]
        public String AttachmentDisplayName { get; set; }
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
        public Boolean IsOpenInNewWindow { get; set; }
        public Boolean IsTooltip { get; set; }
        public Boolean IsHorizontalScrollBar { get; set; }
        public Boolean IsVerticalScrollBar { get; set; }
        [AlignmentColumnFormatter]
        public Int32 Alignment { get; set; }
        public Boolean IsFolderBrowse { get; set; }
        public Boolean IsAddAttachments { get; set; }
        public Boolean IsCollapsible { get; set; }
    }
}
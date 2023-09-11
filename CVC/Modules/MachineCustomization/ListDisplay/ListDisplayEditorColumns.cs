
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

    [ColumnsScript("MachineCustomization.ListDisplayEditor")]
    [BasedOnRow(typeof(Entities.ListDisplayRow))]
    public class ListDisplayEditorColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ListDisplayId { get; set; }
        [EditLink]
        [ColoredColumnFormatter(BackgroundProperty = "BackgroundColor", HideText = true)]
        public String BackgroundColor { get; set; }
        [BorderStyleColumnFormatter]
        public Int32 BorderStyle { get; set; }
        public Boolean Checkbox { get; set; }
        public String Font { get; set; }
        [ColoredColumnFormatter(BackgroundProperty = "FontColor", HideText = true)]
        public String FontColor { get; set; }
        public Int32 FontSize { get; set; }
        public Boolean FullRowSelect { get; set; }
        public Boolean Gridlines { get; set; }
        public Boolean UseWaitCursorOnClick { get; set; }
        [ActivationColumnFormatter]
        public Int32 Activation { get; set; }
        [AlignmentColumnFormatter]
        public Int32 Alignment { get; set; }
        [SortTypeColumnFormatter]
        public Int32 SortingType { get; set; }
        public Boolean SortAscDesc { get; set; }
        public Boolean MultiSelect { get; set; }
        public Boolean AutoResize { get; set; }
        public Boolean Collapsible { get; set; }
    }
}
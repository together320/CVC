
namespace CVC.MachineCustomization.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using CVC.Common.CustomEditors;

    [FormScript("MachineCustomization.LineChartDisplay")]
    [BasedOnRow(typeof(Entities.LineChartDisplayRow), CheckNames = true)]
    public class LineChartDisplayForm
    {
        [Category("Name")]
        [LabelWidth(190)]
        public String LineChartDisplayName { get; set; }
        [Category("Appearance")]
        [LabelWidth(190), HalfWidth]
        [FontValueEditor]
        public String Font { get; set; }
        [LabelWidth(190), HalfWidth]
        [BorderStyleValueEditor]
        public Int32 BorderStyle { get; set; }
        [LabelWidth(190), HalfWidth]
        [ColorPickerEditor]
        public String BackgroundColor { get; set; }
        [LabelWidth(190), HalfWidth]
        [ColorPickerEditor]
        public String FontColor { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsLegends { get; set; }
        [LabelWidth(190), HalfWidth]
        [ColorPickerEditor]
        public String AxisColor { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsGridlines { get; set; }
        [LabelWidth(190), HalfWidth]
        [ColorPickerEditor]
        public String GridlineColor { get; set; }
        [Category("Behavior")]
        [LabelWidth(190)]
        [AlignmentValueEditor]
        public Int32 Alignment { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsTooltip { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsRealtime { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsHorizontalScrollBar { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsVerticalScrollBar { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsCollapsible { get; set; }
    }
}
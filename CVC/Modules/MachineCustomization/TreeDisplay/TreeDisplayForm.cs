
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

    [FormScript("MachineCustomization.TreeDisplay")]
    [BasedOnRow(typeof(Entities.TreeDisplayRow), CheckNames = true)]
    public class TreeDisplayForm
    {
        [Category("Name")]
        [LabelWidth(190)]
        public String TreeDisplayName { get; set; }
        [Category("Appearance")]
        [LabelWidth(190), HalfWidth]
        [ColorPickerEditor]
        public String BackgroundColor { get; set; }
        [LabelWidth(190), HalfWidth]
        [BorderStyleValueEditor]
        public Int32 BorderStyle { get; set; }
        [LabelWidth(190), HalfWidth]
        [FontValueEditor]
        public String Font { get; set; }
        [LabelWidth(190), HalfWidth]
        [ColorPickerEditor]
        public String FontColor { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsFullRowSelect { get; set; }
        [LabelWidth(190), HalfWidth]
        [ColorPickerEditor]
        public String LineColor { get; set; }
        [Category("Behavior")]
        [LabelWidth(190), HalfWidth]
        [DefaultViewValueEditor]
        public Int32 DefaultView { get; set; }
        [LabelWidth(190), HalfWidth]
        [AlignmentValueEditor]
        public Int32 Alignment { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsTooltip { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsHorizontalScrollBar { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsVerticalScrollBar { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsRealtime { get; set; }
    }
}
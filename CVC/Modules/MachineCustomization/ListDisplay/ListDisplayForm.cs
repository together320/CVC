
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
    using CVC.MachineCustomization.Entities;

    [FormScript("MachineCustomization.ListDisplay")]
    [BasedOnRow(typeof(Entities.ListDisplayRow))]
    public class ListDisplayForm
    {
        [Category("Name")]
        [LabelWidth(190)]
        public String ListDisplayName { get; set; }
        [Category("Appearance")]
        [Visible(false)]
        public Int32 ListDisplayId { get; set; }
        [LabelWidth(190)]
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
        [NumberInputEditor]
        public Int32 FontSize { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean Checkbox { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean FullRowSelect { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean Gridlines { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean UseWaitCursorOnClick { get; set; }
        [Category("Behavior")]
        [LabelWidth(190)]
        [ActivationValueEditor]
        public Int32 Activation { get; set; }
        [LabelWidth(190), HalfWidth]
        [AlignmentValueEditor]
        public Int32 Alignment { get; set; }
        [LabelWidth(190), HalfWidth]
        [SortTypeValueEditor]
        public Int32 SortingType { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean SortAscDesc { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean MultiSelect { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean AutoResize { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean Collapsible { get; set; }
        //[LookupEditor(typeof(DisplayObjectRow))]
        //public Int32 ViewId { get; set; }
    }
}
using CVC.Common.CustomEditors;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CVC.MachineCustomization.Forms
{
    [FormScript("MachineCustomization.ListDisplayEditor")]
    [BasedOnRow(typeof(Entities.ListDisplayRow), CheckNames =true)]
    public class ListDisplayEditorForm
    {
        [Category("Appearance")]
        [LabelWidth(190)]
        [ColorPickerEditor]
        public String BackgroundColor { get; set; }
        [LabelWidth(190), HalfWidth]
        [BorderStyleValueEditor]
        public Int32 BorderStyle { get; set; }
        [LabelWidth(190), HalfWidth]
        public String Font { get; set; }
        [LabelWidth(190), HalfWidth]
        [ColorPickerEditor]
        public String FontColor { get; set; }
        [LabelWidth(190), HalfWidth]
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
    }
}
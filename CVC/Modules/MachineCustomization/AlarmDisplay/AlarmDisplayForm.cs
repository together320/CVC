
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

    [FormScript("MachineCustomization.AlarmDisplay")]
    [BasedOnRow(typeof(Entities.AlarmDisplayRow), CheckNames = true)]
    public class AlarmDisplayForm
    {
        [Category("Name")]
        [LabelWidth(190)]
        public String AlarmDisplayName { get; set; }
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
        public String FontColorSelected { get; set; }
        [LabelWidth(190), HalfWidth]
        [ColorPickerEditor]
        public String FontColorUnselected { get; set; }
        [LabelWidth(190), HalfWidth]
        [ColorPickerEditor]
        public String CautionColor { get; set; }
        [LabelWidth(190), HalfWidth]
        [ColorPickerEditor]
        public String WarningColor { get; set; }
        [LabelWidth(190), HalfWidth]
        [ColorPickerEditor]
        public String EmergencyColor { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsCheckbox { get; set; }
        [Category("Behavior")]
        [LabelWidth(190), HalfWidth]
        [ActivationValueEditor]
        public Int32 Activation { get; set; }
        [LabelWidth(190), HalfWidth]
        [AppearanceValueEditor]
        public Int32 Appearance { get; set; }
        [LabelWidth(190), HalfWidth]
        [AlignmentValueEditor]
        public Int32 Alignment { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsOpenInNewWindow { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsTooltip { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsHorizontalScrollBar { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsVerticalScrollBar { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsFolderBrowse { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsAddAttachments { get; set; }
        [LabelWidth(190), HalfWidth]
        public Boolean IsCollapsible { get; set; }
    }
}
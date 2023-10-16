
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

    [FormScript("MachineCustomization.DisplayObjectTypeColor")]
    [BasedOnRow(typeof(Entities.DisplayObjectTypeColorRow), CheckNames = true)]
    public class DisplayObjectTypeColorForm
    {
        [ColorPickerEditor]
        public String DotColor { get; set; }
        [NumberInputEditor]
        public Double Min { get; set; }
        [NumberInputEditor]
        public Double Max { get; set; }
        public Int32 DisplayObjectTypeId { get; set; }
        public Int32 SubTypeId { get; set; }
    }
}
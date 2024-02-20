
namespace CVC.MachineCustomization.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MachineCustomization.DisplayObjectColor")]
    [BasedOnRow(typeof(Entities.DisplayObjectColorRow), CheckNames = true)]
    public class DisplayObjectColorForm
    {
        public Double RangeFrom { get; set; }
        public Double RangeTo { get; set; }
        public String Color { get; set; }
        public Int32 ViewsId { get; set; }
    }
}
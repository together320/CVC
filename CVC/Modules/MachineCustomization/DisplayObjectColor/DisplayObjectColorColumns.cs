
namespace CVC.MachineCustomization.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MachineCustomization.DisplayObjectColor")]
    [BasedOnRow(typeof(Entities.DisplayObjectColorRow), CheckNames = true)]
    public class DisplayObjectColorColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ColorId { get; set; }
        public Double RangeFrom { get; set; }
        public Double RangeTo { get; set; }
        [EditLink]
        public String Color { get; set; }
        public String ViewsViewName { get; set; }
    }
}
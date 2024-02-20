
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

    [ColumnsScript("MachineCustomization.DisplayObjectTypeColor")]
    [BasedOnRow(typeof(Entities.DisplayObjectTypeColorRow), CheckNames = true)]
    public class DisplayObjectTypeColorColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 DotColorId { get; set; }
        [EditLink]
        [ColoredColumnFormatter(BackgroundProperty = "DotColor", HideText = true)]
        public String DotColor { get; set; }
        public Double Min { get; set; }
        public Double Max { get; set; }
        public Int32 DisplayObjectTypeId { get; set; }
        public Int32 SubTypeId { get; set; }
    }
}

namespace CVC.MachineCustomization.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MachineCustomization.ScreenViews")]
    [BasedOnRow(typeof(Entities.ScreenViewsRow), CheckNames = true)]
    public class ScreenViewsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ScreenViewId { get; set; }
        [EditLink]
        public String ScreenViewName { get; set; }
        public String PrimaryRelationshipRelationshipName { get; set; }
        public Boolean IsNoBer { get; set; }
        public String StatusStatusName { get; set; }
        public String CreatedByUsername { get; set; }
        public DateTime CreatedDate { get; set; }
        public String UpdatedByUsername { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
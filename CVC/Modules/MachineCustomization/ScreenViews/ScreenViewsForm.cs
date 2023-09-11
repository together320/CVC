
namespace CVC.MachineCustomization.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MachineCustomization.ScreenViews")]
    [BasedOnRow(typeof(Entities.ScreenViewsRow), CheckNames = true)]
    public class ScreenViewsForm
    {
        public String ScreenViewName { get; set; }
        public Int32 PrimaryRelationshipId { get; set; }
        public Boolean IsNoBer { get; set; }
        public Int32 StatusId { get; set; }
        //public Int32 CreatedBy { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public Int32 UpdatedBy { get; set; }
        //public DateTime UpdatedDate { get; set; }
    }
}

namespace CVC.MachineCustomization.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MachineCustomization.SecondaryRelationship")]
    [BasedOnRow(typeof(Entities.SecondaryRelationshipRow), CheckNames = true)]
    public class SecondaryRelationshipColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 SecondaryRelationshipId { get; set; }
        [QuickFilter, EditLink]
        public String PrimaryRelationshipRelationshipName { get; set; }
        public String PrimaryBeMachineName { get; set; }
        // Added by Denis for RS 8.7 and RS 8.8 dated 9/10/2021
        public String PrimaryEfParameterName { get; set; }
        public String SecondaryBeMachineName { get; set; }
        // Added by Denis for RS 8.7 and RS 8.8 dated 9/10/2021
        public String SecondaryEfParameterName { get; set; }
        public String Description { get; set; }
        //[DisplayName("Created By")]
        //public Int32 CreatedBy { get; set; }
        //[DisplayName("Created Date")]
        //public DateTime CreatedDate { get; set; }
        //[DisplayName("Updated By")]
        //public Int32 UpdatedBy { get; set; }
        //[DisplayName("Updated Date")]
        //public DateTime UpdatedDate { get; set; }
    }
}

namespace CVC.MachineCustomization.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MachineCustomization.PrimaryRelationship")]
    [BasedOnRow(typeof(Entities.PrimaryRelationshipRow), CheckNames = true)]
    public class PrimaryRelationshipColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 PrimaryRelationshipId { get; set; }
        [EditLink]
        public String RelationshipName { get; set; }
        public String PrimaryBeMachineName { get; set; }
        // Added by Denis for RS 8.7 and RS 8.8 dated 9/10/2021
        public String PrimaryEfParameterName { get; set; }
        public String Description { get; set; }
        public String StatusStatusName { get; set; }
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
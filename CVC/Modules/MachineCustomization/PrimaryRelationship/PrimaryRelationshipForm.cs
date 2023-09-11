
namespace CVC.MachineCustomization.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MachineCustomization.PrimaryRelationship")]
    [BasedOnRow(typeof(Entities.PrimaryRelationshipRow), CheckNames = true)]
    public class PrimaryRelationshipForm
    {
        public String RelationshipName { get; set; }
        public Int32 PrimaryBe { get; set; }
        // Added by Denis for RS 8.7 and RS 8.8 dated 9/10/2021
        public Int32 PrimaryEf { get; set; }
        public String Description { get; set; }
        public Int32 Status { get; set; }
    }
}
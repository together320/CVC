
namespace CVC.MachineCustomization.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MachineCustomization.SecondaryRelationship")]
    [BasedOnRow(typeof(Entities.SecondaryRelationshipRow), CheckNames = true)]
    public class SecondaryRelationshipForm
    {
        public Int32 PrimaryRelationshipId { get; set; }
        public Int32 SecondaryBe { get; set; }
        // Added by Denis for RS 8.7 and RS 8.8 dated 9/10/2021
        public Int32 SecondaryEf { get; set; }
        public String Description { get; set; }
    }
}
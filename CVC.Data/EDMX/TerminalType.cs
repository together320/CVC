//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CVC.Data.EDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class TerminalType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TerminalType()
        {
            this.MasterTerminals = new HashSet<MasterTerminal>();
        }
    
        public int TerminalTypeId { get; set; }
        public string TerminalTypeName { get; set; }
        public bool IsActive { get; set; }
        public bool IsRead { get; set; }
        public bool IsWrite { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> EditedBy { get; set; }
        public Nullable<System.DateTime> EditedOn { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterTerminal> MasterTerminals { get; set; }
    }
}

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
    
    public partial class LineMaintenanceSchedule
    {
        public int LineMainSchId { get; set; }
        public Nullable<int> MachineLineId { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public string Description { get; set; }
        public string Remark { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual MachineLine MachineLine { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}

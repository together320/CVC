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
    
    public partial class ViewFieldAccess
    {
        public int ViewFieldAccessId { get; set; }
        public Nullable<int> ViewFieldId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<bool> IsView { get; set; }
        public Nullable<bool> IsModify { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> ViewsId { get; set; }
    
        public virtual Role Role { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ViewField ViewField { get; set; }
    }
}

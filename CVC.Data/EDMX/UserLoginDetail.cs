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
    
    public partial class UserLoginDetail
    {
        public long UserLoginDetailsId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<System.DateTime> LoginDatetime { get; set; }
        public Nullable<System.DateTime> LogoutDatetime { get; set; }
        public Nullable<bool> IsOnline { get; set; }
    
        public virtual User User { get; set; }
    }
}
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
    
    public partial class ViewFieldAuthentication
    {
        public int ViewFieldAuthenticationId { get; set; }
        public int ViewFieldId { get; set; }
        public int RoleId { get; set; }
    
        public virtual Role Role { get; set; }
        public virtual ViewField ViewField { get; set; }
    }
}
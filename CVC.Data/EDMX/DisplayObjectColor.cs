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

    public partial class DisplayObjectColor
    {
        public int ColorId { get; set; }
        public Nullable<double> RangeFrom { get; set; }
        public Nullable<double> RangeTo { get; set; }
        public string Color { get; set; }
        public int ViewsId { get; set; }

        public virtual View View { get; set; }
    }
}

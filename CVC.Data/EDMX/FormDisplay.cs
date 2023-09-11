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
    
    public partial class FormDisplay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormDisplay()
        {
            this.Views = new HashSet<View>();
        }
    
        public int FormDisplayId { get; set; }
        public string FormDisplayName { get; set; }
        public string BackgroundColor { get; set; }
        public Nullable<int> BorderStyle { get; set; }
        public Nullable<bool> IsCheckbox { get; set; }
        public string Font { get; set; }
        public string FontColorSelected { get; set; }
        public string FontColorUnselected { get; set; }
        public Nullable<int> Activation { get; set; }
        public Nullable<int> Alignment { get; set; }
        public Nullable<bool> IsTooltip { get; set; }
        public Nullable<bool> IsHorizontalScrollBar { get; set; }
        public Nullable<bool> IsVerticalScrollBar { get; set; }
        public Nullable<bool> IsCollapsible { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<View> Views { get; set; }
    }
}

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
    
    public partial class View
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public View()
        {
            this.ViewFields = new HashSet<ViewField>();
            this.ViewsAccesses = new HashSet<ViewsAccess>();
            this.ListDisplays = new HashSet<ListDisplay>();
        }
    
        public int ViewsId { get; set; }
        public Nullable<int> ModuleId { get; set; }
        public string ViewName { get; set; }
        public Nullable<bool> IsAccessFieldWise { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsMachineSettings { get; set; }
        public Nullable<bool> IsMachineSummary { get; set; }
        public Nullable<bool> IslabelRoll { get; set; }
        public Nullable<bool> IsCommandPanel { get; set; }
        public Nullable<bool> IsFactorySetting { get; set; }
        public Nullable<int> DisplayObjectTypeId { get; set; }
        public Nullable<int> MachineId { get; set; }
        public Nullable<int> ListDisplayId { get; set; }
        public Nullable<int> FormDisplayId { get; set; }
        public Nullable<int> ButtonDisplayId { get; set; }
        public Nullable<int> RealtimeParameterDisplayId { get; set; }
        public Nullable<int> LineChartDisplayId { get; set; }
        public Nullable<int> PieChartDisplayId { get; set; }
        public Nullable<int> TreeDisplayId { get; set; }
        public Nullable<int> AttachmentDisplayId { get; set; }
        public Nullable<int> AlarmDisplayId { get; set; }
        public Nullable<int> NotificationDisplayId { get; set; }
        public Nullable<int> ContainerDisplayId { get; set; }
    
        public virtual Module Module { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ViewField> ViewFields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ViewsAccess> ViewsAccesses { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual ListDisplay ListDisplay { get; set; }
        public virtual FormDisplay FormDisplay { get; set; }
        public virtual ButtonDisplay ButtonDisplay { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListDisplay> ListDisplays { get; set; }
        public virtual View Views1 { get; set; }
        public virtual View View1 { get; set; }
    }
}

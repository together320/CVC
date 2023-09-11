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
    
    public partial class BatchMachineWise
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BatchMachineWise()
        {
            this.BatchRecipeModifies = new HashSet<BatchRecipeModify>();
            this.BatchRunDatas = new HashSet<BatchRunData>();
        }
    
        public int BatchMachineId { get; set; }
        public Nullable<int> MachineId { get; set; }
        public Nullable<int> BatchId { get; set; }
        public Nullable<int> RecipeId { get; set; }
        public Nullable<bool> IsMachineInUse { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual Batch Batch { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual MachineRecipe MachineRecipe { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchRecipeModify> BatchRecipeModifies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchRunData> BatchRunDatas { get; set; }
    }
}
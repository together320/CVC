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
    
    public partial class MachineRecipeParameter
    {
        public long MachineRecipeParameterId { get; set; }
        public Nullable<int> MachineRecipeId { get; set; }
        public Nullable<int> RecipeSettingsParameterId { get; set; }
        public string RecipeParameterValue { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string MachineParameterValue { get; set; }
        public Nullable<int> MachineParameterId { get; set; }
    
        public virtual MachineParameter MachineParameter { get; set; }
        public virtual MachineRecipe MachineRecipe { get; set; }
        public virtual RecipeSettingsParameter RecipeSettingsParameter { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}

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
    
    public partial class MachineParameter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MachineParameter()
        {
            this.Alarms = new HashSet<Alarm>();
            this.Alarms1 = new HashSet<Alarm>();
            this.BatchSettings = new HashSet<BatchSetting>();
            this.BatchSettings1 = new HashSet<BatchSetting>();
            this.BatchSettings2 = new HashSet<BatchSetting>();
            this.BatchSettings3 = new HashSet<BatchSetting>();
            this.BatchSettings4 = new HashSet<BatchSetting>();
            this.BatchSettings5 = new HashSet<BatchSetting>();
            this.IPCParameters = new HashSet<IPCParameter>();
            this.MachineParameter1 = new HashSet<MachineParameter>();
            this.MachineParameter11 = new HashSet<MachineParameter>();
            this.MachineParameter12 = new HashSet<MachineParameter>();
            this.MachineRecipeParameters = new HashSet<MachineRecipeParameter>();
            this.ViewFields = new HashSet<ViewField>();
        }
    
        public int MachineParameterId { get; set; }
        public Nullable<int> MachineId { get; set; }
        public string ParameterName { get; set; }
        public string PLCAddress { get; set; }
        public string Description { get; set; }
        public Nullable<int> DataTypeId { get; set; }
        public Nullable<bool> IsRangeUnlimited { get; set; }
        public Nullable<decimal> Min { get; set; }
        public Nullable<decimal> Max { get; set; }
        public Nullable<bool> IsUseUnit { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<bool> IsRead { get; set; }
        public Nullable<bool> IsWrite { get; set; }
        public Nullable<int> RowId { get; set; }
        public Nullable<bool> IsBitWise { get; set; }
        public Nullable<int> BitWiseIndex { get; set; }
        public Nullable<int> QueryTypeRowId { get; set; }
        public Nullable<int> OperationType { get; set; }
        public Nullable<decimal> OperationValue { get; set; }
        public Nullable<bool> Is32Bit { get; set; }
        public Nullable<int> Bit32RowId { get; set; }
        public Nullable<bool> IsStopAt { get; set; }
        public Nullable<int> ReadMachineParameterId { get; set; }
        public Nullable<int> ReloadMachineParameterId { get; set; }
        public Nullable<bool> IsShowAsMessage { get; set; }
        public Nullable<bool> IsBatchStartRequired { get; set; }
        public Nullable<bool> IsResetOnBatchCreate { get; set; }
        public Nullable<bool> IsLabelRoll { get; set; }
        public Nullable<int> DisableParameterId { get; set; }
        public string DisableParameterValue { get; set; }
        public Nullable<bool> AllowDecimalPoint { get; set; }
        public Nullable<bool> IsStopOnBatchStop { get; set; }
        public string RecordAddedSource { get; set; }
        public string ColumnName { get; set; }
        public Nullable<int> PickListId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alarm> Alarms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alarm> Alarms1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchSetting> BatchSettings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchSetting> BatchSettings1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchSetting> BatchSettings2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchSetting> BatchSettings3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchSetting> BatchSettings4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchSetting> BatchSettings5 { get; set; }
        public virtual DataType DataType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPCParameter> IPCParameters { get; set; }
        public virtual Machine Machine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachineParameter> MachineParameter1 { get; set; }
        public virtual MachineParameter MachineParameter2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachineParameter> MachineParameter11 { get; set; }
        public virtual MachineParameter MachineParameter3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachineParameter> MachineParameter12 { get; set; }
        public virtual MachineParameter MachineParameter4 { get; set; }
        public virtual PickListValue PickListValue { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachineRecipeParameter> MachineRecipeParameters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ViewField> ViewFields { get; set; }
        public virtual PickList PickList { get; set; }
    }
}

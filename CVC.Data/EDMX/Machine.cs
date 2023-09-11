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
    
    public partial class Machine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Machine()
        {
            this.Alarms = new HashSet<Alarm>();
            this.AlarmLogs = new HashSet<AlarmLog>();
            this.AlarmLogArchives = new HashSet<AlarmLogArchive>();
            this.AuditLogs = new HashSet<AuditLog>();
            this.AuditLogArchives = new HashSet<AuditLogArchive>();
            this.BatchLogs = new HashSet<BatchLog>();
            this.BatchMachineWises = new HashSet<BatchMachineWise>();
            this.IPCParameters = new HashSet<IPCParameter>();
            this.LabelReconciliations = new HashSet<LabelReconciliation>();
            this.LabelRolls = new HashSet<LabelRoll>();
            this.MachineCommunications = new HashSet<MachineCommunication>();
            this.MachineHelpFiles = new HashSet<MachineHelpFile>();
            this.MachineHistories = new HashSet<MachineHistory>();
            this.MachineMaintenanceSchedules = new HashSet<MachineMaintenanceSchedule>();
            this.MachineParameters = new HashSet<MachineParameter>();
            this.MachineRecipes = new HashSet<MachineRecipe>();
            this.MachineSpareParts = new HashSet<MachineSparePart>();
            this.MachineSpecifications = new HashSet<MachineSpecification>();
            this.MachineUsers = new HashSet<MachineUser>();
            this.MachineVideos = new HashSet<MachineVideo>();
            this.Modules = new HashSet<Module>();
            this.RecipeSettings = new HashSet<RecipeSetting>();
            this.TerminalMachineMappings = new HashSet<TerminalMachineMapping>();
            this.Views = new HashSet<View>();
        }
    
        public int MachineId { get; set; }
        public Nullable<int> MachineLineId { get; set; }
        public string MachineName { get; set; }
        public string ModelNumber { get; set; }
        public string SerialNumber { get; set; }
        public string Make { get; set; }
        public Nullable<int> Year { get; set; }
        public string PlcMake { get; set; }
        public string PlcModelNumber { get; set; }
        public string PlcSerialNumber { get; set; }
        public string PLCAddress { get; set; }
        public string AccessIPAddress { get; set; }
        public Nullable<int> MachineSequence { get; set; }
        public byte[] MachineImage { get; set; }
        public Nullable<int> MachineTypeID { get; set; }
        public Nullable<int> StatusId { get; set; }
        public string Description { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string EquipmentID { get; set; }
        public Nullable<int> TimerForAlarm { get; set; }
        public Nullable<bool> isactive { get; set; }
        public Nullable<bool> IsShowStatistics { get; set; }
        public string RecordAddedSource { get; set; }
        public Nullable<bool> IsRealTime { get; set; }
        public Nullable<int> TableId { get; set; }
        public string TableName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alarm> Alarms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlarmLog> AlarmLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlarmLogArchive> AlarmLogArchives { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuditLog> AuditLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuditLogArchive> AuditLogArchives { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchLog> BatchLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchMachineWise> BatchMachineWises { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPCParameter> IPCParameters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LabelReconciliation> LabelReconciliations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LabelRoll> LabelRolls { get; set; }
        public virtual MachineLine MachineLine { get; set; }
        public virtual MachineType MachineType { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachineCommunication> MachineCommunications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachineHelpFile> MachineHelpFiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachineHistory> MachineHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachineMaintenanceSchedule> MachineMaintenanceSchedules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachineParameter> MachineParameters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachineRecipe> MachineRecipes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachineSparePart> MachineSpareParts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachineSpecification> MachineSpecifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachineUser> MachineUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachineVideo> MachineVideos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Module> Modules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecipeSetting> RecipeSettings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TerminalMachineMapping> TerminalMachineMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<View> Views { get; set; }
    }
}

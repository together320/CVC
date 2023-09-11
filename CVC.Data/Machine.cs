// Decompiled with JetBrains decompiler
// Type: CVC.Data.Machine
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class Machine
  {
    public Machine()
    {
      this.Alarms = (ICollection<Alarm>) new HashSet<Alarm>();
      this.AlarmLogs = (ICollection<AlarmLog>) new HashSet<AlarmLog>();
      this.AuditLogs = (ICollection<AuditLog>) new HashSet<AuditLog>();
      this.BatchLogs = (ICollection<BatchLog>) new HashSet<BatchLog>();
      this.BatchMachineWises = (ICollection<BatchMachineWise>) new HashSet<BatchMachineWise>();
      this.IPCParameters = (ICollection<IPCParameter>) new HashSet<IPCParameter>();
      this.LabelReconciliations = (ICollection<LabelReconciliation>) new HashSet<LabelReconciliation>();
      this.LabelRolls = (ICollection<LabelRoll>) new HashSet<LabelRoll>();
      this.MachineCommunications = (ICollection<MachineCommunication>) new HashSet<MachineCommunication>();
      this.MachineHelpFiles = (ICollection<MachineHelpFile>) new HashSet<MachineHelpFile>();
      this.MachineHistories = (ICollection<MachineHistory>) new HashSet<MachineHistory>();
      this.MachineMaintenanceSchedules = (ICollection<MachineMaintenanceSchedule>) new HashSet<MachineMaintenanceSchedule>();
      this.MachineParameters = (ICollection<MachineParameter>) new HashSet<MachineParameter>();
      this.MachineRecipes = (ICollection<MachineRecipe>) new HashSet<MachineRecipe>();
      this.MachineSpareParts = (ICollection<MachineSparePart>) new HashSet<MachineSparePart>();
      this.MachineSpecifications = (ICollection<MachineSpecification>) new HashSet<MachineSpecification>();
      this.MachineUsers = (ICollection<MachineUser>) new HashSet<MachineUser>();
      this.MachineVideos = (ICollection<MachineVideo>) new HashSet<MachineVideo>();
      this.Modules = (ICollection<Module>) new HashSet<Module>();
      this.RecipeSettings = (ICollection<RecipeSetting>) new HashSet<RecipeSetting>();
    }

    public int MachineId { get; set; }

    public int? MachineLineId { get; set; }

    public string MachineName { get; set; }

    public string ModelNumber { get; set; }

    public string SerialNumber { get; set; }

    public string Make { get; set; }

    public int? Year { get; set; }

    public string PlcMake { get; set; }

    public string PlcModelNumber { get; set; }

    public string PlcSerialNumber { get; set; }

    public string PLCAddress { get; set; }

    public string AccessIPAddress { get; set; }

    public int? MachineSequence { get; set; }

    public string MachineImage { get; set; }

    public int? MachineTypeID { get; set; }

    public int? StatusId { get; set; }

    public string Description { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<Alarm> Alarms { get; set; }

    public virtual ICollection<AlarmLog> AlarmLogs { get; set; }

    public virtual ICollection<AuditLog> AuditLogs { get; set; }

    public virtual ICollection<BatchLog> BatchLogs { get; set; }

    public virtual ICollection<BatchMachineWise> BatchMachineWises { get; set; }

    public virtual ICollection<IPCParameter> IPCParameters { get; set; }

    public virtual ICollection<LabelReconciliation> LabelReconciliations { get; set; }

    public virtual ICollection<LabelRoll> LabelRolls { get; set; }

    public virtual MachineLine MachineLine { get; set; }

    public virtual MachineType MachineType { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }

    public virtual ICollection<MachineCommunication> MachineCommunications { get; set; }

    public virtual ICollection<MachineHelpFile> MachineHelpFiles { get; set; }

    public virtual ICollection<MachineHistory> MachineHistories { get; set; }

    public virtual ICollection<MachineMaintenanceSchedule> MachineMaintenanceSchedules { get; set; }

    public virtual ICollection<MachineParameter> MachineParameters { get; set; }

    public virtual ICollection<MachineRecipe> MachineRecipes { get; set; }

    public virtual ICollection<MachineSparePart> MachineSpareParts { get; set; }

    public virtual ICollection<MachineSpecification> MachineSpecifications { get; set; }

    public virtual ICollection<MachineUser> MachineUsers { get; set; }

    public virtual ICollection<MachineVideo> MachineVideos { get; set; }

    public virtual ICollection<Module> Modules { get; set; }

    public virtual ICollection<RecipeSetting> RecipeSettings { get; set; }
  }
}

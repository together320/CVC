// Decompiled with JetBrains decompiler
// Type: CVC.Data.Batch
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class Batch
  {
    public Batch()
    {
      this.AlarmLogs = (ICollection<AlarmLog>) new HashSet<AlarmLog>();
      this.AuditLogs = (ICollection<AuditLog>) new HashSet<AuditLog>();
      this.BatchLogs = (ICollection<BatchLog>) new HashSet<BatchLog>();
      this.BatchMachineWises = (ICollection<BatchMachineWise>) new HashSet<BatchMachineWise>();
      this.LabelReconciliations = (ICollection<LabelReconciliation>) new HashSet<LabelReconciliation>();
      this.LabelRolls = (ICollection<LabelRoll>) new HashSet<LabelRoll>();
    }

    public int BatchId { get; set; }

    public string BatchName { get; set; }

    public int? PackId { get; set; }

    public DateTime? BatchStartDateTime { get; set; }

    public DateTime? BatchEndDateTime { get; set; }

    public int? MachineLineId { get; set; }

    public string BatchStatus { get; set; }

    public int? BatchSize { get; set; }

    public int? BatchFor { get; set; }

    public int? NumberOfBottles { get; set; }

    public int? TotalGoodBottles { get; set; }

    public int? TotalRejectedBottles { get; set; }

    public string ProductionSpeed { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<AlarmLog> AlarmLogs { get; set; }

    public virtual ICollection<AuditLog> AuditLogs { get; set; }

    public virtual MachineLine MachineLine { get; set; }

    public virtual Pack Pack { get; set; }

    public virtual PickListValue PickListValue { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }

    public virtual ICollection<BatchLog> BatchLogs { get; set; }

    public virtual ICollection<BatchMachineWise> BatchMachineWises { get; set; }

    public virtual ICollection<LabelReconciliation> LabelReconciliations { get; set; }

    public virtual ICollection<LabelRoll> LabelRolls { get; set; }
  }
}

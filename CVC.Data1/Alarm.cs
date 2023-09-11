// Decompiled with JetBrains decompiler
// Type: CVC.Data.Alarm
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class Alarm
  {
    public Alarm()
    {
      this.AlarmResetIds = (ICollection<AlarmResetId>) new HashSet<AlarmResetId>();
      this.AlarmLogs = (ICollection<AlarmLog>) new HashSet<AlarmLog>();
    }

    public int AlarmId { get; set; }

    public string AlarmName { get; set; }

    public int? MachineId { get; set; }

    public int? IPCParameterId { get; set; }

    public string Message { get; set; }

    public string Description { get; set; }

    public bool? IsResetRequired { get; set; }

    public bool? IsCommentRequired { get; set; }

    public bool? IsMachineRequiredToStop { get; set; }

    public int? MachineStopIPCParameterId { get; set; }

    public bool? BitValue { get; set; }

    public bool? IsCheckAtMachineStart { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual IPCParameter IPCParameter { get; set; }

    public virtual Machine Machine { get; set; }

    public virtual IPCParameter IPCParameter1 { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }

    public virtual ICollection<AlarmResetId> AlarmResetIds { get; set; }

    public virtual ICollection<AlarmLog> AlarmLogs { get; set; }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Data.IPCParameter
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class IPCParameter
  {
    public IPCParameter()
    {
      this.Alarms = (ICollection<Alarm>) new HashSet<Alarm>();
      this.Alarms1 = (ICollection<Alarm>) new HashSet<Alarm>();
      this.BatchRunDatas = (ICollection<BatchRunData>) new HashSet<BatchRunData>();
      this.RecipeSettingsParameters = (ICollection<RecipeSettingsParameter>) new HashSet<RecipeSettingsParameter>();
      this.ScreenFields = (ICollection<ScreenField>) new HashSet<ScreenField>();
    }

    public int IPCParameterId { get; set; }

    public int? MachineId { get; set; }

    public string IPCParameterName { get; set; }

    public int? MachineParameterId { get; set; }

    public string IPCAddress { get; set; }

    public bool? IsChangeInRuntime { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<Alarm> Alarms { get; set; }

    public virtual ICollection<Alarm> Alarms1 { get; set; }

    public virtual ICollection<BatchRunData> BatchRunDatas { get; set; }

    public virtual Machine Machine { get; set; }

    public virtual MachineParameter MachineParameter { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }

    public virtual ICollection<RecipeSettingsParameter> RecipeSettingsParameters { get; set; }

    public virtual ICollection<ScreenField> ScreenFields { get; set; }
  }
}

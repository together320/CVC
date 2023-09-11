// Decompiled with JetBrains decompiler
// Type: CVC.Data.PickListValue
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class PickListValue
  {
    public PickListValue()
    {
      this.Batches = (ICollection<Batch>) new HashSet<Batch>();
      this.Bottles = (ICollection<Bottle>) new HashSet<Bottle>();
      this.Caps = (ICollection<Cap>) new HashSet<Cap>();
      this.Cotton = (ICollection<CVC.Data.Cotton>) new HashSet<CVC.Data.Cotton>();
      this.DataTypes = (ICollection<DataType>) new HashSet<DataType>();
      this.Desiccants = (ICollection<Desiccant>) new HashSet<Desiccant>();
      this.LabelLosts = (ICollection<LabelLost>) new HashSet<LabelLost>();
      this.MachineHistories = (ICollection<MachineHistory>) new HashSet<MachineHistory>();
      this.MachineParameters = (ICollection<MachineParameter>) new HashSet<MachineParameter>();
      this.PickListValueRoleAccesses = (ICollection<PickListValueRoleAccess>) new HashSet<PickListValueRoleAccess>();
      this.PLCParameters = (ICollection<PLCParameter>) new HashSet<PLCParameter>();
      this.TabletDetails = (ICollection<TabletDetail>) new HashSet<TabletDetail>();
      this.TabletDetails1 = (ICollection<TabletDetail>) new HashSet<TabletDetail>();
      this.TabletDetails2 = (ICollection<TabletDetail>) new HashSet<TabletDetail>();
    }

    public int PickListValueId { get; set; }

    public int? PickListId { get; set; }

    public string PickListValueName { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<Batch> Batches { get; set; }

    public virtual ICollection<Bottle> Bottles { get; set; }

    public virtual ICollection<Cap> Caps { get; set; }

    public virtual ICollection<CVC.Data.Cotton> Cotton { get; set; }

    public virtual ICollection<DataType> DataTypes { get; set; }

    public virtual ICollection<Desiccant> Desiccants { get; set; }

    public virtual ICollection<LabelLost> LabelLosts { get; set; }

    public virtual ICollection<MachineHistory> MachineHistories { get; set; }

    public virtual ICollection<MachineParameter> MachineParameters { get; set; }

    public virtual PickList PickList { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }

    public virtual ICollection<PickListValueRoleAccess> PickListValueRoleAccesses { get; set; }

    public virtual ICollection<PLCParameter> PLCParameters { get; set; }

    public virtual ICollection<TabletDetail> TabletDetails { get; set; }

    public virtual ICollection<TabletDetail> TabletDetails1 { get; set; }

    public virtual ICollection<TabletDetail> TabletDetails2 { get; set; }
  }
}

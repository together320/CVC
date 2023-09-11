// Decompiled with JetBrains decompiler
// Type: CVC.Data.MachineParameter
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class MachineParameter
  {
    public MachineParameter()
    {
      this.IPCParameters = (ICollection<IPCParameter>) new HashSet<IPCParameter>();
    }

    public int MachineParameterId { get; set; }

    public int? MachineId { get; set; }

    public string ParameterName { get; set; }

    public string PLCAddress { get; set; }

    public string Description { get; set; }

    public int? DataTypeId { get; set; }

    public bool? IsRangeUnlimited { get; set; }

    public Decimal? Min { get; set; }

    public Decimal? Max { get; set; }

    public bool? IsUseUnit { get; set; }

    public int? UnitId { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual DataType DataType { get; set; }

    public virtual ICollection<IPCParameter> IPCParameters { get; set; }

    public virtual Machine Machine { get; set; }

    public virtual PickListValue PickListValue { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }
  }
}

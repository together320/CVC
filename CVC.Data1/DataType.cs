﻿// Decompiled with JetBrains decompiler
// Type: CVC.Data.DataType
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class DataType
  {
    public DataType()
    {
      this.MachineParameters = (ICollection<MachineParameter>) new HashSet<MachineParameter>();
      this.PLCParameters = (ICollection<PLCParameter>) new HashSet<PLCParameter>();
    }

    public int DataTypeId { get; set; }

    public string DataTypeName { get; set; }

    public int? TypeId { get; set; }

    public int? Bit { get; set; }

    public bool? isSigned { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual PickListValue PickListValue { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }

    public virtual ICollection<MachineParameter> MachineParameters { get; set; }

    public virtual ICollection<PLCParameter> PLCParameters { get; set; }
  }
}

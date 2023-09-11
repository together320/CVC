// Decompiled with JetBrains decompiler
// Type: CVC.Data.PLC
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System.Collections.Generic;

namespace CVC.Data
{
  public class PLC
  {
    public PLC()
    {
      this.PLCParameters = (ICollection<PLCParameter>) new HashSet<PLCParameter>();
    }

    public int PlcId { get; set; }

    public int? MachineTypeId { get; set; }

    public string PlcName { get; set; }

    public virtual MachineType MachineType { get; set; }

    public virtual ICollection<PLCParameter> PLCParameters { get; set; }
  }
}

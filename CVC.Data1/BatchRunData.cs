// Decompiled with JetBrains decompiler
// Type: CVC.Data.BatchRunData
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;

namespace CVC.Data
{
  public class BatchRunData
  {
    public long BatchRunDataId { get; set; }

    public int? BatchMachineWiseId { get; set; }

    public int? IPCParameterId { get; set; }

    public string IPCParameterValue { get; set; }

    public DateTime? UpdatedDateTime { get; set; }

    public int? LoggedInUser { get; set; }

    public virtual BatchMachineWise BatchMachineWise { get; set; }

    public virtual IPCParameter IPCParameter { get; set; }

    public virtual User User { get; set; }
  }
}

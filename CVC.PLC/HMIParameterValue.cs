// Decompiled with JetBrains decompiler
// Type: CVC.PLC.HMIParameterValue
// Assembly: CVC.PLC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FFB0FA40-B101-48D7-B75E-43CA22888CCD
// Assembly location: D:\Anil\CVC\bin\CVC.PLC.dll

using System;

namespace CVC.PLC
{
  public class HMIParameterValue
  {
    public int Id { get; set; }

    public int MachineId { get; set; }

    public int HMIParameterId { get; set; }

    public string ParameterValue { get; set; }

    public DateTime FetchedDate { get; set; }
  }
}

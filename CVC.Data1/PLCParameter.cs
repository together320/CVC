// Decompiled with JetBrains decompiler
// Type: CVC.Data.PLCParameter
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

namespace CVC.Data
{
  public class PLCParameter
  {
    public int PlcParameterId { get; set; }

    public int? PLCId { get; set; }

    public string ParameterName { get; set; }

    public string PLCAddress { get; set; }

    public int? DataTypeId { get; set; }

    public bool? IsUnit { get; set; }

    public int? UnitId { get; set; }

    public virtual DataType DataType { get; set; }

    public virtual PickListValue PickListValue { get; set; }

    public virtual PLC PLC { get; set; }
  }
}

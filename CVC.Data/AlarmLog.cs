// Decompiled with JetBrains decompiler
// Type: CVC.Data.AlarmLog
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;

namespace CVC.Data
{
  public class AlarmLog
  {
    public long AlarmLogId { get; set; }

    public int? MachineId { get; set; }

    public int? AlarmId { get; set; }

    public int? BatchId { get; set; }

    public int? LoggedUserId { get; set; }

    public string Comment { get; set; }

    public string Description { get; set; }

    public DateTime? AlarmDateTime { get; set; }

    public string PCIPAddress { get; set; }

    public virtual Alarm Alarm { get; set; }

    public virtual Batch Batch { get; set; }

    public virtual Machine Machine { get; set; }

    public virtual User User { get; set; }
  }
}

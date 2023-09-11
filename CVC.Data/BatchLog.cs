// Decompiled with JetBrains decompiler
// Type: CVC.Data.BatchLog
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;

namespace CVC.Data
{
  public class BatchLog
  {
    public long BatchLogId { get; set; }

    public int? MachineId { get; set; }

    public int? BatchId { get; set; }

    public string Description { get; set; }

    public int? UserId { get; set; }

    public DateTime? UpdatedDateTime { get; set; }

    public virtual Batch Batch { get; set; }

    public virtual Machine Machine { get; set; }

    public virtual User User { get; set; }
  }
}

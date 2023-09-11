// Decompiled with JetBrains decompiler
// Type: CVC.Data.AuditLog
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;

namespace CVC.Data
{
  public class AuditLog
  {
    public long AuditLogId { get; set; }

    public int? UserId { get; set; }

    public string UserName { get; set; }

    public string Action { get; set; }

    public DateTime? ChangedOn { get; set; }

    public string TableName { get; set; }

    public int? RowId { get; set; }

    public string Module { get; set; }

    public string Page { get; set; }

    public string FieldName { get; set; }

    public string OldValue { get; set; }

    public string NewValue { get; set; }

    public string Comments { get; set; }

    public string PCIPAddress { get; set; }

    public int? BatchId { get; set; }

    public string BatchName { get; set; }

    public int? MachineId { get; set; }

    public string MachineName { get; set; }

    public virtual Batch Batch { get; set; }

    public virtual Machine Machine { get; set; }

    public virtual User User { get; set; }
  }
}

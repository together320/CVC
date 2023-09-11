// Decompiled with JetBrains decompiler
// Type: CVC.Report.Forms.AuditLogForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Report.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.Report.Forms
{
  [FormScript("Report.AuditLog")]
  [BasedOnRow(typeof (AuditLogRow))]
  public class AuditLogForm
  {
    public int UserId { get; set; }

    public string UserName { get; set; }

    public string Action { get; set; }
       
    public DateTime ChangedOn { get; set; }

    public string TableName { get; set; }

    public int RowId { get; set; }

    public string Module { get; set; }

    public string Page { get; set; }

    public string FieldName { get; set; }

    public string OldValue { get; set; }

    public string NewValue { get; set; }

    public string Comments { get; set; }

    public string PcipAddress { get; set; }

    public int BatchId { get; set; }
      
    [DisplayName("Batch Number")]
    public string BatchName { get; set; }

    public int MachineId { get; set; }

    public string MachineName { get; set; }
  }
}

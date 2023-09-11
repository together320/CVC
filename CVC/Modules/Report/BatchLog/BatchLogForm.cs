// Decompiled with JetBrains decompiler
// Type: CVC.Report.Forms.BatchLogForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Report.Entities;
using Serenity.ComponentModel;
using System;

namespace CVC.Report.Forms
{
  [FormScript("Report.BatchLog")]
  [BasedOnRow(typeof (BatchLogRow))]
  public class BatchLogForm
  {
    public int MachineId { get; set; }

    public int BatchId { get; set; }

    public string Description { get; set; }

    public int UserId { get; set; }

    public DateTime UpdatedDateTime { get; set; }
        //public string BatchVersion { get; set; }

    }
}

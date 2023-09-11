// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Forms.BatchRunDataForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using Serenity.ComponentModel;
using System;

namespace CVC.Batch.Forms
{
  [FormScript("Batch.BatchRunData")]
  [BasedOnRow(typeof (BatchRunDataRow))]
  public class BatchRunDataForm
  {
    public int BatchMachineWiseId { get; set; }

    public int IpcParameterId { get; set; }

    public string IpcParameterValue { get; set; }

    public DateTime UpdatedDateTime { get; set; }

    public int LoggedInUser { get; set; }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Batch.Forms.BatchMachineWiseForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Batch.Entities;
using Serenity.ComponentModel;
using System;

namespace CVC.Batch.Forms
{
  [FormScript("Batch.BatchMachineWise")]
  [BasedOnRow(typeof (BatchMachineWiseRow))]
  public class BatchMachineWiseForm
  {
    public int MachineId { get; set; }

    public int BatchId { get; set; }

    public int RecipeId { get; set; }

    public short IsMachineInUse { get; set; }

    public int StatusId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Data.Pack
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class Pack
  {
    public Pack()
    {
      this.Batches = (ICollection<Batch>) new HashSet<Batch>();
    }

    public int PackId { get; set; }

    public string PackName { get; set; }

    public int? TabletId { get; set; }

    public int? TabletCount { get; set; }

    public int? BottleId { get; set; }

    public int? CapId { get; set; }

    public int? CottonId { get; set; }

    public string CottonLength { get; set; }

    public int? NumberOfCottonPieces { get; set; }

    public int? DesiccantId { get; set; }

    public int? NumberOfDesicantPieces { get; set; }

    public int? OutsertId { get; set; }

    public int? LabelId { get; set; }

    public int? StatusId { get; set; }

    public int? EndOfLineId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<Batch> Batches { get; set; }

    public virtual Bottle Bottle { get; set; }

    public virtual Cap Cap { get; set; }

    public virtual Cotton Cotton { get; set; }

    public virtual Desiccant Desiccant { get; set; }

    public virtual EndOfLine EndOfLine { get; set; }

    public virtual Label Label { get; set; }

    public virtual Outsert Outsert { get; set; }

    public virtual Status Status { get; set; }

    public virtual TabletDetail TabletDetail { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Data.BatchDTO
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll
//na4oct2018
using System;

namespace CVC.Data
{
  public class BatchDTO
  {
    public int BatchId { get; set; }

    public string BatchName { get; set; }

    public int? PackId { get; set; }

    public DateTime? BatchStartDateTime { get; set; }

    public DateTime? BatchEndDateTime { get; set; }

    public int? MachineLineId { get; set; }

    public string BatchStatus { get; set; }

    public int? BatchSize { get; set; }

    public int? BatchFor { get; set; }

    public int? NumberOfBottles { get; set; }

    public int? TotalGoodBottles { get; set; }

    public int? TotalRejectedBottles { get; set; }

    public string ProductionSpeed { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

        public string PackageLine { get; set; }

        public DateTime? UpdatedDate { get; set; }

    public PackDTO Pack { get; set; }
        public string lblBottle { get; set; }
  }
}

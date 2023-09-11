// Decompiled with JetBrains decompiler
// Type: CVC.Data.EndOfLine
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class EndOfLine
  {
    public EndOfLine()
    {
      this.Packs = (ICollection<Pack>) new HashSet<Pack>();
    }

    public int EndOfLineId { get; set; }

    public string EndOfLineName { get; set; }

    public string CartonLength { get; set; }

    public string CartonHeight { get; set; }

    public string CartonWidth { get; set; }

    public string CartonType { get; set; }

    public string BottleConfiguration { get; set; }

    public string MedicationLength { get; set; }

    public string MedicationWidth { get; set; }

    public string NoOfMedication { get; set; }

    public string InnerShipperBoxType { get; set; }

    public string InnerShipperBoxLength { get; set; }

    public string InnerShipperBoxWidth { get; set; }

    public string InnerShipperBoxHeight { get; set; }

    public string OuterShipperBoxLength { get; set; }

    public string OuterShipperBoxWidth { get; set; }

    public string OuterShipperBoxHeight { get; set; }

    public string InnerShipperMatrix { get; set; }

    public string OuterShipperQuantity { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }

    public virtual ICollection<Pack> Packs { get; set; }
  }
}

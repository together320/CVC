// Decompiled with JetBrains decompiler
// Type: CVC.Data.Bottle
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class Bottle
  {
    public Bottle()
    {
      this.Packs = (ICollection<Pack>) new HashSet<Pack>();
    }

    public int BottleId { get; set; }

    public string BottleName { get; set; }

    public string BottleCC { get; set; }

    public int? ContainerTypeId { get; set; }

    public string BottleHeight { get; set; }

    public string BottleDiameter { get; set; }

    public string BottleMouthOpening_ID { get; set; }

    public string BottleMouthOpening_OD { get; set; }

    public int? SupplierId { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual PickListValue PickListValue { get; set; }

    public virtual Status Status { get; set; }

    public virtual Supplier Supplier { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }

    public virtual ICollection<Pack> Packs { get; set; }
  }
}

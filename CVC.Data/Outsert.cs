﻿// Decompiled with JetBrains decompiler
// Type: CVC.Data.Outsert
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class Outsert
  {
    public Outsert()
    {
      this.Packs = (ICollection<Pack>) new HashSet<Pack>();
    }

    public int OutsertId { get; set; }

    public string OutsertName { get; set; }

    public string OutsertLength { get; set; }

    public string OutsertWidth { get; set; }

    public string OutsertThickness { get; set; }

    public int? SupplierId { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Status Status { get; set; }

    public virtual Supplier Supplier { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }

    public virtual ICollection<Pack> Packs { get; set; }
  }
}

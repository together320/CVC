// Decompiled with JetBrains decompiler
// Type: CVC.Data.Supplier
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class Supplier
  {
    public Supplier()
    {
      this.Caps = (ICollection<Cap>) new HashSet<Cap>();
      this.Cotton = (ICollection<CVC.Data.Cotton>) new HashSet<CVC.Data.Cotton>();
      this.Desiccants = (ICollection<Desiccant>) new HashSet<Desiccant>();
      this.Labels = (ICollection<Label>) new HashSet<Label>();
    }

    public int SupplierId { get; set; }

    public string SupplierName { get; set; }

    public string SupplierAddress { get; set; }

    public int? CityId { get; set; }

    public string PinCode { get; set; }

    public int? MobileCode { get; set; }

    public int? MobileNumber { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Bottle Bottle { get; set; }

    public virtual ICollection<Cap> Caps { get; set; }

    public virtual CityDetail CityDetail { get; set; }

    public virtual ICollection<CVC.Data.Cotton> Cotton { get; set; }

    public virtual ICollection<Desiccant> Desiccants { get; set; }

    public virtual ICollection<Label> Labels { get; set; }

    public virtual Outsert Outsert { get; set; }

    public virtual Status Status { get; set; }
  }
}

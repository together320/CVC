// Decompiled with JetBrains decompiler
// Type: CVC.Data.CityDetail
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class CityDetail
  {
    public CityDetail()
    {
      this.Companies = (ICollection<Company>) new HashSet<Company>();
      this.Suppliers = (ICollection<Supplier>) new HashSet<Supplier>();
      this.Users = (ICollection<User>) new HashSet<User>();
    }

    public int CityDetailsId { get; set; }

    public string Country { get; set; }

    public string State { get; set; }

    public string City { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }

    public virtual ICollection<Company> Companies { get; set; }

    public virtual ICollection<Supplier> Suppliers { get; set; }

    public virtual ICollection<User> Users { get; set; }
  }
}

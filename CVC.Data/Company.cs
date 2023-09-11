// Decompiled with JetBrains decompiler
// Type: CVC.Data.Company
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;

namespace CVC.Data
{
  public class Company
  {
    public int CompanyId { get; set; }

    public string CompanyName { get; set; }

    public string Address { get; set; }

    public int? CityId { get; set; }

    public string PinCode { get; set; }

    public string Website { get; set; }

    public string CompanyLogo { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual CityDetail CityDetail { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }
  }
}

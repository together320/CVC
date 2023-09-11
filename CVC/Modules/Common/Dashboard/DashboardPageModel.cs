// Decompiled with JetBrains decompiler
// Type: CVC.Common.DashboardPageModel
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

namespace CVC.Common
{
  public class DashboardPageModel
  {
    public string PackageLineName { get; set; }

    public int BatchId { get; set; }

    public string BatchName { get; set; }

    public string PackName { get; set; }

    public string BatchStartDate { get; set; }

    public string BatchEndDate { get; set; }

    public string TotalBottles { get; set; }

    public string ProductionSpeed { get; set; }

    public string TotalGood { get; set; }

    public string TotalReject { get; set; }

    public int OpenOrders { get; set; }

    public int ClosedOrderPercent { get; set; }

    public int CustomerCount { get; set; }

    public int ProductCount { get; set; }
  }
}

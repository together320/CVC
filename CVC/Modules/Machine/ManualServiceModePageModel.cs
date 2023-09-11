// Decompiled with JetBrains decompiler
// Type: CVC.Machine.ManualServiceModePageModel
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Data;
using CVC.Data.EDMX;
using System.Collections.Generic;

namespace CVC.Machine
{
  public class ManualServiceModePageModel
  {
    public IList<ViewField> ViewFieldList { get; set; }

    public int OpenOrders { get; set; }

    public int ClosedOrderPercent { get; set; }

    public int CustomerCount { get; set; }

    public int ProductCount { get; set; }
  }
}

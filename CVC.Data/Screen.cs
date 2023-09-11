// Decompiled with JetBrains decompiler
// Type: CVC.Data.Screen
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class Screen
  {
    public Screen()
    {
      this.ScreenModules = (ICollection<ScreenModule>) new HashSet<ScreenModule>();
    }

    public int ScreenId { get; set; }

    public string ScreenName { get; set; }

    public int? MachineId { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Status Status { get; set; }

    public virtual ICollection<ScreenModule> ScreenModules { get; set; }
  }
}

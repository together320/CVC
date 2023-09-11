﻿// Decompiled with JetBrains decompiler
// Type: CVC.Data.Module
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class Module
  {
    public Module()
    {
      this.ModuleAccesses = (ICollection<ModuleAccess>) new HashSet<ModuleAccess>();
      this.Views = (ICollection<View>) new HashSet<View>();
    }

    public int ModuleId { get; set; }

    public string ModuleName { get; set; }

    public int? MachineId { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Machine Machine { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }

    public virtual ICollection<ModuleAccess> ModuleAccesses { get; set; }

    public virtual ICollection<View> Views { get; set; }
  }
}

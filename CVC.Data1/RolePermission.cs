﻿// Decompiled with JetBrains decompiler
// Type: CVC.Data.RolePermission
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

namespace CVC.Data
{
  public class RolePermission
  {
    public long RolePermissionId { get; set; }

    public int RoleId { get; set; }

    public string PermissionKey { get; set; }

    public virtual Role Role { get; set; }
  }
}

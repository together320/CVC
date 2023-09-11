// Decompiled with JetBrains decompiler
// Type: CVC.Data.UserLoginDetail
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;

namespace CVC.Data
{
  public class UserLoginDetail
  {
    public long UserLoginDetailsId { get; set; }

    public int? UserId { get; set; }

    public DateTime? LoginDatetime { get; set; }

    public DateTime? LogoutDatetime { get; set; }

    public bool? IsOnline { get; set; }

    public virtual User User { get; set; }
  }
}

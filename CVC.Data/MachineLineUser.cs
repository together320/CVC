// Decompiled with JetBrains decompiler
// Type: CVC.Data.MachineLineUser
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;

namespace CVC.Data
{
  public class MachineLineUser
  {
    public int MachineLineUserId { get; set; }

    public int? MachineLineId { get; set; }

    public int? UserId { get; set; }

    public int? ShiftId { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual MachineLine MachineLine { get; set; }

    public virtual Shift Shift { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }

    public virtual User User2 { get; set; }
  }
}

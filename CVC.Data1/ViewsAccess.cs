// Decompiled with JetBrains decompiler
// Type: CVC.Data.ViewsAccess
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;

namespace CVC.Data
{
  public class ViewsAccess
  {
    public int ViewsAccessId { get; set; }

    public int? ViewsId { get; set; }

    public int? RoleId { get; set; }

    public bool? IsView { get; set; }

    public bool? IsEdit { get; set; }

    public bool? IsAdd { get; set; }

    public bool? IsDelete { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Role Role { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }

    public virtual View View { get; set; }
  }
}

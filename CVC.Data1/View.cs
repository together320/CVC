// Decompiled with JetBrains decompiler
// Type: CVC.Data.View
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class View
  {
    public View()
    {
      this.ViewFields = (ICollection<ViewField>) new HashSet<ViewField>();
      this.ViewsAccesses = (ICollection<ViewsAccess>) new HashSet<ViewsAccess>();
    }

    public int ViewsId { get; set; }

    public int? ModuleId { get; set; }

    public string ViewName { get; set; }

    public bool? IsAccessFieldWise { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Module Module { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }

    public virtual ICollection<ViewField> ViewFields { get; set; }

    public virtual ICollection<ViewsAccess> ViewsAccesses { get; set; }
  }
}

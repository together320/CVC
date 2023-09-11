// Decompiled with JetBrains decompiler
// Type: CVC.Data.TabletDetail
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;
using System.Collections.Generic;

namespace CVC.Data
{
  public class TabletDetail
  {
    public TabletDetail()
    {
      this.Packs = (ICollection<Pack>) new HashSet<Pack>();
    }

    public int TabletDetailsId { get; set; }

    public string TabletName { get; set; }

    public string TabletStrength { get; set; }

    public int? TabletTypeId { get; set; }

    public int? TabletCharOneId { get; set; }

    public int? TabletCharTwoId { get; set; }

    public int? TabletShapeId { get; set; }

    public string TabletLength { get; set; }

    public string TabletThickness { get; set; }

    public string TabletWidth { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<Pack> Packs { get; set; }

    public virtual PickListValue PickListValue { get; set; }

    public virtual PickListValue PickListValue1 { get; set; }

    public virtual PickListValue PickListValue2 { get; set; }

    public virtual Status Status { get; set; }
  }
}

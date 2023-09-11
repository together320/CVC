// Decompiled with JetBrains decompiler
// Type: CVC.Data.ScreenField
// Assembly: CVC.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47E8AB0A-5811-4D94-AF76-6F9B6303484D
// Assembly location: D:\Anil\CVC\bin\CVC.Data.dll

using System;

namespace CVC.Data
{
  public class ScreenField
  {
    public int ScreenFieldId { get; set; }

    public int? ScreenModuleId { get; set; }

    public int? ScreenSectionId { get; set; }

    public string FieldName { get; set; }

    public int? IPCParameterId { get; set; }

    public bool? IsDependentOn { get; set; }

    public int? DependentFieldId { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual IPCParameter IPCParameter { get; set; }

    public virtual ScreenModule ScreenModule { get; set; }

    public virtual Status Status { get; set; }
  }
}

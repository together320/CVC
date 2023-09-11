// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Forms.DepartmentForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.ComponentModel;

namespace CVC.Configuration.Forms
{
  [FormScript("Configuration.Department")]
  [BasedOnRow(typeof (DepartmentRow))]
  public class DepartmentForm
  {
    [LabelWidth(190)]
    public string DepartmentCode { get; set; }

    [LabelWidth(190)]
    public string DepartmentName { get; set; }

    [LookupEditor(typeof (StatusRow))]
    [LabelWidth(190)]
    public int StatusId { get; set; }
  }
}

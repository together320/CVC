// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Forms.PickListValueForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.ComponentModel;

namespace CVC.Configuration.Forms
{
  [FormScript("Configuration.PickListValue")]
  [BasedOnRow(typeof (PickListValueRow))]
  public class PickListValueForm
  {
    [LabelWidth(190)]
    [LookupEditor(typeof (PickListRow))]
    public int PickListId { get; set; }

    [LabelWidth(190)]
    public string PickListValueName { get; set; }

    [LabelWidth(190)]
    [LookupEditor(typeof (StatusRow))]
    public int StatusId { get; set; }
  }
}

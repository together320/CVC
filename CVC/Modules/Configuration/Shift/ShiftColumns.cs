// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Columns.ShiftColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.ComponentModel;

namespace CVC.Configuration.Columns
{
  [ColumnsScript("Configuration.Shift")]
  [BasedOnRow(typeof (ShiftRow))]
  public class ShiftColumns
  {
    [EditLink]
    public string ShiftName { get; set; }

    public string StartTime { get; set; }

    public string EndTime { get; set; }

    public string StatusStatusName { get; set; }
  }
}

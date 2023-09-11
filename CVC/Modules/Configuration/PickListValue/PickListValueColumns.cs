// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Columns.PickListValueColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.ComponentModel;

namespace CVC.Configuration.Columns
{
  [ColumnsScript("Configuration.PickListValue")]
  [BasedOnRow(typeof (PickListValueRow))]
  public class PickListValueColumns
  {
    [EditLink]
    public string PickListValueName { get; set; }

    public string PickListName { get; set; }

    public string StatusStatusName { get; set; }
  }
}

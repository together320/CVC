// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Columns.StatusColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.ComponentModel;
using System.ComponentModel;

namespace CVC.Configuration.Columns
{
  [ColumnsScript("Configuration.Status")]
  [BasedOnRow(typeof (StatusRow))]
  public class StatusColumns
  {
    [EditLink]
    [DisplayName("Db.Shared.RecordId")]
    [AlignRight]
    public int StatusId { get; set; }

    [EditLink]
    public string StatusName { get; set; }
  }
}

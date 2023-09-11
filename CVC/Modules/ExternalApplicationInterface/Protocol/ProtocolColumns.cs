// Decompiled with JetBrains decompiler
// Type: CVC.ExternalApplicationInterface.Columns.ProtocolColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.ExternalApplicationInterface.Entities;
using Serenity.ComponentModel;
using System;

namespace CVC.ExternalApplicationInterface.Columns
{
  [ColumnsScript("ExternalApplicationInterface.Protocol")]
  [BasedOnRow(typeof (ProtocolRow))]
  public class ProtocolColumns
  {
    [EditLink]
    public string ProtocolName { get; set; }

    public string StatusStatusName { get; set; }

    public string UpdatedByEmployeeId { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}

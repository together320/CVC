// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Forms.DataTypeForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.ComponentModel;
using System;

namespace CVC.Configuration.Forms
{
  [FormScript("Configuration.DataType")]
  [BasedOnRow(typeof (DataTypeRow))]
  public class DataTypeForm
  {
    public string DataTypeName { get; set; }

    public int TypeId { get; set; }

    public int Bit { get; set; }

    public short IsSigned { get; set; }

    public int StatusId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}

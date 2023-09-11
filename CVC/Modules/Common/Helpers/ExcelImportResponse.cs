// Decompiled with JetBrains decompiler
// Type: CVC.ExcelImportResponse
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.Services;
using System.Collections.Generic;

namespace CVC
{
  public class ExcelImportResponse : ServiceResponse
  {
    public int Inserted { get; set; }

    public int Updated { get; set; }

    public List<string> ErrorList { get; set; }
  }
}

﻿// Decompiled with JetBrains decompiler
// Type: CVC.GetNextNumberResponse
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.Services;

namespace CVC
{
  public class GetNextNumberResponse : ServiceResponse
  {
    public long Number { get; set; }

    public string Serial { get; set; }
  }
}

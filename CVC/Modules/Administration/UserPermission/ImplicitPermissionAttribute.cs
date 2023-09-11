// Decompiled with JetBrains decompiler
// Type: CVC.ImplicitPermissionAttribute
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using System;

namespace CVC
{
  [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
  public class ImplicitPermissionAttribute : Attribute
  {
    public ImplicitPermissionAttribute(string value)
    {
      this.Value = value;
    }

    public string Value { get; private set; }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.ScriptUserDefinition
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.ComponentModel;
using System.Collections.Generic;

namespace CVC
{
  [ScriptInclude]
  public class ScriptUserDefinition
  {
    public string Username { get; set; }

    public string DisplayName { get; set; }

    public bool IsAdmin { get; set; }

    public Dictionary<string, bool> Permissions { get; set; }
  }
}

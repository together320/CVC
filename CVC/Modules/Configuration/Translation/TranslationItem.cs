// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.TranslationItem
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.ComponentModel;

namespace CVC.Configuration
{
  [ScriptInclude]
  public class TranslationItem
  {
    public string Key { get; set; }

    public string SourceText { get; set; }

    public string TargetText { get; set; }

    public string CustomText { get; set; }
  }
}

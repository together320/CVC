// Decompiled with JetBrains decompiler
// Type: CVC.Common.UserPreferenceUpdateRequest
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.Services;

namespace CVC.Common
{
  public class UserPreferenceUpdateRequest : ServiceRequest
  {
    public string PreferenceType { get; set; }

    public string Name { get; set; }

    public string Value { get; set; }
  }
}

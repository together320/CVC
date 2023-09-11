// Decompiled with JetBrains decompiler
// Type: CVC.FilterConfig
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.Services;
using System.Web.Mvc;

namespace CVC
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add((object) new HandleErrorAttribute());
      filters.Add((object) new AntiforgeryCookieResultFilter());
      filters.Add((object) new AutoValidateAntiforgeryTokenAttribute());
    }
  }
}

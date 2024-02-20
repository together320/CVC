// Decompiled with JetBrains decompiler
// Type: CVC.RouteConfig
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using System.Web.Mvc;
using System.Web.Routing;

namespace CVC
{
  public class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
      routes.IgnoreRoute("Content/{resource}.axd/{*pathInfo}");
      routes.MapMvcAttributeRoutes();
    }
  }
}

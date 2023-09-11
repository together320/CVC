// Decompiled with JetBrains decompiler
// Type: CVC.WebApiConfig
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using System.Web.Http;

namespace CVC
{
  public class WebApiConfig
  {


    public static void Register(HttpConfiguration config)
    {


      config.MapHttpAttributeRoutes();
      config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{action}/{id}", (object) new
      {
        id = RouteParameter.Optional
      });
    }
  }
}

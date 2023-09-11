// Decompiled with JetBrains decompiler
// Type: CVC.Administration.RolePermissionListRequest
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.Services;

namespace CVC.Administration
{
  public class RolePermissionListRequest : ServiceRequest
  {
    public int? RoleID { get; set; }

    public string Module { get; set; }

    public string Submodule { get; set; }
  }
}

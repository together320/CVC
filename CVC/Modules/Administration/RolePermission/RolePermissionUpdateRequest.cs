// Decompiled with JetBrains decompiler
// Type: CVC.Administration.RolePermissionUpdateRequest
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Newtonsoft.Json;
using Serenity.Services;
using System.Collections.Generic;

namespace CVC.Administration
{
  public class RolePermissionUpdateRequest : ServiceRequest
  {
    public int? RoleID { get; set; }

    [JsonProperty(Required = Required.AllowNull)]
    public string Module { get; set; }

    [JsonProperty(Required = Required.AllowNull)]
    public string Submodule { get; set; }

    public List<string> Permissions { get; set; }
  }
}

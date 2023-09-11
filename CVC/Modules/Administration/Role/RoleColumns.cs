// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Forms.RoleColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using Serenity.ComponentModel;

namespace CVC.Administration.Forms
{
  [ColumnsScript("Administration.Role")]
  [BasedOnRow(typeof (RoleRow))]
  public class RoleColumns
  {
    [EditLink]
    [Width(300)]
    public string RoleName { get; set; }

    public string RolesRoleName { get; set; }

    public string StatusStatusName { get; set; }
  }
}

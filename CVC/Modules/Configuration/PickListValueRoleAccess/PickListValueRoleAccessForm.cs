// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Forms.PickListValueRoleAccessForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.ComponentModel;
using System;

namespace CVC.Configuration.Forms
{
  [FormScript("Configuration.PickListValueRoleAccess")]
  [BasedOnRow(typeof (PickListValueRoleAccessRow))]
  public class PickListValueRoleAccessForm
  {
    public int PickListValueId { get; set; }

    public int RoleId { get; set; }

    public int StatusId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }
  }
}

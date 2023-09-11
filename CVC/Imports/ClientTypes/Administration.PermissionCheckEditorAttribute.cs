// Decompiled with JetBrains decompiler
// Type: CVC.Administration.PermissionCheckEditorAttribute
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.ComponentModel;

namespace CVC.Administration
{
  public class PermissionCheckEditorAttribute : CustomEditorAttribute
  {
    public const string Key = "CVC.Administration.PermissionCheckEditor";

    public PermissionCheckEditorAttribute()
      : base("CVC.Administration.PermissionCheckEditor")
    {
    }

    public bool ShowRevoke
    {
      get
      {
        return this.GetOption<bool>("showRevoke");
      }
      set
      {
        this.SetOption("showRevoke", (object) value);
      }
    }
  }
}

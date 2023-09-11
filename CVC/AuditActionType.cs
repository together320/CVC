// Decompiled with JetBrains decompiler
// Type: CVC.Modules.Common.BaseClass.AuditActionType
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.ComponentModel;
using System.ComponentModel;

namespace CVC.Modules.Common.BaseClass
{
  [EnumKey("Enum.Audit.AuditActionType")]
  public enum AuditActionType
  {
    [Description("INSERT")] Insert = 1,
    [Description("UPDATE")] Update = 2,
    [Description("DELETE")] Delete = 3,
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Administration.PermissionKeys
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.Extensibility;
using System.ComponentModel;

namespace CVC.Administration
{
    [NestedPermissionKeys]
    [DisplayName("Administration")]
    public class PermissionKeys
    {
       // [Description("User, Role Management and Permissions")]
      //  public const string Security = "Administration:Security";
      //  [Description("Languages and Translations")]
      //  public const string Translation = "Administration:Translation";
    }

    [NestedPermissionKeys]
    [DisplayName("Batch")]
    public class PermissionBatchKeys
    {
        ////[Description("User, Role Management and Permissions")]
        //public const string Read = "Batch:Read";
        //[Description("Languages and Translations")]
        public const string Modify = "Batch:Modify";
        public const string Authentication = "Batch:Authentication";
    }
}

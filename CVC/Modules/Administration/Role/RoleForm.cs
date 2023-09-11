// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Forms.RoleForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;

using CVC.Configuration.Entities;
using Serenity.ComponentModel;
using System.ComponentModel;

namespace CVC.Administration.Forms
{
  [FormScript("Administration.Role")]
  [BasedOnRow(typeof (RoleRow))]
  public class RoleForm
  {
    [LabelWidth(190)]
    [Category("General")]
    public string RoleName { get; set; }

    [LabelWidth(190)]
        
        [LookupEditor(typeof (RoleRow))]
      
        public int ParentRoleId { get; set; }


        [LabelWidth(190)]
    [Category("Status")]
    [LookupEditor(typeof (StatusRow))]
    public int StatusId { get; set; }
  }
}

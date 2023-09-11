// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Columns.ViewsAccessColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.Administration.Columns
{
  [ColumnsScript("Administration.ViewsAccess")]
  [BasedOnRow(typeof (ViewsAccessRow))]
  public class ViewsAccessColumns
  {
    [EditLink]
    [DisplayName("Db.Shared.RecordId")]
    [AlignRight]
    public int ViewsAccessId { get; set; }

    public string ViewsViewName { get; set; }

    public string RoleRoleName { get; set; }

        public bool IsView { get; set; }

        public bool IsModify { get; set; }

        public string StatusStatusName { get; set; }

    //public string CreatedByEmployeeId { get; set; }

    //public DateTime CreatedDate { get; set; }

    //public string UpdatedByEmployeeId { get; set; }

    //public DateTime UpdatedDate { get; set; }
  }
}

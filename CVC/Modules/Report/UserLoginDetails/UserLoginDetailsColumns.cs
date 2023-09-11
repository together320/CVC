// Decompiled with JetBrains decompiler
// Type: CVC.Report.Columns.UserLoginDetailsColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Report.Entities;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace CVC.Report.Columns
{
  [ColumnsScript("Report.UserLoginDetails")]
  [BasedOnRow(typeof (UserLoginDetailsRow))]
  public class UserLoginDetailsColumns
  {
    [EditLink]
    [DisplayName("Db.Shared.RecordId")]
    [AlignRight]
    public long UserLoginDetailsId { get; set; }

    public string UserEmployeeId { get; set; }
        [CustomDisplayFormatAttribute("")]
        public DateTime LoginDatetime { get; set; }
        [CustomDisplayFormatAttribute("")]
        public DateTime LogoutDatetime { get; set; }

    public short IsOnline { get; set; }
  }
}

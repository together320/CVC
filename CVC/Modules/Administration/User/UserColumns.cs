// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Columns.UserColumns
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using Serenity.ComponentModel;

namespace CVC.Administration.Columns
{
  [ColumnsScript("Administration.User")]
  [BasedOnRow(typeof (UserRow))]
  public class UserColumns
  {
    [EditLink]
    [Width(150)]
    public string Username { get; set; }

    public string EmployeeId { get; set; }

    [Width(150)]
    public string FirstName { get; set; }

    [Width(150)]
    public string LastName { get; set; }

    public string DepartmentName { get; set; }

    public string Designation { get; set; }

    public string MobileNumberString { get; set; }

    [Width(250)]
    public string Email { get; set; }

    public string City { get; set; }

    public string RolesRoleName { get; set; }

    public string StatusStatusName { get; set; }
  }
}

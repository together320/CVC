// Decompiled with JetBrains decompiler
// Type: CVC.Report.Forms.UserLoginDetailsForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Report.Entities;
using Serenity.ComponentModel;
using System;

namespace CVC.Report.Forms
{
  [FormScript("Report.UserLoginDetails")]
  [BasedOnRow(typeof (UserLoginDetailsRow))]
  public class UserLoginDetailsForm
  {
    public int UserId { get; set; }

    public DateTime LoginDatetime { get; set; }

    public DateTime LogoutDatetime { get; set; }

    public short IsOnline { get; set; }
  }
}

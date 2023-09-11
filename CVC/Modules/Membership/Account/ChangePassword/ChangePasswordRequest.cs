// Decompiled with JetBrains decompiler
// Type: CVC.Membership.ChangePasswordRequest
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.ComponentModel;
using Serenity.Services;
using System.ComponentModel;

namespace CVC.Membership
{
  [FormScript("Membership.ChangePassword")]
  public class ChangePasswordRequest : ServiceRequest
  {
    [PasswordEditor]
    [Required(true)]
    [DisplayName("Current Password")]
    public string OldPassword { get; set; }

    [PasswordEditor]
    [Required(true)]
    [DisplayName("New Password")]
    public string NewPassword { get; set; }

    [PasswordEditor]
    [Required(true)]
    [DisplayName("Confirm Password")]
    public string ConfirmPassword { get; set; }
  }
}

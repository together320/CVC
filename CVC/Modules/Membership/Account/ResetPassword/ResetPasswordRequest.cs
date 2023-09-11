// Decompiled with JetBrains decompiler
// Type: CVC.Membership.ResetPasswordRequest
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.ComponentModel;
using Serenity.Services;
using System.ComponentModel;

namespace CVC.Membership
{
  [FormScript("Membership.ResetPassword")]
  public class ResetPasswordRequest : ServiceRequest
  {
    [Ignore]
    public string Token { get; set; }

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

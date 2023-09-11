// Decompiled with JetBrains decompiler
// Type: CVC.Membership.SignUpForm
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity.ComponentModel;

namespace CVC.Membership
{
  [FormScript("Membership.SignUp")]
  public class SignUpForm
  {
    [Required(true)]
    [Placeholder("Full name")]
    public string DisplayName { get; set; }

    [EmailEditor]
    [Required(true)]
    [Placeholder("Email")]
    public string Email { get; set; }

    [EmailEditor]
    [Required(true)]
    [Placeholder("Confirm email")]
    public string ConfirmEmail { get; set; }

    [PasswordEditor]
    [Required(true)]
    [Placeholder("Password")]
    public string Password { get; set; }

    [PasswordEditor]
    [Required(true)]
    [Placeholder("Confirm password")]
    public string ConfirmPassword { get; set; }
  }
}

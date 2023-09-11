// Decompiled with JetBrains decompiler
// Type: CVC.Membership.LoginRequest
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using Serenity.ComponentModel;
using Serenity.Services;

namespace CVC.Membership
{
    [FormScript("Membership.Login")]
    [BasedOnRow(typeof(UserRow))]
    public class LoginRequest : ServiceRequest
    {


        public string Username { get; set; }

        [PasswordEditor]
        [Required(true)]
        public string Password { get; set; }

        public bool IsADUser { get; set; }



    }
}

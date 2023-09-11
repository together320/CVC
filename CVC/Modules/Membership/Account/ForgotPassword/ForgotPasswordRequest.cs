// Decompiled with JetBrains decompiler
// Type: CVC.Membership.ForgotPasswordRequest
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Scripts;
using Serenity.ComponentModel;
using Serenity.Services;
using System.ComponentModel;

namespace CVC.Membership
{
    [FormScript("Membership.ForgotPassword")]
    public class ForgotPasswordRequest : ServiceRequest
    {
        [Required(true)]
        [StringEditor]
        [DisplayName("Username")]
        public string Username { get; set; }

       
        
        [Required]
        [LookupEditor(typeof(PickListValueLookup), CascadeField = "PickListId", CascadeValue = "15")]
        public int QuestionId { get; set; }

       
      
        [Required]
        [DisplayName("Answer")]
        public string QuestionAns { get; set; }

       
     
        [PasswordEditor]
        [Required(true)]
        public string Password { get; set; }

       
       
        [PasswordEditor]       
        [Required(true)]
        public string PasswordConfirm { get; set; }
    }
}

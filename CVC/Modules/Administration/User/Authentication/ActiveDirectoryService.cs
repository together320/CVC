// Decompiled with JetBrains decompiler
// Type: CVC.Administration.ActiveDirectoryService
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity;
using Serenity.ComponentModel;
using System;
using System.DirectoryServices.AccountManagement;

namespace CVC.Administration
{
  public class ActiveDirectoryService : IDirectoryService
  {
    public DirectoryEntry Validate(string username, string password)
    {
      using (PrincipalContext context = new PrincipalContext(ContextType.Domain, Config.Get<ActiveDirectoryService.Settings>().Domain))
      {
        bool flag;
        try
        {
          flag = context.ValidateCredentials(username, password, ContextOptions.Negotiate);
        }
        catch (Exception ex)
        {
          Log.Error("Error authenticating user", ex, this.GetType());
          return (DirectoryEntry) null;
        }
        if (!flag)
          return (DirectoryEntry) null;
        UserPrincipal byIdentity = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, username);
        return new DirectoryEntry()
        {
          Username = byIdentity.SamAccountName,
          Email = byIdentity.EmailAddress.TrimToNull(),
          FirstName = byIdentity.GivenName,
          LastName = byIdentity.Surname
        };
      }
    }

    [Hidden]
    [SettingScope("Application")]
    [SettingKey("ActiveDirectory")]
    private class Settings
    {
      public string Domain { get; set; }
    }
  }
}

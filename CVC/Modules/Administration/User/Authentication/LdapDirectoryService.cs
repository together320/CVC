// Decompiled with JetBrains decompiler
// Type: CVC.Administration.LdapDirectoryService
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity;
using Serenity.ComponentModel;
using System;
using System.DirectoryServices.Protocols;
using System.Net;

namespace CVC.Administration
{
  public class LdapDirectoryService : IDirectoryService
  {
    public DirectoryEntry Validate(string username, string password)
    {
      LdapDirectoryService.Settings settings = Config.Get<LdapDirectoryService.Settings>();
      LdapConnection ldapConnection = new LdapConnection(new LdapDirectoryIdentifier(settings.Host, settings.Port, true, false), new NetworkCredential(settings.Username, settings.Password))
      {
        AuthType = AuthType.Basic
      };
      try
      {
        ldapConnection.SessionOptions.ProtocolVersion = 3;
        SearchRequest searchRequest = new SearchRequest(settings.DistinguishedName, "(&(objectClass=*)(uid=" + username + "))", SearchScope.Subtree, new string[4]
        {
          "uid",
          "givenName",
          "sn",
          "mail"
        });
        SearchResponse searchResponse = (SearchResponse) ldapConnection.SendRequest((DirectoryRequest) searchRequest);
        if (searchResponse.Entries.Count == 0)
          return (DirectoryEntry) null;
        SearchResultEntry entry = searchResponse.Entries[0];
        try
        {
          ldapConnection.Bind(new NetworkCredential(entry.DistinguishedName, password));
        }
        catch (Exception ex)
        {
          Log.Error("Error authenticating user", ex, this.GetType());
          return (DirectoryEntry) null;
        }
        DirectoryAttribute attribute1 = entry.Attributes["uid"];
        DirectoryAttribute attribute2 = entry.Attributes["givenName"];
        DirectoryAttribute attribute3 = entry.Attributes["sn"];
        DirectoryAttribute attribute4 = entry.Attributes["mail"];
        return new DirectoryEntry()
        {
          Username = attribute1[0] as string,
          FirstName = attribute1.Count > 0 ? attribute2[0] as string : (string) null,
          LastName = attribute3.Count > 0 ? attribute3[0] as string : (string) null,
          Email = attribute4.Count > 0 ? attribute4[0] as string : (string) null
        };
      }
      finally
      {
        try
        {
          ldapConnection.Dispose();
        }
        catch
        {
        }
      }
    }

    [Hidden]
    [SettingScope("Application")]
    [SettingKey("LDAP")]
    private class Settings
    {
      public string Host { get; set; }

      public int Port { get; set; }

      public string DistinguishedName { get; set; }

      public string Username { get; set; }

      public string Password { get; set; }
    }
  }
}

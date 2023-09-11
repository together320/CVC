// Decompiled with JetBrains decompiler
// Type: CVC.Administration.AuthorizationService
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity;
using Serenity.Abstractions;

namespace CVC.Administration
{
  public class AuthorizationService : IAuthorizationService
  {
    public bool IsLoggedIn
    {
      get
      {
        return !string.IsNullOrEmpty(this.Username);
      }
    }

    public string Username
    {
      get
      {
        return WebSecurityHelper.HttpContextUsername;
      }
    }

    public string UserID
    {
      get
      {
        return ((UserDefinition) Authorization.UserDefinition).Id;
      }
    }
  }
}

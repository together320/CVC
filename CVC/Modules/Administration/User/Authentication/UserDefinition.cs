// Decompiled with JetBrains decompiler
// Type: CVC.UserDefinition
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using Serenity;
using System;

namespace CVC
{
  [Serializable]
  public class UserDefinition : IUserDefinition
  {
    public string Id
    {
      get
      {
        return this.UserId.ToInvariant();
      }
    }

    public string DisplayName { get; set; }

    public string Email { get; set; }

    public string UserImage { get; set; }

    public short IsActive { get; set; }

    public int UserId { get; set; }

    public string Username { get; set; }

    public string PasswordHash { get; set; }

    public string PasswordSalt { get; set; }

    public string Source { get; set; }

    public DateTime? LastDirectoryUpdate { get; set; }

    public string Role { get; set; }

    public string IsAdmin { get; set; }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Administration.UserRetrieveService
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using System;
using System.Data;

namespace CVC.Administration
{
  public class UserRetrieveService : IUserRetrieveService
  {
    private static UserRow.RowFields fld
    {
      get
      {
        return UserRow.Fields;
      }
    }

    private UserDefinition GetFirst(IDbConnection connection, BaseCriteria criteria)
    {
      UserRow userRow = connection.TrySingle<UserRow>((ICriteria) criteria);
      if (userRow == null)
        return (UserDefinition) null;
      return new UserDefinition()
      {
        UserId = userRow.UserId.Value,
        Username = userRow.Username,
        Email = userRow.Email,
        UserImage = userRow.UserImage,
        IsActive = userRow.StatusId.Value,
        PasswordHash = userRow.PasswordHash,
        PasswordSalt = userRow.PasswordSalt
      };
    }

    public IUserDefinition ById(string id)
    {
      return (IUserDefinition) TwoLevelCache.Get<UserDefinition>("UserByID_" + id, TimeSpan.Zero, TimeSpan.FromDays(1.0), UserRetrieveService.fld.GenerationKey, (Func<UserDefinition>) (() =>
      {
        using (IDbConnection connection = SqlConnections.NewByKey("Default"))
          return this.GetFirst(connection, (BaseCriteria) new Criteria((IField) UserRetrieveService.fld.UserId) == int.Parse(id));
      }));
    }

    public IUserDefinition ByUsername(string username)
    {
      if (username.IsEmptyOrNull())
        return (IUserDefinition) null;
      return (IUserDefinition) TwoLevelCache.Get<UserDefinition>("UserByName_" + username.ToLowerInvariant(), TimeSpan.Zero, TimeSpan.FromDays(1.0), UserRetrieveService.fld.GenerationKey, (Func<UserDefinition>) (() =>
      {
        using (IDbConnection connection = SqlConnections.NewByKey("Default"))
          return this.GetFirst(connection, (BaseCriteria) new Criteria((IField) UserRetrieveService.fld.Username) == username);
      }));
    }

    public static void RemoveCachedUser(int? userId, string username)
    {
      if (userId.HasValue)
        TwoLevelCache.Remove("UserByID_" + (object) userId);
      if (username == null)
        return;
      TwoLevelCache.Remove("UserByName_" + username.ToLowerInvariant());
    }
  }
}

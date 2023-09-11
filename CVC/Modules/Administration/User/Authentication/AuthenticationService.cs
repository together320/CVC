// Decompiled with JetBrains decompiler
// Type: CVC.Administration.AuthenticationService
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Administration.Repositories;
using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using System;
using System.Data;
using CVC.Data.EDMX;
using System.Linq;

namespace CVC.Administration
{
  public class AuthenticationService : IAuthenticationService
  {
    public bool Validate(ref string username, string password)
    {
       if (username.IsTrimmedEmpty() || string.IsNullOrEmpty(password))
        return false;
      username = username.TrimToEmpty();
      UserDefinition user = Dependency.Resolve<IUserRetrieveService>().ByUsername(username) as UserDefinition;
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                var UserDetails = cvcEntities.Users.FirstOrDefault(u => u.UserId == user.UserId);
                if(UserDetails!=null)
                {
                    user.PasswordHash = UserDetails.PasswordHash;
                    user.PasswordSalt = UserDetails.PasswordSalt;

                }
            }

                if (user != null)
                    return this.ValidateExistingUser(ref username, password, user);
      return this.ValidateFirstTimeUser(ref username, password);
    }

    private bool ValidateExistingUser(ref string username, string password, UserDefinition user)
    {
      username = user.Username;
      if (user.IsActive != (short) 1)
      {
        if (Log.IsInfoEnabled)
          Log.Error(string.Format("Inactive user login attempt: {0}", (object) username), this.GetType());
        return false;
      }
      Throttler throttler = new Throttler("ValidateUser:" + username.ToLowerInvariant(), TimeSpan.FromMinutes(30.0), 50);
      if (!throttler.Check())
        return false;
      IDirectoryService directoryService = Dependency.TryResolve<IDirectoryService>();
      Func<bool> func = (Func<bool>) (() => UserRepository.CalculateHash(password, user.PasswordSalt).Equals(user.PasswordHash, StringComparison.OrdinalIgnoreCase));
      if (user.Source == "site" || user.Source == "sign" || directoryService == null)
      {
        if (!func())
          return false;
        throttler.Reset();
        return true;
      }
      if (user.Source != "ldap")
        throw new ArgumentOutOfRangeException("userSource");
      if (!string.IsNullOrEmpty(user.PasswordHash))
      {
        DateTime? lastDirectoryUpdate = user.LastDirectoryUpdate;
        if (lastDirectoryUpdate.HasValue)
        {
          lastDirectoryUpdate = user.LastDirectoryUpdate;
          if (lastDirectoryUpdate.Value.AddHours(1.0) >= DateTime.Now)
          {
            if (!func())
              return false;
            throttler.Reset();
            return true;
          }
        }
      }
      DirectoryEntry directoryEntry;
      try
      {
        directoryEntry = directoryService.Validate(username, password);
        if (directoryEntry == null)
          return false;
        throttler.Reset();
      }
      catch (System.Exception ex)
      {
        Log.Error("Error on directory access", ex, this.GetType());
        if (!user.PasswordHash.IsTrimmedEmpty())
        {
          if (!func())
            return false;
          throttler.Reset();
          return true;
        }
        throw;
      }
      try
      {
        string salt = user.PasswordSalt.TrimToNull();
        string hash = UserRepository.GenerateHash(password, ref salt);
        string firstName = directoryEntry.FirstName;
        string lastName = directoryEntry.LastName;
        string str = directoryEntry.Email.TrimToNull() ?? user.Email ?? username + "@yourdefaultdomain.com";
        using (IDbConnection connection = SqlConnections.NewFor<UserRow>())
        {
          using (UnitOfWork unitOfWork = new UnitOfWork(connection))
          {
            UserRow.RowFields fields = UserRow.Fields;
            new SqlUpdate(fields.TableName).Set<SqlUpdate>((IField) fields.FirstName, (object) firstName).Set<SqlUpdate>((IField) fields.LastName, (object) lastName).Set<SqlUpdate>((IField) fields.PasswordHash, (object) hash).Set<SqlUpdate>((IField) fields.PasswordSalt, (object) salt).Set<SqlUpdate>((IField) fields.Email, (object) str).WhereEqual<SqlUpdate>((IField) fields.UserId, (object) user.UserId).Execute(connection, ExpectedRows.One);
            unitOfWork.Commit();
            UserRetrieveService.RemoveCachedUser(new int?(user.UserId), username);
          }
        }
        return true;
      }
      catch (System.Exception ex)
      {
        Log.Error("Error while updating directory user", ex, this.GetType());
        return true;
      }
    }

    private bool ValidateFirstTimeUser(ref string username, string password)
    {
      Throttler throttler = new Throttler("ValidateUser:" + username.ToLowerInvariant(), TimeSpan.FromMinutes(30.0), 50);
      if (!throttler.Check())
        return false;
      IDirectoryService directoryService = Dependency.TryResolve<IDirectoryService>();
      if (directoryService == null)
        return false;
      DirectoryEntry directoryEntry;
      try
      {
        directoryEntry = directoryService.Validate(username, password);
        if (directoryEntry == null)
          return false;
        throttler.Reset();
      }
      catch (System.Exception ex)
      {
        Log.Error("Error on directory first time authentication", ex, this.GetType());
        return false;
      }
      try
      {
        string salt = (string) null;
        string hash = UserRepository.GenerateHash(password, ref salt);
        string firstName = directoryEntry.FirstName;
        string lastName = directoryEntry.LastName;
        string str = directoryEntry.Email.TrimToNull() ?? username + "@yourdefaultdomain.com";
        username = directoryEntry.Username.TrimToNull() ?? username;
        using (IDbConnection connection = SqlConnections.NewFor<UserRow>())
        {
          using (UnitOfWork unitOfWork = new UnitOfWork(connection))
          {
            int num = (int) connection.InsertAndGetID<UserRow>(new UserRow()
            {
              Username = username,
              FirstName = firstName,
              LastName = lastName,
              Email = str,
              PasswordHash = hash,
              PasswordSalt = salt,
              StatusId = new short?((short) 1)
            }).Value;
            unitOfWork.Commit();
            UserRetrieveService.RemoveCachedUser(new int?(num), username);
          }
        }
        return true;
      }
      catch (System.Exception ex)
      {
        Log.Error("Error while importing directory user", ex, this.GetType());
        return false;
      }
    }
  }
}

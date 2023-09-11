// Decompiled with JetBrains decompiler
// Type: CVC.Administration.PermissionService
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Administration.Repositories;
using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CVC.Administration
{
    public class PermissionService : IPermissionService
    {
        public bool HasPermission(string permission)
        {
            if (permission == "Lookup")
                return true;

            if (Authorization.Username == "admin")
            {
                return true;
            }
            //else if(Authorization.Username.ToLower() == "fatoperator")
            //{
            //    return true;
            //}
 
            UserDefinition userDefinition = (UserDefinition)Authorization.UserDefinition;
            if (userDefinition == null)
                return false;
            bool flag;
            if (this.GetUserPermissions(userDefinition.UserId).TryGetValue(permission, out flag))
                return flag;
            foreach (int userRole in this.GetUserRoles(userDefinition.UserId))
            {
                var ff = this.GetRolePermissions(userRole).Contains(permission);

                    if (this.GetRolePermissions(userRole).Contains(permission))
                    return true;
            }
            return false;
        }

        private Dictionary<string, bool> GetUserPermissions(int userId)
        {
            UserPermissionRow.RowFields fld = UserPermissionRow.Fields;
            return TwoLevelCache.GetLocalStoreOnly<Dictionary<string, bool>>("UserPermissions:" + (object)userId, TimeSpan.Zero, fld.GenerationKey, (Func<Dictionary<string, bool>>)(() =>
          {
              using (IDbConnection connection = SqlConnections.NewByKey("Default"))
              {
                  Dictionary<string, bool> result = new Dictionary<string, bool>((IEqualityComparer<string>)StringComparer.OrdinalIgnoreCase);
                  connection.List<UserPermissionRow>((Action<SqlQuery>)(q => q.Select((IField)fld.PermissionKey).Select((IField)fld.Granted).Where<SqlQuery>((ICriteria)((BaseCriteria)new Criteria((IField)fld.UserId) == userId)))).ForEach((Action<UserPermissionRow>)(x =>
       {
                  Dictionary<string, bool> dictionary = result;
                  string permissionKey = x.PermissionKey;
                  bool? granted = x.Granted;
                  int num = granted.HasValue ? (granted.GetValueOrDefault() ? 1 : 0) : 1;
                  dictionary[permissionKey] = num != 0;
              }));
                  Dictionary<string, HashSet<string>> implicitPermissions = new UserPermissionRepository().ImplicitPermissions;
                  foreach (KeyValuePair<string, bool> keyValuePair in result.ToArray<KeyValuePair<string, bool>>())
                  {
                      HashSet<string> stringSet;
                      if (keyValuePair.Value && implicitPermissions.TryGetValue(keyValuePair.Key, out stringSet))
                      {
                          foreach (string key in stringSet)
                              result.Add(key, true);
                      }
                  }
                  return result;
              }
          }));
        }

        private HashSet<string> GetRolePermissions(int userId)
        {
            RolePermissionRow.RowFields fld = RolePermissionRow.Fields;
            return TwoLevelCache.GetLocalStoreOnly<HashSet<string>>("RolePermissions:" + (object)userId, TimeSpan.Zero, fld.GenerationKey, (Func<HashSet<string>>)(() =>
          {
              using (IDbConnection connection = SqlConnections.NewByKey("Default"))
              {
                  HashSet<string> result = new HashSet<string>((IEqualityComparer<string>)StringComparer.OrdinalIgnoreCase);
                  connection.List<RolePermissionRow>((Action<SqlQuery>)(q => q.Select((IField)fld.PermissionKey).Where<SqlQuery>((ICriteria)((BaseCriteria)new Criteria((IField)fld.RoleId) == userId)))).ForEach((Action<RolePermissionRow>)(x => result.Add(x.PermissionKey)));
                  Dictionary<string, HashSet<string>> implicitPermissions = new UserPermissionRepository().ImplicitPermissions;
                  foreach (string key in result.ToArray<string>())
                  {
                      HashSet<string> stringSet;
                      if (implicitPermissions.TryGetValue(key, out stringSet))
                      {
                          foreach (string str in stringSet)
                              result.Add(str);
                      }
                  }
                  return result;
              }
          }));
        }

        private HashSet<int> GetUserRoles(int userId)
        {
            UserRoleRow.RowFields fld = UserRoleRow.Fields;
            return TwoLevelCache.GetLocalStoreOnly<HashSet<int>>("UserRoles:" + (object)userId, TimeSpan.Zero, fld.GenerationKey, (Func<HashSet<int>>)(() =>
          {
              using (IDbConnection connection = SqlConnections.NewByKey("Default"))
              {
                  HashSet<int> result = new HashSet<int>();
                  connection.List<UserRow>((Action<SqlQuery>)(q => q.Select((IField)fld.RoleId).Where<SqlQuery>((ICriteria)((BaseCriteria)new Criteria((IField)fld.UserId) == userId)))).ForEach((Action<UserRow>)(x => result.Add(x.RoleId.Value)));
                 // connection.List<UserRoleRow>((Action<SqlQuery>)(q => q.Select((IField)fld.RoleId).Where<SqlQuery>((ICriteria)((BaseCriteria)new Criteria((IField)fld.UserId) == userId)))).ForEach((Action<UserRoleRow>)(x => result.Add(x.RoleId.Value)));
                  return result;
              }
          }));
        }
    }
}

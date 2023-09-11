// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Repositories.UserPermissionRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Extensibility;
using Serenity.Localization;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace CVC.Administration.Repositories
{
  public class UserPermissionRepository
  {
    private static readonly string[] emptyPermissions = new string[0];
    private static readonly char[] splitChar = new char[2]
    {
      '|',
      '&'
    };

    private static UserPermissionRow.RowFields fld
    {
      get
      {
        return UserPermissionRow.Fields;
      }
    }

    public SaveResponse Update(IUnitOfWork uow, UserPermissionUpdateRequest request)
    {
      Check.NotNull((object) request, nameof (request));
      Check.NotNull((object) request.UserID, "userID");
      Check.NotNull((object) request.Permissions, "permissions");
      int userId = request.UserID.Value;
      Dictionary<string, bool> source = new Dictionary<string, bool>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
      foreach (UserPermissionRow userPermissionRow in this.GetExisting(uow.Connection, userId, request.Module, request.Submodule))
        source[userPermissionRow.PermissionKey] = userPermissionRow.Granted.Value;
      Dictionary<string, bool> newList = new Dictionary<string, bool>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
      foreach (UserPermissionRow permission in request.Permissions)
      {
        Dictionary<string, bool> dictionary = newList;
        string permissionKey = permission.PermissionKey;
        bool? granted = permission.Granted;
        int num = granted.HasValue ? (granted.GetValueOrDefault() ? 1 : 0) : 0;
        dictionary[permissionKey] = num != 0;
      }
      if (source.Count == newList.Count && source.All<KeyValuePair<string, bool>>((Func<KeyValuePair<string, bool>, bool>) (x =>
      {
        if (newList.ContainsKey(x.Key))
          return newList[x.Key] == x.Value;
        return false;
      })))
        return new SaveResponse();
      foreach (string key in source.Keys)
      {
        if (!newList.ContainsKey(key))
          new SqlDelete(UserPermissionRepository.fld.TableName).Where<SqlDelete>((ICriteria) ((BaseCriteria) new Criteria((IField) UserPermissionRepository.fld.UserId) == userId & (BaseCriteria) new Criteria((IField) UserPermissionRepository.fld.PermissionKey) == key)).Execute(uow.Connection, ExpectedRows.One);
      }
      foreach (string key in newList.Keys)
      {
        if (!source.ContainsKey(key))
          uow.Connection.Insert<UserPermissionRow>(new UserPermissionRow()
          {
            UserId = new int?(userId),
            PermissionKey = key,
            Granted = new bool?(newList[key])
          });
        else if (source[key] != newList[key])
          new SqlUpdate(UserPermissionRepository.fld.TableName).Where<SqlUpdate>((ICriteria) ((Field) UserPermissionRepository.fld.UserId == userId & (Field) UserPermissionRepository.fld.PermissionKey == key)).Set<SqlUpdate>((IField) UserPermissionRepository.fld.Granted, (object) newList[key]).Execute(uow.Connection, ExpectedRows.One);
      }
      BatchGenerationUpdater.OnCommit(uow, UserPermissionRepository.fld.GenerationKey);
      return new SaveResponse();
    }

    private List<UserPermissionRow> GetExisting(IDbConnection connection, int userId, string module, string submodule)
    {
      string prefix = "";
      module = module.TrimToEmpty();
      submodule = submodule.TrimToEmpty();
      if (module.Length > 0)
        prefix = module;
      if (submodule.Length > 0)
        prefix = prefix + ":" + submodule;
      return connection.List<UserPermissionRow>((Action<SqlQuery>) (q =>
      {
        q.Select(new IField[3]
        {
          (IField) UserPermissionRepository.fld.UserPermissionId,
          (IField) UserPermissionRepository.fld.PermissionKey,
          (IField) UserPermissionRepository.fld.Granted
        }).Where<SqlQuery>((ICriteria) ((BaseCriteria) new Criteria((IField) UserPermissionRepository.fld.UserId) == userId));
        if (prefix.Length <= 0)
          return;
        q.Where<SqlQuery>((ICriteria) ~((BaseCriteria) new Criteria((IField) UserPermissionRepository.fld.PermissionKey) == prefix | new Criteria((IField) UserPermissionRepository.fld.PermissionKey).StartsWith(prefix + ":")));
      }));
    }

    public ListResponse<UserPermissionRow> List(IDbConnection connection, UserPermissionListRequest request)
    {
      Check.NotNull((object) request, nameof (request));
      Check.NotNull((object) request.UserID, "userID");
      string str1 = "";
      string empty1 = request.Module.TrimToEmpty();
      string empty2 = request.Submodule.TrimToEmpty();
      if (empty1.Length > 0)
        str1 = empty1;
      if (empty2.Length > 0)
      {
        string str2 = str1 + ":" + empty2;
      }
      return new ListResponse<UserPermissionRow>()
      {
        Entities = this.GetExisting(connection, request.UserID.Value, request.Module, request.Submodule)
      };
    }

    public ListResponse<string> ListRolePermissions(IDbConnection connection, UserPermissionListRequest request)
    {
      Check.NotNull((object) request, nameof (request));
      Check.NotNull((object) request.UserID, "userID");
      string str1 = "";
      string empty1 = request.Module.TrimToEmpty();
      string empty2 = request.Submodule.TrimToEmpty();
      if (empty1.Length > 0)
        str1 = empty1;
      if (empty2.Length > 0)
      {
        string str2 = str1 + ":" + empty2;
      }
      RolePermissionRow.RowFields rowFields1 = RolePermissionRow.Fields.As<RolePermissionRow.RowFields>("rp");
      UserRoleRow.RowFields rowFields2 = UserRoleRow.Fields.As<UserRoleRow.RowFields>("ur");
      SqlQuery sqlQuery1 = new SqlQuery().From((IAlias) rowFields1).Select((IField) rowFields1.PermissionKey).Distinct(true).OrderBy((IField) rowFields1.PermissionKey, false);
      SqlQuery self1 = sqlQuery1;
      Int32Field roleId = rowFields1.RoleId;
      SqlQuery[] sqlQueryArray = new SqlQuery[1];
      int index = 0;
      SqlQuery self2 = sqlQuery1.SubQuery().From((IAlias) rowFields2).Select((IField) rowFields2.RoleId);
      Int32Field userId = rowFields2.UserId;
      int? nullable = request.UserID;
      int num1 = nullable.Value;
      BaseCriteria baseCriteria1 = (Field) userId == num1;
      SqlQuery sqlQuery2 = self2.Where<SqlQuery>((ICriteria) baseCriteria1);
      sqlQueryArray[index] = sqlQuery2;
      BaseCriteria baseCriteria2 = roleId.In<SqlQuery>(sqlQueryArray);
      self1.Where<SqlQuery>((ICriteria) baseCriteria2);
      ListResponse<string> listResponse = new ListResponse<string>();
      //IDbConnection cnn = connection;
      //SqlQuery sqlQuery3 = sqlQuery1;
      //// ISSUE: variable of the null type
      //__Null local = null;
      //int num2 = 1;
      //nullable = new int?();
      //int? commandTimeout = nullable;
      //CommandType? commandType = new CommandType?();
      //listResponse.Entities = cnn.Query<string>((ISqlQuery) sqlQuery3, (IDbTransaction) local, num2 != 0, commandTimeout, commandType).ToList<string>();
      return listResponse;
    }

    private string[] SplitPermissions(string permission)
    {
      if (string.IsNullOrEmpty(permission))
        return UserPermissionRepository.emptyPermissions;
      return permission.Split(UserPermissionRepository.splitChar, StringSplitOptions.RemoveEmptyEntries);
    }

    private void ProcessAttributes<TAttr>(HashSet<string> hash, MemberInfo member, Func<TAttr, string> getPermission) where TAttr : Attribute
    {
      try
      {
        foreach (TAttr customAttribute in member.GetCustomAttributes<TAttr>(false))
        {
          string permission = getPermission(customAttribute);
          hash.AddRange<string>(this.SplitPermissions(permission));
        }
      }
      catch
      {
      }
    }

    public ListResponse<string> ListPermissionKeys()
    {
      return LocalCache.Get<ListResponse<string>>("Administration:PermissionKeys", TimeSpan.Zero, (Func<ListResponse<string>>) (() =>
      {
        HashSet<string> stringSet = new HashSet<string>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
        stringSet.AddRange<string>((IEnumerable<string>) ((ILocalTextRegistry) null).AddNestedPermissions((IEnumerable<Assembly>) null));
        foreach (Assembly selfAssembly in ExtensibilityHelper.SelfAssemblies)
        {
          foreach (PermissionAttributeBase customAttribute in selfAssembly.GetCustomAttributes<PermissionAttributeBase>())
          {
            if (!customAttribute.Permission.IsEmptyOrNull())
              stringSet.AddRange<string>(this.SplitPermissions(customAttribute.Permission));
          }
          foreach (Type type in selfAssembly.GetTypes())
          {
            this.ProcessAttributes<PageAuthorizeAttribute>(stringSet, (MemberInfo) type, (Func<PageAuthorizeAttribute, string>) (x => x.Permission));
            this.ProcessAttributes<PermissionAttributeBase>(stringSet, (MemberInfo) type, (Func<PermissionAttributeBase, string>) (x => x.Permission));
            this.ProcessAttributes<ServiceAuthorizeAttribute>(stringSet, (MemberInfo) type, (Func<ServiceAuthorizeAttribute, string>) (x => x.Permission));
            foreach (MethodInfo method in type.GetMethods(BindingFlags.Instance | BindingFlags.Public))
            {
              this.ProcessAttributes<PageAuthorizeAttribute>(stringSet, (MemberInfo) method, (Func<PageAuthorizeAttribute, string>) (x => x.Permission));
              this.ProcessAttributes<PermissionAttributeBase>(stringSet, (MemberInfo) method, (Func<PermissionAttributeBase, string>) (x => x.Permission));
              this.ProcessAttributes<ServiceAuthorizeAttribute>(stringSet, (MemberInfo) method, (Func<ServiceAuthorizeAttribute, string>) (x => x.Permission));
            }
            foreach (PropertyInfo property in type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
              if (property.GetIndexParameters().Length == 0)
                this.ProcessAttributes<PermissionAttributeBase>(stringSet, (MemberInfo) property, (Func<PermissionAttributeBase, string>) (x => x.Permission));
            }
          }
        }
        stringSet.Remove("*");
        stringSet.Remove("?");
        return new ListResponse<string>()
        {
          Entities = new List<string>((IEnumerable<string>) stringSet)
        };
      }));
    }

    public Dictionary<string, HashSet<string>> ImplicitPermissions
    {
      get
      {
        return LocalCache.Get<Dictionary<string, HashSet<string>>>(nameof (ImplicitPermissions), TimeSpan.Zero, (Func<Dictionary<string, HashSet<string>>>) (() =>
        {
          Dictionary<string, HashSet<string>> result = new Dictionary<string, HashSet<string>>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
          Action<Type> addFrom = (Action<Type>) null;
          addFrom = (Action<Type>) (type =>
          {
            foreach (FieldInfo field in type.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
            {
              if (!(field.FieldType != typeof (string)))
              {
                string key = field.GetValue((object) null) as string;
                if (key != null)
                {
                  foreach (ImplicitPermissionAttribute customAttribute in field.GetCustomAttributes<ImplicitPermissionAttribute>())
                  {
                    HashSet<string> stringSet;
                    if (!result.TryGetValue(key, out stringSet))
                    {
                      stringSet = new HashSet<string>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
                      result[key] = stringSet;
                    }
                    stringSet.Add(customAttribute.Value);
                  }
                }
              }
            }
            foreach (Type nestedType in type.GetNestedTypes(BindingFlags.DeclaredOnly | BindingFlags.Public))
              addFrom(nestedType);
          });
          foreach (Assembly selfAssembly in ExtensibilityHelper.SelfAssemblies)
          {
            foreach (Type type in selfAssembly.GetTypes())
            {
              if (type.GetCustomAttribute<NestedPermissionKeysAttribute>() != null)
                addFrom(type);
            }
          }
          return result;
        }));
      }
    }
  }
}

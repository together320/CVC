// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Repositories.UserRoleRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace CVC.Administration.Repositories
{
  public class UserRoleRepository
  {
    private static UserRoleRow.RowFields fld
    {
      get
      {
        return UserRoleRow.Fields;
      }
    }

    public SaveResponse Update(IUnitOfWork uow, UserRoleUpdateRequest request)
    {
      Check.NotNull((object) request, nameof (request));
      Check.NotNull((object) request.UserID, "userID");
      Check.NotNull((object) request.Roles, "permissions");
      int userId = request.UserID.Value;
      HashSet<int> intSet1 = new HashSet<int>(this.GetExisting(uow.Connection, userId).Select<UserRoleRow, int>((Func<UserRoleRow, int>) (x => x.RoleId.Value)));
      HashSet<int> intSet2 = new HashSet<int>((IEnumerable<int>) request.Roles.ToList<int>());
      if (intSet1.SetEquals((IEnumerable<int>) intSet2))
        return new SaveResponse();
      foreach (int num in intSet1)
      {
        if (!intSet2.Contains(num))
          new SqlDelete(UserRoleRepository.fld.TableName).Where<SqlDelete>((ICriteria) ((BaseCriteria) new Criteria((IField) UserRoleRepository.fld.UserId) == userId & (BaseCriteria) new Criteria((IField) UserRoleRepository.fld.RoleId) == num)).Execute(uow.Connection, ExpectedRows.One);
      }
      foreach (int num in intSet2)
      {
        if (!intSet1.Contains(num))
          uow.Connection.Insert<UserRoleRow>(new UserRoleRow()
          {
            UserId = new int?(userId),
            RoleId = new int?(num)
          });
      }
      BatchGenerationUpdater.OnCommit(uow, UserRoleRepository.fld.GenerationKey);
      BatchGenerationUpdater.OnCommit(uow, UserPermissionRow.Fields.GenerationKey);
      return new SaveResponse();
    }

    private List<UserRoleRow> GetExisting(IDbConnection connection, int userId)
    {
      return connection.List<UserRoleRow>((Action<SqlQuery>) (q => q.Select(new IField[2]
      {
        (IField) UserRoleRepository.fld.UserRoleId,
        (IField) UserRoleRepository.fld.RoleId
      }).Where<SqlQuery>((ICriteria) ((BaseCriteria) new Criteria((IField) UserRoleRepository.fld.UserId) == userId))));
    }

    public UserRoleListResponse List(IDbConnection connection, UserRoleListRequest request)
    {
      Check.NotNull((object) request, nameof (request));
      Check.NotNull((object) request.UserID, "userID");
            /* UserRoleListResponse roleListResponse = new UserRoleListResponse();
             roleListResponse.Entities = this.GetExisting(connection, request.UserID.Value).Select<UserRoleRow, int>((Func<UserRoleRow, int>)(x => x.RoleId.Value)).ToList<int>();*/
            UserRoleListResponse roleListResponse = new UserRoleListResponse
            {
                Entities = this.GetExisting(connection, request.UserID.Value).Select<UserRoleRow, int>((Func<UserRoleRow, int>)(x => x.RoleId.Value)).ToList<int>()
            };
            return roleListResponse;
    }

    private void ProcessAttributes<TAttr>(HashSet<string> hash, MemberInfo member, Func<TAttr, string> getRole) where TAttr : Attribute
    {
      foreach (TAttr customAttribute in member.GetCustomAttributes<TAttr>())
      {
        string str = getRole(customAttribute);
        if (!str.IsEmptyOrNull())
          hash.Add(str);
      }
    }
  }
}

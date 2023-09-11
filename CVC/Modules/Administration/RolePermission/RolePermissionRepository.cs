// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Repositories.RolePermissionRepository
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

namespace CVC.Administration.Repositories
{
  public class RolePermissionRepository
  {
    private static RolePermissionRow.RowFields fld
    {
      get
      {
        return RolePermissionRow.Fields;
      }
    }

    public SaveResponse Update(IUnitOfWork uow, RolePermissionUpdateRequest request)
    {
      Check.NotNull((object) request, nameof (request));
      Check.NotNull((object) request.RoleID, "roleID");
      Check.NotNull((object) request.Permissions, "permissions");
      int roleId = request.RoleID.Value;
      HashSet<string> stringSet1 = new HashSet<string>(this.GetExisting(uow.Connection, roleId, request.Module, request.Submodule).Select<RolePermissionRow, string>((Func<RolePermissionRow, string>) (x => x.PermissionKey)), (IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
      HashSet<string> stringSet2 = new HashSet<string>((IEnumerable<string>) request.Permissions.ToList<string>(), (IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
      if (stringSet1.SetEquals((IEnumerable<string>) stringSet2))
        return new SaveResponse();
      foreach (string str in stringSet1)
      {
        if (!stringSet2.Contains(str))
          new SqlDelete(RolePermissionRepository.fld.TableName).Where<SqlDelete>((ICriteria) ((BaseCriteria) new Criteria((IField) RolePermissionRepository.fld.RoleId) == roleId & (BaseCriteria) new Criteria((IField) RolePermissionRepository.fld.PermissionKey) == str)).Execute(uow.Connection, ExpectedRows.One);
      }
      foreach (string str in stringSet2)
      {
        if (!stringSet1.Contains(str))
          uow.Connection.Insert<RolePermissionRow>(new RolePermissionRow()
          {
            RoleId = new int?(roleId),
            PermissionKey = str
          });
      }
      BatchGenerationUpdater.OnCommit(uow, RolePermissionRepository.fld.GenerationKey);
      BatchGenerationUpdater.OnCommit(uow, UserPermissionRow.Fields.GenerationKey);
      return new SaveResponse();
    }

    private List<RolePermissionRow> GetExisting(IDbConnection connection, int roleId, string module, string submodule)
    {
      string prefix = "";
      module = module.TrimToEmpty();
      submodule = submodule.TrimToEmpty();
      if (module.Length > 0)
        prefix = module;
      if (submodule.Length > 0)
        prefix = prefix + ":" + submodule;
      return connection.List<RolePermissionRow>((Action<SqlQuery>) (q =>
      {
        q.Select(new IField[2]
        {
          (IField) RolePermissionRepository.fld.RolePermissionId,
          (IField) RolePermissionRepository.fld.PermissionKey
        }).Where<SqlQuery>((ICriteria) ((BaseCriteria) new Criteria((IField) RolePermissionRepository.fld.RoleId) == roleId));
        if (prefix.Length <= 0)
          return;
        q.Where<SqlQuery>((ICriteria) ((BaseCriteria) new Criteria((IField) RolePermissionRepository.fld.PermissionKey) == prefix | new Criteria((IField) RolePermissionRepository.fld.PermissionKey).StartsWith(prefix + ":")));
      }));
    }

    public RolePermissionListResponse List(IDbConnection connection, RolePermissionListRequest request)
    {
      Check.NotNull((object) request, nameof (request));
      Check.NotNull((object) request.RoleID, "roleID");
      string str1 = "";
      string empty1 = request.Module.TrimToEmpty();
      string empty2 = request.Submodule.TrimToEmpty();
      if (empty1.Length > 0)
        str1 = empty1;
      if (empty2.Length > 0)
      {
        string str2 = str1 + ":" + empty2;
      }
      RolePermissionListResponse permissionListResponse = new RolePermissionListResponse();
      permissionListResponse.Entities = this.GetExisting(connection, request.RoleID.Value, request.Module, request.Submodule).Select<RolePermissionRow, string>((Func<RolePermissionRow, string>) (x => x.PermissionKey)).ToList<string>();

          //  permissionListResponse = RemoveItemsFromPermissionList(permissionListResponse);
      return permissionListResponse;
    }
        
     private RolePermissionListResponse RemoveItemsFromPermissionList(RolePermissionListResponse rolePermissionListResponse)
        {
           var nameToRemove = new[] { "Administration:ViewsAccess:Read" };

          rolePermissionListResponse.Entities.RemoveAll(t => t== "Administration:ViewsAccess:Read" || t== "Administration:ViewsAccess:Modify");
            return rolePermissionListResponse;

        }
    }
}

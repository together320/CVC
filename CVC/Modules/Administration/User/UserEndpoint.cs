// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Endpoints.UserController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Administration.Repositories;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;

namespace CVC.Administration.Endpoints
{
  [RoutePrefix("Services/Administration/User")]
  [Route("{action}")]
  [ConnectionKey(typeof (UserRow))]
  [ServiceAuthorize(typeof (UserRow))]
  public class UserController : ServiceEndpoint
  {
    private static string[] permissionsUsedFromScript;

    [HttpPost]
    [AuthorizeCreate(typeof (UserRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<UserRow> request)
    {
      return new UserRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (UserRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<UserRow> request)
    {
      return new UserRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (UserRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new UserRepository().Delete(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (UserRow))]
    public UndeleteResponse Undelete(IUnitOfWork uow, UndeleteRequest request)
    {
      return new UserRepository().Undelete(uow, request);
    }

    public RetrieveResponse<UserRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new UserRepository().Retrieve(connection, request);
    }

    public ListResponse<UserRow> List(IDbConnection connection, ListRequest request)
    {
      return new UserRepository().List(connection, request);
    }

    [NonAction]
    [DataScript("UserData", CacheDuration = -1)]
    [ServiceAuthorize]
    public ScriptUserDefinition GetUserData()
    {
      ScriptUserDefinition scriptUserDefinition = new ScriptUserDefinition();
      UserDefinition userDefinition = Authorization.UserDefinition as UserDefinition;
      if (userDefinition == null)
      {
        scriptUserDefinition.Permissions = new Dictionary<string, bool>();
        return scriptUserDefinition;
      }
      scriptUserDefinition.Username = userDefinition.Username;
      scriptUserDefinition.DisplayName = userDefinition.DisplayName;
      scriptUserDefinition.IsAdmin = userDefinition.Username == "admin";
      scriptUserDefinition.Permissions = TwoLevelCache.GetLocalStoreOnly<Dictionary<string, bool>>("ScriptUserPermissions:" + userDefinition.Id, TimeSpan.Zero, UserPermissionRow.Fields.GenerationKey, (Func<Dictionary<string, bool>>) (() =>
      {
        Dictionary<string, bool> dictionary = new Dictionary<string, bool>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
        if (UserController.permissionsUsedFromScript == null)
          UserController.permissionsUsedFromScript = new UserPermissionRepository().ListPermissionKeys().Entities.Where<string>((Func<string, bool>) (permissionKey => true)).ToArray<string>();
        foreach (string permission in UserController.permissionsUsedFromScript)
        {
          if (Authorization.HasPermission(permission))
            dictionary[permission] = true;
        }
        return dictionary;
      }));
      return scriptUserDefinition;
    }
  }
}

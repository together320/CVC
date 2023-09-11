// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Endpoints.UserPermissionController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Administration.Repositories;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Services;
using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;

namespace CVC.Administration.Endpoints
{
  [RoutePrefix("Services/Administration/UserPermission")]
  [Route("{action}")]
  [ConnectionKey(typeof (UserPermissionRow))]
  [ServiceAuthorize(typeof (UserPermissionRow))]
  public class UserPermissionController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeUpdate(typeof (UserPermissionRow))]
    public SaveResponse Update(IUnitOfWork uow, UserPermissionUpdateRequest request)
    {
      return new UserPermissionRepository().Update(uow, request);
    }

    public ListResponse<UserPermissionRow> List(IDbConnection connection, UserPermissionListRequest request)
    {
      return new UserPermissionRepository().List(connection, request);
    }

    public ListResponse<string> ListRolePermissions(IDbConnection connection, UserPermissionListRequest request)
    {
      return new UserPermissionRepository().ListRolePermissions(connection, request);
    }

    [DataScript("Administration.PermissionKeys")]
    public ListResponse<string> ListPermissionKeys()
    {
      return new UserPermissionRepository().ListPermissionKeys();
    }

    [DataScript("Administration.ImplicitPermissions")]
    [NonAction]
    public Dictionary<string, HashSet<string>> ListImplicitPermissions()
    {
      return new UserPermissionRepository().ImplicitPermissions;
    }
  }
}

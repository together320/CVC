// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Endpoints.RolePermissionController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Administration.Entities;
using CVC.Administration.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Administration.Endpoints
{
  [RoutePrefix("Services/Administration/RolePermission")]
  [Route("{action}")]
  [ConnectionKey(typeof (RolePermissionRow))]
  [ServiceAuthorize(typeof (RolePermissionRow))]
  public class RolePermissionController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeUpdate(typeof (RolePermissionRow))]
    public SaveResponse Update(IUnitOfWork uow, RolePermissionUpdateRequest request)
    {
      return new RolePermissionRepository().Update(uow, request);
    }

    public RolePermissionListResponse List(IDbConnection connection, RolePermissionListRequest request)
    {
      return new RolePermissionRepository().List(connection, request);
    }
  }
}

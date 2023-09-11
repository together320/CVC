// Decompiled with JetBrains decompiler
// Type: CVC.Administration.Endpoints.UserRoleController
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
  [RoutePrefix("Services/Administration/UserRole")]
  [Route("{action}")]
  [ConnectionKey(typeof (UserRoleRow))]
  [ServiceAuthorize(typeof (UserRoleRow))]
  public class UserRoleController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeUpdate(typeof (UserRoleRow))]
    public SaveResponse Update(IUnitOfWork uow, UserRoleUpdateRequest request)
    {
      return new UserRoleRepository().Update(uow, request);
    }

    public UserRoleListResponse List(IDbConnection connection, UserRoleListRequest request)
    {
      return new UserRoleRepository().List(connection, request);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Common.Endpoints.UserPreferenceController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Common.Entities;
using CVC.Common.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Common.Endpoints
{
  [RoutePrefix("Services/Common/UserPreference")]
  [Route("{action}")]
  [ConnectionKey(typeof (UserPreferenceRow))]
  [ServiceAuthorize]
  public class UserPreferenceController : ServiceEndpoint
  {
    [HttpPost]
    public ServiceResponse Update(IUnitOfWork uow, UserPreferenceUpdateRequest request)
    {
      return (ServiceResponse) new UserPreferenceRepository().Update(uow, request);
    }

    public UserPreferenceRetrieveResponse Retrieve(IDbConnection connection, UserPreferenceRetrieveRequest request)
    {
      return new UserPreferenceRepository().Retrieve(connection, request);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Report.Endpoints.UserLoginDetailsController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Report.Entities;
using CVC.Report.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Report.Endpoints
{
  [RoutePrefix("Services/Report/UserLoginDetails")]
  [Route("{action}")]
  [ConnectionKey(typeof (UserLoginDetailsRow))]
  [ServiceAuthorize(typeof (UserLoginDetailsRow))]
  public class UserLoginDetailsController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (UserLoginDetailsRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<UserLoginDetailsRow> request)
    {
      return new UserLoginDetailsRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (UserLoginDetailsRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<UserLoginDetailsRow> request)
    {
      return new UserLoginDetailsRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (UserLoginDetailsRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new UserLoginDetailsRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<UserLoginDetailsRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new UserLoginDetailsRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<UserLoginDetailsRow> List(IDbConnection connection, ListRequest request)
    {
      return new UserLoginDetailsRepository().List(connection, request);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Endpoints.CityDetailsController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.Configuration.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.Configuration.Endpoints
{
  [RoutePrefix("Services/Configuration/CityDetails")]
  [Route("{action}")]
  [ConnectionKey(typeof (CityDetailsRow))]
  [ServiceAuthorize(typeof (CityDetailsRow))]
  public class CityDetailsController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (CityDetailsRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<CityDetailsRow> request)
    {
      return new CityDetailsRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (CityDetailsRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<CityDetailsRow> request)
    {
      return new CityDetailsRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (CityDetailsRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new CityDetailsRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<CityDetailsRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new CityDetailsRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<CityDetailsRow> List(IDbConnection connection, ListRequest request)
    {
      return new CityDetailsRepository().List(connection, request);
    }
  }
}

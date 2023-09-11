// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Endpoints.LanguageController
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
  [RoutePrefix("Services/Configuration/Language")]
  [Route("{action}")]
  [ConnectionKey(typeof (LanguageRow))]
  [ServiceAuthorize(typeof (LanguageRow))]
  public class LanguageController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (LanguageRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<LanguageRow> request)
    {
      return new LanguageRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (LanguageRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<LanguageRow> request)
    {
      return new LanguageRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (LanguageRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new LanguageRepository().Delete(uow, request);
    }

    public RetrieveResponse<LanguageRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new LanguageRepository().Retrieve(connection, request);
    }

    public ListResponse<LanguageRow> List(IDbConnection connection, ListRequest request)
    {
      return new LanguageRepository().List(connection, request);
    }
  }
}

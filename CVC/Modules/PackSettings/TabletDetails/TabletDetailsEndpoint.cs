// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Endpoints.TabletDetailsController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.PackSettings.Entities;
using CVC.PackSettings.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace CVC.PackSettings.Endpoints
{
  [RoutePrefix("Services/PackSettings/TabletDetails")]
  [Route("{action}")]
  [ConnectionKey(typeof (TabletDetailsRow))]
  [ServiceAuthorize(typeof (TabletDetailsRow))]
  public class TabletDetailsController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (TabletDetailsRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<TabletDetailsRow> request)
    {
      return new TabletDetailsRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (TabletDetailsRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<TabletDetailsRow> request)
    {
      return new TabletDetailsRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (TabletDetailsRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new TabletDetailsRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<TabletDetailsRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new TabletDetailsRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<TabletDetailsRow> List(IDbConnection connection, ListRequest request)
    {
      return new TabletDetailsRepository().List(connection, request);
    }
  }
}

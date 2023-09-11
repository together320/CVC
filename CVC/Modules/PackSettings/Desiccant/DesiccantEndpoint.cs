// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Endpoints.DesiccantController
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
  [RoutePrefix("Services/PackSettings/Desiccant")]
  [Route("{action}")]
  [ConnectionKey(typeof (DesiccantRow))]
  [ServiceAuthorize(typeof (DesiccantRow))]
  public class DesiccantController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (DesiccantRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<DesiccantRow> request)
    {
      return new DesiccantRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (DesiccantRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<DesiccantRow> request)
    {
      return new DesiccantRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (DesiccantRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new DesiccantRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<DesiccantRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new DesiccantRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<DesiccantRow> List(IDbConnection connection, ListRequest request)
    {
      return new DesiccantRepository().List(connection, request);
    }
  }
}

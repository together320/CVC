// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Endpoints.EndOfLineController
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
  [RoutePrefix("Services/PackSettings/EndOfLine")]
  [Route("{action}")]
  [ConnectionKey(typeof (EndOfLineRow))]
  [ServiceAuthorize(typeof (EndOfLineRow))]
  public class EndOfLineController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (EndOfLineRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<EndOfLineRow> request)
    {
      return new EndOfLineRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (EndOfLineRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<EndOfLineRow> request)
    {
      return new EndOfLineRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (EndOfLineRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new EndOfLineRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<EndOfLineRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new EndOfLineRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<EndOfLineRow> List(IDbConnection connection, ListRequest request)
    {
      return new EndOfLineRepository().List(connection, request);
    }
  }
}

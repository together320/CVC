// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Endpoints.LabelController
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
  [RoutePrefix("Services/PackSettings/Label")]
  [Route("{action}")]
  [ConnectionKey(typeof (LabelRow))]
  [ServiceAuthorize(typeof (LabelRow))]
  public class LabelController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (LabelRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<LabelRow> request)
    {
      return new LabelRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (LabelRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<LabelRow> request)
    {
      return new LabelRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (LabelRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new LabelRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<LabelRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new LabelRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<LabelRow> List(IDbConnection connection, ListRequest request)
    {
      return new LabelRepository().List(connection, request);
    }
  }
}

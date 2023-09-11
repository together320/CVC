// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Endpoints.DataTypeController
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
  [RoutePrefix("Services/MachineCustomization/DataType")]
  [Route("{action}")]
  [ConnectionKey(typeof (DataTypeRow))]
  [ServiceAuthorize(typeof (DataTypeRow))]
  public class DataTypeController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (DataTypeRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<DataTypeRow> request)
    {
      return new DataTypeRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (DataTypeRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<DataTypeRow> request)
    {
      return new DataTypeRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (DataTypeRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new DataTypeRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<DataTypeRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new DataTypeRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<DataTypeRow> List(IDbConnection connection, ListRequest request)
    {
      return new DataTypeRepository().List(connection, request);
    }
  }
}

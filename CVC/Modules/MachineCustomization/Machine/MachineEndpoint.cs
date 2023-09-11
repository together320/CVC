// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Endpoints.MachineController
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.MachineCustomization.Entities;
using CVC.MachineCustomization.Repositories;
using Serenity.Data;
using Serenity.Services;
using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;

namespace CVC.MachineCustomization.Endpoints
{
  [RoutePrefix("Services/MachineCustomization/Machine")]
  [Route("{action}")]
  [ConnectionKey(typeof (MachineRow))]
  [ServiceAuthorize(typeof (MachineRow))]
  public class MachineController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof (MachineRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineRow> request)
    {
      return new MachineRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof (MachineRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineRow> request)
    {
      return new MachineRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof (MachineRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new MachineRepository().Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MachineRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<MachineRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineRepository().List(connection, request);
    }

    // added by Denis for RS 3.4 dated 7/20/2021
    public ListResponse<TableObjIDRow> FetchAllTables(IDbConnection connection)
    {
      var data = connection.Query<TableObjIDRow>("SELECT Name, OBJECT_ID(name) ObjectId FROM sys.Tables ORDER BY Name ASC;", param: null, commandType: System.Data.CommandType.Text);

      var response = new ListResponse<TableObjIDRow>();
      response.Entities = (List<TableObjIDRow>)data;
      return response;
    }
  }
}

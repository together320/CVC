// Decompiled with JetBrains decompiler
// Type: CVC.MachineCustomization.Endpoints.MachineParameterController
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
  [RoutePrefix("Services/MachineCustomization/MachineParameter")]
  [Route("{action}")]
  [ConnectionKey(typeof(MachineParameterRow))]
  [ServiceAuthorize(typeof(MachineParameterRow))]
  public class MachineParameterController : ServiceEndpoint
  {
    [HttpPost]
    [AuthorizeCreate(typeof(MachineParameterRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MachineParameterRow> request)
    {
      return new MachineParameterRepository().Create(uow, request);
    }

    [HttpPost]
    [AuthorizeUpdate(typeof(MachineParameterRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MachineParameterRow> request)
    {
      return new MachineParameterRepository().Update(uow, request);
    }

    [HttpPost]
    [AuthorizeDelete(typeof(MachineParameterRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      try
      {
        return new MachineParameterRepository().Delete(uow, request);
      }
      catch (ValidationError ex)
      {
        // Handle the error, e.g., log it, show a message to the user, etc.
        return new DeleteResponse { Error = new ServiceError { Message = ex.Message } };
      }
    }

    [HttpPost]
    public RetrieveResponse<MachineParameterRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new MachineParameterRepository().Retrieve(connection, request);
    }

    [HttpPost]
    public ListResponse<MachineParameterRow> List(IDbConnection connection, ListRequest request)
    {
      return new MachineParameterRepository().List(connection, request);
    }

    // added by Denis for RS 3.7 dated 7/20/2021
    // Fetch names and ids of all columns in a table
    public ListResponse<ColumnIDRow> FetchAllColumns(IDbConnection connection, ColumnIdsRequest request)
    {
      var data = connection.Query<ColumnIDRow>(@"SELECT 
                                                    COL.name ColumnName,
                                                    COL.column_id ColumnId
                                            From sys.columns COL
                                            WHERE COL.object_id = @tableId;",
                                              param: new
                                              {
                                                tableId = request.TableId
                                              },
                                              commandType: System.Data.CommandType.Text);
      var response = new ListResponse<ColumnIDRow>();
      response.Entities = (List<ColumnIDRow>)data;
      return response;
    }
  }
}

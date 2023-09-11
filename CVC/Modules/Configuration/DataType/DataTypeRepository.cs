// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Repositories.DataTypeRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Configuration.Repositories
{
  public class DataTypeRepository
  {
    private static DataTypeRow.RowFields fld
    {
      get
      {
        return DataTypeRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<DataTypeRow> request)
    {
      return new DataTypeRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<DataTypeRow> request)
    {
      return new DataTypeRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new DataTypeRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<DataTypeRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new DataTypeRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<DataTypeRow> List(IDbConnection connection, ListRequest request)
    {
      return new DataTypeRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<DataTypeRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<DataTypeRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<DataTypeRow>
    {
    }

    private class MyListHandler : ListRequestHandler<DataTypeRow>
    {
    }
  }
}

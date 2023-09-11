// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Repositories.CompanyRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Configuration.Repositories
{
  public class CompanyRepository
  {
    private static CompanyRow.RowFields fld
    {
      get
      {
        return CompanyRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<CompanyRow> request)
    {
      return new CompanyRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<CompanyRow> request)
    {
      return new CompanyRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new CompanyRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<CompanyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new CompanyRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<CompanyRow> List(IDbConnection connection, ListRequest request)
    {
      return new CompanyRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<CompanyRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<CompanyRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<CompanyRow>
    {
    }

    private class MyListHandler : ListRequestHandler<CompanyRow>
    {
    }
  }
}

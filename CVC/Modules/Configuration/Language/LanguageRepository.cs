// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Repositories.LanguageRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Configuration.Repositories
{
  public class LanguageRepository
  {
    private static LanguageRow.RowFields fld
    {
      get
      {
        return LanguageRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<LanguageRow> request)
    {
      return new LanguageRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<LanguageRow> request)
    {
      return new LanguageRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new LanguageRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<LanguageRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new LanguageRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<LanguageRow> List(IDbConnection connection, ListRequest request)
    {
      return new LanguageRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<LanguageRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<LanguageRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<LanguageRow>
    {
    }

    private class MyListHandler : ListRequestHandler<LanguageRow>
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CVC.Report.Repositories.UserLoginDetailsRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Report.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Report.Repositories
{
  public class UserLoginDetailsRepository
  {
    private static UserLoginDetailsRow.RowFields fld
    {
      get
      {
        return UserLoginDetailsRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<UserLoginDetailsRow> request)
    {
      return new UserLoginDetailsRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<UserLoginDetailsRow> request)
    {
      return new UserLoginDetailsRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new UserLoginDetailsRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<UserLoginDetailsRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new UserLoginDetailsRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<UserLoginDetailsRow> List(IDbConnection connection, ListRequest request)
    {
      return new UserLoginDetailsRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<UserLoginDetailsRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<UserLoginDetailsRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<UserLoginDetailsRow>
    {
    }

    private class MyListHandler : ListRequestHandler<UserLoginDetailsRow>
    {
    }
  }
}

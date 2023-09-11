// Decompiled with JetBrains decompiler
// Type: CVC.Report.Repositories.AlarmLogRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Report.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Report.Repositories
{
  public class AlarmLogRepository
  {
    private static AlarmLogRow.RowFields fld
    {
      get
      {
        return AlarmLogRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<AlarmLogRow> request)
    {
      return new AlarmLogRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<AlarmLogRow> request)
    {
      return new AlarmLogRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new AlarmLogRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<AlarmLogRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new AlarmLogRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<AlarmLogRow> List(IDbConnection connection, ListRequest request)
    {
      return new AlarmLogRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<AlarmLogRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<AlarmLogRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<AlarmLogRow>
    {
    }

    private class MyListHandler : ListRequestHandler<AlarmLogRow>
    {
    }
  }
}

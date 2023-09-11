// Decompiled with JetBrains decompiler
// Type: CVC.Report.Repositories.AuditLogRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Report.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;

namespace CVC.Report.Repositories
{
  public class AuditLogRepository
  {
    private static AuditLogRow.RowFields fld
    {
      get
      {
        return AuditLogRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<AuditLogRow> request)
    {
      return new AuditLogRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<AuditLogRow> request)
    {
      return new AuditLogRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new AuditLogRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<AuditLogRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new AuditLogRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<AuditLogRow> List(IDbConnection connection, ListRequest request)
    {
      return new AuditLogRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<AuditLogRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<AuditLogRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<AuditLogRow>
    {
    }

    private class MyListHandler : ListRequestHandler<AuditLogRow>
    {
    }
  }
}

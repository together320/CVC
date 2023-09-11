// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Repositories.EndOfLineRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Data.EDMX;
using CVC.PackSettings.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Linq;

namespace CVC.PackSettings.Repositories
{
  public class EndOfLineRepository
  {
    private static EndOfLineRow.RowFields fld
    {
      get
      {
        return EndOfLineRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<EndOfLineRow> request)
        {
            CheckEndOfLineNameExist(request.Entity.EndOfLineName, request.Entity.EndOfLineId, "Create");

            return new EndOfLineRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<EndOfLineRow> request)
        {
            CheckEndOfLineNameExist(request.Entity.EndOfLineName, request.Entity.EndOfLineId, "Update");

            return new EndOfLineRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new EndOfLineRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<EndOfLineRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new EndOfLineRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<EndOfLineRow> List(IDbConnection connection, ListRequest request)
    {
      return new EndOfLineRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<EndOfLineRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<EndOfLineRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<EndOfLineRow>
    {
    }

    private class MyListHandler : ListRequestHandler<EndOfLineRow>
    {
    }

        private void CheckEndOfLineNameExist(string endOfLineName, int? endOfLineId, string requestType)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                #region Check End Of Line Name exist
                var endOfLine = new EndOfLine();
                if (requestType == "Create")
                {
                    endOfLine = cvcEntities?.EndOfLines?.FirstOrDefault(e => e.EndOfLineName.ToLower() == endOfLineName.ToLower());
                }
                else
                {
                    endOfLine = cvcEntities?.EndOfLines?.FirstOrDefault(e => e.EndOfLineName.ToLower() == endOfLineName.ToLower() && e.EndOfLineId != endOfLineId);
                }
                if (endOfLine != null)
                {
                    throw new Serenity.Services.ValidationError("Alert", "Another record with the same 'End Of Line Name' value(s) exists!");
                }

                #endregion
            }
        }

    }
}

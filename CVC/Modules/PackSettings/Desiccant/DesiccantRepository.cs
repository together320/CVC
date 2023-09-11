// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Repositories.DesiccantRepository
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
  public class DesiccantRepository
  {
    private static DesiccantRow.RowFields fld
    {
      get
      {
        return DesiccantRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<DesiccantRow> request)
        {
            CheckDesiccantNameExist(request.Entity.DesiccantName, request.Entity.DesiccantId, "Create");

            return new DesiccantRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<DesiccantRow> request)
        {
            CheckDesiccantNameExist(request.Entity.DesiccantName, request.Entity.DesiccantId, "Update");
            return new DesiccantRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new DesiccantRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<DesiccantRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new DesiccantRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<DesiccantRow> List(IDbConnection connection, ListRequest request)
    {
      return new DesiccantRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<DesiccantRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<DesiccantRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<DesiccantRow>
    {
    }

    private class MyListHandler : ListRequestHandler<DesiccantRow>
    {
    }

        private void CheckDesiccantNameExist(string desiccantName, int? desiccantId, string requestType)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                #region Check Desiccant Name exist
                var desiccant = new Desiccant();
                if (requestType == "Create")
                {
                    desiccant = cvcEntities?.Desiccants?.FirstOrDefault(d => d.DesiccantName.ToLower() == desiccantName.ToLower());
                }
                else
                {
                    desiccant = cvcEntities?.Desiccants?.FirstOrDefault(d => d.DesiccantName.ToLower() == desiccantName.ToLower() && d.DesiccantId != desiccantId);
                }
                if (desiccant != null)
                {
                    throw new Serenity.Services.ValidationError("Alert", "Another record with the same 'Desiccant Name' value(s) exists!");
                }

                #endregion
            }
        }

    }
}

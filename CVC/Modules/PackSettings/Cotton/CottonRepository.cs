// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Repositories.CottonRepository
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
  public class CottonRepository
  {
    private static CottonRow.RowFields fld
    {
      get
      {
        return CottonRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<CottonRow> request)
    {
            CheckCottonNameExist(request.Entity.CottonName, request.Entity.CottonId, "Create");

            return new CottonRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<CottonRow> request)
        {
            CheckCottonNameExist(request.Entity.CottonName, request.Entity.CottonId, "Update");

            return new CottonRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new CottonRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<CottonRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new CottonRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<CottonRow> List(IDbConnection connection, ListRequest request)
    {
      return new CottonRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<CottonRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<CottonRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<CottonRow>
    {
    }

    private class MyListHandler : ListRequestHandler<CottonRow>
    {
    }

        private void CheckCottonNameExist(string cottonName, int? cottonId, string requestType)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                #region Check Cotton Name exist
                var cotton = new Cotton();
                if (requestType == "Create")
                {
                    cotton = cvcEntities?.Cotton?.FirstOrDefault(b => b.CottonName.ToLower() == cottonName.ToLower());
                }
                else
                {
                    cotton = cvcEntities?.Cotton?.FirstOrDefault(b => b.CottonName.ToLower() == cottonName.ToLower() && b.CottonId != cottonId);
                }
                if (cotton != null)
                {
                    throw new Serenity.Services.ValidationError("Alert", "Another record with the same 'Cotton Name' value(s) exists!");
                }

                #endregion
            }
        }

    }
}

// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Repositories.PackRepository
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
  public class PackRepository
  {
    private static PackRow.RowFields fld
    {
      get
      {
        return PackRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<PackRow> request)
        {
            CheckPackNameExist(request.Entity.PackName, request.Entity.PackId, "Create");

            return new PackRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<PackRow> request)
        {
            CheckPackNameExist(request.Entity.PackName, request.Entity.PackId, "Update");

            return new PackRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new PackRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<PackRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new PackRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<PackRow> List(IDbConnection connection, ListRequest request)
    {
      return new PackRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<PackRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<PackRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<PackRow>
    {
    }

    private class MyListHandler : ListRequestHandler<PackRow>
    {
    }

        private void CheckPackNameExist(string packName, int? packId, string requestType)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                #region Check Pack Name exist
                var pack = new Pack();
                if (requestType == "Create")
                {
                    pack = cvcEntities?.Packs?.FirstOrDefault(p => p.PackName.ToLower() == packName.ToLower());
                }
                else
                {
                    pack = cvcEntities?.Packs?.FirstOrDefault(p => p.PackName.ToLower() == packName.ToLower() && p.PackId != packId);
                }
                if (pack != null)
                {
                    throw new Serenity.Services.ValidationError("Alert", "Another record with the same 'Pack Name' value(s) exists!");
                }

                #endregion
            }
        }

    }
}

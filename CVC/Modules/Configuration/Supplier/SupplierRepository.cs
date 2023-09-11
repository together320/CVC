// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Repositories.SupplierRepository
// Assembly: CVC.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 250FBC80-8FD8-44B6-9120-1561B0D3D414
// Assembly location: D:\Anil\CVC\bin\CVC.Web.dll

using CVC.Configuration.Entities;
using CVC.Data.EDMX;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Linq;

namespace CVC.Configuration.Repositories
{
  public class SupplierRepository
  {
    private static SupplierRow.RowFields fld
    {
      get
      {
        return SupplierRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<SupplierRow> request)
    {
            CheckSupplierNameExist(request.Entity.SupplierName, request.Entity.SupplierId, "Create");
            return new SupplierRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<SupplierRow> request)
    {
            CheckSupplierNameExist(request.Entity.SupplierName, request.Entity.SupplierId, "Update");
            return new SupplierRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new SupplierRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<SupplierRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new SupplierRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<SupplierRow> List(IDbConnection connection, ListRequest request)
    {
      return new SupplierRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<SupplierRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<SupplierRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<SupplierRow>
    {
    }

    private class MyListHandler : ListRequestHandler<SupplierRow>
    {
    }

        private void CheckSupplierNameExist(string supplierName, int? supplierId, string requestType)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                #region Check Supplier Name exist
                var supplier = new Supplier();
                if (requestType == "Create")
                {
                    supplier = cvcEntities?.Suppliers?.FirstOrDefault(s => s.SupplierName.ToLower() == supplierName.ToLower());
                }
                else
                {
                    supplier = cvcEntities?.Suppliers?.FirstOrDefault(s => s.SupplierName.ToLower() == supplierName.ToLower() && s.SupplierId != supplierId);
                }
                if (supplier != null)
                {
                    throw new Serenity.Services.ValidationError("Alert", "Another record with the same 'Supplier Name' value(s) exists!");
                }

                #endregion
            }
        }

    }
}

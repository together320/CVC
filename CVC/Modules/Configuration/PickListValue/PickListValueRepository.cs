// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Repositories.PickListValueRepository
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
  public class PickListValueRepository
  {
    private static PickListValueRow.RowFields fld
    {
      get
      {
        return PickListValueRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<PickListValueRow> request)
    {
            CheckSPickListValueExist(request.Entity.PickListValueName, request.Entity.PickListId,request.Entity.PickListValueId, "Create");
            return new PickListValueRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<PickListValueRow> request)
        {
            CheckSPickListValueExist(request.Entity.PickListValueName, request.Entity.PickListId, request.Entity.PickListValueId, "Update");
            return new PickListValueRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new PickListValueRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<PickListValueRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new PickListValueRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<PickListValueRow> List(IDbConnection connection, ListRequest request)
    {
      return new PickListValueRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<PickListValueRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<PickListValueRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<PickListValueRow>
    {
    }

    private class MyListHandler : ListRequestHandler<PickListValueRow>
    {
    }

        private void CheckSPickListValueExist(string pickListValueName, int? pickListId,int? pickListValueId, string requestType)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                #region Check PickList Value exist
                var pickListValue = new PickListValue();
                if (requestType == "Create")
                {
                    pickListValue = cvcEntities?.PickListValues?.FirstOrDefault(p => p.PickListValueName.ToLower() == pickListValueName.ToLower() && p.PickListId==pickListId );
                }
                else
                {
                    pickListValue = cvcEntities?.PickListValues?.FirstOrDefault(p => p.PickListValueName.ToLower() == pickListValueName.ToLower() && p.PickListId == pickListId && p.PickListValueId!=pickListValueId);
                }
                if (pickListValue != null)
                {
                    throw new Serenity.Services.ValidationError("Alert", "Another record with the same 'PickList Value Name' value(s) exists!");
                }

                #endregion
            }
        }

    }
}

// Decompiled with JetBrains decompiler
// Type: CVC.PackSettings.Repositories.TabletDetailsRepository
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
  public class TabletDetailsRepository
  {
    private static TabletDetailsRow.RowFields fld
    {
      get
      {
        return TabletDetailsRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<TabletDetailsRow> request)
        {
            CheckTabletNameExist(request.Entity.TabletName, request.Entity.TabletDetailsId, "Create");

            return new TabletDetailsRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<TabletDetailsRow> request)
        {
            CheckTabletNameExist(request.Entity.TabletName, request.Entity.TabletDetailsId, "Update");

            return new TabletDetailsRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new TabletDetailsRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<TabletDetailsRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new TabletDetailsRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<TabletDetailsRow> List(IDbConnection connection, ListRequest request)
    {
      return new TabletDetailsRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<TabletDetailsRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<TabletDetailsRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<TabletDetailsRow>
    {
    }

    private class MyListHandler : ListRequestHandler<TabletDetailsRow>
    {
    }

        private void CheckTabletNameExist(string tabletName, int? tabletId, string requestType)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                #region Check Tablet Name exist
                var tabletDetail = new TabletDetail();
                if (requestType == "Create")
                {
                    tabletDetail = cvcEntities?.TabletDetails?.FirstOrDefault(t => t.TabletName.ToLower() == tabletName.ToLower());
                }
                else
                {
                    tabletDetail = cvcEntities?.TabletDetails?.FirstOrDefault(t => t.TabletName.ToLower() == tabletName.ToLower() && t.TabletDetailsId != tabletId);
                }
                if (tabletDetail != null)
                {
                    throw new Serenity.Services.ValidationError("Alert", "Another record with the same 'Tablet Name' value(s) exists!");
                }

                #endregion
            }
        }

    }
}

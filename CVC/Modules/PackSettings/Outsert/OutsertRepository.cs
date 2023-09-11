

using CVC.Data.EDMX;
using CVC.PackSettings.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Linq;

namespace CVC.PackSettings.Repositories
{
  public class OutsertRepository
  {
    private static OutsertRow.RowFields fld
    {
      get
      {
        return OutsertRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<OutsertRow> request)
        {
            CheckOutsertNameExist(request.Entity.OutsertName, request.Entity.OutsertId, "Create");

            return new OutsertRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<OutsertRow> request)
        {
            CheckOutsertNameExist(request.Entity.OutsertName, request.Entity.OutsertId, "Update");

            return new OutsertRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new OutsertRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<OutsertRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new OutsertRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<OutsertRow> List(IDbConnection connection, ListRequest request)
    {
      return new OutsertRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<OutsertRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<OutsertRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<OutsertRow>
    {
    }

    private class MyListHandler : ListRequestHandler<OutsertRow>
    {
    }

        private void CheckOutsertNameExist(string outsertName, int? outsertId, string requestType)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                #region Check Outsert Name exist
                var outsert = new Outsert();
                if (requestType == "Create")
                {
                    outsert = cvcEntities?.Outserts?.FirstOrDefault(o => o.OutsertName.ToLower() == outsertName.ToLower());
                }
                else
                {
                    outsert = cvcEntities?.Outserts?.FirstOrDefault(o => o.OutsertName.ToLower() == outsertName.ToLower() && o.OutsertId != outsertId);
                }
                if (outsert != null)
                {
                    throw new Serenity.Services.ValidationError("Alert", "Another record with the same 'Outsert Name' value(s) exists!");
                }

                #endregion
            }
        }

    }
}

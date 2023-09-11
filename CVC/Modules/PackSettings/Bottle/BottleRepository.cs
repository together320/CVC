

using CVC.Data.EDMX;
using CVC.PackSettings.Entities;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Linq;

namespace CVC.PackSettings.Repositories
{
  public class BottleRepository
  {
    private static BottleRow.RowFields fld
    {
      get
      {
        return BottleRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<BottleRow> request)
        {
            CheckBottleNameExist(request.Entity.BottleName, request.Entity.BottleId, "Create");

            return new BottleRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<BottleRow> request)
        {
            CheckBottleNameExist(request.Entity.BottleName, request.Entity.BottleId, "Update");
            return new BottleRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new BottleRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<BottleRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new BottleRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<BottleRow> List(IDbConnection connection, ListRequest request)
    {
      return new BottleRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<BottleRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<BottleRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<BottleRow>
    {
    }

    private class MyListHandler : ListRequestHandler<BottleRow>
    {
    }

        private void CheckBottleNameExist(string bottleName, int? bottleId, string requestType)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                #region Check Bottle Name exist
                var bottle = new Bottle();
                if (requestType == "Create")
                {
                    bottle = cvcEntities?.Bottles?.FirstOrDefault(b => b.BottleName.ToLower() == bottleName.ToLower());
                }
                else
                {
                    bottle = cvcEntities?.Bottles?.FirstOrDefault(b => b.BottleName.ToLower() == bottleName.ToLower() && b.BottleId!=bottleId);
                }
                if (bottle != null)
                {
                    throw new Serenity.Services.ValidationError("Alert", "Another record with the same 'Bottle Name' value(s) exists!");
                }

                #endregion
            }
        }

    }
}

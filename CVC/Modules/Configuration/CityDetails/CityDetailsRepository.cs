// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Repositories.CityDetailsRepository
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
  public class CityDetailsRepository
  {
    private static CityDetailsRow.RowFields fld
    {
      get
      {
        return CityDetailsRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<CityDetailsRow> request)
        {
            CheckCityNameExist(request.Entity.City, request.Entity.State, request.Entity.CityDetailsId, "Create");
            return new CityDetailsRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<CityDetailsRow> request)
    {
            CheckCityNameExist(request.Entity.City, request.Entity.State, request.Entity.CityDetailsId, "Update");
            return new CityDetailsRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new CityDetailsRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<CityDetailsRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new CityDetailsRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<CityDetailsRow> List(IDbConnection connection, ListRequest request)
    {
      return new CityDetailsRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<CityDetailsRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<CityDetailsRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<CityDetailsRow>
    {
    }

    private class MyListHandler : ListRequestHandler<CityDetailsRow>
    {
    }

        private void CheckCityNameExist(string cityName, string stateName, int? cityId, string requestType)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                #region Check City Name exist
                var city = new CityDetail();
                if (requestType == "Create")
                {
                    city = cvcEntities?.CityDetails?.FirstOrDefault(c => c.City.ToLower() == cityName.ToLower() && c.State.ToLower() == stateName);
                }
                else
                {
                    city = cvcEntities?.CityDetails?.FirstOrDefault(c => c.City.ToLower() == cityName.ToLower() && c.State.ToLower() == stateName && c.CityDetailsId!=cityId );
                }
                if (city != null)
                {
                    throw new Serenity.Services.ValidationError("Alert", "Another record with the same 'City Name' value(s) exists!");
                }

                #endregion
            }
        }

    }
}

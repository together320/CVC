// Decompiled with JetBrains decompiler
// Type: CVC.Configuration.Repositories.ShiftRepository
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
  public class ShiftRepository
  {
    private static ShiftRow.RowFields fld
    {
      get
      {
        return ShiftRow.Fields;
      }
    }

    public SaveResponse Create(IUnitOfWork uow, SaveRequest<ShiftRow> request)
        {
            CheckShiftNameExist(request.Entity.ShiftName, request.Entity.ShiftId, "Create");

            return new ShiftRepository.MySaveHandler().Process(uow, request, SaveRequestType.Create);
    }

    public SaveResponse Update(IUnitOfWork uow, SaveRequest<ShiftRow> request)
        {
            CheckShiftNameExist(request.Entity.ShiftName, request.Entity.ShiftId, "Update");

            return new ShiftRepository.MySaveHandler().Process(uow, request, SaveRequestType.Update);
    }

    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
    {
      return new ShiftRepository.MyDeleteHandler().Process(uow, request);
    }

    public RetrieveResponse<ShiftRow> Retrieve(IDbConnection connection, RetrieveRequest request)
    {
      return new ShiftRepository.MyRetrieveHandler().Process(connection, request);
    }

    public ListResponse<ShiftRow> List(IDbConnection connection, ListRequest request)
    {
      return new ShiftRepository.MyListHandler().Process(connection, request);
    }

    private class MySaveHandler : SaveRequestHandler<ShiftRow>
    {
    }

    private class MyDeleteHandler : DeleteRequestHandler<ShiftRow>
    {
    }

    private class MyRetrieveHandler : RetrieveRequestHandler<ShiftRow>
    {
    }

    private class MyListHandler : ListRequestHandler<ShiftRow>
    {
    }

    private void CheckShiftNameExist(string shiftName, int? shiftId, string requestType)
        {
            using (CVCEntities cvcEntities = new CVCEntities())
            {
                #region Check Shift Name exist
                var shift = new Shift();
                if (requestType == "Create")
                {
                    shift = cvcEntities?.Shifts?.FirstOrDefault(s => s.ShiftName.ToLower() == shiftName.ToLower());
                }
                else
                {
                    shift = cvcEntities?.Shifts?.FirstOrDefault(s => s.ShiftName.ToLower() == shiftName.ToLower() && s.ShiftId!=shiftId);
                }
                if (shift!= null)
                {
                    throw new Serenity.Services.ValidationError("Alert", "Another record with the same 'Shift Name' value(s) exists!");
                }

                #endregion
            }
        }

    }
}
